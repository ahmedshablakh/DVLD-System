using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class clsLicenseClassBusiness
    {

        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal ClassFees { set; get; }

        public clsLicenseClassBusiness()

        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
            this.MinimumAllowedAge = 0;




        }
        private clsLicenseClassBusiness(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)

        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.DefaultValidityLength = DefaultValidityLength;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.ClassFees = ClassFees;
        }

        public static clsLicenseClassBusiness Find(int LicenseClassID)
        {

            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 1,
                DefaultValidityLength =1;
            decimal ClassFees = 0;
            if (clsLicenseClassesDataAccess.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription,ref MinimumAllowedAge,ref DefaultValidityLength,ref ClassFees))

                return new clsLicenseClassBusiness(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }

        public static clsLicenseClassBusiness Find(string ClassName)
        {

            int LicenseClassID = -1;
            string ClassDescription = "";
            byte MinimumAllowedAge = 0,
                DefaultValidityLength = 0;
            decimal ClassFees = 0;
            if (clsLicenseClassesDataAccess.GetLicenseClassInfoByName(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClassBusiness(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }


        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesDataAccess.GetAllLicenseClasses();
        }


        public static int GetApplicationClassInfoByID(int ApplicationID)
        {
            int LicenseClassID = -1;
            if (clsLicenseClassesDataAccess.GetApplicationInfoByID(ApplicationID, ref LicenseClassID))
               
            {
                return LicenseClassID;
            }
            else
                return -1;
        }
    }
}
