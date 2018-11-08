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
            this.btnConnectPort = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSettingStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 460);
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
        private System.Windows.Forms.Button btnConnectPort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSettingStatus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

