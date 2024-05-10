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
    public partial class frmUserInfo : Form
    {

        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            ctrlUserInfo1.LoadUser(UserID);
            this.BackColor = clsColors.PrimaryColor;
        }
    }
}
