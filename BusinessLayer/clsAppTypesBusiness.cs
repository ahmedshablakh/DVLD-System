using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ContactsDataAccessLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsAppTypesBusiness
    {


       
        public int Id { get; set; }
        public string Title { get; set; }
        public float Fees { get; set; }


        public clsAppTypesBusiness()
        {
            this.Id = -1;
            this.Title = "";
            this.Fees = 0;
        }
        private clsAppTypesBusiness(int ID,string Title,float Fees)
        {
            this.Id = ID;
            this.Title = Title;
            this.Fees = Fees;
        }


        public static clsAppTypesBusiness GetApplicationTypeByID(int ID)
        {
            string Title = "";
            float Fees = 0;

            if (clsAppTypeDataAccess.GetApplicationTypeByID(ID, ref Title, ref Fees))
            {
                return new clsAppTypesBusiness(ID, Title, Fees);
            }
            else
                return null;
        }


        private bool UpdateAppType()
        {
            return clsAppTypeDataAccess.UpdateAppType(this.Id, this.Title, this.Fees);
        }
        public bool Save()
        {
            if(UpdateAppType())
            {
                return true;
            }
            return false;
        }
        public static DataTable GetAllAppType()
        {
            return clsAppTypeDataAccess.GetAllAppType();
        }
    }
}
