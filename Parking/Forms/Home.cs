using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parking.Entry.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.Show();
        }

        private void EntryToolStripMenuItemClick(object sender, EventArgs e)
        {
            var vehicleEntry = new VehicleEntry();
            vehicleEntry.Show();
        }

        private void HomeLoad(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Size = new Size(1024, 768);

            //C:\Projects\ConsoleApplication1\bin\Debug
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}