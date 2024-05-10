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
    public partial class frmTestAppointment : Form
    {
        public frmTestAppointment(int TestAppointmentID, int LoaclApplicationID, int TestTypeID)
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
            ctrlTests1.LoadTestInfo(TestAppointmentID, LoaclApplicationID, TestTypeID);
        }
    }
}
