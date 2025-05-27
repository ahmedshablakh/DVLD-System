namespace DVLD_System
{
    partial class frmLicenseHistory
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
            this.ucFindPerson1 = new DVLD_System.ucFindPerson();
            this.tabLicenses = new System.Windows.Forms.TabControl();
            this.tabLocal = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.tabInternotioal = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dvInternotionalLicenses = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.palPersonInfo = new System.Windows.Forms.Panel();
            this.tabLicenses.SuspendLayout();
            this.tabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLocalLicenses)).BeginInit();
            this.tabInternotioal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInternotionalLicenses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.palPersonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucFindPerson1
            // 
            this.ucFindPerson1.Location = new System.Drawing.Point(6, 6);
            this.ucFindPerson1.Name = "ucFindPerson1";
            this.ucFindPerson1.Size = new System.Drawing.Size(870, 394);
            this.ucFindPerson1.TabIndex = 0;
            // 
            // tabLicenses
            // 
            this.tabLicenses.Controls.Add(this.tabLocal);
            this.tabLicenses.Controls.Add(this.tabInternotioal);
            this.tabLicenses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabLicenses.Location = new System.Drawing.Point(38, 48);
            this.tabLicenses.Name = "tabLicenses";
            this.tabLicenses.SelectedIndex = 0;
            this.tabLicenses.Size = new System.Drawing.Size(1037, 343);
            this.tabLicenses.TabIndex = 1;
            // 
            // tabLocal
            // 
            this.tabLocal.Controls.Add(this.label3);
            this.tabLocal.Controls.Add(this.label2);
            this.tabLocal.Controls.Add(this.label1);
            this.tabLocal.Controls.Add(this.dvLocalLicenses);
            this.tabLocal.Location = new System.Drawing.Point(4, 25);
            this.tabLocal.Name = "tabLocal";
            this.tabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocal.Size = new System.Drawing.Size(1029, 314);
            this.tabLocal.TabIndex = 0;
            this.tabLocal.Text = "Local";
            this.tabLocal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recore :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Lisenses History :";
            // 
            // dvLocalLicenses
            // 
            this.dvLocalLicenses.AllowUserToAddRows = false;
            this.dvLocalLicenses.AllowUserToDeleteRows = false;
            this.dvLocalLicenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLocalLicenses.Location = new System.Drawing.Point(19, 43);
            this.dvLocalLicenses.Name = "dvLocalLicenses";
            this.dvLocalLicenses.ReadOnly = true;
            this.dvLocalLicenses.RowHeadersWidth = 51;
            this.dvLocalLicenses.RowTemplate.Height = 24;
            this.dvLocalLicenses.Size = new System.Drawing.Size(1007, 217);
            this.dvLocalLicenses.TabIndex = 0;
            // 
            // tabInternotioal
            // 
            this.tabInternotioal.Controls.Add(this.label4);
            this.tabInternotioal.Controls.Add(this.label5);
            this.tabInternotioal.Controls.Add(this.label6);
            this.tabInternotioal.Controls.Add(this.dvInternotionalLicenses);
            this.tabInternotioal.Location = new System.Drawing.Point(4, 25);
            this.tabInternotioal.Name = "tabInternotioal";
            this.tabInternotioal.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternotioal.Size = new System.Drawing.Size(1029, 314);
            this.tabInternotioal.TabIndex = 1;
            this.tabInternotioal.Text = "tabInternotioal";
            this.tabInternotioal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(103, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Recore :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Local Lisenses History :";
            // 
            // dvInternotionalLicenses
            // 
            this.dvInternotionalLicenses.AllowUserToAddRows = false;
            this.dvInternotionalLicenses.AllowUserToDeleteRows = false;
            this.dvInternotionalLicenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvInternotionalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvInternotionalLicenses.Location = new System.Drawing.Point(13, 48);
            this.dvInternotionalLicenses.Name = "dvInternotionalLicenses";
            this.dvInternotionalLicenses.ReadOnly = true;
            this.dvInternotionalLicenses.RowHeadersWidth = 51;
            this.dvInternotionalLicenses.RowTemplate.Height = 24;
            this.dvInternotionalLicenses.Size = new System.Drawing.Size(1013, 217);
            this.dvInternotionalLicenses.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabLicenses);
            this.groupBox1.Location = new System.Drawing.Point(12, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving Licenses";
            // 
            // palPersonInfo
            // 
            this.palPersonInfo.Controls.Add(this.ucFindPerson1);
            this.palPersonInfo.Location = new System.Drawing.Point(215, 6);
            this.palPersonInfo.Name = "palPersonInfo";
            this.palPersonInfo.Size = new System.Drawing.Size(885, 403);
            this.palPersonInfo.TabIndex = 3;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 809);
            this.Controls.Add(this.palPersonInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.tabLicenses.ResumeLayout(false);
            this.tabLocal.ResumeLayout(false);
            this.tabLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLocalLicenses)).EndInit();
            this.tabInternotioal.ResumeLayout(false);
            this.tabInternotioal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInternotionalLicenses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.palPersonInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucFindPerson ucFindPerson1;
        private System.Windows.Forms.TabControl tabLicenses;
        private System.Windows.Forms.TabPage tabLocal;
        private System.Windows.Forms.TabPage tabInternotioal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvLocalLicenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvInternotionalLicenses;
        private System.Windows.Forms.Panel palPersonInfo;
    }
}