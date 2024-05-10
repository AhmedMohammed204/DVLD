using DriversBusinessLayer;
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
    public partial class frmManageInternationalLicenses : Form
    {
        public frmManageInternationalLicenses()
        {
            InitializeComponent();
        }

        private void frmManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            lblTitle.ForeColor = clsColors.LightColor;

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            ctrlDataGrid1.LoadData(clsInternationalLicense.GetAllInternationalLicenses());
            ctrlDataGrid1.AddContextMenuStrip(contextMenuStrip1);
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)ctrlDataGrid1.GetCurrentRow().Cells["DriverID"].Value;
            frmShowDrivingLicenseHistory frm = new frmShowDrivingLicenseHistory(DriverID);
            frm.ShowDialog();
        }

        private void showPerosnDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)ctrlDataGrid1.GetCurrentRow().Cells["DriverID"].Value;
            int PersonID = clsDriver.Find(DriverID).PersonID;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int internationalLicenseID = ctrlDataGrid1.GetFirstItemInRow();
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(internationalLicenseID);
            frm.ShowDialog();
        }


        public delegate void BakcToApplicationsFormHandler();
        public event BakcToApplicationsFormHandler BakcToApplicationsForm;

        private void btnBack_Click(object sender, EventArgs e)
        {
            BakcToApplicationsForm?.Invoke();
        }
    }
}
