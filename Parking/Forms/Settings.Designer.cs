namespace Parking.Entry.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFourWheelerParkingChargesPerHour = new System.Windows.Forms.TextBox();
            this.txtTwoWheelerParkingChargesPerHour = new System.Windows.Forms.TextBox();
            this.txtLostTicketPenalty = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtParkingPlaceName = new System.Windows.Forms.TextBox();
            this.txtParkingPlaceCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnectPort = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSettingStatus = new System.Windows.Forms.Label();
            this.cbTDClientPLCBoardPortNumber = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTDClientDeviceId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTDClientUserId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTDClientPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTDClientLongLat = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTDServerIPAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTDServerPortNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTDClientDriverCameraPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTDClientVehicleCameraIPAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTDClientVehicleCameraUserId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTDClientDriverCameraUserId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTDClientDriverCameraIPAddress = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTDClientVehicleCameraPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(673, 418);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(188, 33);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Parking Charges/Hours (4 Wheeler)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Parking Charges/Hours (2 Wheeler)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lost Ticket Penalty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Company Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Location Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Location Code";
            // 
            // txtFourWheelerParkingChargesPerHour
            // 
            this.txtFourWheelerParkingChargesPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFourWheelerParkingChargesPerHour.Location = new System.Drawing.Point(301, 134);
            this.txtFourWheelerParkingChargesPerHour.Margin = new System.Windows.Forms.Padding(2);
            this.txtFourWheelerParkingChargesPerHour.Name = "txtFourWheelerParkingChargesPerHour";
            this.txtFourWheelerParkingChargesPerHour.Size = new System.Drawing.Size(159, 26);
            this.txtFourWheelerParkingChargesPerHour.TabIndex = 21;
            // 
            // txtTwoWheelerParkingChargesPerHour
            // 
            this.txtTwoWheelerParkingChargesPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwoWheelerParkingChargesPerHour.Location = new System.Drawing.Point(301, 166);
            this.txtTwoWheelerParkingChargesPerHour.Margin = new System.Windows.Forms.Padding(2);
            this.txtTwoWheelerParkingChargesPerHour.Name = "txtTwoWheelerParkingChargesPerHour";
            this.txtTwoWheelerParkingChargesPerHour.Size = new System.Drawing.Size(159, 26);
            this.txtTwoWheelerParkingChargesPerHour.TabIndex = 22;
            // 
            // txtLostTicketPenalty
            // 
            this.txtLostTicketPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLostTicketPenalty.Location = new System.Drawing.Point(301, 199);
            this.txtLostTicketPenalty.Margin = new System.Windows.Forms.Padding(2);
            this.txtLostTicketPenalty.Name = "txtLostTicketPenalty";
            this.txtLostTicketPenalty.Size = new System.Drawing.Size(159, 26);
            this.txtLostTicketPenalty.TabIndex = 23;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(301, 40);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(159, 26);
            this.txtCompanyName.TabIndex = 24;
            // 
            // txtParkingPlaceName
            // 
            this.txtParkingPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParkingPlaceName.Location = new System.Drawing.Point(301, 71);
            this.txtParkingPlaceName.Margin = new System.Windows.Forms.Padding(2);
            this.txtParkingPlaceName.Name = "txtParkingPlaceName";
            this.txtParkingPlaceName.Size = new System.Drawing.Size(159, 26);
            this.txtParkingPlaceName.TabIndex = 25;
            // 
            // txtParkingPlaceCode
            // 
            this.txtParkingPlaceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParkingPlaceCode.Location = new System.Drawing.Point(301, 102);
            this.txtParkingPlaceCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtParkingPlaceCode.Name = "txtParkingPlaceCode";
            this.txtParkingPlaceCode.Size = new System.Drawing.Size(159, 26);
            this.txtParkingPlaceCode.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Port Number (PLC)";
            // 
            // btnConnectPort
            // 
            this.btnConnectPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectPort.Location = new System.Drawing.Point(495, 418);
            this.btnConnectPort.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectPort.Name = "btnConnectPort";
            this.btnConnectPort.Size = new System.Drawing.Size(174, 33);
            this.btnConnectPort.TabIndex = 30;
            this.btnConnectPort.Text = "Test Port";
            this.btnConnectPort.UseVisualStyleBackColor = true;
            this.btnConnectPort.Click += new System.EventHandler(this.BtnConnectPortClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(866, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 33);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSettingStatus
            // 
            this.lblSettingStatus.AutoSize = true;
            this.lblSettingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingStatus.Location = new System.Drawing.Point(16, 424);
            this.lblSettingStatus.Name = "lblSettingStatus";
            this.lblSettingStatus.Size = new System.Drawing.Size(0, 20);
            this.lblSettingStatus.TabIndex = 32;
            // 
            // cbTDClientPLCBoardPortNumber
            // 
            this.cbTDClientPLCBoardPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTDClientPLCBoardPortNumber.FormattingEnabled = true;
            this.cbTDClientPLCBoardPortNumber.Location = new System.Drawing.Point(315, 162);
            this.cbTDClientPLCBoardPortNumber.Name = "cbTDClientPLCBoardPortNumber";
            this.cbTDClientPLCBoardPortNumber.Size = new System.Drawing.Size(159, 28);
            this.cbTDClientPLCBoardPortNumber.TabIndex = 33;
            this.cbTDClientPLCBoardPortNumber.SelectedIndexChanged += new System.EventHandler(this.cbPLCBoardPortNumber_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.txtParkingPlaceName);
            this.groupBox1.Controls.Add(this.txtParkingPlaceCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLostTicketPenalty);
            this.groupBox1.Controls.Add(this.txtFourWheelerParkingChargesPerHour);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTwoWheelerParkingChargesPerHour);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 240);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtTDClientVehicleCameraPassword);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtTDClientDriverCameraIPAddress);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtTDClientDriverCameraUserId);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTDClientVehicleCameraUserId);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtTDClientVehicleCameraIPAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTDClientDriverCameraPassword);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTDClientLongLat);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbTDClientPLCBoardPortNumber);
            this.groupBox2.Controls.Add(this.txtTDClientPassword);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTDClientUserId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTDClientDeviceId);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(495, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 401);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TD Client Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Device ID";
            // 
            // txtTDClientDeviceId
            // 
            this.txtTDClientDeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientDeviceId.Location = new System.Drawing.Point(315, 36);
            this.txtTDClientDeviceId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientDeviceId.Name = "txtTDClientDeviceId";
            this.txtTDClientDeviceId.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientDeviceId.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "User ID";
            // 
            // txtTDClientUserId
            // 
            this.txtTDClientUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientUserId.Location = new System.Drawing.Point(315, 67);
            this.txtTDClientUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientUserId.Name = "txtTDClientUserId";
            this.txtTDClientUserId.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientUserId.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Password";
            // 
            // txtTDClientPassword
            // 
            this.txtTDClientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientPassword.Location = new System.Drawing.Point(315, 99);
            this.txtTDClientPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientPassword.Name = "txtTDClientPassword";
            this.txtTDClientPassword.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientPassword.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "LONG/LAT";
            // 
            // txtTDClientLongLat
            // 
            this.txtTDClientLongLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientLongLat.Location = new System.Drawing.Point(315, 131);
            this.txtTDClientLongLat.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientLongLat.Name = "txtTDClientLongLat";
            this.txtTDClientLongLat.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientLongLat.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtTDServerPortNumber);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTDServerIPAddress);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 156);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TD Server Settings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "IP Address";
            // 
            // txtTDServerIPAddress
            // 
            this.txtTDServerIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDServerIPAddress.Location = new System.Drawing.Point(301, 33);
            this.txtTDServerIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDServerIPAddress.Name = "txtTDServerIPAddress";
            this.txtTDServerIPAddress.Size = new System.Drawing.Size(159, 26);
            this.txtTDServerIPAddress.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Port Number";
            // 
            // txtTDServerPortNumber
            // 
            this.txtTDServerPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDServerPortNumber.Location = new System.Drawing.Point(301, 64);
            this.txtTDServerPortNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDServerPortNumber.Name = "txtTDServerPortNumber";
            this.txtTDServerPortNumber.Size = new System.Drawing.Size(159, 26);
            this.txtTDServerPortNumber.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Driver Camera Password";
            // 
            // txtTDClientDriverCameraPassword
            // 
            this.txtTDClientDriverCameraPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientDriverCameraPassword.Location = new System.Drawing.Point(315, 261);
            this.txtTDClientDriverCameraPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientDriverCameraPassword.Name = "txtTDClientDriverCameraPassword";
            this.txtTDClientDriverCameraPassword.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientDriverCameraPassword.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 299);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Vehicle Camera IP Address";
            // 
            // txtTDClientVehicleCameraIPAddress
            // 
            this.txtTDClientVehicleCameraIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientVehicleCameraIPAddress.Location = new System.Drawing.Point(315, 293);
            this.txtTDClientVehicleCameraIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientVehicleCameraIPAddress.Name = "txtTDClientVehicleCameraIPAddress";
            this.txtTDClientVehicleCameraIPAddress.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientVehicleCameraIPAddress.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 331);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Vehicle Camera User ID";
            // 
            // txtTDClientVehicleCameraUserId
            // 
            this.txtTDClientVehicleCameraUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientVehicleCameraUserId.Location = new System.Drawing.Point(315, 325);
            this.txtTDClientVehicleCameraUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientVehicleCameraUserId.Name = "txtTDClientVehicleCameraUserId";
            this.txtTDClientVehicleCameraUserId.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientVehicleCameraUserId.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 234);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 20);
            this.label17.TabIndex = 40;
            this.label17.Text = "Driver Camera User ID";
            // 
            // txtTDClientDriverCameraUserId
            // 
            this.txtTDClientDriverCameraUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientDriverCameraUserId.Location = new System.Drawing.Point(315, 228);
            this.txtTDClientDriverCameraUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientDriverCameraUserId.Name = "txtTDClientDriverCameraUserId";
            this.txtTDClientDriverCameraUserId.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientDriverCameraUserId.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 202);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(192, 20);
            this.label18.TabIndex = 42;
            this.label18.Text = "Driver Camera IP Address";
            // 
            // txtTDClientDriverCameraIPAddress
            // 
            this.txtTDClientDriverCameraIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientDriverCameraIPAddress.Location = new System.Drawing.Point(315, 196);
            this.txtTDClientDriverCameraIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientDriverCameraIPAddress.Name = "txtTDClientDriverCameraIPAddress";
            this.txtTDClientDriverCameraIPAddress.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientDriverCameraIPAddress.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 363);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(194, 20);
            this.label19.TabIndex = 44;
            this.label19.Text = "Vehicle Camera Password";
            // 
            // txtTDClientVehicleCameraPassword
            // 
            this.txtTDClientVehicleCameraPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDClientVehicleCameraPassword.Location = new System.Drawing.Point(315, 357);
            this.txtTDClientVehicleCameraPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDClientVehicleCameraPassword.Name = "txtTDClientVehicleCameraPassword";
            this.txtTDClientVehicleCameraPassword.Size = new System.Drawing.Size(159, 26);
            this.txtTDClientVehicleCameraPassword.TabIndex = 45;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSettingStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnectPort);
            this.Controls.Add(this.btnSaveSettings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFourWheelerParkingChargesPerHour;
        private System.Windows.Forms.TextBox txtTwoWheelerParkingChargesPerHour;
        private System.Windows.Forms.TextBox txtLostTicketPenalty;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtParkingPlaceName;
        private System.Windows.Forms.TextBox txtParkingPlaceCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConnectPort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSettingStatus;
        private System.Windows.Forms.ComboBox cbTDClientPLCBoardPortNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTDClientDeviceId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTDClientPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTDClientUserId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTDClientLongLat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTDServerIPAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTDServerPortNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTDClientDriverCameraIPAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTDClientDriverCameraUserId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTDClientVehicleCameraUserId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTDClientVehicleCameraIPAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTDClientDriverCameraPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTDClientVehicleCameraPassword;
    }
}

