using DetainedLicensesBusinessLayer;
using DVLD.Licenses;
using LicensesBusinessLayer;
using System;
using System.Windows.Forms;
using UsersBusinessLayer;

namespace DVLD
{
    public partial class frmDetainLicense : Form
    {
        clsLicense License;
        int DetainID;
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            btnIssue.btnTxt = "Detain";
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.User.UserName;
        }
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        void EnableDisableControls(bool Enable)
        {
            NudFees.Enabled = Enable;
            btnIssue.Enabled = Enable;
            llblShowLicenseInfo.Enabled = Enable;
            llblShowPersonLicenseHistory.Enabled = Enable;
        }
        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            EnableDisableControls(false);
            License = clsLicense.Find(obj);
            if (!License.IsActive)
            {
                MessageBox.Show("License isn't active", "Error");
                return;
            }
            if (clsDetain.isDetainExistByLicenseID(License.LicenseID))
            {
                MessageBox.Show("License is already detaind", "Error");
                return;
            }
            EnableDisableControls(true);
            lblLicenseID.Text = obj.ToString();
        }


        private void Save()
        {
            clsDetain detain = new clsDetain();
            detain.LicenseID = License.LicenseID;
            detain.FineFees = NudFees.Value;
            detain.CreatedByUserID = clsGlobal.User.UserID;
            detain.IsReleased = false;
            detain.DetainDate = DateTime.Now;




            if (detain.Save())
            {
                DetainID = detain.DetainID;
                MessageBox.Show($"License detained successfully with id = {DetainID}", "Done");
                ctrlLicenseInfoWithFilter1.Enabled = false;
                lblDetainID.Text = DetainID.ToString();
                btnIssue.Enabled = false;
            }

        }

        private void btnIssue_OnButtonClick(Button obj)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Save();
            }
        }

        private void llblShowPersonLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDrivingLicenseHistory frm = new frmShowDrivingLicenseHistory(License.DriverID);
            frm.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseDetails frm = new frmLicenseDetails(License.LicenseID);
            frm.ShowDialog();
        }

        private void btnIssue_Load(object sender, EventArgs e)
        {

        }

        public delegate void BackToDetainReleaseScreenHandler();
        public event BackToDetainReleaseScreenHandler BackToDetainReleaseScreen;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDetainReleaseScreen?.Invoke();
        }
    }
}
