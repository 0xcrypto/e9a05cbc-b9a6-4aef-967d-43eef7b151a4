using System;
using System.IO.Ports;
using Parking.Interfaces;

namespace Parking.PortCommunicate
{
    public class SerialPortCommunicate : ISerialPortCommunicate
    {
        private SerialPort sPort;
        private Action<string> vehicleEntryCallback;

        public void Connect(string portName, int baudRate, Parity parity, int databits, StopBits stopBits)
        {
            sPort = new SerialPort(portName, baudRate, parity, databits, stopBits);
            try
            {
                sPort.Open();
                sPort.DataReceived += SubscribePortDataReceived;
                Console.WriteLine("Connected Port");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString(), "Error");
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
                Console.WriteLine(e);
            }
        }

        //private void VehicleEntry()
        //{
        //    Console.WriteLine("Vehicle come to Entry Gate");
        //    ThreadPool.QueueUserWorkItem(VehicleEntryLaunch);
        //}
        //private void VehicleEntryLaunch(object state)
        //{
        //    var form2 = new VehicleEntry();
        //    form2.Text = "Bad one";
        //    form2.Show();
        //}
    }
}
