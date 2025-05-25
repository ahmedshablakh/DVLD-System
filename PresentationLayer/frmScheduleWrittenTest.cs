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
    public partial class frmScheduleWrittenTest : Form
    {
        public enum enMode { AddNew, Update }
        public enMode Mode;
        clsLocalDrivingLicenseApplicationsBusiness LocaAppInfo;
        clsApplicationBusiness Application;
        clsTestAppointmentsBusiness WrittenTestInfo;
        clsApplicationBusiness RetakeTestApplication;
        public decimal TotalFees;
        public frmScheduleWrittenTest(int LocalAppID, int AppointID)
        {
            InitializeComponent();
            Mode = enMode.AddNew;
            LocaAppInfo = clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalAppID);
            Application = clsApplicationBusiness.GetApplicationInfoByID(LocaAppInfo.ApplicationID);
            if (AppointID != -1)
            {
                WrittenTestInfo = clsTestAppointmentsBusiness.GetTestAppointmentInfoByID(AppointID);
                Mode = enMode.Update;
            }
        }

        private void _LoadData()
        {

            lblTrial.Text = clsTestAppointmentsBusiness.GetCountTestAppointmentByLcalAppIDAndTestTypeID(LocaAppInfo.LocalDrivingLicenseApplicationID, 2).ToString();
            if (Mode == enMode.AddNew)
            {
                AddNewTest();
                return;
            }

           
            grRetakeTest.Enabled = (Convert.ToInt16(lblTrial.Text) != 0);
            dateTimePicker1.MinDate = WrittenTestInfo.AppointmentDate;
            lblDLAID.Text = LocaAppInfo.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClassBusiness.Find(LocaAppInfo.LicenseClassID).ClassName;
            lblName.Text = PeopleBusiness.GetPersonFullNameByID(clsApplicationBusiness.GetApplicationInfoByID(LocaAppInfo.ApplicationID).ApplicantPersonID);
            decimal AppFees = (decimal)clsTestTypeBusiness.GetTestTypeByID(1).Fees;
            lblFees.Text = AppFees.ToString();
            lblRAppFees.Text = "0";
            TotalFees = AppFees;
            if (grRetakeTest.Enabled == true)
            {


                decimal ReFees = clsAppTypesBusiness.GetApplicationTypeByID(8).Fees;
                lblRAppFees.Text = ReFees.ToString();
                TotalFees = AppFees + ReFees;
            }

            lblTotalFees.Text = TotalFees.ToString();



        }
        private void AddNewTest()
        {
            WrittenTestInfo = new clsTestAppointmentsBusiness();
            grRetakeTest.Enabled = (Convert.ToInt16(lblTrial.Text) != 0);
            dateTimePicker1.MinDate = DateTime.Now;
            lblDLAID.Text = LocaAppInfo.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClassBusiness.Find(LocaAppInfo.LicenseClassID).ClassName;
            lblName.Text = PeopleBusiness.GetPersonFullNameByID(clsApplicationBusiness.GetApplicationInfoByID(LocaAppInfo.ApplicationID).ApplicantPersonID);
            decimal AppFees = (decimal)clsTestTypeBusiness.GetTestTypeByID(1).Fees;
            lblFees.Text = AppFees.ToString();
            lblRAppFees.Text = "0";
            TotalFees = AppFees;

            if (grRetakeTest.Enabled == true && Mode == enMode.AddNew)
            {
                decimal ReFees = clsAppTypesBusiness.GetApplicationTypeByID(8).Fees;

                TotalFees = ReFees + AppFees;
                lblRAppFees.Text = ReFees.ToString();
                RetakeTestApplication = new clsApplicationBusiness();

                RetakeTestApplication.ApplicationTypeID = 8;
                RetakeTestApplication.ApplicantPersonID = Application.ApplicantPersonID;
                RetakeTestApplication.PaidFees = ReFees;
                RetakeTestApplication.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;


            }
            lblTotalFees.Text = TotalFees.ToString();
        }
        private void frmScheduleWrittenTest_Load(object sender, EventArgs e)
        {

            if (Mode == enMode.Update)
            {
                if (WrittenTestInfo.IsLocked == true)
                {
                    btnSave.Enabled = false;
                    dateTimePicker1.Enabled = false;

                }

            }

            _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (grRetakeTest.Enabled == true && Mode == enMode.AddNew)
            {
                RetakeTestApplication.Save();
            }
            WrittenTestInfo.TestTypeID = 2;
            WrittenTestInfo.LocalDrivingLicenseApplicationID = LocaAppInfo.LocalDrivingLicenseApplicationID;
            WrittenTestInfo.AppointmentDate = dateTimePicker1.Value;
            WrittenTestInfo.PaidFees = TotalFees;
            WrittenTestInfo.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
            if (WrittenTestInfo.Save())
            {
                if (Mode == enMode.AddNew)
                {
                    MessageBox.Show("Add New Teste Successfully.");
                    lblRTestAppID.Text = WrittenTestInfo.TestAppointmentID.ToString();
                    Mode = enMode.Update;
                }

                else
                {
                    MessageBox.Show("Updated Successfully.");
                }


                _LoadData();


            }
            else
            {
                MessageBox.Show("Erorr.");
            }

        }

      
    }
}
