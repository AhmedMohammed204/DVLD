using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypesBusinessLayer;

namespace DVLD
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
        }
        private void _LoadData()
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            dgvTestTypes.DataSource = clsTestType.GetAllTestTypes();
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)dgvTestTypes.CurrentRow.Cells[0].Value;

            frmUpdateTestType frm = new frmUpdateTestType(TestTypeID);
            frm.ShowDialog();
            _LoadData();
        }

        public delegate void BackToApplicationsFormHandler();
        public event BackToApplicationsFormHandler BackToApplicationsForm;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToApplicationsForm?.Invoke();
        }
    }
}
