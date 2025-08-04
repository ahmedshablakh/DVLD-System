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
using System.IO;

namespace DVLD_System
{
    public partial class ucDriverLicenseInfo : UserControl
    {
       
        clsApplication ApplicationInfo;
        clsLicensesBusiness LicenseInfo;
        clsPerson PersonInfo;
        public ucDriverLicenseInfo()
        {
            InitializeComponent();
        }
        public ucDriverLicenseInfo(int ApplicationID)
        {
            InitializeComponent();

            ApplicationInfo = clsApplication.GetApplicationInfoByID(ApplicationID);
            PersonInfo = clsPerson.GetPersonInfoByID(ApplicationInfo.ApplicantPersonID);
            LicenseInfo = clsLicensesBusiness.GetLicenseInfoByApplicationID(ApplicationID);

        }

        private void ucDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            if(ApplicationInfo !=null)
            {
                lblClass.Text = clsLicenseClass.Find(LicenseInfo.LicenseClass).ClassName;
                lblFullName.Text = PersonInfo.FirstName + " " + PersonInfo.SecondName + " " + PersonInfo.ThirdName + " " + PersonInfo.LastName;
                lblLicenseID.Text = LicenseInfo.LicenseID.ToString();
                lblNotionalNo.Text = PersonInfo.NationalNo;
                lblGendor.Text = PersonInfo.Gender ? "Male" : "Fimaly";
                lblIssueDate.Text = LicenseInfo.IssueDate.ToShortDateString();
                lblIssueReason.Text = LicenseInfo.IssueReason == 1 ? "First Time" : "Second";
                lblNotes.Text = LicenseInfo.Notes == "" ? "No Notes" : LicenseInfo.Notes;
                lblIsActive.Text = LicenseInfo.IsActive ? "Yes" : "No";
                lblDateOfBirth.Text = PersonInfo.DateOfBirth.ToShortDateString();
                lblDriverID.Text = LicenseInfo.DriverID.ToString();
                lblExpirationDate.Text = LicenseInfo.ExpirationDate.ToShortDateString();
                lblIsDetained.Text = clsDetainLicenseBusiness.IsDetainLicense(LicenseInfo.LicenseID)?"Yes":"No";
                if (!string.IsNullOrEmpty(PersonInfo.ImagePath) && File.Exists(PersonInfo.ImagePath))
                {
                    pictureBox1.Image = Image.FromFile(PersonInfo.ImagePath);
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.patient_boy;
                }
            }
           

        }
    }
}
