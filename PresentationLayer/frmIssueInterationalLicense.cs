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
    public partial class frmIssueInterationalLicense : Form
    {
        int LocalLicenseID=-1;
        int ApplicationID = -1;
        int DriverID = -1,
        NewApplicationID = -1; 

        public frmIssueInterationalLicense()
        {
            InitializeComponent();
        }

        private void _LoadAppInfo()
        {

            lblLocalLicenseID.Text = LocalLicenseID.ToString();
            lblApplicationDate.Text= DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblCreateBy.Text = clsGlobalUser.CurrentUser.Username;
            lblFees.Text= clsAppTypesBusiness.GetApplicationTypeByID(6).Fees.ToString();

        }


        private bool _AddNewInterationalApp()
        {
            clsApplicationBusiness LocalAppInfo = clsApplicationBusiness.GetApplicationInfoByID(ApplicationID);
             clsApplicationBusiness NewApplicationInfo = new clsApplicationBusiness();
            NewApplicationInfo.ApplicantPersonID = LocalAppInfo.ApplicantPersonID;
            NewApplicationInfo.ApplicationDate = DateTime.Now;
            NewApplicationInfo.ApplicationTypeID = 6;
            NewApplicationInfo.ApplicationStatus = 1;
            NewApplicationInfo.LastApplicationDate = DateTime.Now;
            NewApplicationInfo.PaidFees = Convert.ToDecimal(lblFees.Text);
            NewApplicationInfo.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
            if(NewApplicationInfo.Save())
            {
                NewApplicationID = NewApplicationInfo.ApplicationID;
                return true;
            }
            return false;

        }



        private void _Find()
        {
            
            clsLicensesBusiness LicenseInfo = clsLicensesBusiness.GetLicenseInfoByLicenseID(Convert.ToInt16(txtPersonID.Text));
            if (LicenseInfo != null)
            {
                
                panel1.Controls.Clear();
                ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo(LicenseInfo.ApplicationID);
                ucDL.Dock = DockStyle.Fill;
                panel1.Controls.Add(ucDL);
                LocalLicenseID = LicenseInfo.LicenseID;
                lblShowLicensesHistory.Enabled = true;
                ApplicationID = LicenseInfo.ApplicationID;
                DriverID = LicenseInfo.DriverID;
                _LoadAppInfo();
            }
            else
            {
                MessageBox.Show("The license ID was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                panel1.Controls.Clear();
                ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
                ucDL.Dock = DockStyle.Fill;
                panel1.Controls.Add(ucDL);
            }

        }

        private void frmIssueInterationalLicense_Load(object sender, EventArgs e)
        {
            ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
            ucDL.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucDL);
            lblShowLicensesHistory.Enabled = false;
            lblShowLicenseInfo.Enabled = false;
        }

        private void ucFindLicenseInfo_Load(object sender, EventArgs e)
        {
            ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
            ucDL.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucDL);
        }

        public void txtPersonID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Find();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _Find();
        }
        
        private void lblShowLicensesHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseByApplicationInfID(ApplicationID).LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_AddNewInterationalApp())
            {

                clsInternationalLicensesBusienss InternationalLicensesInfo = new clsInternationalLicensesBusienss();
                InternationalLicensesInfo.ApplicationID = NewApplicationID;
                InternationalLicensesInfo.IssuedUsingLocalLicenseID = LocalLicenseID;
                InternationalLicensesInfo.DriverID = DriverID;
                InternationalLicensesInfo.IssueDate = DateTime.Now;
                InternationalLicensesInfo.ExpirationDate = DateTime.Now;
                InternationalLicensesInfo.IsActive= true;
                InternationalLicensesInfo.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
                if(InternationalLicensesInfo.Save())
                {
                    MessageBox.Show("The issuance process was completed successfully. The international LicenseID is : " + InternationalLicensesInfo.InternationalLicenseID);
                    lblILLicenseID.Text = InternationalLicensesInfo.InternationalLicenseID.ToString();
                    lblILApplicationID.Text = NewApplicationID.ToString();
                }
                else
                {
                   
                    MessageBox.Show("Application submission failed.");
                    clsApplicationBusiness.DeleteApplicationByID(NewApplicationID);

                }

            }
            else
            {
                MessageBox.Show("Application submission failed.");

            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {   
            this.Close();
        }
    }
}
