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
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew = 1, Update = 2}
        enMode _Mode;
        private int _UserID;
        private int _PersonID;
        private clsUser _User;
        private void _LoadTitle()
        {
            string Title = "Add New User";
            if (_Mode == enMode.Update)
                Title = "Update User";

            this.Text = Title;
            lblTitle.Text = Title;
        }
        private void _LoadData()
        {
            ctrlButtonClose.btnTxt = "Close";
            ctrlButtonSave.btnTxt = "Save";
            _LoadTitle();
            if(_Mode == enMode.AddNew )
            {
                _User = new clsUser();

                return;
            }
            _User = clsUser.Find(_UserID);
            if (_User == null)
                return;
            gbUserInfo.Enabled = true;
            txtUsername.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsAcvite;
            _PersonID = _User.PersonID;
            ctrlFindPerson2.Find(_PersonID);
            ctrlFindPerson2.UpdateMode();
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

        }

        
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {

            _LoadData();
        }
        private void ResetUserData()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cbIsActive.Checked = false;
        }
        private void ctrlFindPerson2_OnPersonFound(int obj)
        {
            int PersonID = obj;
            if(clsUser.isUserExistByPersonID(PersonID) && _Mode == enMode.AddNew)
            {
                ResetUserData();
                gbUserInfo.Enabled = false;
                MessageBox.Show("This person has already user exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gbUserInfo.Enabled = true;
            txtUsername.Focus();
            _PersonID = PersonID;
        }
        private bool _IsValidToSave()
        {
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("You have to fill all text boxes", "Error", MessageBoxButtons.OK); 
                return false;
            }
            
            if(clsUser.isUserExist(txtUsername.Text) && _Mode == enMode.AddNew)
            {

                MessageBox.Show("Username is already exist", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {

                MessageBox.Show("Password doesn't match", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        private void ctrlButtonSave_OnButtonClick(Button obj)
        {
            if (!_IsValidToSave())
                return;

            _User.UserName = txtUsername.Text;
            _User.Password = txtPassword.Text;
            _User.PersonID = _PersonID;
            _User.IsAcvite = cbIsActive.Checked;
            if (!_User.Save())
            {
                MessageBox.Show("User doesn't save", "Error", MessageBoxButtons.OK);
                return;
            }
            else
                MessageBox.Show("User saved successfully !", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _Mode = enMode.Update;
            _UserID = _User.UserID;
            _LoadData();
        }

        public delegate void CloseWindowHandler();
        public event CloseWindowHandler CloseWindow;
        private void ctrlButtonClose_OnButtonClick(Button obj)
        {
            CloseWindow?.Invoke();
        }
    }
}
