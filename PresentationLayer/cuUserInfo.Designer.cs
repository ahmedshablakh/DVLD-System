namespace DVLD_System
{
    partial class cuUserInfo
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
            this.panLoginInfo = new System.Windows.Forms.Panel();
            this.panPersonInfo = new System.Windows.Forms.Panel();
            this.cuDetailsPersonInfo1 = new DVLD_System.cuDetailsPersonInfo();
            this.ucLoginInformation1 = new DVLD_System.ucLoginInformation();
            this.panLoginInfo.SuspendLayout();
            this.panPersonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLoginInfo
            // 
            this.panLoginInfo.Controls.Add(this.ucLoginInformation1);
            this.panLoginInfo.Location = new System.Drawing.Point(3, 334);
            this.panLoginInfo.Name = "panLoginInfo";
            this.panLoginInfo.Size = new System.Drawing.Size(885, 106);
            this.panLoginInfo.TabIndex = 5;
            // 
            // panPersonInfo
            // 
            this.panPersonInfo.Controls.Add(this.cuDetailsPersonInfo1);
            this.panPersonInfo.Location = new System.Drawing.Point(6, 3);
            this.panPersonInfo.Name = "panPersonInfo";
            this.panPersonInfo.Size = new System.Drawing.Size(882, 325);
            this.panPersonInfo.TabIndex = 6;
            // 
            // cuDetailsPersonInfo1
            // 
            this.cuDetailsPersonInfo1.Location = new System.Drawing.Point(3, 0);
            this.cuDetailsPersonInfo1.Name = "cuDetailsPersonInfo1";
            this.cuDetailsPersonInfo1.Size = new System.Drawing.Size(876, 305);
            this.cuDetailsPersonInfo1.TabIndex = 4;
            // 
            // ucLoginInformation1
            // 
            this.ucLoginInformation1.Location = new System.Drawing.Point(6, 3);
            this.ucLoginInformation1.Name = "ucLoginInformation1";
            this.ucLoginInformation1.Size = new System.Drawing.Size(865, 100);
            this.ucLoginInformation1.TabIndex = 1;
            // 
            // cuUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panPersonInfo);
            this.Controls.Add(this.panLoginInfo);
            this.Name = "cuUserInfo";
            this.Size = new System.Drawing.Size(896, 447);
            this.Load += new System.EventHandler(this.cuUserInfo_Load);
            this.panLoginInfo.ResumeLayout(false);
            this.panPersonInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private cuDetailsPersonInfo cuDetailsPersonInfo1;
        private ucLoginInformation ucLoginInformation1;
        private System.Windows.Forms.Panel panLoginInfo;
        private System.Windows.Forms.Panel panPersonInfo;
    }
}
