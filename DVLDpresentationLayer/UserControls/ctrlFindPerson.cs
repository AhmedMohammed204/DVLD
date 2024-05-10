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
    public partial class ctrlFindPerson : UserControl
    {
        public event Action<int> OnPersonFound;
        protected virtual void PersonFound(int PersonID)
        {
            Action<int> handler = OnPersonFound;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        private void _LoadData()
        {
            cbFilter.SelectedIndex = 0;
        }
        public ctrlFindPerson()
        {
            InitializeComponent();
            _LoadData();
        }
        private void _FindPerson()
        {
            if (cbFilter.SelectedItem.ToString() == "National No.")
                ctrlPersonInfo1.LoadPerson(txtFilter.Text);
            else
                ctrlPersonInfo1.LoadPerson(int.Parse(txtFilter.Text));

        }
        private void pbFindUser_Click(object sender, EventArgs e)
        {
            _FindPerson();
        }

        private void ctrlPersonInfo1_OnPersonSelected(int obj)
        {
            int PersonID = obj;
            if(PersonID == -1)
            {
                MessageBox.Show("User doesn't defind", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (OnPersonFound != null)
                OnPersonFound(PersonID);
        }

        public void Find(string NationalNo)
        {
            ctrlPersonInfo1.LoadPerson(NationalNo);
        }
        public void Find(int PersonID)
        {
            cbFilter.SelectedItem = "PersonID";
            ctrlPersonInfo1.LoadPerson(PersonID);
            txtFilter.Text = PersonID.ToString();
        }
        public void UpdateMode()
        {
            txtFilter.Enabled = false;
            cbFilter.Enabled = false;
            pbFindUser.Enabled = false;
            pbAddPerson.Enabled = false;
        }
        
        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
