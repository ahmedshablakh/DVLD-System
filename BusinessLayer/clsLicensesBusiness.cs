using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicensesBusiness
    {
        public enum enMode { AddNew ,Update}
        public enMode Mode { get; set; }
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        


        public clsLicensesBusiness()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReason = 1;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;

        }
        private clsLicensesBusiness(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.Mode = enMode.Update;

        }

        private bool _IssueLicense()
        {
            this.LicenseID = clsLisenceDataAccess.IssueNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID != -1);
        }





        private bool _UpdateLicensInfo()
        {
            return clsLisenceDataAccess.UpdateLicensInfo(this.LicenseID, this.IsActive);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    _IssueLicense();
                    Mode= enMode.Update;
                    return true;
                case enMode.Update:
                _UpdateLicensInfo();
                    return true;
                default:
                    return false;

            }
        }

        public static clsLicensesBusiness GetLicenseInfoByApplicationID(int ApplicationID)
        {
            int LicensID = -1,
                  DriverID = -1,
                  LicenseClass = -1,
             CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now,
               ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 1;
            if (clsLisenceDataAccess.GetLicenseInfoByApplicationID(ref LicensID, ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
                return new clsLicensesBusiness(LicensID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;


        }

        public static clsLicensesBusiness GetLicenseInfoByLicenseID(int LicenseID)
        {
            int DriverID = -1,
                  LicenseClass = -1,
                  ApplicationID = -1,
             CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now,
               ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 1;
            if (clsLisenceDataAccess.GetLicenseInfoByLicenseID(LicenseID,ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
                return new clsLicensesBusiness(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;


        }

        public static DataTable GetAllLocalLicansesByPersonID(int PersonID)
        {
          return  clsLisenceDataAccess.GetAllLocalLicansesByPersonID(PersonID);
        }

       
    }
}
