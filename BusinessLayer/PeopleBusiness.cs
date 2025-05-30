﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class PeopleBusiness
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool Gender { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        public int CountryID { get; set; }

        public string ImagePath { get; set; }


        public PeopleBusiness()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = new DateTime(1999, 1, 1);
            this.Gender = true;
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.CountryID = -1;
            this.ImagePath = "";
            Mode = enMode.AddNew;

        }

        private PeopleBusiness(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, bool Gender, string Address, string Phone, string Email, int CountryID, string ImagePath)

        {

            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;

        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone,
            this.Email, this.CountryID, this.ImagePath);
            return (this.PersonID != 1);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }

        public static bool ChechNationalNoIsExis(string NationalNO)
        {
            return clsPeopleDataAccess.NationalNoIsExis(NationalNO);
        }

        static public DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }


        public static bool DeletePerson(int ID)
        {
            return (clsPeopleDataAccess.DeletePerson(ID));
        }
        public static PeopleBusiness GetPersonInfoByID(int PersonID)
        {

            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "",
               Address = "", Phone = "", Email = "", ImagePath = "";

            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;
            bool Gendor = true;



            if (clsPeopleDataAccess.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName,
                          ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref CountryID, ref ImagePath))

                return new PeopleBusiness(PersonID, NationalNo, FirstName, SecondName,
                           ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryID, ImagePath);
            else
                return null;
        }


        public static PeopleBusiness GetPersonInfoByNationalNo(string NationalNo)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
               Address = "", Phone = "", Email = "", ImagePath = "";

            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1,
                PersonID = -1;
            bool Gendor = true;



            if (clsPeopleDataAccess.GetPersonInfoByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName,
                          ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref CountryID, ref ImagePath))

                return new PeopleBusiness(PersonID, NationalNo, FirstName, SecondName,
                           ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryID, ImagePath);
            else
                return null;
        }



        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPeopleDataAccess.UpdatePersonInfo(this.PersonID, this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,
                this.CountryID, this.ImagePath);

        }

        public static string GetPersonFullNameByID(int PersonID)
        {
            return clsPeopleDataAccess.GetPersonFullNameByID(PersonID);
        }
    }
}
