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
    public partial class frmMain
    {
        
        private void _OpenApplicationTypesForm()
        {
            frmApplicationTypes frm = new frmApplicationTypes();
            _OpenForm(frm);
        }
        private void btnApplicationTypes_Click(object sender, EventArgs e)
        {
            _OpenApplicationTypesForm();
        }
    }
    
}
