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

namespace DVLD
{
    public partial class frmUpdateApplicationType : Form
    {
        List<TextBox> textBoxesList = new List<TextBox>();

        clsApplicationType ApplicationType;
        void SetColorForLables()
        {
            lblApplicationTypeID.ForeColor = clsColors.DarkColor;
        }
        void _LoadData()
        {
            SetColorForLables();
            if (ApplicationType == null)
            {
                MessageBox.Show("Application is not availbal");
                this.Close();
                return;
            }
            textBoxesList.Add(txtTitle);
            textBoxesList.Add(txtFees);
            
            lblApplicationTypeID.Text = ApplicationType.ApplicationTypeID.ToString();
            txtTitle.Text = ApplicationType.ApplicationTypeTitle;
            
            ctrlButton1.btnTxt = "Save";
            txtFees.Text = Convert.ToInt32( ApplicationType.ApplicationFees).ToString();
            
            
        }
        public frmUpdateApplicationType(int ApplicationID)
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;

            ApplicationType = clsApplicationType.Find(ApplicationID);
            

            _LoadData();
        }
        private bool IsValidToSave()
        {
            if(!clsTextBoxValidationRequired.IsAllTextBoxesFill(textBoxesList))
            {
                MessageBox.Show("You have to fill all text boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!int.TryParse(txtFees.Text, out int number) && !Decimal.TryParse(txtFees.Text, out decimal DesNumber))
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

            ApplicationType.ApplicationTypeTitle = txtTitle.Text;
            ApplicationType.ApplicationFees = Convert.ToDecimal(txtFees.Text);
            if(!ApplicationType.Save())
            {
                MessageBox.Show("There was an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(MessageBox.Show("Update saved successfully!\n\nDo you want to close this page", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }

            }

            _LoadData();
        }
    }
}
