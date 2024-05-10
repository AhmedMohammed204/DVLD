using ApplicationsBusinessLayer;
using ApplicationTypesBusinessLayer;
using LicensesBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmRenewLicense : Form
    {
        clsLicense OldLicense;
        clsLicense NewLicense;
        clsApplication RenewLicenseApplication;
        public frmRenewLicense()
        {
            InitializeComponent();
        }
        void LoadApplicationData()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = Convert.ToUInt32(clsApplicationType.Find(clsApplicationTypes.RenewLicenseService).ApplicationFees).ToString();
            lblExpirationDate.Text = new DateTime(DateTime.Now.Year + 10, DateTime.Now.Month, DateTime.Now.Day).ToShortDateString();
            lblCreatedBy.Text = "1";
        }
        private void frmRenewLicense_Load(object sender, EventArgs e)
        {


            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            LoadApplicationData();
            btnIssue.btnTxt = "Issue";

        }






        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            llblShowPersonLicenseHistory.Enabled = true;
            if(ctrlLicenseInfoWithFilter1.LicenseInfo.license.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("This licese isn't expird yet");
                return;
            }
            if(ctrlLicenseInfoWithFilter1.LicenseInfo.license.IsActive == false)
            {
                MessageBox.Show("This license isn't active already");
                return;
            }
            OldLicense = clsLicense.Find(obj);
            lblOldLicenseID.Text = obj.ToString();
            lblLicenseFees.Text = Convert.ToInt32(ctrlLicenseInfoWithFilter1.LicenseInfo.license.PaidFees).ToString();
            lblTotalFees.Text = (Convert.ToInt32(lblLicenseFees.Text) + Convert.ToInt32(lblApplicationFees.Text)).ToString();
            btnIssue.Enabled = true;
        }
        void SaveApplication()
        {

            RenewLicenseApplication = new clsApplication();

            RenewLicenseApplication.ApplicantPersonID = ctrlLicenseInfoWithFilter1.LicenseInfo.Person.PersonID;
            RenewLicenseApplication.ApplicationTypeID = clsApplicationTypes.RenewLicenseService;
            RenewLicenseApplication.ApplicationStatus = 3;
            RenewLicenseApplication.LastStatusDate = Convert.ToDateTime(lblApplicationDate.Text);
            RenewLicenseApplication.ApplicationDate = Convert.ToDateTime(lblApplicationDate.Text);
            RenewLicenseApplication.PaidFees = Convert.ToInt32(lblTotalFees.Text);
            RenewLicenseApplication.CreatedByUserID = 1;

            if(!RenewLicenseApplication.Save())
            {
                MessageBox.Show("There was a problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        void UnActiveOldLicense()
        {
            OldLicense.IsActive = false;

            if (!OldLicense.Save())
            {
                MessageBox.Show("There was a problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        void AddNewLicense()
        {
            NewLicense = new clsLicense();
            NewLicense.ApplicationID = RenewLicenseApplication.ApplicationID;
            NewLicense.DriverID = ctrlLicenseInfoWithFilter1.LicenseInfo.driver.DriverID;
            NewLicense.LicenseClass = OldLicense.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = Convert.ToDateTime(lblExpirationDate.Text);
            NewLicense.Notes = txtNotes.Text;
            NewLicense.PaidFees = Convert.ToInt32( lblLicenseFees.Text);
            NewLicense.IsActive = true;
            NewLicense.IssueReason = 2;
            NewLicense.CreatedByUserID = 1;

            if(!NewLicense.Save())
            {
                MessageBox.Show("There was a problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }else
            {
                MessageBox.Show($"License Issued Seccussfully! with ID = {NewLicense.LicenseID}", "Done");
                ctrlLicenseInfoWithFilter1.Enabled = false;
                llblLicenseDetails.Enabled = true;
                btnIssue.Enabled = false;
                llblShowPersonLicenseHistory.Enabled = true;
                lblApplicationID.Text = RenewLicenseApplication.ApplicationID.ToString();
            }
        }
        void IssueLicense()
        {
            SaveApplication();
            UnActiveOldLicense();
            AddNewLicense();
        }
        private void btnIssue_OnButtonClick(Button obj)
        {
            IssueLicense();
        }

        private void llblShowPersonLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDrivingLicenseHistory frm = new frmShowDrivingLicenseHistory(ctrlLicenseInfoWithFilter1.LicenseInfo.driver.DriverID);
            frm.ShowDialog();
        }

        private void llblLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NewLicense == null)
                return;
            frmLicenseDetails frm = new frmLicenseDetails(NewLicense.LicenseID);
            frm.ShowDialog();
        }



        public delegate void BackToDrivingLicenseServices();
        public event BackToDrivingLicenseServices Back;
        private void btnBack_Click(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
