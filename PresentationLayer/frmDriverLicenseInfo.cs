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
    public partial class frmDriverLicenseInfo : Form
    {
        int _localAppID;
        public frmDriverLicenseInfo(int LocalAppID)
        {
            InitializeComponent();
            _localAppID = LocalAppID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            ucDriverLicenseInfo ucLInfo= new ucDriverLicenseInfo(_localAppID);
            ucLInfo.Dock = DockStyle.Fill;
            pnlDriverLicenseInfo.Controls.Add(ucLInfo);
        }
    }
}
