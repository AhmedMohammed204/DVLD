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


        void _LoadAddNewLocalApplicationForm()
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(1);
            _OpenForm(frm);
        }
        private void btnAddLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            _LoadAddNewLocalApplicationForm();
        }
    }
}
