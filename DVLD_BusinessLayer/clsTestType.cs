using System;
using System.Data;
using TestTypesDataAccessLayer;
namespace TestTypesBusinessLayer
{

    public class clsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }


        public clsTestType()
        {
            this.TestTypeID = default;
            this.TestTypeTitle = default;
            this.TestTypeDescription = default;
            this.TestTypeFees = default;


            Mode = enMode.AddNew;

        }

        private clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;


            Mode = enMode.Update;

        }

        private bool _AddNewTestType()
        {
            //call DataAccess Layer 

            this.TestTypeID = clsTestTypesDataAccess.AddNewTestType(this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);

            return (this.TestTypeID != -1);

        }

        private bool _UpdateTestType()
        {
            //call DataAccess Layer 

            return clsTestTypesDataAccess.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);

        }

        public static clsTestType Find(int TestTypeID)
        {
            string TestTypeTitle = default;
            string TestTypeDescription = default;
            decimal TestTypeFees = default;


            if (clsTestTypesDataAccess.GetTestTypeInfoByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestType();

            }




            return false;
        }

        public static DataTable GetAllTestTypes() { return clsTestTypesDataAccess.GetAllTestTypes(); }

        public static bool DeleteTestType(int TestTypeID) { return clsTestTypesDataAccess.DeleteTestType(TestTypeID); }

        public static bool isTestTypeExist(int TestTypeID) { return clsTestTypesDataAccess.IsTestTypeExist(TestTypeID); }


    }

}