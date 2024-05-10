using System;
using System.Data;
using TestAppointments_ViewDataAccessLayer;
namespace TestAppointments_ViewBusinessLayer
{

    public class clsTestAppointments_View
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string TestTypeTitle { get; set; }
        public string ClassName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public string FullName { get; set; }
        public bool IsLocked { get; set; }


        public clsTestAppointments_View()
        {
            this.TestAppointmentID = default;
            this.LocalDrivingLicenseApplicationID = default;
            this.TestTypeTitle = default;
            this.ClassName = default;
            this.AppointmentDate = default;
            this.PaidFees = default;
            this.FullName = default;
            this.IsLocked = default;


            Mode = enMode.AddNew;

        }

        private clsTestAppointments_View(int TestAppointmentID, int LocalDrivingLicenseApplicationID, string TestTypeTitle, string ClassName, DateTime AppointmentDate, decimal PaidFees, string FullName, bool IsLocked)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.TestTypeTitle = TestTypeTitle;
            this.ClassName = ClassName;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.FullName = FullName;
            this.IsLocked = IsLocked;


            Mode = enMode.Update;

        }

        private bool _AddNewTestAppointments_View()
        {
            //call DataAccess Layer 

            this.TestAppointmentID = clsTestAppointments_ViewDataAccess.AddNewTestAppointments_View(this.LocalDrivingLicenseApplicationID, this.TestTypeTitle, this.ClassName, this.AppointmentDate, this.PaidFees, this.FullName, this.IsLocked);

            return (this.TestAppointmentID != -1);

        }

        private bool _UpdateTestAppointments_View()
        {
            //call DataAccess Layer 

            return clsTestAppointments_ViewDataAccess.UpdateTestAppointments_View(this.TestAppointmentID, this.LocalDrivingLicenseApplicationID, this.TestTypeTitle, this.ClassName, this.AppointmentDate, this.PaidFees, this.FullName, this.IsLocked);

        }

        public static clsTestAppointments_View Find(int TestAppointmentID)
        {
            int LocalDrivingLicenseApplicationID = default;
            string TestTypeTitle = default;
            string ClassName = default;
            DateTime AppointmentDate = default;
            decimal PaidFees = default;
            string FullName = default;
            bool IsLocked = default;
            


            if (clsTestAppointments_ViewDataAccess.GetTestAppointments_ViewInfoByID(TestAppointmentID, ref LocalDrivingLicenseApplicationID, ref TestTypeTitle, ref ClassName, ref AppointmentDate, ref PaidFees, ref FullName, ref IsLocked))
                return new clsTestAppointments_View(TestAppointmentID, LocalDrivingLicenseApplicationID, TestTypeTitle, ClassName, AppointmentDate, PaidFees, FullName, IsLocked);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointments_View())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointments_View();

            }




            return false;
        }

        public static DataTable GetAllTestAppointments_View() { return clsTestAppointments_ViewDataAccess.GetAllTestAppointments_View(); }

        public static bool DeleteTestAppointments_View(int TestAppointmentID) { return clsTestAppointments_ViewDataAccess.DeleteTestAppointments_View(TestAppointmentID); }

        public static bool isTestAppointments_ViewExist(int TestAppointmentID) { return clsTestAppointments_ViewDataAccess.IsTestAppointments_ViewExist(TestAppointmentID); }


    }

}