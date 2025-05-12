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
        public frmAddEditUser()
        {
            InitializeComponent();
        }

        private void cuDetailsPersonInfo1_Load(object sender, EventArgs e)
        {
            
        }


        private void _LoadData(PeopleBusiness PersonInfo)
        {
            cuDetailsPersonInfo.lab1PersonID.Text = Convert.ToString(PersonInfo.PersonID);
            cuDetailsPersonInfo.lblNotionalNo.Text = PersonInfo.NationalNo;
            cuDetailsPersonInfo.lblFullName.Text = PersonInfo.FirstName + " " + PersonInfo.SecondName + " " + PersonInfo.ThirdName + " " + PersonInfo.LastName;

            cuDetailsPersonInfo.lblPhone.Text = PersonInfo.Phone;
            cuDetailsPersonInfo.lblEmail.Text = PersonInfo.Email;
            cuDetailsPersonInfo.lblDateOfBirth.Text = ((DateTime)PersonInfo.DateOfBirth).ToString("dd-MM-yyyy");
            cuDetailsPersonInfo.lblAddress.Text = PersonInfo.Address;
            cuDetailsPersonInfo.lblCountry.Text = clsCountriesBusiness.Find(PersonInfo.CountryID).CountryName;

            if (PersonInfo.Gender == false)
            {
                cuDetailsPersonInfo.lblGendor.Text = "Male";
            }
            else
            {
                cuDetailsPersonInfo.lblGendor.Text = "Famile";
            }
            if (!string.IsNullOrWhiteSpace(PersonInfo.ImagePath) && File.Exists(PersonInfo.ImagePath))
            {
                cuDetailsPersonInfo.pictureBox1.Image = Image.FromFile(PersonInfo.ImagePath);
            }
            else
            {
                // صورة افتراضية بناءً على النوع
                cuDetailsPersonInfo.pictureBox1.Image = PersonInfo.Gender ?
                    Properties.Resources.admin_female :
                    Properties.Resources.patient_boy;
            }
            cuDetailsPersonInfo.lblEditInfo.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtFindPeerson.Text!="")
            {
                PeopleBusiness PersonInfo;
                if(comFilter.SelectedIndex==1)
                {
                    PersonInfo = PeopleBusiness.GetPersonInfoByID(Convert.ToInt32(txtFindPeerson.Text));
                    if (PersonInfo!=null)
                    {
                        _LoadData(PersonInfo);

                    }
                    else
                    {
                        MessageBox.Show("IS Not Fond By PersonID = " + txtFindPeerson.Text, "Not Fond Person",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                else if (comFilter.SelectedIndex == 2)
                {
                    PersonInfo = PeopleBusiness.GetPersonInfoByNationalNo(txtFindPeerson.Text);
                    if (PersonInfo != null)
                    {
                        _LoadData(PersonInfo);
                    }
                    else
                    {
                        MessageBox.Show("IS Not Fond By NationalNo  = " + txtFindPeerson.Text, "Not Fond Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }




            }
        }

        private void txtFindPeerson_TextChanged(object sender, EventArgs e)
        {

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
    }
}
