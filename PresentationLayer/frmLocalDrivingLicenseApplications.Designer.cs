namespace DVLD_System
{
    partial class frmLocalDrivingLicenseApplications
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
            this.components = new System.ComponentModel.Container();
            this.comStatus = new System.Windows.Forms.ComboBox();
            this.comFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblRecordText = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SchduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schesuleVisoimTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schesuleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schesuleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.callToUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewLocalApplications = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comStatus
            // 
            this.comStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comStatus.FormattingEnabled = true;
            this.comStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Completed",
            "Cancelled"});
            this.comStatus.Location = new System.Drawing.Point(399, 279);
            this.comStatus.Name = "comStatus";
            this.comStatus.Size = new System.Drawing.Size(124, 33);
            this.comStatus.TabIndex = 15;
            this.comStatus.SelectedIndexChanged += new System.EventHandler(this.comStatus_SelectedIndexChanged);
            // 
            // comFilterBy
            // 
            this.comFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comFilterBy.FormattingEnabled = true;
            this.comFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.A.ID",
            "NationalNo",
            "FullName",
            "Status"});
            this.comFilterBy.Location = new System.Drawing.Point(199, 280);
            this.comFilterBy.Name = "comFilterBy";
            this.comFilterBy.Size = new System.Drawing.Size(194, 33);
            this.comFilterBy.TabIndex = 14;
            this.comFilterBy.SelectedIndexChanged += new System.EventHandler(this.comFilterBy_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilter.Location = new System.Drawing.Point(399, 282);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(180, 30);
            this.txtFilter.TabIndex = 13;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter By :";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalRecords.Location = new System.Drawing.Point(191, 677);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(0, 29);
            this.lblTotalRecords.TabIndex = 11;
            // 
            // lblRecordText
            // 
            this.lblRecordText.AutoSize = true;
            this.lblRecordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecordText.Location = new System.Drawing.Point(51, 675);
            this.lblRecordText.Name = "lblRecordText";
            this.lblRecordText.Size = new System.Drawing.Size(130, 29);
            this.lblRecordText.TabIndex = 10;
            this.lblRecordText.Text = "Records :";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(366, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.CancelApplication,
            this.toolStripSeparator3,
            this.SchduleTestToolStripMenuItem,
            this.toolStripSeparator4,
            this.callToUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(370, 296);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.info;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(369, 40);
            this.detailsToolStripMenuItem.Text = "Show Application Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.user_avatar;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(369, 40);
            this.editToolStripMenuItem.Text = "Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.remove;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(369, 40);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(366, 6);
            // 
            // CancelApplication
            // 
            this.CancelApplication.Image = global::DVLD_System.Properties.Resources.cancelled;
            this.CancelApplication.Name = "CancelApplication";
            this.CancelApplication.Size = new System.Drawing.Size(369, 40);
            this.CancelApplication.Text = "Cancel Application";
            this.CancelApplication.Click += new System.EventHandler(this.CancelApplication_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(366, 6);
            // 
            // SchduleTestToolStripMenuItem
            // 
            this.SchduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schesuleVisoimTestToolStripMenuItem,
            this.schesuleWrittenTestToolStripMenuItem,
            this.schesuleStreetTestToolStripMenuItem});
            this.SchduleTestToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.test__2_;
            this.SchduleTestToolStripMenuItem.Name = "SchduleTestToolStripMenuItem";
            this.SchduleTestToolStripMenuItem.Size = new System.Drawing.Size(369, 40);
            this.SchduleTestToolStripMenuItem.Text = "Sechdule Test";
            this.SchduleTestToolStripMenuItem.MouseHover += new System.EventHandler(this.SchduleTestToolStripMenuItem_MouseHover);
            // 
            // schesuleVisoimTestToolStripMenuItem
            // 
            this.schesuleVisoimTestToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.eye;
            this.schesuleVisoimTestToolStripMenuItem.Name = "schesuleVisoimTestToolStripMenuItem";
            this.schesuleVisoimTestToolStripMenuItem.Size = new System.Drawing.Size(331, 40);
            this.schesuleVisoimTestToolStripMenuItem.Text = "Schesule Vision Test";
            this.schesuleVisoimTestToolStripMenuItem.Click += new System.EventHandler(this.schesuleVisoimTestToolStripMenuItem_Click);
            // 
            // schesuleWrittenTestToolStripMenuItem
            // 
            this.schesuleWrittenTestToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.examination;
            this.schesuleWrittenTestToolStripMenuItem.Name = "schesuleWrittenTestToolStripMenuItem";
            this.schesuleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(331, 40);
            this.schesuleWrittenTestToolStripMenuItem.Text = "Schesule WrittenTest";
            this.schesuleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.schesuleWrittenTestToolStripMenuItem_Click);
            // 
            // schesuleStreetTestToolStripMenuItem
            // 
            this.schesuleStreetTestToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.driver;
            this.schesuleStreetTestToolStripMenuItem.Name = "schesuleStreetTestToolStripMenuItem";
            this.schesuleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(331, 40);
            this.schesuleStreetTestToolStripMenuItem.Text = "Schesule Street Test";
            this.schesuleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.schesuleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(366, 6);
            // 
            // callToUserToolStripMenuItem
            // 
            this.callToUserToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.phone;
            this.callToUserToolStripMenuItem.Name = "callToUserToolStripMenuItem";
            this.callToUserToolStripMenuItem.Size = new System.Drawing.Size(369, 40);
            this.callToUserToolStripMenuItem.Text = "Call To User";
            // 
            // dataGridViewLocalApplications
            // 
            this.dataGridViewLocalApplications.AllowUserToAddRows = false;
            this.dataGridViewLocalApplications.AllowUserToDeleteRows = false;
            this.dataGridViewLocalApplications.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLocalApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewLocalApplications.Location = new System.Drawing.Point(56, 316);
            this.dataGridViewLocalApplications.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridViewLocalApplications.Name = "dataGridViewLocalApplications";
            this.dataGridViewLocalApplications.ReadOnly = true;
            this.dataGridViewLocalApplications.RowHeadersWidth = 51;
            this.dataGridViewLocalApplications.RowTemplate.Height = 24;
            this.dataGridViewLocalApplications.Size = new System.Drawing.Size(1137, 344);
            this.dataGridViewLocalApplications.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(376, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Local Driving License Applications";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.street;
            this.pictureBox1.Location = new System.Drawing.Point(590, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DVLD_System.Properties.Resources.food_11060629;
            this.pictureBox2.Location = new System.Drawing.Point(1091, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 745);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comStatus);
            this.Controls.Add(this.comFilterBy);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.lblRecordText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewLocalApplications);
            this.Name = "frmLocalDrivingLicenseApplications";
            this.Text = "frmLocalDrivingLicenseApplications";
            this.Activated += new System.EventHandler(this.frmLocalDrivingLicenseApplications_Activated);
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplications_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comStatus;
        private System.Windows.Forms.ComboBox comFilterBy;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblRecordText;
        private System.Windows.Forms.ToolStripMenuItem callToUserToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem SchduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelApplication;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridViewLocalApplications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem schesuleVisoimTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schesuleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schesuleStreetTestToolStripMenuItem;
    }
}