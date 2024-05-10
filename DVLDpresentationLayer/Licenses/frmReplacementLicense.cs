using ApplicationsBusinessLayer;
using ApplicationTypesBusinessLayer;
using DVLD.Licenses;
using LicensesBusinessLayer;
using System;
using System.Windows.Forms;
using UsersBusinessLayer;

namespace DVLD
{
    public partial class frmReplacementLicense : Form
    {

        public delegate void BackToDrivingLicenseServices();
        public event BackToDrivingLicenseServices Back;

        clsLicense oldLicense;
        int ApplicationTypeID;
        int ReplacementApplicationID;
        int NewLicenseID;
        byte IssueReason;
        public frmReplacementLicense()
        {
            InitializeComponent();
        }
        void LoadApplicationFees()
        {
            if (rbDamagedLicense.Checked)
            {
                IssueReason = 3;
                ApplicationTypeID = clsApplicationTypes.ReplacementForADamagedDrivingLicense;
                lblApplicationFees.Text = Convert.ToInt32(clsApplicationType.Find(ApplicationTypeID).ApplicationFees).ToString();
            }
            else
            if (rbLostLicense.Checked)
            {
                IssueReason = 4;
                ApplicationTypeID = clsApplicationTypes.ReplacementForALostDrivingLicense;
                lblApplicationFees.Text = Convert.ToInt32(clsApplicationType.Find(ApplicationTypeID).ApplicationFees).ToString();
            }
        }
        private void frmReplacementLicense_Load(object sender, EventArgs e)
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            btnIssue.btnTxt = "Issue";
            LoadApplicationFees();
            lblCreatedBy.Text = clsGlobal.User.UserName;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
        }
        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            oldLicense = ctrlLicenseInfoWithFilter1.LicenseInfo.license;
            if (!oldLicense.IsActive)
            {
                MessageBox.Show("This license is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnIssue.Enabled = true;
            lblOldLicenceID.Text = obj.ToString();
            llblShowPersonLicenseHistory.Enabled = true;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            LoadApplicationFees();

        }


        private void llblShowPersonLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDrivingLicenseHistory frm = new frmShowDrivingLicenseHistory(ctrlLicenseInfoWithFilter1.LicenseInfo.driver.DriverID);
            frm.ShowDialog();
        }
        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseDetails frm = new frmLicenseDetails(NewLicenseID);
            frm.Show();
        }

        void Save()
        {
            clsSave.SaveApplication(ref ReplacementApplicationID, ctrlLicenseInfoWithFilter1, lblApplicationDate, lblApplicationFees);
            clsSave.UnActiveOldLicense(oldLicense);
            clsSave.AddNewLicense(ref NewLicenseID, ReplacementApplicationID, IssueReason, ctrlLicenseInfoWithFilter1, oldLicense.LicenseClass, oldLicense.ExpirationDate, new Label(), lblApplicationFees);
            lblReplecedLicenceID.Text = NewLicenseID.ToString();
            lblLRApplication.Text = ReplacementApplicationID.ToString();
            
        }

        private void btnIssue_OnButtonClick(Button obj)
        {
            Save();
            ctrlLicenseInfoWithFilter1.Enabled = false;
            llblShowNewLicenseInfo.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
