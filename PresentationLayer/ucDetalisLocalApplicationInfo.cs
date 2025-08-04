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
    public partial class ucDetalisLocalApplicationInfo : UserControl
    {
        clsLocalDrivingLicenseApplication DLAppInfo;
        
        
        public ucDetalisLocalApplicationInfo()
        {
            InitializeComponent();
        }
        public ucDetalisLocalApplicationInfo(int DLAID)
        {
            InitializeComponent();
            DLAppInfo= clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(DLAID);
        }



        private void ucDetalisApplicationInfo_Load(object sender, EventArgs e)
        {
            

            clsApplication ApplicationInfo = clsApplication.GetApplicationInfoByID(DLAppInfo.ApplicationID);
            lblShowLisInfo.Enabled =(ApplicationInfo.ApplicationStatus==3);
            

            lblDLAID.Text = DLAppInfo.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = clsLicenseClass.Find(DLAppInfo.LicenseClassID).ClassName;
            lblPassesTeste.Text = clsLocalDrivingLicenseApplication.GetTotalPassedTestByID(DLAppInfo.LocalDrivingLicenseApplicationID).ToString();
            ucDetalisBascApplicationInfo ucBInfo =new ucDetalisBascApplicationInfo(DLAppInfo.ApplicationID);
            ucBInfo.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucBInfo);
        }

        private void lblShowLisInfo_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(DLAppInfo.ApplicationID);
            frm.ShowDialog();
        }
    }
}
