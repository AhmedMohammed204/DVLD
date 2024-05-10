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
    public partial class frmChangeUserPassword : Form
    {
        private clsUser _User;
        List<TextBox> textBoxes = new List<TextBox>();
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();

            if (!clsUser.isUserExist(UserID))
            {
                MessageBox.Show("User doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            _User = clsUser.Find(UserID);
        }
        private void _LoadData()
        {
            ctrlButton1.btnTxt = "Save";
            ctrlButtonClose.btnTxt = "Cancel";
            ctrlUserInfo1.LoadUser(_User.UserID);

            txtCurrentPassword.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            textBoxes.Add(txtPassword);
            textBoxes.Add(txtConfirmPassword);
            textBoxes.Add(txtCurrentPassword);
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        public delegate void CloseWindowEventHandler();
        public event CloseWindowEventHandler CloseWindow;

        private void ctrlButtonClose_OnButtonClick(Button obj)
        {
            CloseWindow?.Invoke();
        }
        private bool _IsValidToSave()
        {

            if(!clsTextBoxValidationRequired.IsAllTextBoxesFill(textBoxes))
            {
                MessageBox.Show("You have to fill all gaps");
                return false;
            }

            if(_User.Password != txtCurrentPassword.Text)
            {
                MessageBox.Show("User current password is not true");
                return false;
            }

            if(txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password and Confirm password doesn't match");
                return false;
            }

            return true;
        }
        private void ctrlButton1_OnButtonClick(Button obj)
        {
            if (!_IsValidToSave())
                return;

            _User.Password = txtPassword.Text;

            if(!_User.Save())
            {
                MessageBox.Show("There was an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _LoadData();
        }
    }
}
