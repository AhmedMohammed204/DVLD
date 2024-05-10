using ApplicationsBusinessLayer;
using ApplicationTypesBusinessLayer;
using DVLD.Licenses;
using InternationalLicensesBusinessLayer;
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
    public partial class frmNewInternationalDrivingLicense : Form
    {
        clsApplication application;
        clsInternationalLicense InternationalLicense;
        int LocalLicenseID;
        void LoadData()
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            DateTime TodayDate = DateTime.Now;
            lblApplicationDate.Text = TodayDate.ToShortDateString();
            lblIssueDate.Text = TodayDate.ToShortDateString();
            lblFees.Text = Convert.ToInt32( clsApplicationType.Find(6).ApplicationFees).ToString();
            lblExpirationDate.Text = new DateTime(TodayDate.Year + 1, TodayDate.Month, TodayDate.Day).ToShortDateString();
            //lblCreatedBy.Text = clsGlobal.User.UserID.ToString();
            lblCreatedBy.Text = "1";


            btnIssue.btnTxt = "Issue";
        }
        public frmNewInternationalDrivingLicense()
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
            LoadData();
        }
        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            if(ctrlLicenseInfoWithFilter1.LicenseInfo.license.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("This license is expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            LocalLicenseID = obj;
            btnIssue.Enabled = true;
            lblLocalLicenseID.Text = obj.ToString();
        }
        bool IsValidToSave()
        {
            if(ctrlLicenseInfoWithFilter1.LicenseInfo.lisenceClass.LicenseClassID != 3)
            {
                MessageBox.Show("License is not Ordinary driving license (car licence)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            clsInternationalLicense I_License = clsInternationalLicense.FindByDriverID(ctrlLicenseInfoWithFilter1.LicenseInfo.driver.DriverID);
            if ( I_License != null && I_License.IsActive)
            {

                MessageBox.Show("Driver is already have an international driving license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        void SaveInternationalApplication()
        {
            application = new clsApplication();
            application.ApplicantPersonID = ctrlLicenseInfoWithFilter1.LicenseInfo.Person.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationTypeID = clsApplicationTypes.NewInternationalLicense;
            application.ApplicationStatus = 3;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = clsApplicationType.Find(clsApplicationTypes.NewInternationalLicense).ApplicationFees;
            application.CreatedByUserID = 1;
            application.Save();


        }
        void CreateNewInternationalLicense()
        {
            InternationalLicense = new clsInternationalLicense();
            InternationalLicense.ApplicationID = application.ApplicationID;
            InternationalLicense.DriverID = ctrlLicenseInfoWithFilter1.LicenseInfo.driver.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = LocalLicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = Convert.ToDateTime(lblExpirationDate.Text);
            InternationalLicense.IsActive= true;
            InternationalLicense.CreatedByUserID = 1;
            if(InternationalLicense.Save())
            {
                MessageBox.Show("License issued seccussfully", "Done");
                ctrlLicenseInfoWithFilter1.FilterAbility(false);
                lblILApplicationID.Text = application.ApplicationID.ToString();
                lblILLicense.Text = InternationalLicense.InternationalLicenseID.ToString();
            }
        }
        void Save()
        {
            if(!IsValidToSave())
                return;
            SaveInternationalApplication();
            CreateNewInternationalLicense();


        }
        private void btnIssue_OnButtonClick(Button obj)
        {
            Save();
        }

        private void llblLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(InternationalLicense.InternationalLicenseID);
            frm.ShowDialog();
        }

        private void frmNewInternationalDrivingLicense_Load(object sender, EventArgs e)
        {

        }

        public delegate void BackToDrivingLicenseServicesHandler();
        public event BackToDrivingLicenseServicesHandler BackToDrivingLicenseServices;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDrivingLicenseServices?.Invoke();
        }
    }
}
