using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MSFSConnector
{
    class DeviceControl
    {
        private bool _continue;
        private static SerialPort _serialPort;
        private Thread _readThread;

        public event EventHandler ActivityRecieved;

        public void Connect(string comPort)
        {
            _readThread = new Thread(Read);

            _serialPort = new SerialPort();

            _serialPort.PortName = comPort;
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.RequestToSend;
            _serialPort.DtrEnable = true;

            _serialPort.ReadTimeout = 1000;
            _serialPort.WriteTimeout = 500;

            try
            {
                _serialPort.Open();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }

            _continue = true;
            _readThread.Start();
        }

        public void Disconnect()
        {
            _continue = false;
            _readThread.Join();
            _serialPort.Close();
        }

        public void SendMessage(MessageType type, string data)
        {
            _serialPort.Write($"{(int)type}{data}");
            _serialPort.Write(new char[] { (char)3 }, 0, 1);
        }

        public void Read()
        {
            while (_continue)
            {
                try
                {

                    string ETX = $"{(char)3}";

                    string message = _serialPort.ReadTo(ETX);
                    Debug.WriteLine(message);

                    ActivityType type = (ActivityType) Enum.Parse(typeof(ActivityType), message.Substring(0, 3), true);
                    string data = message.Remove(0, 3);

                    OnActivityRecieved(new ActivityEventArgs(type, data));

                    //}
                    //else
                    //{
                    //    Thread.Sleep(50);
                    //}
                }
                catch (TimeoutException) { }
            }
        }

        protected virtual void OnActivityRecieved(ActivityEventArgs e)
        {
            EventHandler handler = ActivityRecieved;
            handler?.Invoke(this, e);
        }

        public enum MessageType
        {
            COM1ACTV = 100,
            COM1STBY = 110,
            ALTITUDE = 120,
        }

        public enum ActivityType
        {
            COM1_MAJOR_UP = 100,
            COM1_MAJOR_DOWN = 101,
            COM1_MINOR_UP = 110,
            COM1_MINOR_DOWN = 111,
            COM1_SWAP = 120,
        }

        public class ActivityEventArgs : EventArgs
        {
            public ActivityEventArgs(ActivityType type, string data)
            {
                this.ActivityType = type;
                this.Data = data;
            }

            public ActivityType ActivityType { get; set; }
            public string Data { get; set; }

        }


    }
}
