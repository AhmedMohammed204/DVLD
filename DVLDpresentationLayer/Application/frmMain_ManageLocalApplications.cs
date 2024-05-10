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
        void _LoadManageLocalApplicationsForm()
        {
            frmManageLocalDrivingLicenseApplications frm = new frmManageLocalDrivingLicenseApplications();
            _OpenForm(frm);
        }
        private void btnManageLocalApplications_Click(object sender, EventArgs e)
        {
            _LoadManageLocalApplicationsForm();
        }
    }
}
