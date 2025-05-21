using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class clsApplicationBusiness
    {

         enum enMode { AddNew, Update };
        public enum enStatus { New, Completed, Cancelled }

         enMode Mode = enMode.AddNew;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enStatus ApplicationStatus { get; set; }

        public DateTime LastApplicationDate { get; set; }

        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }




        public clsApplicationBusiness()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enStatus.New;
            this.LastApplicationDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;

        }

        private clsApplicationBusiness(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastApplicationDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus =(enStatus) ApplicationStatus;
            this.LastApplicationDate = LastApplicationDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;

        }




        private bool _AddNewApplication()
        {

            this.ApplicationID = clsAppliationDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, Convert.ToInt16(this.ApplicationStatus), this.LastApplicationDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID != -1);

        }


        private bool _UpdateApplicationInfo()
        {
            return clsAppliationDataAccess.UpdateApplicationInfo(this.ApplicationID,(byte)this.ApplicationStatus, this.LastApplicationDate, this.PaidFees, this.CreatedByUserID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplicationInfo();

            }

            return false;
        }

    
       
        public static clsApplicationBusiness GetApplicationInfoByID(int ApplicationID)
        {
            int ApplicantPersonID = -1,
                ApplicationTypeID = -1,
            CreatedByUserID = -1;
            byte ApplicationStatus=0;
            decimal PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now,
                LastApplicationDate = DateTime.Now;

            if (clsAppliationDataAccess.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastApplicationDate, ref PaidFees, ref CreatedByUserID))
                return new clsApplicationBusiness(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastApplicationDate, PaidFees, CreatedByUserID);
            else
            { 
                return null;
            }
        }




        public static bool CancelApplication(int ApplicationID)
        {
            return clsAppliationDataAccess.CancelApplication(ApplicationID);
        }


        public static bool IsApplicationActive(int ApplicantPersonID, int LicenseClassID)
        {
            return clsAppliationDataAccess.IsApplicationActive(ApplicantPersonID, LicenseClassID);
        }
       

      
    }
}
