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
    public partial class ucDetalisBascApplicationInfo : UserControl
    {

        clsApplication AppInfo;
        public ucDetalisBascApplicationInfo()
        {
            InitializeComponent();
        }
        public ucDetalisBascApplicationInfo(int ApplicationID)
        {
            InitializeComponent();
            AppInfo = clsApplication.GetApplicationInfoByID(ApplicationID);
        }
        

        private void ucDetalisBascApplicationInfo_Load(object sender, EventArgs e)
        {
            lblAppID.Text=AppInfo.ApplicationID.ToString();
            lblStatus.Text=AppInfo.ApplicationStatus.ToString();
            lblFees.Text = clsApplicationType.GetApplicationTypeByID(AppInfo.ApplicationTypeID).Fees.ToString();
            lblType.Text = clsApplicationType.GetApplicationTypeByID(AppInfo.ApplicationTypeID).Title;
            lblApplicant.Text=clsPerson.GetPersonFullNameByID(AppInfo.ApplicantPersonID);
            lblDate.Text= AppInfo.ApplicationDate.ToString();
            lblStatusDate.Text=AppInfo.LastApplicationDate.ToString();
            lblCreatedByUser.Text=AppInfo.CreatedByUserID.ToString();

        }

        private void lblViewPersonInfo_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(AppInfo.ApplicantPersonID,2);
            frm.ShowDialog();

        }
    }
}
