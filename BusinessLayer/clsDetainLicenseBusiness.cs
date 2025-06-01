using DataAccessLayer;
using System;
using System.Collections.Generic;
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
                return false;
        }

        public static bool IsDetainLicense(int LicenseID)
        {
            return clsDetainLicenseDataAccess.IsDetainLicense(LicenseID);
        }

    }
}
