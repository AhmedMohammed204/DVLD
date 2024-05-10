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
    public partial class ctrlDataGrid : UserControl
    {
        private DataTable _dt;
        private void FillDataGrid()
        {
            dgv.DataSource = _dt;
        }
        private void FillcbFilter()
        {
            cbFilter.Items.Clear();
            foreach (DataColumn Column in _dt.Columns)
            {
                cbFilter.Items.Add(Column.ToString());
            }
        }
        public void LoadData(DataTable dt)
        {
            _dt = dt;
            FillDataGrid();
            FillcbFilter();
        }
        public ctrlDataGrid()
        {
            InitializeComponent();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if(_dt == null)
            {
                MessageBox.Show("Please load data before fillter your txt");
                return;
            }
            if(string.IsNullOrEmpty(txtFilter.Text)||string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                dgv.DataSource = _dt;
                return;
            }
            clsFilterDgv.Filter(txtFilter.Text, cbFilter.Text, dgv, _dt);
        }


        public void AddContextMenuStrip(ContextMenuStrip contextMenuStrip)
        {
            dgv.ContextMenuStrip = contextMenuStrip;
        }


        public DataGridViewRow GetCurrentRow()
        {
            return dgv.CurrentRow;
        }
        public int GetFirstItemInRow()
        {
            return (int)GetCurrentRow().Cells[0].Value;
        }
    }
}
