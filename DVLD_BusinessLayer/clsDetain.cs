using DetainedLicensesDataAccessLayer;
using System;
using System.Data;
namespace DetainedLicensesBusinessLayer
{

    public class clsDetain
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }


        public clsDetain()
        {
            this.DetainID = default;
            this.LicenseID = default;
            this.DetainDate = default;
            this.FineFees = default;
            this.CreatedByUserID = default;
            this.IsReleased = default;
            


            Mode = enMode.AddNew;

        }

        private clsDetain(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;


            Mode = enMode.Update;

        }

        private bool _AddNewDetain()
        {
            //call DataAccess Layer 

            this.DetainID = clsDetainedLicensesDataAccess.AddNewDetain(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);

            return (this.DetainID != -1);

        }

        private bool _UpdateDetain()
        {
            //call DataAccess Layer 

            return clsDetainedLicensesDataAccess.UpdateDetain(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);

        }

        public static clsDetain Find(int DetainID)
        {
            int LicenseID = default;
            DateTime DetainDate = default;
            decimal FineFees = default;
            int CreatedByUserID = default;
            bool IsReleased = default;
            DateTime ReleaseDate = default;
            int ReleasedByUserID = default;
            int ReleaseApplicationID = default;


            if (clsDetainedLicensesDataAccess.GetDetainInfoByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetain(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }
        
        public static clsDetain FindByLicense(int LicenseID)
        {
            int DetainID = default;
            DateTime DetainDate = default;
            decimal FineFees = default;
            int CreatedByUserID = default;
            bool IsReleased = default;
            DateTime ReleaseDate = default;
            int ReleasedByUserID = default;
            int ReleaseApplicationID = default;


            if (clsDetainedLicensesDataAccess.GetDetainInfoByLicenseID(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetain(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetain())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetain();

            }




            return false;
        }

        public static DataTable GetAllDetainedLicenses() { return clsDetainedLicensesDataAccess.GetAllDetainedLicenses(); }

        public static bool DeleteDetain(int DetainID) { return clsDetainedLicensesDataAccess.DeleteDetain(DetainID); }

        public static bool isDetainExist(int DetainID) { return clsDetainedLicensesDataAccess.IsDetainExist(DetainID); }
        
        public static bool isDetainExistByLicenseID(int LicenseID) { return clsDetainedLicensesDataAccess.IsDetainExistByLicenseID(LicenseID); }


    }

}