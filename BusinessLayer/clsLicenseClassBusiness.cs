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



        public clsLicenseClassBusiness()

        {
            this.LicenseClassID = -1;
            this.ClassName = "";



        }
        private clsLicenseClassBusiness(int LicenseClassID, string ClassName)

        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;




        }

        public static clsLicenseClassBusiness Find(int LicenseClassID)
        {

            string ClassName = "";
            if (clsLicenseClassesDataAccess.GetLicenseClassInfoByID(LicenseClassID, ref ClassName))

                return new clsLicenseClassBusiness(LicenseClassID, ClassName);
            else
                return null;

        }

        public static clsLicenseClassBusiness Find(string ClassName)
        {

            int LicenseClassID = -1;


            if (clsLicenseClassesDataAccess.GetLicenseClassInfoByName(ClassName, ref LicenseClassID))

                return new clsLicenseClassBusiness(LicenseClassID, ClassName);
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
