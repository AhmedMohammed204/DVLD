using System;
using System.Data;
using CountriesDataAccessLayer;
namespace CountriesBusinessLayer
{

    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int CountryID { get; set; }
        public string CountryName { get; set; }


        public clsCountry()
        {
            this.CountryID = default;
            this.CountryName = default;


            Mode = enMode.AddNew;

        }

        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;


            Mode = enMode.Update;

        }

        private bool _AddNewCountry()
        {
            //call DataAccess Layer 

            this.CountryID = clsCountriesDataAccess.AddNewCountry(this.CountryName);

            return (this.CountryID != -1);

        }

        private bool _UpdateCountry()
        {
            //call DataAccess Layer 

            return clsCountriesDataAccess.UpdateCountry(this.CountryID, this.CountryName);

        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = default;


            if (clsCountriesDataAccess.GetCountryInfoByID(CountryID, ref CountryName))
                return new clsCountry(CountryID, CountryName);
            else
                return null;

        }
        
        public static clsCountry Find(string CountryName)
        {
            int CountryID = default;


            if (clsCountriesDataAccess.GetCountryInfoByName(ref CountryID, ref CountryName))
                return new clsCountry(CountryID, CountryName);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCountry();

            }




            return false;
        }

        public static DataTable GetAllCountries() { return clsCountriesDataAccess.GetAllCountries(); }

        public static bool DeleteCountry(int CountryID) { return clsCountriesDataAccess.DeleteCountry(CountryID); }

        public static bool isCountryExist(int CountryID) { return clsCountriesDataAccess.IsCountryExist(CountryID); }
        
        public static bool isCountryExist(string CountryName) { return clsCountriesDataAccess.IsCountryExist(CountryName); }


    }

}