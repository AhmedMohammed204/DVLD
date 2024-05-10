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
    public partial class frmManageUsers : Form
    {
        private DataTable DtUsersMaster = clsUser.GetAllUsersMaster();

        public delegate void AddUserEventHandler(object sender);
        public event AddUserEventHandler AddUser;
        
        public delegate void UpdateUserEventHandler(int UserID, int PersonID);
        public event UpdateUserEventHandler UpdateUser;

        public delegate void UserInfoEventHandler(int UserID);
        public event UserInfoEventHandler UserInfo;

        public delegate void ChangePasswordEventHandler(int UserID);
        public event ChangePasswordEventHandler ChangePassword;

        private void _RefreshDgv()
        {
            dgvUsers.DataSource = clsUser.GetAllUsersMaster();
            dgvUsers.Columns[2].Width = 430;

        }
        private void _FillCbFillter()
        {
            DataTable dt = DtUsersMaster;

            foreach (DataColumn Column in dt.Columns)
            {
                cbFilter.Items.Add(Column.ColumnName);
            }

        }
        private void _LoadData()
        {
            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            _RefreshDgv();
            _FillCbFillter();
            ctrlButtonAddUser.btnTxt = "Add User";
        }
        public frmManageUsers()
        {
            InitializeComponent();
            _LoadData();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;
            txtFilter.Clear();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            clsFilterDgv.Filter(txtFilter.Text, cbFilter.Text, dgvUsers, clsUser.GetAllUsersMaster());
        }

        private void ctrlButtonAddUser_OnButtonClick(Button obj)
        {
            AddUser?.Invoke(this);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int PersonID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            UpdateUser?.Invoke(UserID, PersonID);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if(MessageBox.Show($"Are you sure you want to delete this user [{UserID}] ?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question)  == DialogResult.Yes)
            {
                if(!clsUser.DeleteUser(UserID))
                    MessageBox.Show("User doesn't deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            _LoadData();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser?.Invoke(this);
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            UserInfo?.Invoke(UserID);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            ChangePassword?.Invoke(UserID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
