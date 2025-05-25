using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class clsTestsBusiness
    {
       

        public int TestID { get; set; }
       public int TestAppointmentID { get; set; }
       public bool TestResult { get; set; }
       public string Notes { get; set; }
      public  int CreatedByUserID { get; set; }
        

       public clsTestsBusiness()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
        }
        private clsTestsBusiness(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestsDataAccess.AddNewTest(this.TestAppointmentID,this.TestResult,this.Notes,this.CreatedByUserID);
            return (this.TestID != -1);
        }


        public bool Save()
        {
            if (_AddNewTest())
                return true;
            else
                return false;
        }


       public static clsTestsBusiness GetTestByID(int TestID)
        {
            int TestAppointmentID = -1,
                 CreatedByUserID = -1;
            bool TestResult = false;
                string Notes = "";
             
            if(clsTestsDataAccess.GetTestAppointmentInfoByID(TestID,ref  TestAppointmentID,ref TestResult,ref Notes,ref CreatedByUserID))
            {
                return new clsTestsBusiness(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
                return null;
        }
    }
}
