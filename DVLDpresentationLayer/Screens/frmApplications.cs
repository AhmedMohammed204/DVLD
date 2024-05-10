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
    public partial class frmApplications : Form
    {

        public frmApplications()
        {
            InitializeComponent();

        }
        void LoadData()
        {

            clsChangeControlsColor.ChangeGunaButtonsColor(this);
            clsChangeControlsColor.ChangeGunaButtonsColor(gbManageApplications);
            lblTitle.ForeColor = clsColors.LightColor;

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
        }
        private void frmApplications_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public delegate void OpenApplicationTypesEventHanler();
        public event OpenApplicationTypesEventHanler OpenApplicationTypes;
        private void btnApplications_Click(object sender, EventArgs e)
        {
            OpenApplicationTypes?.Invoke();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public delegate void OpenManageTestTypesHandler();
        public event OpenManageTestTypesHandler OpenManageTestTypes;
        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            OpenManageTestTypes?.Invoke();
        }


        public delegate void OpenDrivingLicenseServicesHandler();
        public event OpenDrivingLicenseServicesHandler OpenDrivingLicenseServices;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenDrivingLicenseServices.Invoke();
        }

        public delegate void OpenManageLocalApplicationsHandler();
        public event OpenManageLocalApplicationsHandler OpenManageLocalApplications;
        private void btnManageLocalApplications_Click(object sender, EventArgs e)
        {
            OpenManageLocalApplications?.Invoke();
        }

        public delegate void OpenManageInternationalApplicationsHandler();
        public event OpenManageInternationalApplicationsHandler OpenManageInternationalApplications;
        private void btnManageInternationalApplications_Click(object sender, EventArgs e)
        {
            OpenManageInternationalApplications?.Invoke();
        }


        public delegate void OpenDetainLicensesHandler();
        public event OpenDetainLicensesHandler OpenDetainLicenses;
        
        private void btnDetainLicenses_Click(object sender, EventArgs e)
        {
            OpenDetainLicenses?.Invoke();
        }
    }
}
