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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_System
{
    public partial class frmRenewLocalDrivingLicense : Form
    {
        int LocalLicenseID = -1;
        int ApplicationID = -1;
        int DriverID = -1,
        NewApplicationID = -1;
        clsLicensesBusiness LicenseInfo;
        clsLicenseClassBusiness ClassInfo;
        clsLicensesBusiness NewLicenseInfo = new clsLicensesBusiness();

        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }


        private bool _AddApp()
        {
            clsApplicationBusiness LocalAppInfo = clsApplicationBusiness.GetApplicationInfoByID(ApplicationID);
            clsApplicationBusiness NewApplicationInfo = new clsApplicationBusiness();
            NewApplicationInfo.ApplicantPersonID = LocalAppInfo.ApplicantPersonID;
            NewApplicationInfo.ApplicationDate = DateTime.Now;
            NewApplicationInfo.ApplicationTypeID = 2;
            NewApplicationInfo.ApplicationStatus = 1;
            NewApplicationInfo.LastApplicationDate = DateTime.Now;
            NewApplicationInfo.PaidFees = Convert.ToDecimal(lblAppFees.Text);
            NewApplicationInfo.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
            if (NewApplicationInfo.Save())
            {
                NewApplicationID = NewApplicationInfo.ApplicationID;
                return true;
            }
            return false;

        }

        private void _LoadAppInfo()
        {
             ClassInfo = clsLicenseClassBusiness.Find(LicenseInfo.LicenseClass);
            lblOldLicenseID.Text = LocalLicenseID.ToString();
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpirationDate.Text = DateTime.Now.AddYears(Convert.ToInt16(ClassInfo.DefaultValidityLength)).ToShortDateString();
            lblCreateBy.Text = clsGlobalUser.CurrentUser.Username;
            lblAppFees.Text = clsAppTypesBusiness.GetApplicationTypeByID(2).Fees.ToString();
            lblLicenseFees.Text = ClassInfo.ClassFees.ToString();
            lblTotalFees.Text = (clsAppTypesBusiness.GetApplicationTypeByID(2).Fees + ClassInfo.ClassFees).ToString();
        }

        private void _Find()
        {

             LicenseInfo = clsLicensesBusiness.GetLicenseInfoByLicenseID(Convert.ToInt16(txtPersonID.Text));
            if (LicenseInfo != null)
            {
                if(LicenseInfo.ExpirationDate >= DateTime.Now)
                {
                    MessageBox.Show("Selected License is not yet expiared, it will expire on :" + LicenseInfo.ExpirationDate.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    panel1.Controls.Clear();
                    ucDriverLicenseInfo u1cDL = new ucDriverLicenseInfo(LicenseInfo.ApplicationID);
                    u1cDL.Dock = DockStyle.Fill;
                    panel1.Controls.Add(u1cDL);
                    lblShowLicensesHistory.Enabled = true;
                    ApplicationID = LicenseInfo.ApplicationID;
                    return;
                }

                panel1.Controls.Clear();
             
                ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo(LicenseInfo.ApplicationID);
                ucDL.Dock = DockStyle.Fill;
                panel1.Controls.Add(ucDL);
                LocalLicenseID = LicenseInfo.LicenseID;
                lblShowLicensesHistory.Enabled = true;
                ApplicationID = LicenseInfo.ApplicationID;
                DriverID = LicenseInfo.DriverID;
                _LoadAppInfo();
                btnRenew.Enabled = true;
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

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
            ucDL.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucDL);
            btnRenew.Enabled = false;
            lblShowLicensesHistory.Enabled = false;
            lblShowLicenseInfo.Enabled = false;
        }
        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            _Find();
        }

        private void txtPersonID_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Find();
            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if(_AddApp())
            {
                

                NewLicenseInfo.ApplicationID = NewApplicationID;
                NewLicenseInfo.LicenseClass = ClassInfo.LicenseClassID;
                NewLicenseInfo.DriverID = LicenseInfo.DriverID;
                NewLicenseInfo.IssueDate= DateTime.Now;
                NewLicenseInfo.ExpirationDate = DateTime.Now.AddYears(ClassInfo.DefaultValidityLength);
                NewLicenseInfo.Notes = lblNotes.Text;
                NewLicenseInfo.PaidFees = ClassInfo.ClassFees;
                NewLicenseInfo.IsActive = true;
                NewLicenseInfo.IssueReason = 2;
                NewLicenseInfo.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
               
                    DialogResult = MessageBox.Show("Are you sure want Renew the license?","Confirm",MessageBoxButtons.OKCancel);
                    if(DialogResult == DialogResult.OK)
                    {
                        if (NewLicenseInfo.Save())
                        {
                            MessageBox.Show("License Renwed Successfully with ID = " + NewLicenseInfo.LicenseID);
                        lblRenewedLicenseID.Text= NewLicenseInfo.LicenseID.ToString();
                        lblRLApplicationID.Text= NewLicenseInfo.ApplicationID.ToString();
                        lblOldLicenseID.Text = LicenseInfo.LicenseID.ToString();
                            LicenseInfo.IsActive = false;
                            LicenseInfo.Save();
                        btnRenew.Enabled = false;
                        lblShowLicenseInfo.Enabled = true;
                      }
                    }



            }
            else
            {
                clsApplicationBusiness.DeleteApplicationByID(NewApplicationID);
            }
        }

        private void lblShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(NewLicenseInfo.ApplicationID);
            frm.ShowDialog();
        }

        private void lblShowLicensesHistory_Click_1(object sender, EventArgs e)
        {

            int LocalAppID = clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseByApplicationInfID(ApplicationID).LocalDrivingLicenseApplicationID;
            if (LocalAppID != null)
            {
                frmLicenseHistory frm = new frmLicenseHistory(LocalAppID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Not License.. ");
            
        }

      
    }
}
