namespace DVLD_System
{
    partial class frmDetainLicense
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
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.btnCls = new System.Windows.Forms.Button();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblShowLicenseInfo = new System.Windows.Forms.Label();
            this.lblShowLicensesHistory = new System.Windows.Forms.Label();
            this.lbl64 = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetain = new System.Windows.Forms.Button();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labNationalNo = new System.Windows.Forms.Label();
            this.grAppInfo = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grAppInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPersonID
            // 
            this.txtPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonID.Location = new System.Drawing.Point(193, 48);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(276, 36);
            this.txtPersonID.TabIndex = 1;
            this.txtPersonID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPersonID_KeyDown);
            // 
            // btnCls
            // 
            this.btnCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCls.Location = new System.Drawing.Point(642, 795);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(158, 48);
            this.btnCls.TabIndex = 30;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreateBy.Location = new System.Drawing.Point(663, 94);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(51, 20);
            this.lblCreateBy.TabIndex = 100;
            this.lblCreateBy.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(501, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "Create By :";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetainDate.Location = new System.Drawing.Point(188, 86);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(51, 20);
            this.lblDetainDate.TabIndex = 98;
            this.lblDetainDate.Text = "[???]";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetainID.Location = new System.Drawing.Point(188, 49);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(51, 20);
            this.lblDetainID.TabIndex = 90;
            this.lblDetainID.Text = "[???]";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowLicenseInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(275, 798);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(184, 20);
            this.lblShowLicenseInfo.TabIndex = 32;
            this.lblShowLicenseInfo.Text = "Show New License Info";
            this.lblShowLicenseInfo.Click += new System.EventHandler(this.lblShowLicenseInfo_Click);
            // 
            // lblShowLicensesHistory
            // 
            this.lblShowLicensesHistory.AutoSize = true;
            this.lblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowLicensesHistory.ForeColor = System.Drawing.Color.Blue;
            this.lblShowLicensesHistory.Location = new System.Drawing.Point(77, 798);
            this.lblShowLicensesHistory.Name = "lblShowLicensesHistory";
            this.lblShowLicensesHistory.Size = new System.Drawing.Size(182, 20);
            this.lblShowLicensesHistory.TabIndex = 31;
            this.lblShowLicensesHistory.Text = "Show Licenses History";
            this.lblShowLicensesHistory.Click += new System.EventHandler(this.lblShowLicensesHistory_Click);
            // 
            // lbl64
            // 
            this.lbl64.AutoSize = true;
            this.lbl64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl64.Location = new System.Drawing.Point(51, 47);
            this.lbl64.Name = "lbl64";
            this.lbl64.Size = new System.Drawing.Size(114, 25);
            this.lbl64.TabIndex = 89;
            this.lbl64.Text = "Detain ID :";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFineFees.Location = new System.Drawing.Point(188, 123);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(51, 20);
            this.lblFineFees.TabIndex = 95;
            this.lblFineFees.Text = "[???]";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labName.Location = new System.Drawing.Point(27, 84);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(138, 25);
            this.labName.TabIndex = 91;
            this.labName.Text = "Detain Date :";
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
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLicenseID.Location = new System.Drawing.Point(663, 49);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(51, 20);
            this.lblLicenseID.TabIndex = 92;
            this.lblLicenseID.Text = "[???]";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labGender.Location = new System.Drawing.Point(495, 44);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(127, 25);
            this.labGender.TabIndex = 88;
            this.labGender.Text = "License ID :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(67, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 350);
            this.panel1.TabIndex = 34;
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetain.Location = new System.Drawing.Point(824, 795);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(158, 48);
            this.btnDetain.TabIndex = 29;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.pictureBox1);
            this.grFilter.Controls.Add(this.txtPersonID);
            this.grFilter.Controls.Add(this.label1);
            this.grFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grFilter.Location = new System.Drawing.Point(67, 88);
            this.grFilter.Name = "grFilter";
            this.grFilter.Size = new System.Drawing.Size(655, 111);
            this.grFilter.TabIndex = 33;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labNationalNo
            // 
            this.labNationalNo.AutoSize = true;
            this.labNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labNationalNo.Location = new System.Drawing.Point(38, 121);
            this.labNationalNo.Name = "labNationalNo";
            this.labNationalNo.Size = new System.Drawing.Size(127, 25);
            this.labNationalNo.TabIndex = 87;
            this.labNationalNo.Text = "Fine Fees : ";
            // 
            // grAppInfo
            // 
            this.grAppInfo.Controls.Add(this.lblCreateBy);
            this.grAppInfo.Controls.Add(this.label5);
            this.grAppInfo.Controls.Add(this.lblDetainDate);
            this.grAppInfo.Controls.Add(this.lblDetainID);
            this.grAppInfo.Controls.Add(this.lbl64);
            this.grAppInfo.Controls.Add(this.lblFineFees);
            this.grAppInfo.Controls.Add(this.lblLicenseID);
            this.grAppInfo.Controls.Add(this.labName);
            this.grAppInfo.Controls.Add(this.labGender);
            this.grAppInfo.Controls.Add(this.labNationalNo);
            this.grAppInfo.Location = new System.Drawing.Point(67, 592);
            this.grAppInfo.Name = "grAppInfo";
            this.grAppInfo.Size = new System.Drawing.Size(932, 179);
            this.grAppInfo.TabIndex = 28;
            this.grAppInfo.TabStop = false;
            this.grAppInfo.Text = "Application Info";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(406, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 29);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Detain License";
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 889);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicensesHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.grFilter);
            this.Controls.Add(this.grAppInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grAppInfo.ResumeLayout(false);
            this.grAppInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnCls;
        public System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblDetainDate;
        public System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblShowLicenseInfo;
        private System.Windows.Forms.Label lblShowLicensesHistory;
        private System.Windows.Forms.Label lbl64;
        public System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labNationalNo;
        private System.Windows.Forms.GroupBox grAppInfo;
        private System.Windows.Forms.Label lblTitle;
    }
}