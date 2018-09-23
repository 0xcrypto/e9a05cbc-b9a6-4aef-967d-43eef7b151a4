using System;
using System.Linq;
using QRCoder;

namespace Parking.Common
{
    public static class QrCode
    {
        public static string GenerateQrCode(string vehicleNumber, string validationNumber)
        {
            var newGuid = new Guid();
            var splitGuid = newGuid.ToString().Split('-');

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(validationNumber, QRCodeGenerator.ECCLevel.Q);
            //var qrCode = new QrCode(qrCodeData);
            //var qrCodeImage = qrCode.GetGraphic(20);

            //qrCode.drawBarcode("C:\\qrcode.gif");
            var myQRcode = "M" + validationNumber + splitGuid.FirstOrDefault() + vehicleNumber + "A5";
            return myQRcode;
        }
    }
}
