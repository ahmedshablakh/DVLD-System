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
    public partial class frmScheduleVisionTest : Form
    {
        public enum enMode { AddNew, Update }
        public enMode Mode;
        clsLocalDrivingLicenseApplicationsBusiness LocaAppInfo;
        clsApplicationBusiness Application;
        clsTestAppointmentsBusiness VisionTestInfo;
        clsApplicationBusiness RetakeTestApplication;
        public  decimal TotalFees;
        public frmScheduleVisionTest(int LocalAppID,int AppointID)
        {
            InitializeComponent();
            Mode = enMode.AddNew;
            LocaAppInfo =clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalAppID);
            Application = clsApplicationBusiness.GetApplicationInfoByID(LocaAppInfo.ApplicationID);
            if (AppointID != -1)
            {
                VisionTestInfo = clsTestAppointmentsBusiness.GetTestAppointmentInfoByID(AppointID);
                Mode = enMode.Update;
            }
               

        }

        private void _LoadData()
        {
            
            if(Mode==enMode.AddNew)
            {
                AddNewTest();
                return;
            }
            
            lblTrial.Text = clsTestAppointmentsBusiness.GetCountTestAppointmentByLcalAppIDAndTestTypeID(LocaAppInfo.LocalDrivingLicenseApplicationID, 1).ToString();
            grRetakeTest.Enabled = (Convert.ToInt16(lblTrial.Text) != 0);
            dateTimePicker1.MinDate = VisionTestInfo.AppointmentDate;
            lblDLAID.Text = LocaAppInfo.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClassBusiness.Find(LocaAppInfo.LicenseClassID).ClassName;
            lblName.Text = PeopleBusiness.GetPersonFullNameByID(clsApplicationBusiness.GetApplicationInfoByID(LocaAppInfo.ApplicationID).ApplicantPersonID);
            decimal AppFees = (decimal)clsTestTypeBusiness.GetTestTypeByID(1).Fees;
            lblFees.Text = AppFees.ToString();
            lblRAppFees.Text = "0";
            TotalFees = AppFees;
            if (grRetakeTest.Enabled == true )
            {
                
              
                decimal ReFees = clsAppTypesBusiness.GetApplicationTypeByID(8).Fees;
                lblRAppFees.Text = ReFees.ToString();
                TotalFees = AppFees + ReFees;
            }
           
            lblTotalFees.Text = TotalFees.ToString();



        }
        private void AddNewTest()
        {
            VisionTestInfo = new clsTestAppointmentsBusiness();
            lblTrial.Text = clsTestAppointmentsBusiness.GetCountTestAppointmentByLcalAppIDAndTestTypeID(LocaAppInfo.LocalDrivingLicenseApplicationID, 1).ToString();
            grRetakeTest.Enabled = (Convert.ToInt16(lblTrial.Text) != 0);
            dateTimePicker1.MinDate = DateTime.Now;
            lblDLAID.Text = LocaAppInfo.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClassBusiness.Find(LocaAppInfo.LicenseClassID).ClassName;
            lblName.Text = PeopleBusiness.GetPersonFullNameByID(clsApplicationBusiness.GetApplicationInfoByID(LocaAppInfo.ApplicationID).ApplicantPersonID);
            decimal AppFees = (decimal)clsTestTypeBusiness.GetTestTypeByID(1).Fees;
            lblFees.Text = AppFees.ToString();
            lblRAppFees.Text = "0";
            TotalFees = AppFees;

            if (grRetakeTest.Enabled == true && Mode== enMode.AddNew)
            {
                decimal ReFees = clsAppTypesBusiness.GetApplicationTypeByID(8).Fees;

                TotalFees = ReFees + AppFees;
                lblRAppFees.Text = ReFees.ToString();
                RetakeTestApplication = new clsApplicationBusiness();

                RetakeTestApplication.ApplicationTypeID = 8;
                RetakeTestApplication.ApplicantPersonID = Application.ApplicantPersonID;
                RetakeTestApplication.PaidFees = ReFees;
                RetakeTestApplication.CreatedByUserID= clsGlobalUser.CurrentUser.UserID;
                

            }
            lblTotalFees.Text = TotalFees.ToString();
        }
        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            if(Mode==enMode.Update)
            {
                if(VisionTestInfo.IsLocked==true)
                {
                    btnSave.Enabled = false;
                    dateTimePicker1.Enabled = false;

                }
                    
            }

            _LoadData();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(grRetakeTest.Enabled==true && Mode == enMode.AddNew)
            {
                RetakeTestApplication.Save();
            }
            VisionTestInfo.TestTypeID = 1;
            VisionTestInfo.LocalDrivingLicenseApplicationID = LocaAppInfo.LocalDrivingLicenseApplicationID;
            VisionTestInfo.AppointmentDate = dateTimePicker1.Value;
            VisionTestInfo.PaidFees = TotalFees;
            VisionTestInfo.CreatedByUserID=clsGlobalUser.CurrentUser.UserID;
            if(VisionTestInfo.Save())
            {
               if(Mode==enMode.AddNew)
                {
                    MessageBox.Show("Add New Teste Successfully.");
                    lblRTestAppID.Text = VisionTestInfo.TestAppointmentID.ToString();
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
