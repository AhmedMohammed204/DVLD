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
    public partial class ctrlUserInfo : UserControl
    {
        private clsUser User;

        public void LoadUser(int UserID)
        {
            if(!clsUser.isUserExist(UserID))
            {
                MessageBox.Show("User Doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User = clsUser.Find(UserID);
            lblUserID.Text = User.UserID.ToString();
            lblUsername.Text = User.UserName.ToString();
            lblIsActive.Text = User.IsAcvite.ToString();
            ctrlPersonInfo1.LoadPerson(User.PersonID);
        }
        public ctrlUserInfo()
        {
            InitializeComponent();
            
        }
    }
}
