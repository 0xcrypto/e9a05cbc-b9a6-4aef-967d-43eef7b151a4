using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Parking.Database.CommandFactory;
using Parking.Common;
using Parking.Common.Model;
using System.IO;
using Parking.Common.Enums;
using System.Threading;
using Parking.Utilities;

namespace Parking.Entry.Forms
{
    public partial class VehicleEntry : Form
    {
        private TDClientSetting tdSetting;
        private readonly ParkingDatabaseFactory parkingDatabaseFactory;
        private static Ticket ticket;
        private string CompnayName;
        private string ParkingPlaceName;
        private string TwoWheelerParkingCharge;
        private string FourWheelerParkingCharge;
        private string LostTicketPenality;
        private string TicketFooterString;
        private VehicleType _vehicleType;
        public VehicleEntry(string vehicleType) : this()
        {
            //Assign Vehicle Type on the basis of message sent from PLC Board
            _vehicleType = vehicleType.Equals("TWO_WHEELER_PARKING_ENTRY") ? VehicleType.Two_Wheeler : VehicleType.Four_Wheeler;
        }

        public VehicleEntry()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();

            tdSetting = ConfigurationReader.GetConfigurationSettings();

            if (tdSetting.TDClientDeviceId == null)
                FileLogger.Log($"Problem Loading Configuration Information from Configuration File");

            LoadMasterSetting();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (tdSetting.TDClientDeviceId == null)
                    return;

                var vehicleNumber = txtVehicleNumber.Text.ToString().Trim();

                generateTicket(vehicleNumber);
                PrintTicket();
                Hide();

                parkingDatabaseFactory.SaveVehicleEntry(tdSetting.TDClientDeviceId, ticket);

                ThreadPool.QueueUserWorkItem(Queuer.Dequeue, null);
            }
            catch (Exception exception)
            {
                ThreadPool.QueueUserWorkItem(Queuer.Queue, ticket);
                FileLogger.Log($"Ticket Processing Failed as : {exception.Message} ");
            }
            finally
            {
                _vehicleType = VehicleType.Unknown;
                ticket = null;
            }
        }

        private void generateTicket(string vehicleNumber)
        {
            var ticketNumber = parkingDatabaseFactory.GetUniqueCode();
            var validationNumber = parkingDatabaseFactory.GetUniqueCode();
            var entryTime = DateTime.Now.ToString();
            var qrCode = QRCode.GenerateQRCode(vehicleNumber, validationNumber, (int)_vehicleType, entryTime);
            var qrCodeImage = QRCode.GetQRCodeImage(qrCode);
            var driverImage = (Image)IPCamera.GetDriverImage();
            var vehicleImage = (Image)IPCamera.GetVehicleImage();

            ticket = new Ticket()
            {
                TicketNumber = ticketNumber,
                ValidationNumber = validationNumber,
                VehicleNumber = vehicleNumber,
                VehicleType = _vehicleType,
                QRCodeImage = qrCodeImage,
                QRCode = qrCode,
                EntryTime = entryTime,
                DriverImage = (Bitmap)driverImage,
                VehicleImage= (Bitmap)vehicleImage
            };
        }


        private void PrintTicket()
        {
            try
            {
                string file = Guid.NewGuid().ToString();
                string directory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Tickets\");

                PrintDocument doc = new PrintDocument()
                {
                    PrinterSettings = new PrinterSettings()
                    {
                        PrinterName = new PrinterSettings().PrinterName,
                        PrintToFile = true,
                        PrintFileName = Path.Combine(directory, file + ".pdf"),
                    }
                };
                doc.DefaultPageSettings.PaperSize = new PaperSize("Parking Slip", 227, 393);
                doc.PrintPage += new PrintPageEventHandler(this.PrintPage);
                doc.Print();
                /*
               TODO: REMOVE FOR LIVE RUN
               PrintDialog pdi = new PrintDialog();
               pdi.Document = doc;
               if (pdi.ShowDialog() == DialogResult.OK) {
                   doc.Print();
               }
               else {
                   MessageBox.Show("Print Cancelled");
               }
           */
            }
            catch (Exception e)
            {
                FileLogger.Log($"Ticket could not be printed Successfully as : {e.Message}");
            }
        }

        public void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font Font_12 = new Font("Times new Roman", 12, FontStyle.Regular);
            Font Font_10 = new Font("Times new Roman", 10, FontStyle.Regular);
            Font Font_8 = new Font("Times new Roman", 8, FontStyle.Regular);
            float leading = 4;
            float startX = 0;
            float startY = leading;
            float Offset = 0;
            float lineheight12 = Font_12.GetHeight() + leading;
            float lineheight8 = Font_8.GetHeight() + leading;
            float lineheightQRCode = 110 + leading;
            int ReciptWidth = 227;
            int ReciptHeight = 393;
            var TICKET_NO_LABEL = "Ticket No. : ";
            var VALIDATION_NO_LABEL = "Validation No. : ";
            var VEHICLE_NO_LABEL = "Vehicle No. : ";
            var VEHICLE_IN_LABEL = "IN: ";

            StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatLeft)
            {
                Alignment = StringAlignment.Center
            };
            SizeF layoutSize = new SizeF(ReciptWidth - Offset * 2, ReciptHeight);
            RectangleF layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            Brush brush = Brushes.Black;

            g.DrawString(CompnayName, Font_12, brush, layout, formatCenter);
            Offset = Offset + lineheight12;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawString(ParkingPlaceName, Font_12, brush, layout, formatCenter);
            Offset = Offset + lineheight12;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawString(TICKET_NO_LABEL + ticket.TicketNumber, Font_12, brush, layout, formatCenter);
            Offset = Offset + lineheight12;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawString(VALIDATION_NO_LABEL + ticket.ValidationNumber, Font_12, brush, layout, formatCenter);
            Offset = Offset + lineheight12;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawImage(ticket.QRCodeImage, 50, 100);
            Offset = Offset + lineheightQRCode;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawString(ticket.QRCode.Substring(0, 30), Font_8, brush, layout, formatCenter);
            Offset = Offset + lineheight8;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawString(VEHICLE_NO_LABEL + ticket.VehicleNumber, Font_12, brush, layout, formatCenter);
            Offset = Offset + lineheight12;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawString(ticket.VehicleType.ToString(), Font_12, brush, layout, formatCenter);
            Offset = Offset + lineheight12;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawString(VEHICLE_IN_LABEL + ticket.EntryTime, Font_12, brush, layout, formatCenter);
            Offset = Offset + lineheight12;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            g.DrawString(TicketFooterString, Font_10, brush, layout, formatCenter);
            g.Dispose();
            Font_12.Dispose();
            Font_10.Dispose();
            Font_8.Dispose();

        }

        private void AddText(string postfixText)
        {
            txtVehicleNumber.Text += postfixText;
        }

        private void BtnOneClick(object sender, EventArgs e)
        {
            AddText(btnOne.Text);
        }


        private void BtnTwoClick(object sender, EventArgs e)
        {
            AddText(btnTwo.Text);
        }

        private void BtnThreeClick(object sender, EventArgs e)
        {
            AddText(btnThree.Text);
        }

        private void BtnFourClick(object sender, EventArgs e)
        {
            AddText(btnFour.Text);
        }

        private void BtnFiveClick(object sender, EventArgs e)
        {
            AddText(btnFive.Text);
        }

        private void BtnSixClick(object sender, EventArgs e)
        {
            AddText(btnSix.Text);
        }

        private void BtnSevenClick(object sender, EventArgs e)
        {
            AddText(btnSeven.Text);
        }

        private void BtnEigthClick(object sender, EventArgs e)
        {
            AddText(btnEigth.Text);
        }

        private void BtnNineClick(object sender, EventArgs e)
        {
            AddText(btnNine.Text);
        }

        private void BtnZeroClick(object sender, EventArgs e)
        {
            AddText(btnZero.Text);
        }

        private void BtnBackSpaceClick(object sender, EventArgs e)
        {
            var length = txtVehicleNumber.Text.Length;
            if (length > 0)
            {
                txtVehicleNumber.Text = txtVehicleNumber.Text.Remove(length - 1);
            }
        }

        private void BtnHrClick(object sender, EventArgs e)
        {
            AddText(btnHR.Text);
        }

        private void BtnUpClick(object sender, EventArgs e)
        {
            AddText(btnUP.Text);
        }

        private void BtnPbClick(object sender, EventArgs e)
        {
            AddText(btnPB.Text);
        }

        private void BtnChClick(object sender, EventArgs e)
        {
            AddText(btnCH.Text);
        }

        private void BtnDlClick(object sender, EventArgs e)
        {
            AddText(btnDL.Text);
        }

        private void BtnRjClick(object sender, EventArgs e)
        {
            AddText(btnRJ.Text);
        }

        private void VehicleEntryLoad(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Size = new Size(1024, 768);

            //Set Vechile_Type Image on vechile entry 
            if (_vehicleType == VehicleType.Two_Wheeler)
            {
                PictureBox_Vehicle.Image = Properties.Resources.Two_Wheeler_Img;
            }
            else if (_vehicleType == VehicleType.Four_Wheeler)
            {

                PictureBox_Vehicle.Image = Properties.Resources.Four_Wheeler_Img;
            }
            else
            {
                PictureBox_Vehicle.Hide();
            }
        }

        private void LoadMasterSetting()
        {
            try
            {
                var dr = parkingDatabaseFactory.GetMasterSettings();
                CompnayName = dr[0].ToString().Trim();
                ParkingPlaceName = dr[2].ToString().Trim();
                TwoWheelerParkingCharge = dr[3].ToString().Trim();
                FourWheelerParkingCharge = dr[4].ToString().Trim();
                LostTicketPenality = dr[5].ToString().Trim();
                TicketFooterString = String.Format("Parking at Owners Risk.\n " +
                    "Four Wheeler Rs. {0} Per Hour.\n " +
                    "Lost Ticket Penality Rs. {1}/-\n" +
                    "and Parking Charges as applicable.\n " +
                    "{2}", FourWheelerParkingCharge, LostTicketPenality, CompnayName);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
