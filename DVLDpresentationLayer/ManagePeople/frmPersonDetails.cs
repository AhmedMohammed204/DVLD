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
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
            ctrlPersonInfo1.LoadPerson(PersonID);
            ctrlButton1.btnTxt = "Close";

        }

        private void ctrlButton1_OnButtonClick(Button obj)
        {
            this.Close();
        }
    }
}
