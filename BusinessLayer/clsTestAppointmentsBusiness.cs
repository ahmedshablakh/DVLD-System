using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestAppointmentsBusiness
    {
        public enum enMode { AddNew, Update }
        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }


        public clsTestAppointmentsBusiness()
        {
            this.TestAppointmentID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.TestTypeID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.Mode = enMode.AddNew;
        }
        private clsTestAppointmentsBusiness(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.TestTypeID = TestTypeID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.Mode = enMode.Update;
        }





        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentsDataAccess.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
            return (this.TestAppointmentID != -1);
        }


        private bool _UpdateTestAppointmentInfoint()
        {
            return clsTestAppointmentsDataAccess.UpdateTestAppointmentInfoint(this.TestAppointmentID, this.AppointmentDate, this.PaidFees,this.IsLocked);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointmentInfoint();

            }

            return false;
        }

        public static DataTable GetAllTestAppointmentsByLocalAppID(int LocalAppID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetAllTestAppointmentsByLocalAppID(LocalAppID, TestTypeID);
        }



        public static clsTestAppointmentsBusiness GetTestAppointmentInfoByID(int AppointmentID)
        {
            int TestTypeID = -1,
               LocalDrivingLicenseApplicationID = -1,
               CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsLocked = false;


            if (clsTestAppointmentsDataAccess.GetTestAppointmentInfoByID(AppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
                return new clsTestAppointmentsBusiness(AppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;
        }

        public static int GetCountTestAppointmentByLcalAppIDAndTestTypeID(int LcalAppID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetCountTestAppointmentByLcalAppIDAndTestTypeID(LcalAppID, TestTypeID);
        }
         public static bool CheckTestIsActive(int LocalAppID,int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.CheckTestIsActive(LocalAppID, TestTypeID);
        }
    }
}
