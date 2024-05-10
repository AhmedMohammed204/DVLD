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
        private void OperDriversScreen()
        {
            frmManageDrivers frm = new frmManageDrivers();
            _OpenForm(frm);
        }
        private void btnDrivers_Click(object sender, EventArgs e)
        {
            OperDriversScreen();
        }
    }
}
