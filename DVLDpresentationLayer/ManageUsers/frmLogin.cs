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

namespace DVLD
{
    public partial class frmLogin : Form
    {
        private string FilePath = @"./RememberMe.txt";

        public frmLogin()
        {
            InitializeComponent();
            ctrlBtnLogin.btnTxt = "Login!";
            this.BackColor = clsColors.PrimaryColor;
            btnClose.FlatAppearance.MouseOverBackColor = clsColors.DarkColor;
        }
        private void _LoadData()
        {
            string[]UserData = File.ReadAllLines(FilePath);
            if (UserData.Length > 0)
            {
                txtUsername.Text = UserData[0];
                txtPassword.Text = UserData[1];
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
            if (cbRememberMe.Checked)
            {
                string[] Content = { txtUsername.Text ,  txtPassword.Text };
                File.WriteAllText(FilePath, $"{txtUsername.Text}\n{txtPassword.Text}");
            }else
            {
                File.WriteAllText(FilePath, string.Empty);
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
