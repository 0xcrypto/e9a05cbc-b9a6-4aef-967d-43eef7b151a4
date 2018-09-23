using System.IO.Ports;

namespace Parking.Interfaces
{
    public interface ISerialPortCommunicate
    {
        void Connect(string portName, int baudRate, Parity parity, int databits, StopBits stopBits);
    }
}
