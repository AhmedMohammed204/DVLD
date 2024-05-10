using System;
using System.Data;
using LocalDrivingLicenseApplicationsDataAccessLayer;
namespace LocalDrivingLicenseApplicationsBusinessLayer
{

    public class clsLocalDrivingLicenseApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = default;
            this.ApplicationID = default;
            this.LicenseClassID = default;


            Mode = enMode.AddNew;

        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;


            Mode = enMode.Update;

        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            //call DataAccess Layer 

            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsDataAccess.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);

        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            //call DataAccess Layer 

            return clsLocalDrivingLicenseApplicationsDataAccess.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);

        }

        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = default;
            int LicenseClassID = default;


            if (clsLocalDrivingLicenseApplicationsDataAccess.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDrivingLicenseApplication();

            }




            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications() { return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplications(); }
        
        public static DataTable GetAllLocalDrivingLicenseApplicationsMaster() { return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplicationsMaster(); }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID) { return clsLocalDrivingLicenseApplicationsDataAccess.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID); }

        public static bool isLocalDrivingLicenseApplicationExist(int LocalDrivingLicenseApplicationID) { return clsLocalDrivingLicenseApplicationsDataAccess.IsLocalDrivingLicenseApplicationExist(LocalDrivingLicenseApplicationID); }


    }

}