using System;
using System.IO.Ports;
using Parking.Common;
using Parking.Interfaces;

namespace Parking.PortCommunicate
{
    public class SerialPortCommunicate : ISerialPortCommunicate
    {
        private SerialPort sPort;
        private Action<string> vehicleEntryCallback;

        public bool Connect(string portName, int baudRate, Parity parity, int databits, StopBits stopBits)
        {
            sPort = new SerialPort(portName, baudRate, parity, databits, stopBits);
            try
            {
                sPort.Open();
                sPort.DataReceived += SubscribePortDataReceived;
                Console.WriteLine("Connected Port");
                return true;
            }
            catch (Exception e)
            {
                FileLogger.Log($"Connection between TDclient and Device failed as : {e.Message}");
                return false;
            }
        }

        private void SubscribePortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var dataReceived = sPort.ReadExisting();

            switch (dataReceived)
            {
                case "PARKING_ENTRY":
                    vehicleEntryCallback(dataReceived);
                    break;
                case "PARKING_EXIT":
                    Console.WriteLine("Vehicle come to Exit Gate");
                    break;
                default:
                    Console.WriteLine("Invalid Data");
                    break;
            }
        }

        /// <summary>
        /// Registers call back method
        /// </summary>
        /// <param name="vehicleEntryCallback">CallBack Method Name</param>
        public void RegisterVehicleEntryCallBack(Action<string> vehicleEntryCallback)
        {
            try
            {
                this.vehicleEntryCallback = vehicleEntryCallback;
            }
            catch (Exception e)
            {
                FileLogger.Log($"No callback assigned for Vehicle Entry : {e.Message}");
            }
        }
    }
}
