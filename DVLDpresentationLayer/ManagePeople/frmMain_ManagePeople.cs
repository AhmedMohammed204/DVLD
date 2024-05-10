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
        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            _SetPageName("Manage People");
            _ButtonSelected((Button)sender);
            frmManagePeople frm = new frmManagePeople();
            _OpenForm(frm);

        }
    }
}
