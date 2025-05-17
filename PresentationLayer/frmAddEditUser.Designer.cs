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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comFilter = new System.Windows.Forms.ComboBox();
            this.txtFindPeerson = new System.Windows.Forms.TextBox();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.cuDetailsPersonInfo = new DVLD_System.cuDetailsPersonInfo();
            this.grNext = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUserID1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grClose = new System.Windows.Forms.GroupBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSave = new System.Windows.Forms.GroupBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grNext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.btnSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
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
            this.txtFindPeerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindPeerson_KeyPress);
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.pictureBox2);
            this.grFilter.Controls.Add(this.pictureBox1);
            this.grFilter.Controls.Add(this.txtFindPeerson);
            this.grFilter.Controls.Add(this.comFilter);
            this.grFilter.Controls.Add(this.label1);
            this.grFilter.Location = new System.Drawing.Point(42, 71);
            this.grFilter.Name = "grFilter";
            this.grFilter.Size = new System.Drawing.Size(855, 77);
            this.grFilter.TabIndex = 1;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPersonInfo);
            this.tabControl.Controls.Add(this.tabLoginInfo);
            this.tabControl.Location = new System.Drawing.Point(8, 86);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1164, 715);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.Controls.Add(this.pnlContainer);
            this.tabPersonInfo.Controls.Add(this.grNext);
            this.tabPersonInfo.Controls.Add(this.grFilter);
            this.tabPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1156, 686);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            this.tabPersonInfo.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.cuDetailsPersonInfo);
            this.pnlContainer.Location = new System.Drawing.Point(24, 185);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1116, 389);
            this.pnlContainer.TabIndex = 5;
            // 
            // cuDetailsPersonInfo
            // 
            this.cuDetailsPersonInfo.Location = new System.Drawing.Point(6, 4);
            this.cuDetailsPersonInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuDetailsPersonInfo.Name = "cuDetailsPersonInfo";
            this.cuDetailsPersonInfo.Size = new System.Drawing.Size(1106, 385);
            this.cuDetailsPersonInfo.TabIndex = 0;



            // 
            // grNext
            // 
            this.grNext.Controls.Add(this.pictureBox3);
            this.grNext.Controls.Add(this.label2);
            this.grNext.Location = new System.Drawing.Point(949, 584);
            this.grNext.Name = "grNext";
            this.grNext.Size = new System.Drawing.Size(169, 73);
            this.grNext.TabIndex = 4;
            this.grNext.TabStop = false;
            this.grNext.MouseCaptureChanged += new System.EventHandler(this.groupBox2_MouseCaptureChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_System.Properties.Resources.right_arrow;
            this.pictureBox3.Location = new System.Drawing.Point(108, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseCaptureChanged += new System.EventHandler(this.groupBox2_MouseCaptureChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Next";
            this.label2.MouseCaptureChanged += new System.EventHandler(this.groupBox2_MouseCaptureChanged);
            // 
            // tabLoginInfo
            // 
            this.tabLoginInfo.Controls.Add(this.txtConfirmPass);
            this.tabLoginInfo.Controls.Add(this.txtPass);
            this.tabLoginInfo.Controls.Add(this.chIsActive);
            this.tabLoginInfo.Controls.Add(this.label7);
            this.tabLoginInfo.Controls.Add(this.lblUserID1);
            this.tabLoginInfo.Controls.Add(this.txtUserName);
            this.tabLoginInfo.Controls.Add(this.pictureBox10);
            this.tabLoginInfo.Controls.Add(this.pictureBox9);
            this.tabLoginInfo.Controls.Add(this.pictureBox5);
            this.tabLoginInfo.Controls.Add(this.pictureBox4);
            this.tabLoginInfo.Controls.Add(this.label6);
            this.tabLoginInfo.Controls.Add(this.label5);
            this.tabLoginInfo.Controls.Add(this.label4);
            this.tabLoginInfo.Controls.Add(this.label3);
            this.tabLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(1156, 686);
            this.tabLoginInfo.TabIndex = 1;
            this.tabLoginInfo.Text = "LoginInfo";
            this.tabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConfirmPass.Location = new System.Drawing.Point(378, 347);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(209, 30);
            this.txtConfirmPass.TabIndex = 16;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(378, 296);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(209, 30);
            this.txtPass.TabIndex = 15;
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Location = new System.Drawing.Point(368, 432);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(18, 17);
            this.chIsActive.TabIndex = 14;
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(272, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Is Active :";
            // 
            // lblUserID1
            // 
            this.lblUserID1.AutoSize = true;
            this.lblUserID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserID1.Location = new System.Drawing.Point(386, 194);
            this.lblUserID1.Name = "lblUserID1";
            this.lblUserID1.Size = new System.Drawing.Size(0, 29);
            this.lblUserID1.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(378, 240);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 30);
            this.txtUserName.TabIndex = 8;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD_System.Properties.Resources.reset_password;
            this.pictureBox10.Location = new System.Drawing.Point(309, 341);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(40, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 7;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD_System.Properties.Resources._17035298;
            this.pictureBox9.Location = new System.Drawing.Point(309, 291);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_System.Properties.Resources._3177440;
            this.pictureBox5.Location = new System.Drawing.Point(309, 239);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_System.Properties.Resources._9512601;
            this.pictureBox4.Location = new System.Drawing.Point(309, 189);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Confirm Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(165, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(152, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(192, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "User ID :";
            // 
            // grClose
            // 
            this.grClose.Controls.Add(this.pictureBox11);
            this.grClose.Controls.Add(this.label8);
            this.grClose.Location = new System.Drawing.Point(828, 803);
            this.grClose.Name = "grClose";
            this.grClose.Size = new System.Drawing.Size(169, 73);
            this.grClose.TabIndex = 5;
            this.grClose.TabStop = false;
            this.grClose.Enter += new System.EventHandler(this.grClose_Enter);
            this.grClose.MouseCaptureChanged += new System.EventHandler(this.pictureBox11_MouseCaptureChanged);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD_System.Properties.Resources.remove;
            this.pictureBox11.Location = new System.Drawing.Point(24, 18);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(46, 47);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 3;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.MouseCaptureChanged += new System.EventHandler(this.pictureBox11_MouseCaptureChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(76, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "Close";
            this.label8.MouseCaptureChanged += new System.EventHandler(this.pictureBox11_MouseCaptureChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(461, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 39);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Add New User";
            // 
            // btnSave
            // 
            this.btnSave.Controls.Add(this.pictureBox12);
            this.btnSave.Controls.Add(this.label9);
            this.btnSave.Location = new System.Drawing.Point(1003, 803);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 73);
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.MouseCaptureChanged += new System.EventHandler(this.groupBox1_MouseCaptureChanged);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD_System.Properties.Resources._489707;
            this.pictureBox12.Location = new System.Drawing.Point(24, 18);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(46, 47);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 3;
            this.pictureBox12.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(76, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Save";
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 919);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grClose);
            this.Controls.Add(this.tabControl);
            this.Name = "frmAddEditUser";
            this.Tag = "PersonID";
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load_1);
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.grNext.ResumeLayout(false);
            this.grNext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grClose.ResumeLayout(false);
            this.grClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.btnSave.ResumeLayout(false);
            this.btnSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cuDetailsPersonInfo cuDetailsPersonInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comFilter;
        private System.Windows.Forms.TextBox txtFindPeerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox grNext;
        private System.Windows.Forms.Label label2;



        
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;



        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.CheckBox chIsActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUserID1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grClose;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox btnSave;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label9;
    }
}