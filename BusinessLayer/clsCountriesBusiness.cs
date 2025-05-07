using DataAccessLayer;
using System.Data;
using static BusinessLayer.PeopleBusiness;

namespace BusinessLayer
{
    public class clsCountriesBusiness
    {

        public int ID { set; get; }
        public string CountryName { set; get; }
        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries(); // استدعاء الدالة من DAL
        }


        public clsCountriesBusiness()

        {
            this.ID = -1;
            this.CountryName = "";



        }
        private clsCountriesBusiness(int ID, string CountryName)

        {
            this.ID = ID;
            this.CountryName = CountryName;
            



        }

        public static clsCountriesBusiness Find(int ID)
        {

            string CountryName = "";


            int CountryID = -1;

            if (clsCountriesDataAccess.GetCountryInfoByID(ID, ref CountryName))

                return new clsCountriesBusiness(ID, CountryName);
            else
                return null;

        }

        public static clsCountriesBusiness Find(string CountryName)
        {

            int ID = -1;


            if (clsCountriesDataAccess.GetCountryInfoByName(CountryName, ref ID))

                return new clsCountriesBusiness(ID, CountryName);
            else
                return null;

        }

    }
}