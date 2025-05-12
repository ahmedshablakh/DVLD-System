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
using System.IO;

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


        private string _SavePersonImageToFolder()
        {
            if (string.IsNullOrWhiteSpace(openFileDialog1.FileName) || !File.Exists(openFileDialog1.FileName))
                return "";

            // مسار المجلد داخل مجلد التطبيق
            string imagesFolder = @"C:\Users\aboar\ahmedshablakh\DVLD-System\Images";


            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            string extension = Path.GetExtension(openFileDialog1.FileName);
            string newFileName = Guid.NewGuid().ToString() + extension;

            string destinationPath = Path.Combine(imagesFolder, newFileName);

            File.Copy(openFileDialog1.FileName, destinationPath, true);

            return destinationPath;
        }


        public void _LoadData()
        {
            _FillCountriesInComoboBox();
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
            radMale.Checked = true;
            comCountry.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Contact";
                Person = new PeopleBusiness();
                return;
            }

            Person = PeopleBusiness.GetPersonInfoByID(_PersonID);

            if (Person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                return;
            }

            comCountry.SelectedIndex = comCountry.FindString(clsCountriesBusiness.Find(Person.CountryID).CountryName);
            lblMode.Text = "Edit Contact ID = " + Person.PersonID;
            lab1PersonID.Text = Person.PersonID.ToString();
            txtFirstName.Text = Person.FirstName;
            txtSecond.Text = Person.SecondName;
            txtThird.Text = Person.ThirdName;
            txtLast.Text = Person.LastName;
            txtNationalNo.Text = Person.NationalNo;
            txtPhone.Text = Person.Phone;
            txtAddress.Text = Person.Address;
            txtEmail.Text = Person.Email;
            lblRemove.Visible = (!string.IsNullOrEmpty(Person.ImagePath));
            if (Person.Gender)
            {
                radFemale.Checked = true;
            }
            else
            {
                radMale.Checked = true;
            }

          

            if (!string.IsNullOrWhiteSpace(Person.ImagePath) && File.Exists(Person.ImagePath))
            {
                pictureBox1.Image = Image.FromFile(Person.ImagePath);
            }
            else
            {
                // صورة افتراضية بناءً على النوع
                pictureBox1.Image = Person.Gender ?
                    Properties.Resources.admin_female :
                    Properties.Resources.patient_boy;
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
            openFileDialog1.Title = "Choose a Profile Picture";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void AddEditPerson()
        {


            Person.NationalNo = txtNationalNo.Text;
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecond.Text;
            Person.ThirdName = txtThird.Text; 
            Person.LastName = txtLast.Text;
            Person.Address = txtAddress.Text;
            Person.Email = txtEmail.Text;
            Person.Phone = txtPhone.Text;


            if (!string.IsNullOrWhiteSpace(openFileDialog1.FileName) && File.Exists(openFileDialog1.FileName))
            {
                Person.ImagePath = _SavePersonImageToFolder();
            }
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
                if (_Mode == enMode.AddNew)
                {
                    MessageBox.Show("Adding Successfuly .. ID is " + Person.PersonID);
                    lab1PersonID.Text = Convert.ToString(Person.PersonID);
                }
                else
                {
                    MessageBox.Show("Update Successfuly");
                }



            }
            else
            {
                MessageBox.Show("Erorr .. ");

            }

        }


        private bool _ValidateInputData()
        {
            bool isValid = true;

            // National ID validation
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "National ID is required.");
                isValid = false;
            }
            else if (_Mode == enMode.AddNew && PeopleBusiness.ChechNationalNoIsExis(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "National ID is already in use.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "");
            }

            // First Name validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First name is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
            // Second Name validation
            if (string.IsNullOrWhiteSpace(txtSecond.Text))
            {
                errorProvider1.SetError(txtSecond, "First name is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtSecond, "");
            }

            // Last Name validation
            if (string.IsNullOrWhiteSpace(txtLast.Text))
            {
                errorProvider1.SetError(txtLast, "Last name is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtLast, "");
            }

            // Phone Number validation
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Phone number is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
            }

            // Email validation (optional)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    errorProvider1.SetError(txtEmail, "Invalid email format.");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(txtEmail, "");
                }
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            return isValid;
        }


        private void butSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInputData())
            {
                MessageBox.Show("Please correct the data before saving.", "Data Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddEditPerson();

            if (_Mode == enMode.AddNew)
            {
                _Mode = enMode.Update;
                _PersonID = Convert.ToInt32(lab1PersonID.Text);

            }

            _LoadData();

        }


        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {


        }

        private void cuAddNewPerson_Load(object sender, EventArgs e)
        {
            lblRemove.Visible = false;
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

        private void txtNationalNo_Leave(object sender, EventArgs e)
        {

        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;
            lblRemove.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
