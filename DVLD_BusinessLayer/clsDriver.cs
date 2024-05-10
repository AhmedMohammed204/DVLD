using DriversDataAccessLayer;
using System;
using System.Data;
namespace DriversBusinessLayer
{

    public class clsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }


        public clsDriver()
        {
            this.DriverID = default;
            this.PersonID = default;
            this.CreatedByUserID = default;
            this.CreatedDate = default;


            Mode = enMode.AddNew;

        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;


            Mode = enMode.Update;

        }

        private bool _AddNewDriver()
        {
            //call DataAccess Layer 

            this.DriverID = clsDriversDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return (this.DriverID != -1);

        }

        private bool _UpdateDriver()
        {
            //call DataAccess Layer 

            return clsDriversDataAccess.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);

        }

        public static clsDriver Find(int DriverID)
        {
            int PersonID = default;
            int CreatedByUserID = default;
            DateTime CreatedDate = default;


            if (clsDriversDataAccess.GetDriverInfoByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }
        
        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = default;
            int CreatedByUserID = default;
            DateTime CreatedDate = default;


            if (clsDriversDataAccess.GetDriverInfoByPersonID(ref DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDriver();

            }




            return false;
        }

        public static DataTable GetAllDrivers() { return clsDriversDataAccess.GetAllDrivers(); }
        public static DataTable GetAllDriversView() { return clsDriversDataAccess.GetAllDriversView(); }

        public static bool DeleteDriver(int DriverID) { return clsDriversDataAccess.DeleteDriver(DriverID); }

        public static bool isDriverExist(int DriverID) { return clsDriversDataAccess.IsDriverExist(DriverID); }


    }

}