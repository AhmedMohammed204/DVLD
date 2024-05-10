using System;
using System.Data;
using TestAppointmentsDataAccessLayer;
namespace TestAppointmentsBusinessLayer
{

    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }


        public clsTestAppointment()
        {
            this.TestAppointmentID = default;
            this.TestTypeID = default;
            this.LocalDrivingLicenseApplicationID = default;
            this.AppointmentDate = default;
            this.PaidFees = default;
            this.CreatedByUserID = default;
            this.IsLocked = default;


            Mode = enMode.AddNew;

        }

        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;


            Mode = enMode.Update;

        }

        private bool _AddNewTestAppointment()
        {
            //call DataAccess Layer 

            this.TestAppointmentID = clsTestAppointmentsDataAccess.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);

            return (this.TestAppointmentID != -1);

        }

        private bool _UpdateTestAppointment()
        {
            //call DataAccess Layer 

            return clsTestAppointmentsDataAccess.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);

        }

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = default;
            int LocalDrivingLicenseApplicationID = default;
            DateTime AppointmentDate = default;
            decimal PaidFees = default;
            int CreatedByUserID = default;
            bool IsLocked = default;


            if (clsTestAppointmentsDataAccess.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;

        }
        
        public static clsTestAppointment FindByLDLApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int TestTypeID = default;
            int TestAppointmentID = default;
            DateTime AppointmentDate = default;
            decimal PaidFees = default;
            int CreatedByUserID = default;
            bool IsLocked = default;


            if (clsTestAppointmentsDataAccess.GetTestAppointmentInfoByLDLID(ref TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;

        }
        
        public static clsTestAppointment FindByLDLID(int LocalDrivingLicenseApplicationID)
        {
            int TestTypeID = default;
            int TestAppointmentID = default;
            DateTime AppointmentDate = default;
            decimal PaidFees = default;
            int CreatedByUserID = default;
            bool IsLocked = default;


            if (clsTestAppointmentsDataAccess.GetTestAppointmentInfoByLDLID(ref TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();

            }




            return false;
        }

        public static DataView GetAllTestAppointments(int LoaclApplicationID, int TestTypeID) { return clsTestAppointmentsDataAccess.GetAllTestAppointments(LoaclApplicationID, TestTypeID); }
        
        public static DataTable GetAllTestAppointmentsToShow() { return clsTestAppointmentsDataAccess.GetAllTestAppointmentsToShow(); }

        public static bool DeleteTestAppointment(int TestAppointmentID) { return clsTestAppointmentsDataAccess.DeleteTestAppointment(TestAppointmentID); }

        public static bool isTestAppointmentExist(int TestAppointmentID) { return clsTestAppointmentsDataAccess.IsTestAppointmentExist(TestAppointmentID); }


    }

}