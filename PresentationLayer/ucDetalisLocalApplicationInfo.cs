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
        clsLocalDrivingLicenseApplicationsBusiness DLAppInfo;
        
        
        public ucDetalisLocalApplicationInfo()
        {
            InitializeComponent();
        }
        public ucDetalisLocalApplicationInfo(int DLAID)
        {
            InitializeComponent();
            DLAppInfo= clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(DLAID);
        }



        private void ucDetalisApplicationInfo_Load(object sender, EventArgs e)
        {
            lblShowLisInfo.Enabled = false;
            lblDLAID.Text = DLAppInfo.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = clsLicenseClassBusiness.Find(DLAppInfo.LicenseClassID).ClassName;
            lblPassesTeste.Text = clsLocalDrivingLicenseApplicationsBusiness.GetTotalPassedTestByID(DLAppInfo.LocalDrivingLicenseApplicationID).ToString();
            ucDetalisBascApplicationInfo ucBInfo =new ucDetalisBascApplicationInfo(DLAppInfo.ApplicationID);
            ucBInfo.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucBInfo);
        }

        private void lblShowLisInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
