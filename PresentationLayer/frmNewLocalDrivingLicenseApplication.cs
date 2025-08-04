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
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        public int _PersonID = -1;
        public int _LicenseClassID = -1;
        public int _LocalDrivingLicenseApplicationID = -1; 
       
        clsApplication ApplicationInfo;
        clsLocalDrivingLicenseApplication LocalAppInfo;
        enum enMode {AddNew,Update }
        enMode Mode;
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
           Mode = enMode.AddNew ;
        }
        public frmNewLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
           LocalAppInfo = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID);
           ApplicationInfo = clsApplication.GetApplicationInfoByID(LocalAppInfo.ApplicationID);
            _PersonID = ApplicationInfo.ApplicantPersonID;

        }
        private void FillLicenseClasses()
        {
            DataTable dt = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr[1]);
            }
            comboBox1.SelectedIndex = 2;
        }

        private void grClose_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            if(_LocalDrivingLicenseApplicationID!=-1)
            {
                Mode = enMode.Update;
                LoadData();
                panel1.Controls.Clear();
                ucFindPerson uc = new ucFindPerson(ApplicationInfo.ApplicantPersonID);
                uc.Dock = DockStyle.Fill;
                panel1.Controls.Add(uc);
                _PersonID = uc._PersonID;
                 FillLicenseClasses();
                LoadData();

            }
            else
            {
               
                btnSave.Enabled = false;
                LoadData();
            }
          
            

        }

        private void pictureBox3_MouseCaptureChanged(object sender, EventArgs e)
        {
            
            if (ucFindPerson1._PersonID==-1 && Mode == enMode.AddNew)
            {
                MessageBox.Show("Errorr");
                return;
                
            }

            if (Mode == enMode.AddNew)
                _PersonID = ucFindPerson1._PersonID;
            tabControl.SelectTab(tabAppInfo);
            btnSave.Enabled = true;
            
            


        }

        private void LoadData()
        {
            FillLicenseClasses();
            if (Mode== enMode.AddNew)
            {
                AddNewApplication();
                return;
            }
            if (ApplicationInfo != null)
            {
                comboBox1.SelectedIndex= LocalAppInfo.LicenseClassID-1;
                lblDLAppID.Text = LocalAppInfo.LocalDrivingLicenseApplicationID.ToString();
                lblTitleFrm.Text = "Update Local Driving License Applications";
                lblApplicationFees.Text = ApplicationInfo.PaidFees.ToString();
                lblAppDate.Text = ApplicationInfo.ApplicationDate.ToString();
                lblCreateBy.Text = clsGlobal.CurrentUser.Username;
                
            }
            
        }
        private void  AddNewApplication()
        {

            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID(1).Fees.ToString();
            lblAppDate.Text = DateTime.Now.ToString();
            lblCreateBy.Text = clsGlobal.CurrentUser.Username;

            ApplicationInfo = new clsApplication();
            ApplicationInfo.ApplicationDate = DateTime.Now;
            ApplicationInfo.ApplicationTypeID = 1;
            ApplicationInfo.ApplicationStatus =1;
            ApplicationInfo.LastApplicationDate = DateTime.Now;
            ApplicationInfo.PaidFees = clsApplicationType.GetApplicationTypeByID(1).Fees;
            ApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
        }

        private bool _ValidationData()
        {
            bool isValid = true;
            clsLicenseClass LicenseClassInfo = clsLicenseClass.Find(comboBox1.SelectedItem.ToString());
            clsPerson PersonInfo = clsPerson.GetPersonInfoByID(_PersonID);

            int age = DateTime.Now.Year - PersonInfo.DateOfBirth.Year;

            
            if (DateTime.Now < PersonInfo.DateOfBirth.AddYears(age))
            {
                age--;
            }
            if(age < LicenseClassInfo.MinimumAllowedAge)
            {
                MessageBox.Show("Your age does not allow you to apply for this license. You must not be less than " + LicenseClassInfo.MinimumAllowedAge + " years old.", "Error");
              
                return false;
            }

            _LicenseClassID = LicenseClassInfo.LicenseClassID;
            if (clsApplication.IsApplicationActive(_PersonID, LicenseClassInfo.LicenseClassID))
            {
                MessageBox.Show("You have an active application of the same Class..", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                isValid = false;
            }



            return isValid;
        }


        private void label9_MouseCaptureChanged(object sender, EventArgs e)
        {
            if(!_ValidationData())
                return;

            
            ApplicationInfo.ApplicantPersonID= _PersonID;
            ApplicationInfo.LastApplicationDate= DateTime.Now;
            if (ApplicationInfo.Save())
            {
                if(Mode ==enMode.AddNew)
                {
                    LocalAppInfo = new clsLocalDrivingLicenseApplication();
                    LocalAppInfo.ApplicationID = ApplicationInfo.ApplicationID;
                    
                }
                LocalAppInfo.LicenseClassID = _LicenseClassID;
                if (LocalAppInfo.Save())
                {
                    if(Mode==enMode.AddNew)
                    {
                        MessageBox.Show("Successfully..");
                        Mode = enMode.Update;
                        lblDLAppID.Text = LocalAppInfo.LocalDrivingLicenseApplicationID.ToString();
                    }
                    
                    else if(Mode==enMode.Update )
                    {
                        MessageBox.Show("Updated Successfully..");
                    }
                    LoadData();
                }

            }
            else
            {
                MessageBox.Show("Falid..");
            }


        }
    }
}
