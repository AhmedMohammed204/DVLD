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

namespace DVLD.Screens
{
    public partial class frmDetainLicenseScreen : Form
    {
        public frmDetainLicenseScreen()
        {
            InitializeComponent();
        }

        private void frmDetainLicenseScreen_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            clsChangeControlsColor.ChangeGunaButtonsColor(this);
            lblTitle.ForeColor = clsColors.LightColor;

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
        }

        public delegate void BackToApplicationsFormHandler();
        public event BackToApplicationsFormHandler BackToApplicationsForm;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToApplicationsForm?.Invoke();
        }


        public delegate void OpenDetainScreenHandler();
        public event OpenDetainScreenHandler OpenDetainScreen;
        private void btnDetain_Click(object sender, EventArgs e)
        {
            OpenDetainScreen?.Invoke();
        }



        public delegate void OpenManageDetainScreenHandler();
        public event OpenManageDetainScreenHandler OpenManageDetainScreen;
        private void btnManageDetain_Click(object sender, EventArgs e)
        {
            OpenManageDetainScreen?.Invoke();
        }



        public delegate void OpenReleaseScreenHandler();
        public event OpenReleaseScreenHandler OpenReleaseScreen;
        private void btnRelease_Click(object sender, EventArgs e)
        {
            OpenReleaseScreen?.Invoke();

        }
    }
}
