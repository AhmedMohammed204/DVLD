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
    public partial class ctrlLicenseInfoWithFilter : UserControl
    {
        public ctrlLicenseInfo LicenseInfo
        {
            get { return this.ctrlLicenseInfo1; }
        }




        public event Action<int> OnLicenseSelected;
        void LicenseSelected(int LicenseID)
        {
            Action <int> handler = OnLicenseSelected;
            if(handler != null)
                handler(LicenseID);
        }
        public ctrlLicenseInfoWithFilter()
        {
            InitializeComponent();
            btnFind.btnTxt = "Find";
        }
        bool IsValidToFind()
        {
            if(string.IsNullOrEmpty(txtLicenseID.Text))
                return false;
            if(! int.TryParse(txtLicenseID.Text, out int id) )
            {
                MessageBox.Show("Only numbers are allow!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public void FilterAbility(bool filterAbility)
        {
            gbFilters.Enabled = filterAbility;
        }
        public void Find(int LicenseID)
        {
            ctrlLicenseInfo1.LoadLicense(LicenseID);
            gbFilters.Enabled = false;
            txtLicenseID.Text = LicenseID.ToString();
        }
        private void btnFind_OnButtonClick(Button obj)
        {
            if(!IsValidToFind()) return;
            int LicenseID = Convert.ToInt32(txtLicenseID.Text);
            Find(LicenseID);
            if (this.LicenseInfo.license == null)
                return;
            LicenseSelected(LicenseID);
        }
    }
}
