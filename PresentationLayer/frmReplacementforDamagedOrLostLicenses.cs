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
    public partial class frmReplacementforDamagedOrLostLicenses : Form
    {
        int LocalLicenseID = -1;
        int ApplicationID = -1;
        int DriverID = -1,
        NewApplicationID = -1;
        clsLicensesBusiness LicenseInfo;
        clsLicenseClass ClassInfo;
        clsLicensesBusiness NewLicenseInfo = new clsLicensesBusiness();
        public frmReplacementforDamagedOrLostLicenses()
        {
            InitializeComponent();
        }

        private bool _AddApp()
        {
            clsApplication LocalAppInfo = clsApplication.GetApplicationInfoByID(ApplicationID);
            clsApplication NewApplicationInfo = new clsApplication();
            NewApplicationInfo.ApplicantPersonID = LocalAppInfo.ApplicantPersonID;
            NewApplicationInfo.ApplicationDate = DateTime.Now;
            NewApplicationInfo.ApplicationTypeID = 2;
            NewApplicationInfo.ApplicationStatus = 1;
            NewApplicationInfo.LastApplicationDate = DateTime.Now;
            NewApplicationInfo.PaidFees = Convert.ToDecimal(lblAppFees.Text);
            NewApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (NewApplicationInfo.Save())
            {
                NewApplicationID = NewApplicationInfo.ApplicationID;
                return true;
            }
            return false;

        }

        private void _LoadAppInfo()
        {
            ClassInfo = clsLicenseClass.Find(LicenseInfo.LicenseClass);
            lblOldLicenseID.Text = LocalLicenseID.ToString();
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
           
            lblCreateBy.Text = clsGlobal.CurrentUser.Username;
           
            
        }

        private void _Find()
        {

            LicenseInfo = clsLicensesBusiness.GetLicenseInfoByLicenseID(Convert.ToInt16(txtPersonID.Text));
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
                btnRenew.Enabled = LicenseInfo.IsActive;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _Find();
        }

        private void txtPersonID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Find();
            }
        }

        private void lblShowLicensesHistory_Click(object sender, EventArgs e)
        {
            int LocalAppID = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseByApplicationInfID(ApplicationID).LocalDrivingLicenseApplicationID;
            if (LocalAppID != null)
            {
                frmLicenseHistory frm = new frmLicenseHistory(LocalAppID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Not License.. ");
        }

        private void lblShowLicenseInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (_AddApp())
            {
                NewLicenseInfo.ApplicationID = NewApplicationID;
                NewLicenseInfo.LicenseClass = ClassInfo.LicenseClassID;
                NewLicenseInfo.DriverID = LicenseInfo.DriverID;
                NewLicenseInfo.IssueDate = LicenseInfo.IssueDate;
                NewLicenseInfo.ExpirationDate = LicenseInfo.ExpirationDate;
                NewLicenseInfo.Notes = LicenseInfo.Notes;
                NewLicenseInfo.PaidFees = ClassInfo.ClassFees;
                NewLicenseInfo.IsActive = true;
                NewLicenseInfo.IssueReason = (byte)(rdioDamageLic.Checked ? 3 : 4);


                NewLicenseInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                DialogResult = MessageBox.Show("Are you sure want Renew the license?", "Confirm", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
                {
                    if (NewLicenseInfo.Save())
                    {
                        MessageBox.Show("License Renwed Successfully with ID = " + NewLicenseInfo.LicenseID);
                        lblRenewedLicenseID.Text = NewLicenseInfo.LicenseID.ToString();
                        lblRLApplicationID.Text = NewLicenseInfo.ApplicationID.ToString();
                        lblOldLicenseID.Text = LicenseInfo.LicenseID.ToString();
                        LicenseInfo.IsActive = false;
                      if(  LicenseInfo.Save())
                        {
                            btnRenew.Enabled = false;
                            lblShowLicenseInfo.Enabled = true;
                        }
                        
                    }
                    else
                    {
                        clsApplication.DeleteApplicationByID(NewApplicationID);
                    }
                }



            }
            
        }

        private void rdioDamageLic_CheckedChanged(object sender, EventArgs e)
        {
            lblAppFees.Text = clsApplicationType.GetApplicationTypeByID(4).Fees.ToString();
            lblTitle.Text = "Replacement for Damaged Licenses";
            this.Text = "Replacement for Damaged Licenses";
        }

        private void rdioLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblAppFees.Text = clsApplicationType.GetApplicationTypeByID(3).Fees.ToString();
            lblTitle.Text = "Replacement for Lost Licenses";
            this.Text = "Replacement for Lost Licenses";

        }

        private void frmReplacementforDamagedOrLostLicenses_Load(object sender, EventArgs e)
        {
            ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
            ucDL.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucDL);
            btnRenew.Enabled = false;
            lblShowLicensesHistory.Enabled = false;
            lblShowLicenseInfo.Enabled = false;
            rdioDamageLic.Checked = true;
        }
    }
}
