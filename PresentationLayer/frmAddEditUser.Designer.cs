namespace DVLD_System
{
    partial class frmAddEditUser
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
            this.cuDetailsPersonInfo = new DVLD_System.cuDetailsPersonInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.comFilter = new System.Windows.Forms.ComboBox();
            this.txtFindPeerson = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuDetailsPersonInfo
            // 
            this.cuDetailsPersonInfo.Location = new System.Drawing.Point(22, 179);
            this.cuDetailsPersonInfo.Name = "cuDetailsPersonInfo";
            this.cuDetailsPersonInfo.Size = new System.Drawing.Size(897, 322);
            this.cuDetailsPersonInfo.TabIndex = 0;
            this.cuDetailsPersonInfo.Load += new System.EventHandler(this.cuDetailsPersonInfo1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find By : ";
            // 
            // comFilter
            // 
            this.comFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comFilter.FormattingEnabled = true;
            this.comFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo"});
            this.comFilter.Location = new System.Drawing.Point(104, 28);
            this.comFilter.Name = "comFilter";
            this.comFilter.Size = new System.Drawing.Size(208, 28);
            this.comFilter.TabIndex = 8;
            // 
            // txtFindPeerson
            // 
            this.txtFindPeerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFindPeerson.Location = new System.Drawing.Point(318, 28);
            this.txtFindPeerson.Name = "txtFindPeerson";
            this.txtFindPeerson.Size = new System.Drawing.Size(187, 26);
            this.txtFindPeerson.TabIndex = 2;
            this.txtFindPeerson.TextChanged += new System.EventHandler(this.txtFindPeerson_TextChanged);
            this.txtFindPeerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindPeerson_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources._15862658;
            this.pictureBox1.Location = new System.Drawing.Point(546, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_System.Properties.Resources._7887065;
            this.pictureBox2.Location = new System.Drawing.Point(648, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtFindPeerson);
            this.groupBox1.Controls.Add(this.comFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cuDetailsPersonInfo);
            this.Name = "frmAddEditUser";
            this.Text = "frmAddEditUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private cuDetailsPersonInfo cuDetailsPersonInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comFilter;
        private System.Windows.Forms.TextBox txtFindPeerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}