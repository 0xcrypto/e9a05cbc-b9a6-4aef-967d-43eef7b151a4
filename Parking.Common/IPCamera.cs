using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Drawing;
using System.IO;

namespace Parking.Common
{
    public class IPCamera
    {
        private const string DRIVER_IMAGE_URL = "https://cleanvehiclerebate.org/sites/default/files/2014_Hyundai_Tucson_Fuel_Cell.jpg";
        private const string VEHICLE_IMAGE_URL = "https://cleanvehiclerebate.org/sites/default/files/2014_Hyundai_Tucson_Fuel_Cell.jpg";

        public static Bitmap GetDriverImage()
        {
            Bitmap image = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DRIVER_IMAGE_URL);
                request.AllowWriteStreamBuffering = true;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();

                if (stream != null)
                {
                    image = new Bitmap(stream);   
                }
            }
            catch (Exception e)
            {
                image = new Bitmap(1,1);
            }

            return image;
        }

        public static Bitmap GetVehicleImage()
        {
            Bitmap image = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(VEHICLE_IMAGE_URL);
                request.AllowWriteStreamBuffering = true;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();

                if (stream != null)
                {
                    image = new Bitmap(stream);
                }
            }
            catch (Exception)
            {
                image = new Bitmap(1, 1);
            }

            return image;
        }
    }
}
