using DriversBusinessLayer;
using InternationalLicensesBusinessLayer;
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
    public partial class frmShowDrivingLicenseHistory : Form
    {
        clsDriver driver;
        public frmShowDrivingLicenseHistory(int DriverID)
        {
            InitializeComponent();
            driver = clsDriver.Find(DriverID);
            if(driver == null)
            {
                MessageBox.Show($"This window will close because there is no driver with id = {DriverID}");
                this.Close();
                return;
            }
            ctrlFindPerson1.Find(driver.PersonID);
            ctrlFindPerson1.UpdateMode();
        }
        void LoadDGVLocalLicense()
        {
            DataView dv =  clsLicense.GetAllLicenses().DefaultView;
            dv.RowFilter = $"DriverID = {driver.DriverID}";
            dgvLocalLicense.DataSource = dv;
        }
        void LoadInternationalLicense()
        {
            DataView dv = clsInternationalLicense.GetAllInternationalLicenses().DefaultView;
            dv.RowFilter = $"DriverID = {driver.DriverID}";
            dgvInternationalLicenses.DataSource = dv;
        }
        void LoadData()
        {
            LoadDGVLocalLicense();
            LoadInternationalLicense();
        }
        private void frmShowDrivingLicenseHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void ShowLocalLicenseDtails()
        {
            frmLicenseDetails frm = new frmLicenseDetails((int)dgvLocalLicense.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        void ShowInternationalLicenseDetails()
        {

            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                ShowLocalLicenseDtails();
            }
            else
            {
                ShowInternationalLicenseDetails();
            }
        }
    }
}
