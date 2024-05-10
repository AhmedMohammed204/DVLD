using DVLD.Lib;
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
    public partial class frmDrivingLicenseServices : Form
    {
        void LoadData()
        {

            clsChangeControlsColor.ChangeGunaButtonsColor(gbAddNew);
            clsChangeControlsColor.ChangeGunaButtonsColor(this);
            lblTitle.ForeColor = clsColors.LightColor;

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
        }
        public frmDrivingLicenseServices()
        {
            InitializeComponent();
        }

        private void frmDrivingLicenseServices_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public delegate void BackToApplicationsFormHandler();
        public event BackToApplicationsFormHandler BackToApplicationsForm;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToApplicationsForm?.Invoke();
        }

        public delegate void OpenAddNewLocalLicenseFormHandler();
        public event OpenAddNewLocalLicenseFormHandler OpenAddNewLocalLicenseForm;
        private void btnAddNewLocalLicense_Click(object sender, EventArgs e)
        {
            OpenAddNewLocalLicenseForm?.Invoke();
        }

        public delegate void OpenAddNewInternationalLicenseFormHandler();
        public event OpenAddNewInternationalLicenseFormHandler OpenAddNewInternationalLicenseForm;
        private void btnAddNewInternationalLicense_Click(object sender, EventArgs e)
        {
            OpenAddNewInternationalLicenseForm?.Invoke();
        }


        public delegate void OpenReplacementFormHandler();
        public event OpenReplacementFormHandler OpenReplacementForm;
        private void btnReplacement_Click(object sender, EventArgs e)
        {
            OpenReplacementForm?.Invoke();
        }

        public delegate void OpenRenewFormHandler();
        public event OpenRenewFormHandler OpenRenewForm;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenRenewForm?.Invoke();
        }
    }
}
