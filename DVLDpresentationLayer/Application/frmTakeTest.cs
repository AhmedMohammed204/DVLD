using ApplicationsBusinessLayer;
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
using TestAppointmentsBusinessLayer;
using TestsBusinessLayer;

namespace DVLD
{
    public partial class frmTakeTest : Form
    {
        int _TestAppointmentID;
        int _LocalDrivingLocenseApplicationID;
        int _TestTypeID;
        clsTest _Test;
        clsTestAppointment TestAppointment;
        void CheckTestAppointment()
        {

            TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (TestAppointment == null)
            {
                clsCloseWindowWithMessage.CloseWindow(this, "Appointment not found", "Error",
                    clsCloseWindowWithMessage.enMessageBoxButtons.Ok, clsCloseWindowWithMessage.enMessageBoxType.Error);

            }
            if(TestAppointment.IsLocked)
            {
                clsCloseWindowWithMessage.CloseWindow(this, "Appoint is already taken", "Error",
                    clsCloseWindowWithMessage.enMessageBoxButtons.Ok, clsCloseWindowWithMessage.enMessageBoxType.Error);
            }

        }
        void LoadData()
        {
            CheckTestAppointment();
            ctrlTests1.LoadTestInfo(_TestAppointmentID, _LocalDrivingLocenseApplicationID, _TestTypeID, false);
            _Test = new clsTest();
            rbFaild.Select();
            btnSave.btnTxt = "Save";

        }
        public frmTakeTest(int testAppointmentID, int LocalDLID, int TestTypeID)
        {
            InitializeComponent();
            _TestAppointmentID = testAppointmentID;
            _LocalDrivingLocenseApplicationID = LocalDLID;
            _TestTypeID = TestTypeID;
        }
        void SetApplicationCompleted()
        {
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLocenseApplicationID);
            if( LDLApplication != null && _TestTypeID == 3 )
            {
                clsApplication application = clsApplication.Find(LDLApplication.ApplicationID);
                if( application != null )
                {
                    application.ApplicationStatus = 3;
                    application.LastStatusDate = DateTime.Now;
                    application.Save();
                }
            }
        }
        private void btnSave_OnButtonClick(Button obj)
        {
            _Test.Notes = txtNotes.Text;
            _Test.TestAppointmentID = _TestAppointmentID;
            //_Test.CreatedByUserID = clsGlobal.User.UserID;
            _Test.CreatedByUserID = 1;
            _Test.TestResult = rbPass.Checked;
            TestAppointment.IsLocked = true;
            
            
            if (_Test.Save())
            {


                TestAppointment.Save();
                //SetApplicationCompleted();
                MessageBox.Show("Test added successfully!", "Done");
                this.Close();
            }
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
