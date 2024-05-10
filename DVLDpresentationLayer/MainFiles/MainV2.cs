using DVLD.Lib;
using DVLD.Licenses;
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
    public partial class MainV2 : Form
    {
        public delegate void DataBackEventHandler(object sernder, bool CloseAllApplication);
        public event DataBackEventHandler DataBack;
        bool CloseAllApplication = true;
        
        Form activeForm = null;
        void LoadData()
        {
            lblTitle.ForeColor = clsColors.LightColor;
            clsChangeControlsColor.ChangeGunaButtonsColor(PanelBody);
            PanelBody.FillColor2 = clsColors.LightColor;
            this.WindowState = FormWindowState.Maximized;

        }
        public MainV2()
        {
            InitializeComponent();
        }
        private void MainV2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void _OpenForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelBody.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();



        }





        //Account Settings
        void LogoutHandler()
        {
            CloseAllApplication = false;
            this.Close();
        }
        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            frmAccountSettings frm = new frmAccountSettings(this);
            frm.Logout += LogoutHandler;
            _OpenForm(frm);
        }
        private void MainV2_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this,CloseAllApplication);
        }





        //People
        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            _OpenForm(frm);

        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();
            _OpenForm(frm);
        }


    }
}
