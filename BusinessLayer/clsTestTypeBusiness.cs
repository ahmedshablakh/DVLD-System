using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTestTypeBusiness
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }


        public clsTestTypeBusiness()
        {
            this.Id = -1;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
        }
        private clsTestTypeBusiness(int ID, string Title,string Description, float Fees)
        {
            this.Id = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }


        public static clsTestTypeBusiness GetTestTypeByID(int ID)
        {
            string Title = "",
                Description ="";
            float Fees = 0;

            if (clsTestTypesDataAccess.GetTestTypeByID(ID, ref Title,ref Description, ref Fees))
            {
                return new clsTestTypeBusiness(ID, Title,Description, Fees);
            }
            else
                return null;
        }


        private bool UpdateTsatType()
        {
            return clsTestTypesDataAccess.UpdateTestType(this.Id, this.Title,this.Description, this.Fees);
        }
        public bool Save()
        {
            if (UpdateTsatType())
            {
                return true;
            }
            return false;
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }


    }
}
