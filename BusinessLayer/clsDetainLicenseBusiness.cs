using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class clsDetainLicenseBusiness
    {
        enum enMode { Detain,Release}
        enMode Mode;
        public int DetainID { get; set; }

        public int LicenseID { get; set; }

        public DateTime DetainDate { get; set; }

        public decimal FineFees { get; set; }

        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }


        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
         public int ReleaseApplicationID { get; set; }

        public clsDetainLicenseBusiness()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.Mode = enMode.Detain;
        }

        private clsDetainLicenseBusiness(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.Mode = enMode.Release;

        }

        private bool _DetainLicense()
        {
            this.DetainID = clsDetainLicenseDataAccess.DetainLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased);
            return (this.DetainID != -1);
        }

        public bool Save()
        {
            if (Mode == enMode.Detain)
            {
                _DetainLicense();
                Mode = enMode.Release;
                return true;
            }
            else
                return _ReleaseDetainedLicense();
        }

        public static bool IsDetainLicense(int LicenseID)
        {
            return clsDetainLicenseDataAccess.IsDetainLicense(LicenseID);
        }

        private bool _ReleaseDetainedLicense()
        {
           return clsDetainLicenseDataAccess.ReleaseDetainedLicense(this.DetainID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        public static clsDetainLicenseBusiness GetDetainInfoByLicenseID(int LicenseID)

        {

                int CreatedByUserID = -1,
                DetainID = -1;
            decimal FineFees = 0; 

            bool IsReleased = false;
            DateTime DetainDate = DateTime.Now;

            if (clsDetainLicenseDataAccess.GetDetainInfoByLicenseID(ref DetainID, LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased))
                return new clsDetainLicenseBusiness(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased);
            else
                return null;

        }


    }
}
