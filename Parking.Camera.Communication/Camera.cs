using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace Parking.Camera.Communication
{
    public static class Camera
    {
        private const string DRIVER_IMAGE_URL = "https://dds.georgia.gov/sites/dds.georgia.gov/files/Teen%20Driver4.jpg";
        private const string VEHICLE_IMAGE_URL = "https://cleanvehiclerebate.org/sites/default/files/2014_Hyundai_Tucson_Fuel_Cell.jpg";
        
        public static System.Drawing.Bitmap GetDriverImage()
        {
            Bitmap bmp;
            try
            {
                HttpWebRequest request;
                HttpWebResponse response;
                Stream stream;

                request = (HttpWebRequest)WebRequest.Create(DRIVER_IMAGE_URL);
                request.AllowWriteStreamBuffering = true;
                response = (HttpWebResponse)request.GetResponse();
                if ((stream = response.GetResponseStream()) != null)
                    bmp = new Bitmap(stream);
            }
            catch (Exception e)
            {

            }
            return (bmp);
        }


    }
}
