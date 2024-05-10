using InternationalLicensesDataAccessLayer;
using System;
using System.Data;
namespace InternationalLicensesBusinessLayer
{

    public class clsInternationalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }


        public clsInternationalLicense()
        {
            this.InternationalLicenseID = default;
            this.ApplicationID = default;
            this.DriverID = default;
            this.IssuedUsingLocalLicenseID = default;
            this.IssueDate = default;
            this.ExpirationDate = default;
            this.IsActive = default;
            this.CreatedByUserID = default;


            Mode = enMode.AddNew;

        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;


            Mode = enMode.Update;

        }

        private bool _AddNewInternationalLicense()
        {
            //call DataAccess Layer 

            this.InternationalLicenseID = clsInternationalLicensesDataAccess.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);

        }

        private bool _UpdateInternationalLicense()
        {
            //call DataAccess Layer 

            return clsInternationalLicensesDataAccess.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = default;
            int DriverID = default;
            int IssuedUsingLocalLicenseID = default;
            DateTime IssueDate = default;
            DateTime ExpirationDate = default;
            bool IsActive = default;
            int CreatedByUserID = default;


            if (clsInternationalLicensesDataAccess.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;

        }
        
        public static clsInternationalLicense FindByDriverID(int DriverID)
        {
            int ApplicationID = default;
            int InternationalLicenseID = default;
            int IssuedUsingLocalLicenseID = default;
            DateTime IssueDate = default;
            DateTime ExpirationDate = default;
            bool IsActive = default;
            int CreatedByUserID = default;


            if (clsInternationalLicensesDataAccess.GetInternationalLicenseInfoByDriverID(ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateInternationalLicense();

            }




            return false;
        }

        public static DataTable GetAllInternationalLicenses() { return clsInternationalLicensesDataAccess.GetAllInternationalLicenses(); }

        public static bool DeleteInternationalLicense(int InternationalLicenseID) { return clsInternationalLicensesDataAccess.DeleteInternationalLicense(InternationalLicenseID); }

        public static bool isInternationalLicenseExist(int InternationalLicenseID) { return clsInternationalLicensesDataAccess.IsInternationalLicenseExist(InternationalLicenseID); }
        public static bool isInternationalLicenseExistByDriverID(int DriverID) { return clsInternationalLicensesDataAccess.IsInternationalLicenseExistByDriverID(DriverID); }


    }

}