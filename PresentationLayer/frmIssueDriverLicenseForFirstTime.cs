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
    public partial class frmIssueDriverLicenseForFirstTime : Form
    {
        int _LocalAppID;
        public frmIssueDriverLicenseForFirstTime(int LocalAppID)
        {
            InitializeComponent();
            _LocalAppID = LocalAppID;
        }

        private void frmIssueDriverLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            ucDetalisLocalApplicationInfo LocalAppInfo = new ucDetalisLocalApplicationInfo(_LocalAppID);
            LocalAppInfo.Dock = DockStyle.Fill;
            pnlAppInfo.Controls.Add(LocalAppInfo);
        }


        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsLicensesBusiness LicenseInfo = new clsLicensesBusiness();
            clsLocalDrivingLicenseApplicationsBusiness LocalAppInfo =clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(_LocalAppID);
           
            LicenseInfo.ApplicationID = LocalAppInfo.ApplicationID;
            LicenseInfo.DriverID = 11;
            LicenseInfo.LicenseClass = LocalAppInfo.LicenseClassID;
            LicenseInfo.IssueDate = DateTime.Now;
            LicenseInfo.ExpirationDate = DateTime.Now.AddYears(clsLicenseClassBusiness.Find(LocalAppInfo.LicenseClassID).DefaultValidityLength);
            LicenseInfo.Notes = lblNotes.Text;
            LicenseInfo.PaidFees = clsLicenseClassBusiness.Find(LocalAppInfo.LicenseClassID).ClassFees;
            LicenseInfo.IsActive = true;
            LicenseInfo.IssueReason = 1;
            LicenseInfo.CreatedByUserID= clsGlobalUser.CurrentUser.UserID;
            if(LicenseInfo.Save())
            {
                clsApplicationBusiness ApplicInfo = clsApplicationBusiness.GetApplicationInfoByID(LicenseInfo.ApplicationID);
                ApplicInfo.ApplicationStatus = 3;
                if (ApplicInfo.Save())

                    MessageBox.Show("License Issue Successfully LicenseID = " + LicenseInfo.LicenseID);

                this.Close();
            }
            else
            {
                MessageBox.Show("Erorr");
            }







        }
    }
}
