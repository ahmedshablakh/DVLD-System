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
       
        clsApplicationBusiness ApplicationInfo;
        clsLocalDrivingLicenseApplicationsBusiness LocalAppInfo;
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
           LocalAppInfo = clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID);
           ApplicationInfo = clsApplicationBusiness.GetApplicationInfoByID(LocalAppInfo.ApplicationID);
            _PersonID = ApplicationInfo.ApplicantPersonID;

        }
        private void FillLicenseClasses()
        {
            DataTable dt = clsLicenseClassBusiness.GetAllLicenseClasses();

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

            }
            btnSave.Enabled = false;
            FillLicenseClasses();
            LoadData();

        }

        private void pictureBox3_MouseCaptureChanged(object sender, EventArgs e)
        {
            if(ucFindPerson1._PersonID!= -1 || Mode ==enMode.Update )
            {
                tabControl.SelectTab(tabAppInfo);
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Errorr");
            }
            _PersonID = ucFindPerson1._PersonID;

        }

        private void LoadData()
        {
            if(Mode== enMode.AddNew)
            {
                AddNewApplication();
                return;
            }
            if (ApplicationInfo != null)
            {
               // comboBox1.SelectedIndex= LocalAppInfo.LicenseClassID;
                lblDLAppID.Text = LocalAppInfo.LocalDrivingLicenseApplicationID.ToString();
                lblTitleFrm.Text = "Update Local Driving License Applications";
                lblApplicationFees.Text = ApplicationInfo.PaidFees.ToString();
                lblAppDate.Text = ApplicationInfo.ApplicationDate.ToString();
                lblCreateBy.Text = clsGlobalUser.CurrentUser.Username;
                
            }
            
        }
        private void  AddNewApplication()
        {

            lblApplicationFees.Text = clsAppTypesBusiness.GetApplicationTypeByID(1).Fees.ToString();
            lblAppDate.Text = DateTime.Now.ToString();
            lblCreateBy.Text = clsGlobalUser.CurrentUser.Username;

            ApplicationInfo = new clsApplicationBusiness();
            ApplicationInfo.ApplicationDate = DateTime.Now;
            ApplicationInfo.ApplicationTypeID = 1;
            ApplicationInfo.ApplicationStatus = clsApplicationBusiness.enStatus.Completed;
            ApplicationInfo.LastApplicationDate = DateTime.Now;
            ApplicationInfo.PaidFees = clsAppTypesBusiness.GetApplicationTypeByID(1).Fees;
            ApplicationInfo.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
        }

        private bool _ValidationData()
        {
            bool isValid = true;
            _LicenseClassID= clsLicenseClassBusiness.Find(comboBox1.SelectedItem.ToString()).LicenseClassID;
            if (clsApplicationBusiness.IsApplicationActive(ApplicationInfo.ApplicantPersonID, _LicenseClassID))
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
                    LocalAppInfo = new clsLocalDrivingLicenseApplicationsBusiness();
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
