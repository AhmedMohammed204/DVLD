using DetainedLicensesBusinessLayer;
using DVLD.Licenses;
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
using UsersBusinessLayer;

namespace DVLD
{
    public partial class frmManageDetainedLicenses : Form
    {
        clsLicense License;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }
        private void LoadData()
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            ctrlDataGrid1.LoadData(clsDetain.GetAllDetainedLicenses());
            ctrlDataGrid1.AddContextMenuStrip(contextMenuStrip1);
            btnDetain.btnTxt = "Detain";
            btnRelease.btnTxt = "Release";
        }
        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(ctrlDataGrid1.GetCurrentRow().Cells["LicenseID"].Value);
            frmReleaseDetaindLicense frm = new frmReleaseDetaindLicense();
            frm.Find(LicenseID);
            frm.ShowDialog();
        }


        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            DataGridViewRow row = ctrlDataGrid1.GetCurrentRow();
            License = clsLicense.Find((int)row.Cells["LicenseID"].Value);
            PerformRelease(row);


        }
        
        void PerformRelease(DataGridViewRow row)
        {
            if (Convert.ToBoolean(row.Cells["IsReleased"].Value) == true)
            {
                releaseToolStripMenuItem.Enabled = false;
            }
            else
            {
                releaseToolStripMenuItem.Enabled = true;
            }
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseDetails frm = new frmLicenseDetails(License.LicenseID);
            frm.ShowDialog();
            LoadData();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDrivingLicenseHistory frm = new frmShowDrivingLicenseHistory(License.DriverID);
            frm.ShowDialog();
            LoadData();
        }

        private void btnRelease_OnButtonClick(Button obj)
        {
            frmReleaseDetaindLicense frm = new frmReleaseDetaindLicense();
            frm.ShowDialog();
            LoadData();
        }


        private void btnDetain_OnButtonClick(Button obj)
        {

            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            LoadData();
        }


        public delegate void BackToDetainReleaseScreenHandler();
        public event BackToDetainReleaseScreenHandler BackToDetainReleaseScreen;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDetainReleaseScreen?.Invoke();
        }

    }
}
