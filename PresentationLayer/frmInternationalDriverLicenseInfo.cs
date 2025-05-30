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
    public partial class frmInternationalDriverLicenseInfo : Form
    {
        int _InternationalLicenseID;
        public frmInternationalDriverLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucInternationalDriverLicenseInfo ucInt = new ucInternationalDriverLicenseInfo(_InternationalLicenseID);
            ucInt.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucInt);
        }
    }
}
