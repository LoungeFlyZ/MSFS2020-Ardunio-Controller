using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using Microsoft.FlightSimulator.SimConnect;

namespace MSFSConnector
{
    public partial class MainWindow : Window
    {
        private HwndSource _hwndSource;

        // handles msfs connection
        private SimControl _simControl;

        // handles connection to arduino device
        private DeviceControl _deviceControl;

        public MainWindow()
        {
            _simControl = new SimControl();
            _simControl.ActionReceived += simControl_ActionReceived;

            _deviceControl = new DeviceControl();
            _deviceControl.ActivityRecieved += DeviceActivityReceived;

            InitializeComponent();

            string port = AutodetectArduinoPort();

            cbo_ComPort.ItemsSource = ComPorts;
            cbo_ComPort.SelectedValue = port;
        }

        public ObservableCollection<ComPort> ComPorts { get; } = new ObservableCollection<ComPort>();
        
        private void simControl_ActionReceived(object sender, EventArgs e)
        {
            var simActivity = (SimControl.SimActivityEventArgs)e;

            if (simActivity.Variable.SimVariable == SimVars.COM_ACTIVE_FREQUENCY && simActivity.Variable.Index == 1)
            {
                _deviceControl.SendMessage(DeviceControl.MessageType.COM1ACTV, simActivity.Data);
            }

            if (simActivity.Variable.SimVariable == SimVars.COM_STANDBY_FREQUENCY && simActivity.Variable.Index == 1)
            {
                _deviceControl.SendMessage(DeviceControl.MessageType.COM1STBY, simActivity.Data);
            }
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            _hwndSource = (HwndSource) PresentationSource.FromVisual(this);
            _hwndSource.AddHook(WndProc);
        }

        protected bool CanConnect()
        {
            if (cbo_ComPort.SelectedValue != null)
            {
                return true;
            }

            return false;
        }

        private IntPtr WndProc(IntPtr hWnd, int iMsg, IntPtr hWParam, IntPtr hLParam, ref bool bHandled)
        {
            if (_simControl != null)
            {
                try
                {
                    if (iMsg == SimControl.WM_USER_SIMCONNECT)
                    {
                        _simControl.ReceiveSimConnectMessage();
                    }
                }
                catch
                {
                    _simControl.Disconnect();
                }
            }

            return IntPtr.Zero;
        }

        private void ToggleConnect(object sender, RoutedEventArgs e)
        {
            if (_simControl.Connected)
            {
                _simControl.Disconnect();

                try
                {
                    _deviceControl?.Disconnect();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                btn_Connection.Content = "Disconnected";
            }
            else
            {
                try
                {
                    _simControl.Connect(_hwndSource.Handle);
                    _deviceControl.Connect(cbo_ComPort.SelectedValue.ToString());
                    btn_Connection.Content = "Connected";
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Failed to connect to simulator\n{exception.Message}", "Failed to connect", MessageBoxButton.OK,
                        MessageBoxImage.Error);

                    Console.WriteLine(exception);
                }
            }
        }

        private void DeviceActivityReceived(object sender, EventArgs e)
        {
            var type = (DeviceControl.ActivityEventArgs)e;

            switch (type.ActivityType)
            {
                case DeviceControl.ActivityType.COM1_MAJOR_UP:
                    _simControl.TransmitClientEvent(EVENT_IDS.COM_RADIO_WHOLE_INC, 0, GROUPS.GROUP1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;

                case DeviceControl.ActivityType.COM1_MAJOR_DOWN:
                    _simControl.TransmitClientEvent(EVENT_IDS.COM_RADIO_WHOLE_DEC, 0, GROUPS.GROUP1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;

                case DeviceControl.ActivityType.COM1_MINOR_UP:
                    _simControl.TransmitClientEvent(EVENT_IDS.COM_RADIO_FRACT_INC, 0, GROUPS.GROUP1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;

                case DeviceControl.ActivityType.COM1_MINOR_DOWN:
                    _simControl.TransmitClientEvent(EVENT_IDS.COM_RADIO_FRACT_DEC, 0, GROUPS.GROUP1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;

                case DeviceControl.ActivityType.COM1_SWAP:
                    _simControl.TransmitClientEvent(EVENT_IDS.COM_STBY_RADIO_SWAP, 0, GROUPS.GROUP1, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;

                default:
                    Debug.WriteLine($"Unknown message from device: {type.ActivityType} {type.Data}");
                    break;
            }
        }
        
        private string AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    var comboEntry = $"{desc} - {deviceId}";
                    ComPorts.Add(new ComPort() { DisplayValue = comboEntry, Value = deviceId });

                    if (desc.Contains("Arduino"))
                    {
                        return deviceId;
                    }
                }
            }
            catch (ManagementException e)
            {
                /* Do Nothing */
            }

            return null;
        }
    }

    public class ComPort
    {
        public string Value { get; set; }
        public string DisplayValue { get; set; }
    }
}
