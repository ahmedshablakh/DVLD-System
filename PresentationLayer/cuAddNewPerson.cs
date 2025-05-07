using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD_System
{
    public partial class cuAddNewPerson : UserControl 
    {


        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        int _PersonID;
        PeopleBusiness Person;

        public cuAddNewPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public cuAddNewPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }


        private void _FillCountriesInComoboBox()
        {
            DataTable dt = clsCountriesBusiness.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                comCountry.Items.Add(row["CountryName"]);
            }
        }


        public void _LoadData()
        {
            _FillCountriesInComoboBox();

            dateTimePicker1.Value = DateTime.Now.AddYears(-18);
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            radMale.Checked = true;
            comCountry.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Contact";
                Person = new PeopleBusiness();
                return;
            }

            Person = PeopleBusiness.Find(_PersonID);

            if (Person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                return;
            }

            comCountry.SelectedIndex = comCountry.FindString(clsCountriesBusiness.Find(Person.CountryID).CountryName);
            lblMode.Text = "Edit Contact ID = " + Person.PersonID;
            labPersonID.Text = Person.PersonID.ToString();
            txtFirstName.Text = Person.FirstName;
            txtSecond.Text = Person.SecondName;
            txtThird.Text = Person.ThirdName;
            txtLast.Text = Person.LastName;
            txtNationalNo.Text = Person.NationalNo;
            txtPhone.Text = Person.Phone;
            txtAddress.Text = Person.Address;


            if (Person.Gender)
            {
                radFemale.Checked = true;


            }
            else
            {
                radMale.Checked = true;
            }

        }







        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radMale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radMale.Checked)
            {
                pictureBox1.Image = Properties.Resources.patient_boy;
            }
        }

        private void radFemale_CheckedChanged_1(object sender, EventArgs e)
        {

            if (radFemale.Checked)
            {
                pictureBox1.Image = Properties.Resources.admin_female;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "اختر صورة شخصية";
            openFileDialog1.Filter = "ملفات الصور|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void AddNewPerson()
        {



            Person.NationalNo = txtNationalNo.Text;
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecond.Text;
            Person.ThirdName = txtThird.Text; ;
            Person.LastName = txtLast.Text;
            Person.Address = txtAddress.Text;
            Person.Email = txtEmail.Text;
            Person.Phone = txtPhone.Text;
            if (radMale.Checked)
            {
                Person.Gender = false;
            }
            if (radFemale.Checked)
            {
                Person.Gender = true;
            }

            Person.CountryID = clsCountriesBusiness.Find(comCountry.Text).ID;


            if (Person.Save())
            {
                MessageBox.Show("Successfuly .. ID is " + Person.PersonID);
                lab1PersonID.Text = Convert.ToString(Person.PersonID);
            }
            else
            {
                MessageBox.Show("Erorr .. ");

            }

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            AddNewPerson();
        }



        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (PeopleBusiness.ChechNationalNoIsExis(txtNationalNo.Text))
            {

                errorProvider1.SetError(txtNationalNo, "This National No IS Used..");

            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "");
            }
        }

        private void cuAddNewPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {

                parentForm.Close();

            }
        }
    }
}
