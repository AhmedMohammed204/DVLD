using DriversBusinessLayer;
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
    public partial class frmManageDrivers : Form
    {
        void LoadData()
        {
            lblTitle.ForeColor = clsColors.LightColor;
            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            ctrlDataGrid1.LoadData(clsDriver.GetAllDriversView());
        }
        public frmManageDrivers()
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
