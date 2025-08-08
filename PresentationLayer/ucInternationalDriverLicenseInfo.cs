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
    public partial class ucInternationalDriverLicenseInfo : UserControl
    {
        clsApplication ApplicationInfo;
        clsPerson PersonInfo;
        clsInternationalLicense IntLicenseInfo;
        public ucInternationalDriverLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            IntLicenseInfo = clsInternationalLicense.GetInternationalLicenseByLicenseID(InternationalLicenseID);
            ApplicationInfo = clsApplication.GetApplicationInfoByID(IntLicenseInfo.ApplicationID);
            PersonInfo = clsPerson.GetPersonInfoByID(ApplicationInfo.ApplicantPersonID);



        }
        public ucInternationalDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void ucInternationalDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            if(ApplicationInfo != null && PersonInfo != null && IntLicenseInfo != null) 
            {

               
                
                lblFullName.Text = PersonInfo.FirstName + " " + PersonInfo.SecondName + " " + PersonInfo.ThirdName + " " + PersonInfo.LastName;
                lblIntLicenseID.Text = IntLicenseInfo.InternationalLicenseID.ToString();
                lblLicenseID.Text = IntLicenseInfo.IssuedUsingLocalLicenseID.ToString();
                lblNotionalNo.Text = PersonInfo.NationalNo;
                lblGendor.Text = PersonInfo.Gender ? "Male" : "Fimaly";
                lblIssueDate.Text = IntLicenseInfo.IssueDate.ToShortDateString();
                lblIsActive.Text = IntLicenseInfo.IsActive ? "Yes" : "No";
                lblDateOfBirth.Text = PersonInfo.DateOfBirth.ToShortDateString();
                lblDriverID.Text = IntLicenseInfo.DriverID.ToString();
                lblExpirationDate.Text = IntLicenseInfo.ExpirationDate.ToShortDateString();
                lblApplicationID.Text = IntLicenseInfo.ApplicationID.ToString();
               
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
