using System;
using System.Data;
using LocalDrivingLicenseApplications_ViewDataAccessLayer;
namespace LocalDrivingLicenseApplications_ViewBusinessLayer
{

    public class clsLocalDrivingLicenseApplicationView
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string ClassName { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int PassedTestCount { get; set; }
        public string Status { get; set; }


        public clsLocalDrivingLicenseApplicationView()
        {
            this.LocalDrivingLicenseApplicationID = default;
            this.ClassName = default;
            this.NationalNo = default;
            this.FullName = default;
            this.ApplicationDate = default;
            this.PassedTestCount = default;
            this.Status = default;


            Mode = enMode.AddNew;

        }

        private clsLocalDrivingLicenseApplicationView(int LocalDrivingLicenseApplicationID, string ClassName, string NationalNo, string FullName, DateTime ApplicationDate, int PassedTestCount, string Status)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ClassName = ClassName;
            this.NationalNo = NationalNo;
            this.FullName = FullName;
            this.ApplicationDate = ApplicationDate;
            this.PassedTestCount = PassedTestCount;
            this.Status = Status;


            Mode = enMode.Update;

        }

        private bool _AddNewLocalDrivingLicenseApplicationView()
        {
            //call DataAccess Layer 

            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplications_ViewDataAccess.AddNewLocalDrivingLicenseApplicationView(this.ClassName, this.NationalNo, this.FullName, this.ApplicationDate, this.PassedTestCount, this.Status);

            return (this.LocalDrivingLicenseApplicationID != -1);

        }

        private bool _UpdateLocalDrivingLicenseApplicationView()
        {
            //call DataAccess Layer 

            return clsLocalDrivingLicenseApplications_ViewDataAccess.UpdateLocalDrivingLicenseApplicationView(this.LocalDrivingLicenseApplicationID, this.ClassName, this.NationalNo, this.FullName, this.ApplicationDate, this.PassedTestCount, this.Status);

        }

        public static clsLocalDrivingLicenseApplicationView Find(int LocalDrivingLicenseApplicationID)
        {
            string ClassName = default;
            string NationalNo = default;
            string FullName = default;
            DateTime ApplicationDate = default;
            int PassedTestCount = default;
            string Status = default;


            if (clsLocalDrivingLicenseApplications_ViewDataAccess.GetLocalDrivingLicenseApplicationViewInfoByID(LocalDrivingLicenseApplicationID, ref ClassName, ref NationalNo, ref FullName, ref ApplicationDate, ref PassedTestCount, ref Status))
                return new clsLocalDrivingLicenseApplicationView(LocalDrivingLicenseApplicationID, ClassName, NationalNo, FullName, ApplicationDate, PassedTestCount, Status);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplicationView())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDrivingLicenseApplicationView();

            }




            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications_View() { return clsLocalDrivingLicenseApplications_ViewDataAccess.GetAllLocalDrivingLicenseApplications_View(); }

        public static bool DeleteLocalDrivingLicenseApplicationView(int LocalDrivingLicenseApplicationID) { return clsLocalDrivingLicenseApplications_ViewDataAccess.DeleteLocalDrivingLicenseApplicationView(LocalDrivingLicenseApplicationID); }

        public static bool isLocalDrivingLicenseApplicationViewExist(int LocalDrivingLicenseApplicationID) { return clsLocalDrivingLicenseApplications_ViewDataAccess.IsLocalDrivingLicenseApplicationViewExist(LocalDrivingLicenseApplicationID); }


    }

}