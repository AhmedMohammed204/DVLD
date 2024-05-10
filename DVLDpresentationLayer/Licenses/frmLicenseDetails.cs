using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmLicenseDetails : Form
    {
        public frmLicenseDetails(int LicenseID)
        {
            InitializeComponent();

            ctrlLicenseInfo1.LoadLicense(LicenseID);
        }
    }
}
