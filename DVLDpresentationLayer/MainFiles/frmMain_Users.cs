using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainV2 : Form
    {        //Manage users
        private void btnUsers_Click(object sender, EventArgs e)
        {
            _OpenManageUsersForm();
        }
        private void _OpenManageUsersForm()
        {

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


    }
}
