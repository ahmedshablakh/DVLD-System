namespace DVLD_System
{
    partial class frmRenewLocalDrivingLicense
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowLicenseInfo = new System.Windows.Forms.Label();
            this.lblShowLicensesHistory = new System.Windows.Forms.Label();
            this.btnCls = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.grAppInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.TextBox();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.labl12 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblRLApplicationID = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lbl64 = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labNationalNo = new System.Windows.Forms.Label();
            this.labI = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grAppInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(56, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 350);
            this.panel1.TabIndex = 17;
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.pictureBox1);
            this.grFilter.Controls.Add(this.txtPersonID);
            this.grFilter.Controls.Add(this.label1);
            this.grFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grFilter.Location = new System.Drawing.Point(56, 80);
            this.grFilter.Name = "grFilter";
            this.grFilter.Size = new System.Drawing.Size(655, 111);
            this.grFilter.TabIndex = 16;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "Filter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources._15862658;
            this.pictureBox1.Location = new System.Drawing.Point(488, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // txtPersonID
            // 
            this.txtPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonID.Location = new System.Drawing.Point(193, 48);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(276, 36);
            this.txtPersonID.TabIndex = 1;
            this.txtPersonID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPersonID_KeyDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID :";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowLicenseInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(256, 965);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(184, 20);
            this.lblShowLicenseInfo.TabIndex = 15;
            this.lblShowLicenseInfo.Text = "Show New License Info";
            this.lblShowLicenseInfo.Click += new System.EventHandler(this.lblShowLicenseInfo_Click);
            // 
            // lblShowLicensesHistory
            // 
            this.lblShowLicensesHistory.AutoSize = true;
            this.lblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowLicensesHistory.ForeColor = System.Drawing.Color.Blue;
            this.lblShowLicensesHistory.Location = new System.Drawing.Point(58, 965);
            this.lblShowLicensesHistory.Name = "lblShowLicensesHistory";
            this.lblShowLicensesHistory.Size = new System.Drawing.Size(182, 20);
            this.lblShowLicensesHistory.TabIndex = 14;
            this.lblShowLicensesHistory.Text = "Show Licenses History";
            this.lblShowLicensesHistory.Click += new System.EventHandler(this.lblShowLicensesHistory_Click_1);
            // 
            // btnCls
            // 
            this.btnCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCls.Location = new System.Drawing.Point(623, 962);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(158, 48);
            this.btnCls.TabIndex = 13;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenew.Location = new System.Drawing.Point(805, 962);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(158, 48);
            this.btnRenew.TabIndex = 12;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // grAppInfo
            // 
            this.grAppInfo.Controls.Add(this.lblTotalFees);
            this.grAppInfo.Controls.Add(this.label8);
            this.grAppInfo.Controls.Add(this.label6);
            this.grAppInfo.Controls.Add(this.lblNotes);
            this.grAppInfo.Controls.Add(this.lblLicenseFees);
            this.grAppInfo.Controls.Add(this.labl12);
            this.grAppInfo.Controls.Add(this.lblExpirationDate);
            this.grAppInfo.Controls.Add(this.lblOldLicenseID);
            this.grAppInfo.Controls.Add(this.label4);
            this.grAppInfo.Controls.Add(this.lblCreateBy);
            this.grAppInfo.Controls.Add(this.label5);
            this.grAppInfo.Controls.Add(this.lblApplicationDate);
            this.grAppInfo.Controls.Add(this.lblRLApplicationID);
            this.grAppInfo.Controls.Add(this.lblIssueDate);
            this.grAppInfo.Controls.Add(this.lbl64);
            this.grAppInfo.Controls.Add(this.lblAppFees);
            this.grAppInfo.Controls.Add(this.lblRenewedLicenseID);
            this.grAppInfo.Controls.Add(this.labName);
            this.grAppInfo.Controls.Add(this.labGender);
            this.grAppInfo.Controls.Add(this.labNationalNo);
            this.grAppInfo.Controls.Add(this.labI);
            this.grAppInfo.Controls.Add(this.lblIssue);
            this.grAppInfo.Location = new System.Drawing.Point(56, 584);
            this.grAppInfo.Name = "grAppInfo";
            this.grAppInfo.Size = new System.Drawing.Size(932, 357);
            this.grAppInfo.TabIndex = 11;
            this.grAppInfo.TabStop = false;
            this.grAppInfo.Text = "Application Info";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalFees.Location = new System.Drawing.Point(724, 213);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(51, 20);
            this.lblTotalFees.TabIndex = 109;
            this.lblTotalFees.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(498, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 108;
            this.label8.Text = "Total Fees :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(84, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 107;
            this.label6.Text = "Notes :";
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(204, 252);
            this.lblNotes.Multiline = true;
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(688, 91);
            this.lblNotes.TabIndex = 106;
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLicenseFees.Location = new System.Drawing.Point(220, 211);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(51, 20);
            this.lblLicenseFees.TabIndex = 105;
            this.lblLicenseFees.Text = "[???]";
            // 
            // labl12
            // 
            this.labl12.AutoSize = true;
            this.labl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labl12.Location = new System.Drawing.Point(29, 209);
            this.labl12.Name = "labl12";
            this.labl12.Size = new System.Drawing.Size(160, 25);
            this.labl12.TabIndex = 104;
            this.labl12.Text = "License Fees : ";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExpirationDate.Location = new System.Drawing.Point(724, 133);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(51, 20);
            this.lblExpirationDate.TabIndex = 103;
            this.lblExpirationDate.Text = "[???]";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOldLicenseID.Location = new System.Drawing.Point(724, 90);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(51, 20);
            this.lblOldLicenseID.TabIndex = 102;
            this.lblOldLicenseID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(498, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 101;
            this.label4.Text = "Old License ID : ";
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreateBy.Location = new System.Drawing.Point(724, 172);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(51, 20);
            this.lblCreateBy.TabIndex = 100;
            this.lblCreateBy.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(498, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "Create By :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblApplicationDate.Location = new System.Drawing.Point(217, 87);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(51, 20);
            this.lblApplicationDate.TabIndex = 98;
            this.lblApplicationDate.Text = "[???]";
            // 
            // lblRLApplicationID
            // 
            this.lblRLApplicationID.AutoSize = true;
            this.lblRLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRLApplicationID.Location = new System.Drawing.Point(217, 49);
            this.lblRLApplicationID.Name = "lblRLApplicationID";
            this.lblRLApplicationID.Size = new System.Drawing.Size(51, 20);
            this.lblRLApplicationID.TabIndex = 90;
            this.lblRLApplicationID.Text = "[???]";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIssueDate.Location = new System.Drawing.Point(217, 125);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(51, 20);
            this.lblIssueDate.TabIndex = 96;
            this.lblIssueDate.Text = "[???]";
            // 
            // lbl64
            // 
            this.lbl64.AutoSize = true;
            this.lbl64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl64.Location = new System.Drawing.Point(26, 47);
            this.lbl64.Name = "lbl64";
            this.lbl64.Size = new System.Drawing.Size(203, 25);
            this.lbl64.TabIndex = 89;
            this.lbl64.Text = "R.L.Application ID : ";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppFees.Location = new System.Drawing.Point(217, 163);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(51, 20);
            this.lblAppFees.TabIndex = 95;
            this.lblAppFees.Text = "[???]";
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(724, 49);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(51, 20);
            this.lblRenewedLicenseID.TabIndex = 92;
            this.lblRenewedLicenseID.Text = "[???]";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labName.Location = new System.Drawing.Point(26, 85);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(183, 25);
            this.labName.TabIndex = 91;
            this.labName.Text = "Application Date :";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labGender.Location = new System.Drawing.Point(498, 44);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(216, 25);
            this.labGender.TabIndex = 88;
            this.labGender.Text = "Renewed License ID:";
            // 
            // labNationalNo
            // 
            this.labNationalNo.AutoSize = true;
            this.labNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labNationalNo.Location = new System.Drawing.Point(26, 161);
            this.labNationalNo.Name = "labNationalNo";
            this.labNationalNo.Size = new System.Drawing.Size(192, 25);
            this.labNationalNo.TabIndex = 87;
            this.labNationalNo.Text = "Application Fees : ";
            // 
            // labI
            // 
            this.labI.AutoSize = true;
            this.labI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labI.Location = new System.Drawing.Point(26, 123);
            this.labI.Name = "labI";
            this.labI.Size = new System.Drawing.Size(134, 25);
            this.labI.TabIndex = 86;
            this.labI.Text = "Issue Date : ";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIssue.Location = new System.Drawing.Point(498, 128);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(172, 25);
            this.lblIssue.TabIndex = 85;
            this.lblIssue.Text = "Expiration Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(334, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Renew Local Driving License";
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1079, 1042);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grFilter);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicensesHistory);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.grAppInfo);
            this.Name = "frmRenewLocalDrivingLicense";
            this.Text = "Renew Local Driving License";
            this.Load += new System.EventHandler(this.frmRenewLocalDrivingLicense_Load);
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grAppInfo.ResumeLayout(false);
            this.grAppInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowLicenseInfo;
        private System.Windows.Forms.Label lblShowLicensesHistory;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.GroupBox grAppInfo;
        public System.Windows.Forms.Label lblExpirationDate;
        public System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblApplicationDate;
        public System.Windows.Forms.Label lblRLApplicationID;
        public System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lbl64;
        public System.Windows.Forms.Label lblAppFees;
        public System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labNationalNo;
        private System.Windows.Forms.Label labI;
        private System.Windows.Forms.Label lblIssue;
        public System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label labl12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblNotes;
        public System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}