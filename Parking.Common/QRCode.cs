using System;
using System.Linq;
using QRCoder;

namespace Parking.Common
{
    public static class QRCode
    {
        public static string Generate(string validationNumber, string vehicleNumber, int vehicleType, string entryTime)
        {
            return Security.Encrypt(validationNumber + "_" + vehicleNumber + "_" + vehicleType + "_" + entryTime);
        }
    }
}
