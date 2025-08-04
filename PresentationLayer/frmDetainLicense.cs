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
    public partial class frmDetainLicense : Form
    {
        clsLicensesBusiness LicenseInfo;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void _Find()
        {

            LicenseInfo = clsLicensesBusiness.GetLicenseInfoByLicenseID(Convert.ToInt16(txtPersonID.Text));
            if (LicenseInfo != null)
            {
                btnDetain.Enabled = true;
                lblShowLicensesHistory.Enabled = true;
                if(clsDetainLicenseBusiness.IsDetainLicense(LicenseInfo.LicenseID))
                {
                    MessageBox.Show("Selected License i already detained , choose another on.","Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    btnDetain.Enabled=false;

                }
                panel1.Controls.Clear();
                ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo(LicenseInfo.ApplicationID);
                ucDL.Dock = DockStyle.Fill;
                panel1.Controls.Add(ucDL);
                lblShowLicensesHistory.Enabled = true;
                lblDetainDate.Text = DateTime.Now.ToString();
                lblFineFees.Text = "50";
                lblCreateBy.Text = clsGlobal.CurrentUser.Username;
                lblLicenseID.Text = LicenseInfo.LicenseID.ToString();
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
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
            ucDL.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucDL);
            lblShowLicenseInfo.Enabled = false;
            lblShowLicensesHistory.Enabled=false;
            btnDetain.Enabled = false;
        }

        private void txtPersonID_KeyDown(object sender, KeyEventArgs e)
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

        private void btnDetain_Click(object sender, EventArgs e)
        {
            clsDetainLicenseBusiness DetainInfo= new clsDetainLicenseBusiness();

            DetainInfo.LicenseID = LicenseInfo.LicenseID;
            DetainInfo.DetainDate=DateTime.Now;
            DetainInfo.CreatedByUserID=clsGlobal.CurrentUser.UserID;
            DetainInfo.FineFees = 50;
            DialogResult result= MessageBox.Show("Are you sure want to detain license?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if (DetainInfo.Save())
                {
                    MessageBox.Show("License Detain Successfully with ID = " + DetainInfo.DetainID,"License Detained");
                    lblShowLicenseInfo.Enabled = true;
                    btnDetain.Enabled=false;
                    lblDetainID.Text= DetainInfo.DetainID.ToString();
                }
            }
           
        }

        private void lblShowLicensesHistory_Click(object sender, EventArgs e)
        {
          //
        }

        private void lblShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LicenseInfo.ApplicationID);
            frm.ShowDialog();

        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
