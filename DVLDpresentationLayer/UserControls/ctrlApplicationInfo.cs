using ApplicationMaster_ViewBusinessLayer;
using ApplicationsBusinessLayer;
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

namespace DVLD
{
    public partial class ctrlApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication LocalApplication;
        private clsApplicationMaster AppMaster;        
        public void LoadApplication(int LocalApplicationID)
        {
            LocalApplication = clsLocalDrivingLicenseApplication.Find(LocalApplicationID);

            if (LocalApplication == null)
            {
                MessageBox.Show("Application doesn't found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppMaster = clsApplicationMaster.Find(LocalApplication.ApplicationID);
            if(AppMaster == null)
            {
                MessageBox.Show("There was an error");
                return;
            }
            lblDLAppID.Text = LocalApplicationID.ToString();
            lblAppliedFor.Text = clsLisenceClass.Find(LocalApplication.LicenseClassID).ClassName;
            lblPassedTests.Text = "3/" + clsLocalDrivingLicenseApplicationView.Find(LocalApplicationID).PassedTestCount;

            FillBasicInfo();
        }
        string _StrApplicationStatus(int ApplicationStatus)
        {
            switch(ApplicationStatus)
            {
                case 1:
                    return "New";
                case 2:
                    return "Canselled";
                case 3:
                    return "Compeleted";
                default:
                    return "";
            }
        }
        private void FillBasicInfo()
        {
            lblID.Text = AppMaster.ApplicationID.ToString();
            lblStatus.Text = _StrApplicationStatus(  AppMaster.ApplicationStatus );
            lblType.Text = AppMaster.ApplicationTypeTitle;
            lblFees.Text = AppMaster.ApplicationFees.ToString();
            lblApplicaint.Text = AppMaster.FullName;
            lblDate.Text = AppMaster.ApplicationDate.ToString();
            lblStatusDate.Text = AppMaster.LastStatusDate.ToString();
            lblCreatedBy.Text = AppMaster.UserName;
        }
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        private void LinklblShowPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AppMaster == null)
                return;

            frmPersonDetails frm = new frmPersonDetails(AppMaster.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
