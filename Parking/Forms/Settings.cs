using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
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

        public Settings()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            parkingDatabaseFactory.UpdateMasterSettings(txtCompanyName.Text.ToString().Trim(),
                                                      txtParkingPlaceCode.Text.ToString().Trim(),
                                                      txtParkingPlaceName.Text.ToString().Trim(),
                                                      txtTwoWheelerParkingChargesPerHour.Text.ToString().Trim(),
                                                      txtFourWheelerParkingChargesPerHour.Text.ToString().Trim(),
                                                      txtLostTicketPenalty.Text.ToString().Trim(),
                                                      cbTDClientPLCBoardPortNumber.SelectedItem.ToString().ToString().Trim(),
                                                      txtTDServerIPAddress.Text.ToString().Trim(), 
                                                      txtTDServerPortNumber.Text.ToString().Trim(),
                                                      txtTDClientDeviceId.Text.ToString().Trim(),
                                                      txtTDClientUserId.Text.ToString().Trim(),
                                                      txtTDClientPassword.Text.ToString().Trim(),
                                                      txtTDClientLongLat.Text.ToString().Trim(),
                                                      txtTDClientDriverCameraIPAddress.Text.ToString().Trim(),
                                                      txtTDClientDriverCameraUserId.Text.ToString().Trim(),
                                                      txtTDClientDriverCameraPassword.Text.ToString().Trim(),
                                                      txtTDClientVehicleCameraIPAddress.Text.ToString().Trim(),
                                                      txtTDClientVehicleCameraUserId.Text.ToString().Trim(),
                                                      txtTDClientVehicleCameraPassword.Text.ToString().Trim());
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
            LoadPorts(dr[6].ToString().Trim());
            txtTDServerIPAddress.Text = dr[7].ToString().Trim();
            txtTDServerPortNumber.Text = dr[8].ToString().Trim();
            txtTDClientDeviceId.Text = dr[9].ToString().Trim();
            txtTDClientUserId.Text = dr[10].ToString().Trim();
            txtTDClientPassword.Text = dr[11].ToString().Trim();
            txtTDClientLongLat.Text = dr[12].ToString().Trim();
            txtTDClientDriverCameraIPAddress.Text = dr[13].ToString().Trim();
            txtTDClientDriverCameraUserId.Text = dr[14].ToString().Trim();
            txtTDClientDriverCameraPassword.Text = dr[15].ToString().Trim();
            txtTDClientVehicleCameraIPAddress.Text = dr[16].ToString().Trim();
            txtTDClientVehicleCameraUserId.Text = dr[17].ToString().Trim();
            txtTDClientVehicleCameraPassword.Text = dr[18].ToString().Trim();
        }

        private void LoadPorts(string selectedPort) {
            foreach (string port in SerialPort.GetPortNames()) {
                cbTDClientPLCBoardPortNumber.Items.Add(port);
            }

            cbTDClientPLCBoardPortNumber.SelectedIndex = cbTDClientPLCBoardPortNumber.FindStringExact(selectedPort);
        }

        private void BtnConnectPortClick(object sender, EventArgs e)
        {
            string portName = cbTDClientPLCBoardPortNumber.SelectedItem.ToString();
            SerialPortCommunicate serialPortCommunicate = new SerialPortCommunicate();

            var result = serialPortCommunicate.Connect(portName, BAUD_RATE, PARITY, DATA_BITS, STOP_BITS);
            if (result)
            {
                lblSettingStatus.Text = "Port connected successfully";
                lblSettingStatus.ForeColor = Color.Green;
            }
            else
            {
                lblSettingStatus.Text = "Problem connecting to Port";
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
