using ApplicationsBusinessLayer;
using ApplicationTypesBusinessLayer;
using LicenseClassesBusinessLayer;
using LocalDrivingLicenseApplicationsBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        enum enMode { AddNew = 1, Update = 2 };
        enMode _Mode;
        int _ApplicationID = -1;
        clsApplication _Application;
        int _PersonID;
        clsApplicationType _ApplicationType;



        public frmNewLocalDrivingLicenseApplication(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationType = clsApplicationType.Find(ApplicationTypeID);
            this.BackColor = clsColors.PrimaryColor;
            if (_ApplicationType == null)
            {
                MessageBox.Show("Application Type doesn't found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


        }
        void _FillCbLicenseClasses()
        {
            cbLicenseClasses.Items.Clear();
            DataTable dtLicenseClasses = clsLisenceClass.GetAllLicenseClasses();

            foreach (DataRow Class in dtLicenseClasses.Rows)
            {
                cbLicenseClasses.Items.Add(Class["ClassName"]);
            }
        }
        void _LoadData()
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            _FillCbLicenseClasses();
            if (_ApplicationID != -1)
            {
                lblApplicationID.Text = _Application.ApplicationID.ToString();

                lblApplicationDate.Text = new DateTime(_Application.ApplicationDate.Year, _Application.ApplicationDate.Month, _Application.ApplicationDate.Day).ToShortDateString();
                return;
            }
            lblApplicationID.Text = "[???]";
            _Application = new clsApplication();
            lblApplicationDate.Text = DateTime.Today.ToShortDateString();
            ctrlButtonSave.btnTxt = "Save";
        }
        private void ctrlFindPerson1_OnPersonFound(int obj)
        {
            _PersonID = obj;
            gbApplicationInfo.Enabled = true;
            lblFees.Text = "15";
            _ApplicationID = -1;
            _LoadData();
        }
        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(cbLicenseClasses.Text))
            {
                MessageBox.Show("You have to choose a class");
                return false;
            }
            int AppPrevID = clsApplication.isApplicationValidToAdd(_PersonID, clsLisenceClass.Find(cbLicenseClasses.Text).LicenseClassID);
            if (AppPrevID != -1)
            {

                MessageBox.Show($"This applicatino is already exist with ID = {AppPrevID},\n\ntry with another application type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }
        private bool SendDataToDatabase()
        {
            _Application.ApplicantPersonID = _PersonID;
            _Application.ApplicationDate = DateTime.Parse(lblApplicationDate.Text);
            _Application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees = Convert.ToDecimal(lblFees.Text);
            _Application.CreatedByUserID = 1;
            //_Application.CreatedByUserID = clsGlobal.User.UserID;
            if (!_Application.Save())
            {
                MessageBox.Show("There was an error, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _ApplicationID = _Application.ApplicationID;
            clsLocalDrivingLicenseApplication LocalDVLapplication = new clsLocalDrivingLicenseApplication();
            LocalDVLapplication.ApplicationID = _ApplicationID;
            LocalDVLapplication.LicenseClassID = clsLisenceClass.Find(cbLicenseClasses.Text).LicenseClassID;

            if (!LocalDVLapplication.Save())
            {
                MessageBox.Show("There was an error, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void Save()
        {
            if (!IsValidToSave())
                return;
            if (!SendDataToDatabase())
                return;
            _LoadData();


        }
        private void ctrlButtonSave_OnButtonClick(Button obj)
        {
            Save();
        }

        private void ctrlButtonSave_Load(object sender, EventArgs e)
        {

        }
        public delegate void BackToDrivingLicenseServicesFormHandler();
        public event BackToDrivingLicenseServicesFormHandler BackToDrivingLicenseServicesForm;

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDrivingLicenseServicesForm?.Invoke();
        }
    }
}
