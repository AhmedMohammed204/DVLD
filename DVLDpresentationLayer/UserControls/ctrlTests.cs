using LicenseClassesBusinessLayer;
using LocalDrivingLicenseApplications_ViewBusinessLayer;
using LocalDrivingLicenseApplicationsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAppointments_ViewBusinessLayer;
using TestAppointmentsBusinessLayer;
using TestTypesBusinessLayer;

namespace DVLD
{
    public partial class ctrlTests : UserControl
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;

        clsLocalDrivingLicenseApplication _LoaclApplication;
        clsLocalDrivingLicenseApplicationView _LocalApplicationView;
        private clsTestAppointment TestAppointment;
        int _LoaclApplicationID;
        int Trials;
        int _TestTypeID;
        void LoadTitle()
        {
            DataView dv = clsTestAppointment.GetAllTestAppointments(_LoaclApplicationID, _TestTypeID);
            Trials = dv.Count;
            if (Trials > 0)
            {
                lblTitle.Text = "Schedule Retake Test";
            }
            else
            {
                lblTitle.Text = "Schedule Test";
            }
        }
        void LoadDateTimePicker()
        {
            
            if (_Mode == enMode.AddNew)
            {
                dtp.Value = DateTime.Now;
                dtp.MinDate = DateTime.Now;
            }
            else
                dtp.Value = TestAppointment.AppointmentDate;


        }
        void LoadTestDetails()
        {
            lblID.Text = _LocalApplicationView.LocalDrivingLicenseApplicationID.ToString();
            lblClass.Text = _LocalApplicationView.ClassName;
            lblName.Text = _LocalApplicationView.FullName;
            lblTrials.Text = Trials.ToString();
            lblFees.Text = ((int)clsTestType.Find(_TestTypeID).TestTypeFees).ToString();
            LoadDateTimePicker();
        }
        void PerformApplicationLocked()
        {
            if (!TestAppointment.IsLocked)
                return;    
            dtp.Enabled = false;
            ctrlButton1.Enabled = false;
        }
        public void LoadTestInfo(int TestAppointmentID, int LoaclApplicationID, int TestTypeID, bool AbleToSave = true)
        {
            if (!AbleToSave)
                ctrlButton1.Visible = false;
            _TestTypeID = TestTypeID;
            if (TestAppointmentID == -1)
            {
                _Mode = enMode.AddNew;
                TestAppointment = new clsTestAppointment();
                LoadData(LoaclApplicationID);
                return;
            }

            TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            _Mode = enMode.Update;
            LoadData(LoaclApplicationID);
        }



        private void LoadData(int LoaclApplicationID)
        {

            TestAppointment.LocalDrivingLicenseApplicationID = LoaclApplicationID;
            TestAppointment.TestTypeID = _TestTypeID;
            _LoaclApplicationID = LoaclApplicationID;
            _LoaclApplication = clsLocalDrivingLicenseApplication.Find(_LoaclApplicationID);
            if (_LoaclApplication == null)
                return;

            LoadTitle();
            _LocalApplicationView = clsLocalDrivingLicenseApplicationView.Find(LoaclApplicationID);
            if (_LocalApplicationView == null) return;
            ctrlButton1.btnTxt = "Save";

            PerformApplicationLocked();
            LoadTestDetails();

        }
        public ctrlTests()
        {
            InitializeComponent();
        }

        private void ctrlButton1_OnButtonClick(Button obj)
        {
            if (TestAppointment == null)
                return;
            //TestAppointment.CreatedByUserID = clsGlobal.User.UserID;
            TestAppointment.CreatedByUserID = 1;
            TestAppointment.PaidFees = clsTestType.Find(_TestTypeID).TestTypeFees;
            TestAppointment.AppointmentDate = dtp.Value;
            if (TestAppointment.Save())
            {
                MessageBox.Show("Appointment saved seccessfully");
            };

            LoadData(TestAppointment.LocalDrivingLicenseApplicationID);
        }
    }
}
