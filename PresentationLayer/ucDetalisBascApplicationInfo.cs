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

        clsApplicationBusiness AppInfo;
        public ucDetalisBascApplicationInfo()
        {
            InitializeComponent();
        }
        public ucDetalisBascApplicationInfo(int ApplicationID)
        {
            InitializeComponent();
            AppInfo = clsApplicationBusiness.GetApplicationInfoByID(ApplicationID);
        }
        

        private void ucDetalisBascApplicationInfo_Load(object sender, EventArgs e)
        {
            lblAppID.Text=AppInfo.ApplicationID.ToString();
            lblStatus.Text=AppInfo.ApplicationStatus.ToString();
            lblFees.Text = clsAppTypesBusiness.GetApplicationTypeByID(AppInfo.ApplicationTypeID).Fees.ToString();
            lblType.Text = clsAppTypesBusiness.GetApplicationTypeByID(AppInfo.ApplicationTypeID).Title;
            lblApplicant.Text=PeopleBusiness.GetPersonFullNameByID(AppInfo.ApplicantPersonID);
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
