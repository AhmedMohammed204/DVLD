using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        void _LoadTestTypeData()
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            _OpenForm(frm);
        }
        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            _LoadTestTypeData();
        }
    }
}
