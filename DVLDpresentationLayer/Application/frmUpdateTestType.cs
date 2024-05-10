using ApplicationTypesBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypesBusinessLayer;

namespace DVLD
{
    public partial class frmUpdateTestType : Form
    {
        List<TextBox> textBoxesList = new List<TextBox>();
        clsTestType TestType;
        int _TestType;
        public frmUpdateTestType(int ApplicationTypeID)
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
            _TestType = ApplicationTypeID;
        }
        void _LoadData()
        {
            TestType = clsTestType.Find(_TestType);

            if (TestType == null)
            {
                MessageBox.Show("Application not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }

            ctrlButton1.btnTxt = "Save";

            lblApplicationTypeID.Text = TestType.TestTypeID.ToString(); ;
            txtTitle.Text = TestType.TestTypeTitle;
            txtDescription.Text = TestType.TestTypeDescription;
            txtFees.Text = Convert.ToUInt32(TestType.TestTypeFees).ToString();

            textBoxesList.Add(txtTitle);
            textBoxesList.Add(txtFees);
            textBoxesList.Add(txtDescription);
            
        }
        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private bool IsValidToSave()
        {
            if (!clsTextBoxValidationRequired.IsAllTextBoxesFill(textBoxesList))
            {
                MessageBox.Show("You have to fill all text boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtFees.Text, out int number) && !Decimal.TryParse(txtFees.Text, out decimal DesNumber))
            {
                MessageBox.Show("Only numbers are exist in application fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFees.Focus();
                return false;
            }

            return true;
        }

        private void ctrlButton1_OnButtonClick(Button obj)
        {
            if (!IsValidToSave())
                return;

            TestType.TestTypeTitle = txtTitle.Text;
            TestType.TestTypeDescription = txtDescription.Text;
            TestType.TestTypeFees = Convert.ToDecimal(txtFees.Text);


            if (!TestType.Save())
            {
                MessageBox.Show("There was an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Update saved successfully!\n\nDo you want to close this page", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }

            }

            _LoadData();

        }
    }
}
