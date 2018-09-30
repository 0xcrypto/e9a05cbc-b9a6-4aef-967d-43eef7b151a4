using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Parking.Common;
using Parking.Database.CommandFactory;
using Parking.Interfaces;
using Parking.PortCommunicate;

namespace Parking.Entry.Forms
{
    public partial class Settings : Form
    {
        private readonly IParkingDatabaseFactory parkingDatabaseFactory;
        private readonly int BAUD_RATE = 9600;
        private readonly Parity PARITY = Parity.None;
        private readonly int DATA_BITS = 8;
        private readonly StopBits STOP_BITS = StopBits.One;
        private TDClientSetting tdSetting;

        public Settings()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();
            var configrationReader = new ConfigurationReader(Application.ExecutablePath, @"DeviceConfig.json");
            tdSetting = configrationReader.Load();

            if (tdSetting.DeviceId == null)
                MessageBox.Show("Problem Loading Configuration Information");
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            parkingDatabaseFactory.UpdateMasterSettings(txtCompanyName.Text.ToString().Trim(),
                                                      txtParkingPlaceCode.Text.ToString().Trim(),
                                                      txtParkingPlaceName.Text.ToString().Trim(),
                                                      txtTwoWheelerParkingChargesPerHour.Text.ToString().Trim(),
                                                      txtFourWheelerParkingChargesPerHour.Text.ToString().Trim(),
                                                      txtLostTicketPenalty.Text.ToString().Trim());
            LoadSettings();
            Hide();
        }

        private void SettingsLoad(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;

            WindowState = FormWindowState.Maximized;

            Size = new Size(1024, 768);

            LoadSettings();

            lblSettingStatus.Text = "";
            lblSettingStatus.ForeColor = Color.Black;
        }
        
        private void LoadSettings()
        {
            var dr = parkingDatabaseFactory.GetMasterSettings();
            txtCompanyName.Text = dr[0].ToString().Trim();
            txtParkingPlaceCode.Text = dr[1].ToString().Trim();
            txtParkingPlaceName.Text = dr[2].ToString().Trim();
            txtTwoWheelerParkingChargesPerHour.Text = dr[3].ToString().Trim();
            txtFourWheelerParkingChargesPerHour.Text = dr[4].ToString().Trim();
            txtLostTicketPenalty.Text = dr[5].ToString().Trim();
        }

        private void BtnConnectPortClick(object sender, EventArgs e)
        {
            string portName = tdSetting.PLCBoardConnectPort;
            SerialPortCommunicate serialPortCommunicate = new SerialPortCommunicate();

            var result = serialPortCommunicate.Connect(portName, BAUD_RATE, PARITY, DATA_BITS, STOP_BITS);
            if (result)
            {
                lblSettingStatus.Text = "Port "+ portName + " connected successfully";
                lblSettingStatus.ForeColor = Color.Green;
            }
            else
            {
                lblSettingStatus.Text = "Problem connecting to Port "+ portName;
                lblSettingStatus.ForeColor = Color.Red;
            }
            serialPortCommunicate.RegisterVehicleEntryCallBack(HandleVehicleEntryData);

        }

        private void HandleVehicleEntryData(string obj)
        {
            ThreadPool.QueueUserWorkItem(VehicleLaunch);
        }

        private void VehicleLaunch(object state)
        {
            Invoke((Action)(() =>
            {
                var vehicleEntry = new VehicleEntry();
                vehicleEntry.Show();
            }));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbPLCBoardPortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
