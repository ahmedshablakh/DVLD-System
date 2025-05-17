using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class cuChangepassword : UserControl
    {
       
        clsUsersBusiness UserInfo;
        public cuChangepassword(int UserID)
        {
            InitializeComponent();
            UserInfo = clsUsersBusiness.GetUserInfoByID(UserID);
        }
        public cuChangepassword()
        {
            InitializeComponent();
        }

        private void cuChangepassword_Load(object sender, EventArgs e)
        {
            cuUserInfo LoadData = new cuUserInfo(UserInfo.UserID);
            panUserInfo.Controls.Clear();
            panUserInfo.Controls.Add(LoadData);

        }



        private bool _ValidateInputData()
        {
            bool isValid = true;
            errorProvider1.Clear(); 

            if (string.IsNullOrWhiteSpace(txtCurrentPasssword.Text))
            {
                errorProvider1.SetError(txtCurrentPasssword, "Please enter the current password.");
                isValid = false;
            }
            else if (txtCurrentPasssword.Text != UserInfo.Password)
            {
                errorProvider1.SetError(txtCurrentPasssword, "The current password is incorrect.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNewPassword, "Please enter a new password.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Please confirm the new password.");
                isValid = false;
            }
            else if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                errorProvider1.SetError(txtNewPassword, "Passwords do not match.");
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match.");
                isValid = false;
            }

            return isValid;
        }



        private void cuChangepassword_MouseCaptureChanged(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.DialogResult = DialogResult.OK;
                parentForm.Close();
            }

        }

        private void btnSave_MouseCaptureChanged(object sender, EventArgs e)
        {

            if (_ValidateInputData())
            {
                UserInfo.Password = txtNewPassword.Text;

                if (UserInfo.Save())
                {
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
