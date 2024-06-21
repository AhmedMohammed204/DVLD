using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD
{

    public partial class frmLogin : Form
    {
        private string ApplicationName = "DVLD";
        public frmLogin()
        {
            InitializeComponent();
            ctrlBtnLogin.btnTxt = "Login!";
            this.BackColor = clsColors.PrimaryColor;
            btnClose.FlatAppearance.MouseOverBackColor = clsColors.DarkColor;
        }
        private void _LoadData()
        {
            WinRegistries registries = new WinRegistries(ApplicationName, WinRegistries.enHKEY.HKEY_CURRENT_USER);
            string Username = registries.Get("Username");
            string Password = registries.Get("Password");
            
            if (Username != string.Empty && Password != string.Empty)
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                cbRememberMe.Checked = true;
                ctrlBtnLogin.Focus();
            }
            else
            {
                txtPassword.Clear();
                txtUsername.Clear();
                cbRememberMe.Checked = false;
                ctrlBtnLogin.Focus();
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            _LoadData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this. Close();
        }
        bool IsUserAccessToLogin()
        {
            
            if (!(clsUser.isUserExist(txtUsername.Text)) || !(clsUser.Find(txtUsername.Text).Password == txtPassword.Text))
            {
                MessageBox.Show("Username or Password is not true");
                return false;
            }
            clsUser User = clsUser.Find(txtUsername.Text);
            if (!User.IsAcvite)
            {
                MessageBox.Show("User is not active");
                return false;
            }

            return true;
        }
        void PerformRememberMe()
        {
            WinRegistries registries = new WinRegistries(ApplicationName, WinRegistries.enHKEY.HKEY_CURRENT_USER);
            if (cbRememberMe.Checked)
            {
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                if (!registries.SetVelue("Username", Username) || !registries.SetVelue("Password", Password))
                    MessageBox.Show("There was an Error", "Error");
            }else
            {
                if (!registries.SetVelue("Username", string.Empty) || !registries.SetVelue("Password", string.Empty))
                    MessageBox.Show("There was an Error", "Error");
            }
        }
        private void frmMainDataBack(object sender, bool CloseAllApplication)
        {
            if (CloseAllApplication)
                this.Close();
            else
            {
                PerformRememberMe();
                _LoadData();
                this.Show();
            }
        }
        private void ctrlBtnLogin_OnButtonClick(Button obj)
        {
            if(!IsUserAccessToLogin())
                return;


            PerformRememberMe();
            clsGlobal.User = clsUser.Find(txtUsername.Text);
            this.Hide();
            MainV2 frm = new MainV2();
            frm.DataBack += frmMainDataBack;
            frm.ShowDialog();

            
        }
    }
}
