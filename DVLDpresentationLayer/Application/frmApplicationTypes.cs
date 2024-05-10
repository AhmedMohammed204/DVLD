using ApplicationTypesBusinessLayer;
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
    public partial class frmApplicationTypes : Form
    {

        public delegate void BackToApplicationTypesEventHandler();
        public event BackToApplicationTypesEventHandler BackToApplicationTypes;
        private void _FillDataGridView()
        {
            dgvApplications.DataSource = clsApplicationType.GetAllApplicationTypes();
            
        }
        private void _LoadData()
        {
            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            _FillDataGridView();
        }
        public frmApplicationTypes()
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
            _LoadData();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            frmUpdateApplicationType frm = new frmUpdateApplicationType(ApplicationID);
            frm.ShowDialog();

            _LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToApplicationTypes?.Invoke();
        }
    }
}
