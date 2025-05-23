﻿using System;
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
    public partial class cuDetailsPersonInfo : UserControl
    {
        public int PersonID =-1;
        PeopleBusiness PersonInfo;

        public cuDetailsPersonInfo()
        {
            InitializeComponent();
        }
        public cuDetailsPersonInfo(int ID)
        {
            InitializeComponent();
            PersonID = ID;
            
        }


        private void _loadData()
        {
            

            if (PersonID !=-1)
            {
                PersonInfo = PeopleBusiness.GetPersonInfoByID(PersonID);
                if(PersonInfo != null)
                {


                    lab1PersonID.Text = Convert.ToString(PersonInfo.PersonID);
                    lblFullName.Text = PersonInfo.FirstName + " " + PersonInfo.SecondName + " " + PersonInfo.ThirdName + " " + PersonInfo.LastName;
                    lblNotionalNo.Text = PersonInfo.NationalNo;
                    lblDateOfBirth.Text = ((DateTime)PersonInfo.DateOfBirth).ToString("dd-MM-yyyy");

                    lblPhone.Text = PersonInfo.Phone;
                    lblAddress.Text = PersonInfo.Address;
                    lblCountry.Text = clsCountriesBusiness.Find(PersonInfo.CountryID).CountryName;
                    lblEmail.Text = PersonInfo.Email;

                    if (!string.IsNullOrWhiteSpace(PersonInfo.ImagePath) && File.Exists(PersonInfo.ImagePath))
                    {
                        pictureBox1.Image = Image.FromFile(PersonInfo.ImagePath);
                    }
                    else
                    {
                        // صورة افتراضية بناءً على النوع
                        pictureBox1.Image = PersonInfo.Gender ?
                            Properties.Resources.admin_female :
                            Properties.Resources.patient_boy;
                    }


                    if (PersonInfo.Gender == false)
                    {
                        lblGendor.Text = "Male";
                    }
                    else
                    {
                        lblGendor.Text = "Famile";
                    }

                }
               
            }
        }
        private void cuDetailsPersonInfo_Load(object sender, EventArgs e)
        {
            if (PersonID == -1)
            {   
                lblEditInfo.Enabled = false;
                return;
            }

            _loadData();
        }

       


        private void lblEditInfo_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(Convert.ToInt32(lab1PersonID.Text), 1);
            frm.ShowDialog();
            PersonInfo = PeopleBusiness.GetPersonInfoByID(PersonID);

            _loadData();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
