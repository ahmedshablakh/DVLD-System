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
    public partial class frmTetakeTest : Form
    {
        clsTestAppointmentsBusiness AppointmentTestInfo;
        clsTestsBusiness TestInfo;
        int _TestType;
        public frmTetakeTest(int AppointTestID, int TestID,int TestType)
        {
            InitializeComponent();
            _TestType = TestType;
            AppointmentTestInfo= clsTestAppointmentsBusiness.GetTestAppointmentInfoByID(AppointTestID);
            if (TestID != -1)
            {
                TestInfo = clsTestsBusiness.GetTestByID(TestID);
            }
            else
                TestInfo = new clsTestsBusiness();
        }

        private void frmTetakeVisionTest_Load(object sender, EventArgs e)
        {

            switch (_TestType)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.eye;
                    grVisionTest.Text = "Vision Test";
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.examination;
                    grVisionTest.Text = "Written Test";
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.driver;
                    grVisionTest.Text = "Driver Test";
                    break;
                default:
                    pictureBox2.Image =null;
                    grVisionTest.Text = "";
                    break;

            }

            clsLocalDrivingLicenseApplicationsBusiness LocaAppInfo = clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(AppointmentTestInfo.LocalDrivingLicenseApplicationID);
            lblTrial.Text = clsTestAppointmentsBusiness.GetCountTestAppointmentByLcalAppIDAndTestTypeID(LocaAppInfo.LocalDrivingLicenseApplicationID, _TestType).ToString();
            lblDateTime.Text = AppointmentTestInfo.AppointmentDate.ToString();
            lblDLAID.Text = LocaAppInfo.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClassBusiness.Find(LocaAppInfo.LicenseClassID).ClassName;
            lblName.Text = PeopleBusiness.GetPersonFullNameByID(clsApplicationBusiness.GetApplicationInfoByID(LocaAppInfo.ApplicationID).ApplicantPersonID);
            lblFees.Text = clsTestTypeBusiness.GetTestTypeByID(_TestType).Fees.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            TestInfo.TestAppointmentID = AppointmentTestInfo.TestAppointmentID;
            TestInfo.TestResult =( radPass.Checked?true:false);
            TestInfo.Notes= txtNotes.Text;
            TestInfo.CreatedByUserID= clsGlobalUser.CurrentUser.UserID;
           
            if(TestInfo.Save())
            {
                AppointmentTestInfo.IsLocked = true;
                if(AppointmentTestInfo.Save())
                {
                    MessageBox.Show("Successfully");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
