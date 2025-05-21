namespace DVLD_System
{
    partial class ucFindPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFindPeerson = new System.Windows.Forms.TextBox();
            this.comFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cuDetailsPersonInfo1 = new DVLD_System.cuDetailsPersonInfo();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.pictureBox2);
            this.grFilter.Controls.Add(this.pictureBox1);
            this.grFilter.Controls.Add(this.txtFindPeerson);
            this.grFilter.Controls.Add(this.comFilter);
            this.grFilter.Controls.Add(this.label1);
            this.grFilter.Location = new System.Drawing.Point(6, 3);
            this.grFilter.Name = "grFilter";
            this.grFilter.Size = new System.Drawing.Size(853, 77);
            this.grFilter.TabIndex = 2;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "Filter";
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // txtFindPeerson
            // 
            this.txtFindPeerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFindPeerson.Location = new System.Drawing.Point(318, 28);
            this.txtFindPeerson.Name = "txtFindPeerson";
            this.txtFindPeerson.Size = new System.Drawing.Size(187, 26);
            this.txtFindPeerson.TabIndex = 2;
            this.txtFindPeerson.TextChanged += new System.EventHandler(this.txtFindPeerson_TextChanged);
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
            // cuDetailsPersonInfo1
            // 
            this.cuDetailsPersonInfo1.Location = new System.Drawing.Point(0, 2);
            this.cuDetailsPersonInfo1.Name = "cuDetailsPersonInfo1";
            this.cuDetailsPersonInfo1.Size = new System.Drawing.Size(861, 301);
            this.cuDetailsPersonInfo1.TabIndex = 3;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.cuDetailsPersonInfo1);
            this.pnlContainer.Location = new System.Drawing.Point(0, 86);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(867, 308);
            this.pnlContainer.TabIndex = 4;
            // 
            // ucFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.grFilter);
            this.Name = "ucFindPerson";
            this.Size = new System.Drawing.Size(871, 421);
            this.Load += new System.EventHandler(this.ucFindPerson_Load);
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtFindPeerson;
        private System.Windows.Forms.ComboBox comFilter;
        private System.Windows.Forms.Label label1;
        private cuDetailsPersonInfo cuDetailsPersonInfo1;
        private System.Windows.Forms.Panel pnlContainer;
    }
}
