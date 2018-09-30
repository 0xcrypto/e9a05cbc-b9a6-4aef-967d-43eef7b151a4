using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Parking.Common.Model
{
    public class Ticket
    {
        public string TicketNumber{ get; set;}
        public string VehicleNumber { get; set; }
        public string VehicleType { get; set; }
        public string EntryTime { get; set; }
        public string ExitTime { get; set; }
        public string ValidationNumber { get; set; }
        public Bitmap QRCodeImage { get; set; }
        public string QRCode { get; set; }
    }
}
