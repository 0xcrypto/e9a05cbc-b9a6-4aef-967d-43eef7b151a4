using System;
using System.Drawing;
using System.Windows.Forms;
using Parking.Database.CommandFactory;

namespace Parking.Entry.Forms
{
    public partial class VehicleEntry : Form
    {
        private readonly ParkingDatabaseFactory parkingDatabaseFactory;

        public VehicleEntry()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            var type = 2; // 2 or 4
            var number = txtVehicleNumber.Text.ToString().Trim();
            parkingDatabaseFactory.SaveVehicleEntry(number, type);

            //var printer = new Printer();
            //printer.PrintTicket(txtVehicleNumber.Text);
            Console.WriteLine("Print");
            Hide();
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
            AddText(txtVehicleNumber.Text += btnEigth.Text);
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
