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
    public partial class frmMain : Form
    {
        public delegate void DataBackEventHandler(object sernder, bool CloseAllApplication);
        public event DataBackEventHandler DataBack;
        Form activeForm = null;
        private void _SetPageName(string name)
        {
            lblPageName.Text = name;
        }
        List<Button> ListOfButtons;
        private void _FillListOfButtons()
        {

            foreach (var Control in panelLeftSide.Controls)
            {
                if(Control is Button)
                    ListOfButtons.Add((Button)Control);
            }
            
        }
        private void _ResetAllButtonsColor()
        {
            foreach (Button btn in ListOfButtons)
            {
                btn.BackColor = Color.Transparent;
            }
        }
        private bool _CloseAllApplication = true;
        private void _LoadData()
        {
            ListOfButtons = new List<Button>();
            panelChildForm.BackColor = clsColors.PrimaryColor;
            panelLeftSide.BackColor = clsColors.MidColor;
            panelTop.BackColor = clsColors.MidColor;
            panel1.BackColor = clsColors.DarkColor;
            panelAccountSubMenu.BackColor = clsColors.DarkColor;
            panelApplications.BackColor = clsColors.DarkColor;
            panelDrivingLicenseServices.BackColor = clsColors.MidColor;
            panelManageApplication.BackColor = clsColors.MidColor;
            panelAddNewDrivingLicense.BackColor = clsColors.DarkColor;
            panelAccountSubMenu.Visible = false;

            _FillListOfButtons();
        }
        public frmMain()
        {
            InitializeComponent();
            _LoadData();
            this.WindowState = FormWindowState.Maximized;

            //ctrlPersonInfo1.LoadPerson(clsGlobal.User.PersonID);
        }
        private void _ButtonSelected(Button btn)
        {
            _ResetAllButtonsColor();
            btn.BackColor = clsColors.PrimaryColor;
        }
        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            _ButtonSelected((Button)sender);
            panelAccountSubMenu.Visible = !(panelAccountSubMenu.Visible);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            _CloseAllApplication = false;
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this, _CloseAllApplication);
        }
        private void _OpenForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();




        }

        private void _OpenManageUsersForm()
        {
            _ButtonSelected(btnUsers);
            frmManageUsers frm = new frmManageUsers();
            frm.AddUser += _OpenAddUserForm;
            frm.UpdateUser += _OpenUpdateUserForm;
            frm.UserInfo += _OpenUserInfoForm;
            frm.ChangePassword += _OpenChangePasswordForm;
            _OpenForm(frm);
        }
        private void _OpenUserInfoForm(int UserID)
        {
            frmUserInfo frm = new frmUserInfo(UserID);
            _OpenForm(frm);
        }
        private void _BackToManageUsers()
        {
            _OpenManageUsersForm();
        }
        private void _OpenUpdateUserForm(int UserID, int PersonID)
        {
            frmAddEditUser frm = new frmAddEditUser(UserID);
            frm.CloseWindow += _BackToManageUsers;

            _OpenForm(frm);
        }
        private void _OpenAddUserForm(object sender)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.CloseWindow += _BackToManageUsers;
            
            _OpenForm(frm);
            
        }
        private void _OpenChangePasswordForm(int UserID)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(UserID);
            frm.CloseWindow += _BackToManageUsers;
            _OpenForm(frm);
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            _SetPageName("Manage Users");
            _OpenManageUsersForm();
        }

        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            _SetPageName("Current User Info");
            _OpenUserInfoForm(clsGlobal.User.UserID);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            _OpenChangePasswordForm(clsGlobal.User.UserID);
        }

        private void panelLeftSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _ButtonSelected(btn);
            panelApplications.Visible = !(panelApplications.Visible);
        }

        

        private void btnDrivingLicenseServices_Click(object sender, EventArgs e)
        {
            panelDrivingLicenseServices.Visible = !(panelDrivingLicenseServices.Visible);
        }

        private void btnAddNewDrivingLicense_Click(object sender, EventArgs e)
        {
            panelAddNewDrivingLicense.Visible = !(panelAddNewDrivingLicense.Visible);
        }


        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            panelManageApplication.Visible = !(panelManageApplication.Visible);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewInternationalDrivingLicense frm = new frmNewInternationalDrivingLicense();
            _OpenForm(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicenses frm = new frmManageInternationalLicenses();
            _OpenForm(frm);
        }
    }
}
