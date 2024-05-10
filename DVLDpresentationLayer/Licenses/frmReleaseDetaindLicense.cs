using ApplicationTypesBusinessLayer;
using DetainedLicensesBusinessLayer;
using DVLD.Licenses;
using LicensesBusinessLayer;
using System;
using System.Windows.Forms;
using UsersBusinessLayer;

namespace DVLD
{
    public partial class frmReleaseDetaindLicense : Form
    {
        clsLicense License;
        int ApplicationID;
        clsDetain detain;
        public frmReleaseDetaindLicense()
        {
            InitializeComponent();
            LoadData();
        }
        void DisableEnableControls(bool Enable)
        {

            btnRelease.Enabled = Enable;
            llblShowLicenseInfo.Enabled = Enable;
            llblShowPersonLicenseHistory.Enabled = Enable;
        }
        void LoadData()
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            DisableEnableControls(false);
            btnRelease.btnTxt = "Realse";
        }
        private void frmReleaseDetaindLicense_Load(object sender, EventArgs e)
        {
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            LicenseSelected(obj);
        }
        void LicenseSelected(int obj)
        {
            DisableEnableControls(false);
            License = clsLicense.Find(obj);
            if (!License.IsActive)
            {
                MessageBox.Show("License isn't active", "Error");
                return;
            }
            if (!clsDetain.isDetainExistByLicenseID(License.LicenseID))
            {
                MessageBox.Show("License is NOT detaind", "Error");
                return;
            }
            DisableEnableControls(true);
            LoadDetainDetails();
        }
        void LoadDetainDetails()
        {
            detain = clsDetain.FindByLicense(License.LicenseID);
            lblDetainID.Text = detain.DetainID.ToString();
            lblDetainDate.Text = detain.DetainDate.ToShortDateString();
            lblFineFees.Text = Convert.ToInt32(detain.FineFees).ToString();
            lblLicenseID.Text = License.LicenseID.ToString();
            lblApplicationFees.Text = Convert.ToInt32(clsApplicationType.Find(clsApplicationTypes.ReleaseDetainedDrivingLicsense).ApplicationFees).ToString();
            lblCreatedBy.Text = clsUser.Find(detain.CreatedByUserID).UserName;
            lblTotalFees.Text = (Convert.ToInt32(lblFineFees.Text) + Convert.ToInt32(lblApplicationFees.Text)).ToString();

        }
        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseDetails frm = new frmLicenseDetails(License.LicenseID);
            frm.ShowDialog();
        }
        private void llblShowPersonLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDrivingLicenseHistory frm = new frmShowDrivingLicenseHistory(License.DriverID);
            frm.ShowDialog();
        }
        private void Save()
        {
            clsSave.SaveApplication(ref ApplicationID, ctrlLicenseInfoWithFilter1, DateTime.Now, Convert.ToInt32(detain.FineFees));
            clsDetain ReleaseDetain = clsDetain.Find(detain.DetainID);
            ReleaseDetain.IsReleased = true;
            ReleaseDetain.ReleaseDate = DateTime.Now;
            ReleaseDetain.ReleaseApplicationID = ApplicationID;
            ReleaseDetain.ReleasedByUserID = clsGlobal.User.UserID;
            if (ReleaseDetain.Save())
            {
                MessageBox.Show("License released successfully!", "Done");
                btnRelease.Enabled = false;
                ctrlLicenseInfoWithFilter1.Enabled = false;
                lblRApplicationID.Text = ApplicationID.ToString();
            }
        }
        private void btnRelease_OnButtonClick(Button obj)
        {

            if (MessageBox.Show("Are you sure you want to release this license?", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Save();
            }
        }


        public delegate void BackToDetainReleaseScreenHandler();
        public event BackToDetainReleaseScreenHandler BackToDetainReleaseScreen;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDetainReleaseScreen?.Invoke();
        }


        public void Find(int LicenseID)
        {
            ctrlLicenseInfoWithFilter1.Find(LicenseID);
            LicenseSelected(LicenseID);
        }

    }
}
