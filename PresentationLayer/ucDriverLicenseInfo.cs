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
        clsLocalDrivingLicenseApplicationsBusiness LocalAppInfo;
        clsApplicationBusiness ApplicationInfo;
        clsLicensesBusiness LicenseInfo;
        PeopleBusiness PersonInfo;
        public ucDriverLicenseInfo()
        {
            InitializeComponent();
        }
        public ucDriverLicenseInfo(int LocalAppID)
        {
            InitializeComponent();

            LocalAppInfo = clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalAppID);
            ApplicationInfo = clsApplicationBusiness.GetApplicationInfoByID(LocalAppInfo.ApplicationID);
            PersonInfo = PeopleBusiness.GetPersonInfoByID(ApplicationInfo.ApplicantPersonID);
            LicenseInfo = clsLicensesBusiness.GetLicenseInfoByID(ApplicationInfo.ApplicationID);

        }

        private void ucDriverLicenseInfo_Load(object sender, EventArgs e)
        {

            lblClass.Text = clsLicenseClassBusiness.Find(LocalAppInfo.LicenseClassID).ClassName;
            lblFullName.Text = PersonInfo.FirstName + " " + PersonInfo.SecondName + " " + PersonInfo.ThirdName + " " + PersonInfo.LastName;
            lblLicenseID.Text = LicenseInfo.LicenseID.ToString();
            lblNotionalNo.Text = PersonInfo.NationalNo;
            lblGendor.Text = PersonInfo.Gender ? "Male" : "Fimaly";
            lblIssueDate.Text= LicenseInfo.IssueDate.ToShortDateString();
            lblIssueReason.Text = LicenseInfo.IssueReason == 1 ? "First Time" : "Second";
            lblNotes.Text = LicenseInfo.Notes == "" ? "No Notes" : LicenseInfo.Notes;
            lblIsActive.Text = LicenseInfo.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text= PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text= LicenseInfo.DriverID.ToString();
            lblExpirationDate.Text = LicenseInfo.ExpirationDate.ToShortDateString();
            lblIsDetained.Text = "No";
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
