using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.IO;


namespace DVLD_System
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew, Update };
        enMode Mode = enMode.AddNew;
        private int _PersonID = -1;
        private int _UserID = -1;
        clsUsersBusiness UserInfo;
        PeopleBusiness PersonInfo;
        public frmAddEditUser()
        {
            UserInfo = new clsUsersBusiness();
            InitializeComponent();

        }
        public frmAddEditUser(int UserID, int PersonID)
        {
            InitializeComponent();
            _UserID = UserID;
            _PersonID = PersonID;
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtFindPeerson.Text != "")
            {
                PeopleBusiness PersonInfo;
                if (comFilter.SelectedIndex == 1)
                {
                    PersonInfo = PeopleBusiness.GetPersonInfoByID(Convert.ToInt32(txtFindPeerson.Text));
                    if (PersonInfo != null)
                    {
                        pnlContainer.Controls.Clear();
                        _PersonID = PersonInfo.PersonID;

                        cuDetailsPersonInfo uc = new cuDetailsPersonInfo(PersonInfo.PersonID);


                        uc.Dock = DockStyle.Fill;
                        pnlContainer.Controls.Add(uc);
                        cuDetailsPersonInfo.lblEditInfo.Enabled = true;
                        grNext.Enabled = true;


                    }
                    else
                    {
                        MessageBox.Show("IS Not Fond By PersonID = " + txtFindPeerson.Text, "Not Fond Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pnlContainer.Controls.Clear();
                        cuDetailsPersonInfo uc = new cuDetailsPersonInfo();


                        uc.Dock = DockStyle.Fill;
                        pnlContainer.Controls.Add(uc);
                        cuDetailsPersonInfo.lblEditInfo.Enabled = false;
                        grNext.Enabled = false;
                    }
                }


                else if (comFilter.SelectedIndex == 2)
                {
                    PersonInfo = PeopleBusiness.GetPersonInfoByNationalNo(txtFindPeerson.Text);
                    if (PersonInfo != null)
                    {
                        pnlContainer.Controls.Clear();
                        _PersonID = PersonInfo.PersonID;

                        cuDetailsPersonInfo uc = new cuDetailsPersonInfo(PersonInfo.PersonID);


                        uc.Dock = DockStyle.Fill;
                        pnlContainer.Controls.Add(uc);
                        grNext.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("IS Not Fond By NationalNo  = " + txtFindPeerson.Text, "Not Fond Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pnlContainer.Controls.Clear();
                        cuDetailsPersonInfo uc = new cuDetailsPersonInfo();


                        uc.Dock = DockStyle.Fill;
                        pnlContainer.Controls.Add(uc);

                        grNext.Enabled = false;
                    }
                }




            }
        }



        private void txtFindPeerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comFilter.SelectedIndex == 1)
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }



            }
        }



        private void groupBox2_MouseCaptureChanged(object sender, EventArgs e)
        {

            if (!tabControl.TabPages.Contains(tabLoginInfo))
                tabControl.TabPages.Add(tabLoginInfo);
            tabControl.SelectTab(tabLoginInfo);
        }


        private void frmAddEditUser_Load_1(object sender, EventArgs e)
        {
            grNext.Enabled = false;
            btnSave.Enabled = false;
            if (_PersonID == -1)
                tabControl.TabPages.Remove(tabLoginInfo);


            if (_PersonID != -1 && _UserID != -1)
            {
                grFilter.Enabled = false;
                 PersonInfo = PeopleBusiness.GetPersonInfoByID(_PersonID);
                if (PersonInfo != null)
                {
                    pnlContainer.Controls.Clear();
                    cuDetailsPersonInfo uc = new cuDetailsPersonInfo(PersonInfo.PersonID);
                    uc.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(uc);
                    grNext.Enabled = true;
                    _LoadUserData(_UserID);

                }

            }


        }


        private void grClose_Enter(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox11_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1, 1);
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK && Convert.ToInt32(frm.Tag) != -1)
            {
                comFilter.SelectedIndex = 1;
                txtFindPeerson.Text = Convert.ToString(frm.Tag);

                pnlContainer.Controls.Clear();

                cuDetailsPersonInfo uc = new cuDetailsPersonInfo(Convert.ToInt32(frm.Tag));
                uc.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(uc);
                _PersonID = uc.PersonID;
                grNext.Enabled = true;
            }

        }


        private bool _ValidateInputData()
        {
            bool isValid = true;
            if (txtUserName.Text == "")
            {
                errorProvider1.SetError(txtUserName, "Username is required.");
                isValid = false;
            }
            if (clsUsersBusiness.IsUsernameExist(txtUserName.Text) && Mode == enMode.AddNew)
            {
                errorProvider1.SetError(txtUserName, "Username already exists.");
                isValid = false;
            }

            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "Password is required.");
                isValid = false;

            }
            if (txtConfirmPass.Text == "")
            {
                errorProvider1.SetError(txtConfirmPass, "Confirm Password is required.");
                isValid = false;

            }


            if (txtConfirmPass.Text != txtPass.Text)
            {
                errorProvider1.SetError(txtConfirmPass, "Passwords do not match.");
                isValid = false;
            }


            return isValid;
        }

        private void _LoadUserData(int UserID)
        {
            UserInfo = clsUsersBusiness.GetUserInfoByID(UserID);
            if (UserID == -1)
            {
                UserInfo = new clsUsersBusiness();
                Mode = enMode.AddNew;
                return;
            }

            lblTitle.Text = "Update User";
            Mode = enMode.Update;
            txtPass.Text = UserInfo.Password;
            txtConfirmPass.Text = UserInfo.Password;
            chIsActive.Checked = UserInfo.IsActive;
            lblUserID1.Text = Convert.ToString(UserInfo.UserID);
            txtUserName.Text = UserInfo.Username;


        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                btnSave.Enabled = true;
            }
            else
                btnSave.Enabled = false;
        }

 

           private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (_ValidateInputData())
            {
                UserInfo.PersonID = _PersonID;
                UserInfo.Username = txtUserName.Text;
                UserInfo.Password = txtPass.Text;
                UserInfo.IsActive = chIsActive.Checked;

                if (UserInfo.Save())
                {
                    grFilter.Enabled = false;
                    MessageBox.Show("Adding Successfuly. User ID is " + UserInfo.UserID);
                    Mode = enMode.Update;
                    _LoadUserData(UserInfo.UserID);
                }
                else
                {
                    MessageBox.Show("An error occurred while saving.", "Save data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grFilter_Enter(object sender, EventArgs e)
        {

        }
    }
}

