using System.Data;
using TestsDataAccessLayer;
namespace TestsBusinessLayer
{

    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public clsTest()
        {
            this.TestID = default;
            this.TestAppointmentID = default;
            this.TestResult = default;
            this.Notes = default;
            this.CreatedByUserID = default;


            Mode = enMode.AddNew;

        }

        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;


            Mode = enMode.Update;

        }

        private bool _AddNewTest()
        {
            //call DataAccess Layer 

            this.TestID = clsTestsDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return (this.TestID != -1);

        }

        private bool _UpdateTest()
        {
            //call DataAccess Layer 

            return clsTestsDataAccess.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

        }

        public static clsTest Find(int TestID)
        {
            int TestAppointmentID = default;
            bool TestResult = default;
            string Notes = default;
            int CreatedByUserID = default;


            if (clsTestsDataAccess.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTest();

            }




            return false;
        }

        public static DataTable GetAllTests() { return clsTestsDataAccess.GetAllTests(); }

        public static bool DeleteTest(int TestID) { return clsTestsDataAccess.DeleteTest(TestID); }

        public static bool isTestExist(int TestID) { return clsTestsDataAccess.IsTestExist(TestID); }

        public static bool IsTestApplicantPassed(int LocalDrivingLicenseApplicationID, int TestTypeID) { return clsTestsDataAccess.IsTestApplicantePassed(LocalDrivingLicenseApplicationID, TestTypeID); }

    }

}