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
    public partial class frmLicenseHistory : Form
    {
        int _LocalAppID;
        clsLocalDrivingLicenseApplication LocalAppInfo;
        clsApplication ApplicationInfo;
        public frmLicenseHistory(int LocalAppID)
        {
            InitializeComponent();
            _LocalAppID = LocalAppID;
            LocalAppInfo = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(_LocalAppID);
            ApplicationInfo = clsApplication.GetApplicationInfoByID(LocalAppInfo.ApplicationID);
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ucFindPerson PersonInfo = new ucFindPerson(ApplicationInfo.ApplicantPersonID);
            palPersonInfo.Controls.Clear();
            PersonInfo.Dock = DockStyle.Fill;
            palPersonInfo.Controls.Add(PersonInfo);


            dvLocalLicenses.DataSource = clsLicensesBusiness.GetAllLocalLicansesByPersonID(ApplicationInfo.ApplicantPersonID);
            dvInternotionalLicenses.DataSource= clsInternationalLicensesBusienss.GetAllInternationalLicensesByPersonID(ApplicationInfo.ApplicantPersonID);
            

        }
    }
}
