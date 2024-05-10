using DVLD.Lib;
using Guna.UI2.WinForms;
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
    public partial class frmAccountSettings : Form
    {
        public delegate void LogoutEventHandler();
        public event LogoutEventHandler Logout;
        
        void LoadData()
        {
            clsChangeControlsColor.ChangeGunaButtonsColor(this);
            lblTitle.ForeColor = clsColors.LightColor;

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;

        }
        Form _MainForm;
        public frmAccountSettings(Form MainForm)
        {
            _MainForm = MainForm;
            InitializeComponent();
        }

        private void frmAccountSettings_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            //int UserID = clsGlobal.User.UserID;
            int UserID = 15;
            frmUserInfo frm = new frmUserInfo(UserID);
            frm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            //int UserID = clsGlobal.User.UserID;
            int UserID = 15;
            frmChangeUserPassword frm = new frmChangeUserPassword(UserID);
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout.Invoke();
        }
    }
}
