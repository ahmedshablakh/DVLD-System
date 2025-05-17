using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace BusinessLayer
{
    public class clsUsersBusiness
    {


        public enum enMode { AddNew, eUpdate }
        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        public clsUsersBusiness()
        {

            this.UserID = -1;
            this.PersonID = -1;
            this.FullName = "";
            this.Username = "";
            this.Password = "";
            this.IsActive = false;

            Mode = enMode.AddNew;

        }

        private clsUsersBusiness(int UserID, int PersonID, string FullName, string Username, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.FullName = FullName;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.eUpdate;
        }




        private bool _AddNewUser()
        {
            this.UserID = clsUsersDataAccess.AddNewUser(this.PersonID, this.Username, this.Password, this.IsActive);
            return (this.UserID != -1);

        }

        private bool _UpdateUserInfo()
        {
            return clsUsersDataAccess.UpdateUserInfo(this.UserID, this.Username, this.Password, this.IsActive);
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.eUpdate:

                    return _UpdateUserInfo();

            }

            return false;
        }


        public static clsUsersBusiness GetUserInfoByID(int UserID)
        {
            int PersonID1 = -1;
            string FullName1 = "", Username1 = "", Password1 = "";
            bool IsActive1 = false;

            if (clsUsersDataAccess.GetUserInfoByID(UserID, ref PersonID1, ref FullName1, ref Username1, ref Password1, ref IsActive1))
                return new clsUsersBusiness(UserID, PersonID1, FullName1, Username1, Password1, IsActive1);
            else
                return null;
        }


        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }

        public static bool IsUsernameExist(string UserName)
        {

            return clsUsersDataAccess.IsUsernameExist(UserName);
        }
        public static bool DeleteUserByID(int UserID)
        {
            return clsUsersDataAccess.DaleteUserByID(UserID);
        }


        public static clsUsersBusiness GetUserInfoByUsernameAndPassword(string Username, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            string FullName = "";
            bool IsActive = false;
            if(clsUsersDataAccess.GetUserInfoByUsernameAndPassword(ref UserID,ref PersonID,ref FullName, Username, Password,ref IsActive))
            {
                return new clsUsersBusiness(UserID,PersonID,FullName,Username,Password,IsActive);
            }
            else
            { return null; }
        }


    }
}
