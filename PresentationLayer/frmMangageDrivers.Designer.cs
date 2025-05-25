namespace DVLD_System
{
    partial class frmMangageDrivers
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
            this.comIsActiv = new System.Windows.Forms.ComboBox();
            this.comUserFilterData = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblRecordText = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewLicense = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changepassword = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sedEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callToUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comIsActiv
            // 
            this.comIsActiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comIsActiv.FormattingEnabled = true;
            this.comIsActiv.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comIsActiv.Location = new System.Drawing.Point(448, 232);
            this.comIsActiv.Name = "comIsActiv";
            this.comIsActiv.Size = new System.Drawing.Size(124, 33);
            this.comIsActiv.TabIndex = 15;
            // 
            // comUserFilterData
            // 
            this.comUserFilterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comUserFilterData.FormattingEnabled = true;
            this.comUserFilterData.Items.AddRange(new object[] {
            "None",
            "UserID",
            "UserName",
            "PersonID",
            "FullName",
            "ISActive"});
            this.comUserFilterData.Location = new System.Drawing.Point(248, 233);
            this.comUserFilterData.Name = "comUserFilterData";
            this.comUserFilterData.Size = new System.Drawing.Size(194, 33);
            this.comUserFilterData.TabIndex = 14;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilter.Location = new System.Drawing.Point(448, 235);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(180, 30);
            this.txtFilter.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter By :";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalRecords.Location = new System.Drawing.Point(234, 628);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(0, 29);
            this.lblTotalRecords.TabIndex = 11;
            // 
            // lblRecordText
            // 
            this.lblRecordText.AutoSize = true;
            this.lblRecordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecordText.Location = new System.Drawing.Point(111, 628);
            this.lblRecordText.Name = "lblRecordText";
            this.lblRecordText.Size = new System.Drawing.Size(116, 29);
            this.lblRecordText.TabIndex = 10;
            this.lblRecordText.Text = "Record :";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(287, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.changepassword,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sedEmailToolStripMenuItem,
            this.callToUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(291, 296);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(287, 6);
            // 
            // dataGridViewLicense
            // 
            this.dataGridViewLicense.AllowUserToAddRows = false;
            this.dataGridViewLicense.AllowUserToDeleteRows = false;
            this.dataGridViewLicense.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewLicense.Location = new System.Drawing.Point(116, 269);
            this.dataGridViewLicense.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridViewLicense.Name = "dataGridViewLicense";
            this.dataGridViewLicense.ReadOnly = true;
            this.dataGridViewLicense.RowHeadersWidth = 51;
            this.dataGridViewLicense.RowTemplate.Height = 24;
            this.dataGridViewLicense.Size = new System.Drawing.Size(952, 344);
            this.dataGridViewLicense.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.zzz;
            this.pictureBox1.Location = new System.Drawing.Point(473, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.info;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Image = global::DVLD_System.Properties.Resources._new;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.user_avatar;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changepassword
            // 
            this.changepassword.Image = global::DVLD_System.Properties.Resources.password;
            this.changepassword.Name = "changepassword";
            this.changepassword.Size = new System.Drawing.Size(290, 40);
            this.changepassword.Text = "Change Password";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.remove;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // sedEmailToolStripMenuItem
            // 
            this.sedEmailToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.communication;
            this.sedEmailToolStripMenuItem.Name = "sedEmailToolStripMenuItem";
            this.sedEmailToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.sedEmailToolStripMenuItem.Text = "Sed Email";
            // 
            // callToUserToolStripMenuItem
            // 
            this.callToUserToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.phone;
            this.callToUserToolStripMenuItem.Name = "callToUserToolStripMenuItem";
            this.callToUserToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.callToUserToolStripMenuItem.Text = "Call To User";
            // 
            // frmMangageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comIsActiv);
            this.Controls.Add(this.comUserFilterData);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.lblRecordText);
            this.Controls.Add(this.dataGridViewLicense);
            this.Name = "frmMangageDrivers";
            this.Text = "frmMangageDrivers";
            this.Load += new System.EventHandler(this.frmMangageDrivers_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comIsActiv;
        private System.Windows.Forms.ComboBox comUserFilterData;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblRecordText;
        private System.Windows.Forms.ToolStripMenuItem callToUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sedEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changepassword;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridViewLicense;
    }
}