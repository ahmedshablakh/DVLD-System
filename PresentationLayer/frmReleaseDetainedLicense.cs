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
    public partial class frmReleaseDetainedLicense : Form
    { 

        clsLicense LicenseInfo;
        clsDetainedLicense ReleaseInfo;
        decimal ApplicaFees;
        int NewAppID = -1;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        private bool _AddApp()
        {
          
            clsApplication NewApplicationInfo = new clsApplication();
            NewApplicationInfo.ApplicantPersonID = clsApplication.GetApplicationInfoByID(LicenseInfo.ApplicationID).ApplicantPersonID;
            NewApplicationInfo.ApplicationDate = DateTime.Now;
            NewApplicationInfo.ApplicationTypeID = 5;
            NewApplicationInfo.ApplicationStatus =31;
            NewApplicationInfo.LastApplicationDate = DateTime.Now;
            NewApplicationInfo.PaidFees = ApplicaFees;
            NewApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (NewApplicationInfo.Save())
            {

                lblApplicationID.Text = NewApplicationInfo.ApplicationID.ToString();
                NewAppID= NewApplicationInfo.ApplicationID;
                return true;
            }
            return false;

        }
 
       
        private void _LoadReleaseInfo()
        {


             ReleaseInfo = clsDetainedLicense.GetDetainInfoByLicenseID(LicenseInfo.LicenseID);
            
            lblCreateBy.Text = clsGlobal.CurrentUser.Username;
            lblShowLicensesHistory.Enabled = true;
            lblDetainID.Text = ReleaseInfo.DetainID.ToString();
            lblDetainDate.Text = ReleaseInfo.DetainDate.ToString();
            lblFineFees.Text = ReleaseInfo.FineFees.ToString();
            lblLicenseID.Text = LicenseInfo.LicenseID.ToString();
             ApplicaFees = clsApplicationType.GetApplicationTypeByID(5).Fees;
            decimal TotalFees = ApplicaFees + ReleaseInfo.FineFees; 
            lblApplicationFees.Text= ApplicaFees.ToString();
            lblTotalFees.Text = TotalFees.ToString();

        }
        
        private void _Find()
        {

            LicenseInfo = clsLicense.GetLicenseInfoByLicenseID(Convert.ToInt16(txtPersonID.Text));
            if (LicenseInfo != null)
            {
                btnRelease.Enabled = true;
                lblShowLicensesHistory.Enabled = true;
                if (!clsDetainedLicense.IsDetainLicense(LicenseInfo.LicenseID))
                {
                    MessageBox.Show("Selected License i not detained , choose another on.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnRelease.Enabled = false;

                }
                else
                {
                    panel1.Controls.Clear();
                    ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo(LicenseInfo.ApplicationID);
                    ucDL.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ucDL);
                    _LoadReleaseInfo();


                }
                
               
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

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {

            ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
            ucDL.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucDL);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if(_AddApp())
            {
                ReleaseInfo.IsReleased = true;
                ReleaseInfo.ReleaseDate = DateTime.Now;
                ReleaseInfo.ReleasedByUserID=clsGlobal.CurrentUser.UserID;
                ReleaseInfo.ReleaseApplicationID = NewAppID;
                if(ReleaseInfo.Save())
                {
                    MessageBox.Show("Detained License released Successfully..", "Detained License Released.",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Error..", "Falid..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsApplication.DeleteApplicationByID(NewAppID);
                }
            }

        }

        private void lblShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LicenseInfo.ApplicationID);
            frm.ShowDialog();
        }
    }
}
