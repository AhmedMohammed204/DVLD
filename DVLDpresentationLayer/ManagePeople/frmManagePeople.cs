using PeopleBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
            dgvPeople.BackgroundColor = clsColors.PrimaryColor;
            ctrlButton1.btnTxt = "Add New";
            dgvPeople.GridColor = clsColors.MidColor;
        }
        private void Fill_cbFiltertems()
        {
            cbFilter.Items.Clear();
            DataTable dt = clsPerson.GetAllPeople();
            foreach (DataColumn Column in dt.Columns)
            {
                cbFilter.Items.Add(Column.ToString());
            }
            cbFilter.SelectedItem = null;
        }
        private void _LoadData()
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            ctrlButtonClose.btnTxt = "Close";
            dgvPeople.DataSource = clsPerson.GetAllPeople();
            Fill_cbFiltertems();
            lblTotalRecords.Text = dgvPeople.RowCount.ToString();
            txtFilter.Visible = false;
            txtFilter.ForeColor = clsColors.HeavyDarkColor;
        }
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;
            txtFilter.Clear();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            clsFilterDgv.Filter(txtFilter.Text, cbFilter.Text, dgvPeople, clsPerson.GetAllPeople());
        }
        private void _AddPersonForm()
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            _LoadData();
        }
        private void ctrlButton1_OnButtonClick(Button obj)
        {
            _AddPersonForm();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            if(MessageBox.Show($"Are you sure you want to delete {PersonID}", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(!clsPerson.DeletePerson(PersonID))
                {
                    MessageBox.Show("Sorry, I couldn't delete this person bcause he/she has a reference with another table", "Sorry",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _LoadData();
            }
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
            _LoadData();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddPersonForm();
        }

        private void ctrlButtonClose_OnButtonClick(Button obj)
        {
            this.Close();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
