using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplicationsBusiness
    {

        public  enum enMode { AddNew, Update };
        enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplicationsBusiness()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
             this.Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplicationsBusiness(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {

            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.Mode = enMode.Update;
        }


        public static clsLocalDrivingLicenseApplicationsBusiness GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID)
        {

            int ApplicationID = -1,
                LicenseClassID = -1;
            if (clsLocalDrivingLicenseApplicationsDataAccess.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
                return new clsLocalDrivingLicenseApplicationsBusiness(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            else
                return null;
        }


        private bool _AddNewLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsDataAccess.AddNewLocalDrivingLicenseApplications(this.ApplicationID,this.LicenseClassID);
            return (this.LocalDrivingLicenseApplicationID != -1);
        }




     
        
        private bool _UpdateLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.UpdateLocalDrivingLicenseApplicationInfo(this.LocalDrivingLicenseApplicationID,this.LicenseClassID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if ((_AddNewLocalDrivingLicenseApplications()))
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDrivingLicenseApplications();

            }

            return false;
        }

        public static int GetTotalPassedTestByID(int LocalDrivingLicensApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetTotalPassedTestByID(LocalDrivingLicensApplicationID);
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplications();
        }
        public static bool DeleteLocalDrivingLicenseApplicationByID(int LocalAppID)
        {
           return clsLocalDrivingLicenseApplicationsDataAccess.DeleteLocalDrivingLicenseApplicationByID(LocalAppID); 

        }

        public static DataTable GetAllDrivers()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAllDrivers();
        }
    }
}
