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
    public partial class ucFindLicenseInfo : UserControl
    {
        public int LicenseID = -1;
        public ucFindLicenseInfo()
        {
            InitializeComponent();
        }


        private void _Find()
        {
            clsLicensesBusiness LicenseInfo = clsLicensesBusiness.GetLicenseInfoByLicenseID(Convert.ToInt16(txtPersonID.Text));
            if(LicenseInfo != null)
            {
                panel1.Controls.Clear();
                ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo(LicenseInfo.ApplicationID);
                ucDL.Dock = DockStyle.Fill;
                panel1.Controls.Add(ucDL);
                LicenseID = LicenseInfo.LicenseID;
            }
            else
            {
                MessageBox.Show("The license ID was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                panel1.Controls.Clear ();
                ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
                ucDL.Dock = DockStyle.Fill;
                panel1.Controls.Add(ucDL);
            }
            
        }
        private void txtPersonID_Enter(object sender, EventArgs e)
        {
            //_Find();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            _Find();
        }

        private void ucFindLicenseInfo_Load(object sender, EventArgs e)
        {
            ucDriverLicenseInfo ucDL = new ucDriverLicenseInfo();
            ucDL.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucDL);
        }

        public void txtPersonID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                _Find();
            }
        }
    }
}
