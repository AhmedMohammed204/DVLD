using ApplicationsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAppointments_ViewBusinessLayer;
using TestAppointmentsBusinessLayer;
using TestsBusinessLayer;

namespace DVLD
{
    public partial class frmAllTests : Form
    {
        private int LoaclApplicationID;
        int TestTypeID;
        public frmAllTests(int LoaclApplicationID, int TestTypeID)
        {
            InitializeComponent();
            this.BackColor = clsColors.PrimaryColor;
            ctrlApplicationInfo1.LoadApplication(LoaclApplicationID);
            this.LoaclApplicationID = LoaclApplicationID;
            this.TestTypeID = TestTypeID;


        }
        void PerformTestType()
        {
            switch(TestTypeID)
            {
                case 1:
                    lblTitle.Text = "Vision Test";
                    break;
                case 2:
                    lblTitle.Text = "Writing Test";
                    break;
                default:
                    lblTitle.Text = "Street Test";
                    break;
            }
        }
        void LoadTestsList()
        {
            DataView dv =  clsTestAppointment.GetAllTestAppointments(LoaclApplicationID, TestTypeID);
            
            dgvAppointments.DataSource = dv;
        }
        void LoadData()
        {
            
            
            LoadTestsList();

            btnAddTest.btnTxt = "Add New";
            PerformTestType();

        }
        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        bool IsApplicationCompleted()
        {
            foreach (DataGridViewRow Row in dgvAppointments.Rows)
            {
                if ((bool)Row.Cells["IsLocked"].Value == false)
                {
                    MessageBox.Show("Sorry but this applicant has already uncompleted application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;
        }
        bool IsReadyToAdd()
        {
            if(clsTest.IsTestApplicantPassed(LoaclApplicationID, TestTypeID))
            {
                MessageBox.Show("This applicaint has already completed this test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (!IsApplicationCompleted())
                return false;

            return true;
        }
        void OpenTestAppointmentForm(int TestAppointmentID = -1)
        {
            if (TestAppointmentID == -1)
                if(!IsReadyToAdd())
                    return;


            frmTestAppointment frm = new frmTestAppointment(TestAppointmentID, LoaclApplicationID, TestTypeID);
            frm.ShowDialog();
            LoadData();

        }
        private void btnAddTest_OnButtonClick(Button obj)
        {
            OpenTestAppointmentForm();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            frmTakeTest frm = new frmTakeTest(TestAppointmentID, LoaclApplicationID, TestTypeID);
            frm.ShowDialog();
            LoadData();
            
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            OpenTestAppointmentForm(TestAppointmentID);
        }
    }
}
