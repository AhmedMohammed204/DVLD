using System;
using System.Data;
using ApplicationMaster_ViewDataAccessLayer;
namespace ApplicationMaster_ViewBusinessLayer
{

    public class clsApplicationMaster
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public byte ApplicationStatus { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }
        public string UserName { get; set; }


        public clsApplicationMaster()
        {
            this.ApplicationID = default;
            this.ApplicantPersonID = default;
            this.ApplicationStatus = default;
            this.ApplicationTypeTitle = default;
            this.ApplicationFees = default;
            this.FullName = default;
            this.ApplicationDate = default;
            this.LastStatusDate = default;
            this.UserName = default;


            Mode = enMode.AddNew;

        }

        private clsApplicationMaster(int ApplicationID, int ApplicantPersonID, byte ApplicationStatus, string ApplicationTypeTitle, decimal ApplicationFees, string FullName, DateTime ApplicationDate, DateTime LastStatusDate, string UserName)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationStatus = ApplicationStatus;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            this.FullName = FullName;
            this.ApplicationDate = ApplicationDate;
            this.LastStatusDate = LastStatusDate;
            this.UserName = UserName;


            Mode = enMode.Update;

        }

        private bool _AddNewApplicationMaster()
        {
            //call DataAccess Layer 

            this.ApplicationID = clsApplicationMaster_ViewDataAccess.AddNewApplicationMaster(this.ApplicantPersonID, this.ApplicationStatus, this.ApplicationTypeTitle, this.ApplicationFees, this.FullName, this.ApplicationDate, this.LastStatusDate, this.UserName);

            return (this.ApplicationID != -1);

        }

        private bool _UpdateApplicationMaster()
        {
            //call DataAccess Layer 

            return clsApplicationMaster_ViewDataAccess.UpdateApplicationMaster(this.ApplicationID, this.ApplicantPersonID, this.ApplicationStatus, this.ApplicationTypeTitle, this.ApplicationFees, this.FullName, this.ApplicationDate, this.LastStatusDate, this.UserName);

        }

        public static clsApplicationMaster Find(int ApplicationID)
        {
            int ApplicantPersonID = default;
            byte ApplicationStatus = default;
            string ApplicationTypeTitle = default;
            decimal ApplicationFees = default;
            string FullName = default;
            DateTime ApplicationDate = default;
            DateTime LastStatusDate = default;
            string UserName = default;


            if (clsApplicationMaster_ViewDataAccess.GetApplicationMasterInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationStatus, ref ApplicationTypeTitle, ref ApplicationFees, ref FullName, ref ApplicationDate, ref LastStatusDate, ref UserName))
                return new clsApplicationMaster(ApplicationID, ApplicantPersonID, ApplicationStatus, ApplicationTypeTitle, ApplicationFees, FullName, ApplicationDate, LastStatusDate, UserName);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationMaster())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplicationMaster();

            }




            return false;
        }

        public static DataTable GetAllApplicationMaster_View() { return clsApplicationMaster_ViewDataAccess.GetAllApplicationMaster_View(); }

        public static bool DeleteApplicationMaster(int ApplicationID) { return clsApplicationMaster_ViewDataAccess.DeleteApplicationMaster(ApplicationID); }

        public static bool isApplicationMasterExist(int ApplicationID) { return clsApplicationMaster_ViewDataAccess.IsApplicationMasterExist(ApplicationID); }


    }

}