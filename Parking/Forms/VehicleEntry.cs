using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Parking.Database.CommandFactory;
using Parking.Common;
using Parking.Common.Model;
using System.IO;
using System.Reflection;

namespace Parking.Entry.Forms
{
    public partial class VehicleEntry : Form
    {
        private TDClientSetting tdSetting;
        private readonly ParkingDatabaseFactory parkingDatabaseFactory;
        private static Ticket ticket;

        public VehicleEntry()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();
            var configrationReader = new ConfigurationReader(Application.ExecutablePath, @"DeviceConfig.json");
            tdSetting = configrationReader.Load();

            if (tdSetting.DeviceId == null)
                MessageBox.Show("Problem Loading Configuration Information");
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            if (tdSetting.DeviceId == null)
                return;

            var vehicleType = 2; // 2 or 4
            var vehicleNumber = txtVehicleNumber.Text.ToString().Trim();
            ticket = parkingDatabaseFactory.SaveVehicleEntry(tdSetting.DeviceId, vehicleNumber, vehicleType);

            PrintTicket();
            Hide();
        }

        public void PrintTicket()
        {
            string file = Guid.NewGuid().ToString();
            string directory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Tickets\");
            
            PrintDocument doc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    //PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true,
                    PrintFileName = Path.Combine(directory, file + ".pdf"),
                }
            };
            doc.DefaultPageSettings.PaperSize = new PaperSize("Parking Slip", 227, 393);
            doc.PrintPage += new PrintPageEventHandler(this.PrintPage);
            doc.Print();
        }

        public void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            var SPACE = 10;

            var font = new Font("Times new Roman", 12, FontStyle.Regular);
            var smallFont = new Font("Times new Roman", 8, FontStyle.Regular);

            g.DrawString("NDMC SMART PARKING", font, Brushes.Black, new PointF(10, 10));
            g.DrawString("PALIKA PARKING", font, Brushes.Black, new PointF(10, 30));
            g.DrawString("Ticket No. :", font, Brushes.Black, new PointF(10, 50));
            g.DrawString(ticket.TicketNumber, font, Brushes.Black, new PointF(120, 50));
            g.DrawString("Validation No. :", font, Brushes.Black, new PointF(10, 70)); 
            g.DrawString(ticket.ValidationNumber, font, Brushes.Black, new PointF(120, 70));

            g.DrawImage(ticket.QRCodeImage, 50, 100);

            g.DrawString(ticket.QRCode.Substring(0, 40), smallFont, Brushes.Black, new PointF(10, 220), StringFormat.GenericTypographic);

            g.DrawString("Vehicle No. :", font, Brushes.Black, new PointF(10, 250));
            g.DrawString("_"+ticket.VehicleNumber, font, Brushes.Black, new PointF(120, 250));
            g.DrawString("In Time:", font, Brushes.Black, new PointF(10, 270));
            g.DrawString(ticket.EntryTime.ToString(), font, Brushes.Black, new PointF(120, 270));

            g.DrawString("Parking at Owners Risk", font, Brushes.Black, new PointF(10, 290));
            g.DrawString("Two Wheeler Rs. 5 Per Hour", font, Brushes.Black, new PointF(10, 310));
            g.DrawString("Lost ticket penalty Rs.50/-", font, Brushes.Black, new PointF(10, 330));
            g.DrawString("and Parking charges as applicable.", font, Brushes.Black, new PointF(10, 350));
            g.DrawString("NDMC smart Parking", font, Brushes.Black, new PointF(10, 370));

            g.Dispose();
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
        }

    }
}
