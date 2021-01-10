using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.FlightSimulator.SimConnect;

namespace MSFSConnector
{
    public class SimControl
    {
        /// simconnect connection
        public const int WM_USER_SIMCONNECT = 0x0402;

        private IntPtr _hWnd = new IntPtr(0);
        private SimConnect _simConnect = null;

        private uint _currentDefinition = 0;
        private uint _currentRequest = 0;

        private ObservableCollection<SimvarRequest> _simvarRequests;

        public event EventHandler ActionReceived;

        public SimControl()
        {
            _simvarRequests = new ObservableCollection<SimvarRequest>();
        }

        public bool Connected { get; private set; } = false;

        public void ReceiveSimConnectMessage()
        {
            _simConnect?.ReceiveMessage();
        }

        public void Connect(IntPtr hWnd)
        {
            _hWnd = hWnd;

            Debug.WriteLine("Connecting...");

            if (_simConnect == null)
            {
                try
                {
                    // The constructor is similar to SimConnect_Open in the native API
                    _simConnect = new SimConnect("Simconnect - SimControl", _hWnd, WM_USER_SIMCONNECT, null, 0);

                    // Listen to connect and quit msgs
                    _simConnect.OnRecvOpen += SimConnect_OnConnected;
                    _simConnect.OnRecvQuit += SimConnect_OnDisconnected;
                    _simConnect.OnRecvException += SimConnect_OnError;
                    _simConnect.OnRecvSimobjectData += SimConnect_OnGotData;
                }
                catch (COMException ex)
                {
                    throw new ApplicationException("Connection to MSFS failed. Make sure its running.", ex);
                }

                RegisterForEvent(EVENT_IDS.COM_RADIO_WHOLE_INC);
                RegisterForEvent(EVENT_IDS.COM_RADIO_WHOLE_DEC);
                RegisterForEvent(EVENT_IDS.COM_RADIO_FRACT_INC);
                RegisterForEvent(EVENT_IDS.COM_RADIO_FRACT_DEC);
                RegisterForEvent(EVENT_IDS.COM_STBY_RADIO_SWAP);

                AddRequest(new SimVar(SimVars.COM_ACTIVE_FREQUENCY, Units.Megahertz, 1));
                AddRequest(new SimVar(SimVars.COM_STANDBY_FREQUENCY, Units.Megahertz, 1));
            }
        }

        public void Disconnect()
        {
            Debug.WriteLine("Disconnect");

            if (_simConnect != null)
            {
                /// Dispose serves the same purpose as SimConnect_Close()
                _simConnect.Dispose();
                _simConnect = null;
            }

            Connected = false;
        }

        protected virtual void OnActivityRecieved(SimVar simVar, string data)
        {
            EventHandler handler = ActionReceived;

            var eventArgs = new SimActivityEventArgs(data, simVar);
            handler?.Invoke(this, eventArgs);
        }

        private void SimConnect_OnConnected(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            Debug.WriteLine("SimConnect Connected");

            Connected = true;

            // register requests we have
            //foreach (SimvarRequest oSimvarRequest in _simvarRequests)
            //{
            //    RegisterWithSimConnect(oSimvarRequest);
            //}
        }

        private void SimConnect_OnDisconnected(SimConnect sender, SIMCONNECT_RECV data)
        {
            Debug.WriteLine("SimConnect_OnDisconnected");
            Disconnect();
        }

        private void SimConnect_OnError(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            SIMCONNECT_EXCEPTION eException = (SIMCONNECT_EXCEPTION)data.dwException;
            Debug.WriteLine("SimConnect_OnError: " + eException.ToString());
        }

        private void SimConnect_OnGotData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            Debug.WriteLine("Got data from sim");

            uint iRequest = data.dwRequestID;
            uint iObject = data.dwObjectID;

            var request = _simvarRequests.SingleOrDefault(r => (uint)r.eRequest == iRequest);

            if (request != null)
            {
                double dValue = (double)data.dwData[0];
                request.dValue = dValue;

                if (request.dValue != request.previousValue)
                {
                    var str = request.dValue.ToString();
                    this.OnActivityRecieved(request.Variable, str);

                    request.previousValue = request.dValue;
                }
            }
        }

        public void TransmitClientEvent(EVENT_IDS eventId, int value, GROUPS group, SIMCONNECT_EVENT_FLAG flags)
        {
            _simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, eventId, (uint)value, group, flags);
        }

        private bool RegisterWithSimConnect(SimvarRequest _oSimvarRequest)
        {
            if (_simConnect != null)
            {
                // Define a data structure
                _simConnect.AddToDataDefinition(_oSimvarRequest.eDef, _oSimvarRequest.Variable.SimConnectVariable, _oSimvarRequest.Variable.SimConnectUnit, SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                // IMPORTANT: Register it with the simconnect managed wrapper marshaller
                // If you skip this step, you will only receive a uint in the .dwData field.
                _simConnect.RegisterDataDefineStruct<double>(_oSimvarRequest.eDef);

                return true;
            }

            return false;
        }

        private void RegisterForEvent(EVENT_IDS eventId)
        {
            try
            {
                Debug.WriteLine($"Registering for event {eventId.ToString()}");
                _simConnect.MapClientEventToSimEvent(eventId, eventId.ToString());
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Failed to register for event {eventId.ToString()}.", ex);
            }
        }

        private void AddRequest(SimVar simVar)
        {
            Debug.WriteLine($"AddRequest: {simVar.SimConnectVariable} {simVar.SimConnectUnit}");

            SimvarRequest request = new SimvarRequest(simVar, (DEFINITION)_currentDefinition, (REQUEST)_currentRequest);

            RegisterWithSimConnect(request);

            _simvarRequests.Add(request);

            ++_currentDefinition;
            ++_currentRequest;

            _simConnect?.RequestDataOnSimObject(
                request.eRequest,
                request.eDef,
                SimConnect.SIMCONNECT_OBJECT_ID_USER,
                SIMCONNECT_PERIOD.VISUAL_FRAME,
                SIMCONNECT_DATA_REQUEST_FLAG.CHANGED, 0, 0, 0);
        }

        public class SimActivityEventArgs : EventArgs
        {
            public SimActivityEventArgs(string data, SimVar simVar)
            {
                this.Variable = simVar;
                this.Data = data;
            }

            public SimVar Variable { get; set; }

            public string Data { get; set; }

        }
    }
}
