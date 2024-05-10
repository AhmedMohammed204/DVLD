using ApplicationsBusinessLayer;
using DriversBusinessLayer;
using LicenseClassesBusinessLayer;
using LicensesBusinessLayer;
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

namespace DVLD
{
    public partial class frmIssuDrivingLicense : Form
    {
        int LocalApplicationID;
        clsLocalDrivingLicenseApplication LocalApplication;
        clsApplication Application;
        clsDriver driver;
        clsLicense License;
        private void LoadLocalApplication()
        {
            LocalApplication = clsLocalDrivingLicenseApplication.Find(LocalApplicationID);
            Application = clsApplication.Find(LocalApplication.ApplicationID);
        }
        private void LoadDriver()
        {
            driver = clsDriver.FindByPersonID(Application.ApplicantPersonID);
            if (driver != null)
            {
                this.Close();
                return;
            }

            driver = new clsDriver();

        }
        private void LoadLicese()
        {
            License = new clsLicense();
        }
        private void LoadData()
        {
            btnIssue.btnTxt = "Issue";
            ctrlApplicationInfo1.LoadApplication(LocalApplicationID);
            LoadLocalApplication();
            LoadDriver();
            LoadLicese();
        }
        public frmIssuDrivingLicense(int LocalApplicationID)
        {
            InitializeComponent();
            this.LocalApplicationID = LocalApplicationID;
            LoadData();
        }
        void SaveDriver()
        {
            driver.CreatedDate = DateTime.Now;
            driver.PersonID = Application.ApplicantPersonID;
            driver.CreatedByUserID = 1;

            if (!driver.Save())
            {
                MessageBox.Show("There was a problem. try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }
        void SaveLicense()
        {
            
            License.ApplicationID = Application.ApplicationID;
            License.DriverID = driver.DriverID;
            License.LicenseClass = LocalApplication.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = new DateTime(DateTime.Now.Year + clsLisenceClass.Find(LocalApplication.LicenseClassID).DefaultValidityLength, License.IssueDate.Month, License.IssueDate.Day);
            License.Notes = txtNotes.Text;
            License.PaidFees = Application.PaidFees;
            License.IsActive = true;
            License.IssueReason = 1;
            License.CreatedByUserID = 1;
            if(License.Save())
            {
                MessageBox.Show($"License Added Successfully with ID = {License.LicenseID}");
                Application.ApplicationStatus = 3;
                Application.Save();
                
            }
        }
        void Save()
        {
            SaveDriver();
            SaveLicense();
        }
        private void btnIssue_OnButtonClick(Button obj)
        {
            Save();
            this.Close();
        }
    }
}
