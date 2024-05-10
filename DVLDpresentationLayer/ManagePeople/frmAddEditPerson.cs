using PeopleBusinessLayer;
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
    public partial class frmAddEditPerson : Form
    {
        int _PersonID;
        private void _LoadPersonIDLable()
        {
            if (_PersonID == -1)
                return;
            lblPersonID.Visible = true;
            lblPersonID.Text = _PersonID.ToString();
        }
        private void _LoadData()
        {
            if(_PersonID == -1)
                lblTitle.Text = "Add New Person";
            else
                lblTitle.Text = "Update Person";
            _LoadPersonIDLable();
            this.BackColor = clsColors.PrimaryColor;
            ctrlAddEditPeron1.LoadPerson(_PersonID);

        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _LoadData();
        }

        private void ctrlAddEditPeron1_onClickClose(bool obj)
        {
            this.Close();
        }

        private void ctrlAddEditPeron1_OnPersonAdded(int obj)
        {
            _PersonID = obj;
            _LoadData();

        }
    }
}
