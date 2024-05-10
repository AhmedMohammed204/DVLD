using ApplicationsBusinessLayer;
using DVLD.Lib;
using LocalDrivingLicenseApplicationsBusinessLayer;
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
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {

        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        void _LoadData()
        {

            btnBack.FillColor = clsColors.DarkColor;
            btnBack.FillColor2 = clsColors.MidColor;
            lblTitle.ForeColor = clsColors.LightColor;
            ctrlButton1.btnTxt = "Add New";
            ctrlDataGrid1.LoadData(clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplicationsMaster());
            ctrlDataGrid1.AddContextMenuStrip(contextMenuStrip);
        }
        

        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void ctrlButton1_OnButtonClick(Button obj)
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(1);
            frm.ShowDialog();
            _LoadData();
        }

        private void canselToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDringLicenseApplicationID = ctrlDataGrid1.GetFirstItemInRow();
            if(MessageBox.Show($"Are you sure you want to cansle application {LocalDringLicenseApplicationID} ?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsApplication application = clsApplication.Find(    clsLocalDrivingLicenseApplication.Find(LocalDringLicenseApplicationID).ApplicationID );
            application.ApplicationStatus = 2;
            if(!application.Save())
            {
                MessageBox.Show("There was an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Application cansled successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _LoadData();
        }

        private void DisabailAllTests()
        {
            visionTestToolStripMenuItem.Enabled = false;
            writtenTestToolStripMenuItem.Enabled= false;
            streetTestToolStripMenuItem.Enabled= false;
        }

        private void _PerformScedualTest(DataGridViewCellCollection Application)
        {
            if (Application["Status"].Value.ToString() != "New" || Application["PassedTestCount"].Value.ToString() == "3")
            {
                MIScedualTest.Enabled = false;


                return;
            }
            MIScedualTest.Enabled = true;

            if (Application["PassedTestCount"].Value.ToString() == "0")
            {
                DisabailAllTests();
                visionTestToolStripMenuItem.Enabled = true;

            }
            else if (Application["PassedTestCount"].Value.ToString() == "1")
            {
                DisabailAllTests();
                writtenTestToolStripMenuItem.Enabled = true;
            }
            else if (Application["PassedTestCount"].Value.ToString() == "2")
            {
                DisabailAllTests();
                streetTestToolStripMenuItem.Enabled = true;
            }
            else
                DisabailAllTests();


        }
        private void _PerfromCanselMenuItem(DataGridViewCellCollection Application)
        {
            if (Application["Status"].Value.ToString() != "New")
            {
                canselToolStripMenuItem.Enabled = false;
            }else
            {
                canselToolStripMenuItem.Enabled = true;
            }
        }
        private void _PerformIssuDrivingLicense(DataGridViewCellCollection Application)
        {
            if (Application["Status"].Value.ToString() == "New" && Application["PassedTestCount"].Value.ToString() == "3")
                issuDrivingLicenseToolStripMenuItem.Enabled = true;
            else
                issuDrivingLicenseToolStripMenuItem.Enabled = false;
        }
        private void _PerformDeleteApplication(DataGridViewCellCollection Application)
        {
            if (Application["Status"].Value.ToString() != "Completed")
                deleteToolStripMenuItem.Enabled = true;
            else
                deleteToolStripMenuItem.Enabled = false;
        }
        private void _OpenContextMenuStrip(DataGridViewCellCollection Application)
        {
            _PerfromCanselMenuItem(Application);
            _PerformScedualTest(Application);
            _PerformIssuDrivingLicense(Application);
            _PerformDeleteApplication(Application);

        }
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            DataGridViewCellCollection Application = ctrlDataGrid1.GetCurrentRow().Cells;
            _OpenContextMenuStrip(Application);
        
        }
        void _OpenTestWindow(int TestTypeID)
        {
            int LocalApplicationID = (int)ctrlDataGrid1.GetCurrentRow().Cells[0].Value;
            frmAllTests frm = new frmAllTests(LocalApplicationID, TestTypeID);
            frm.ShowDialog();
            _LoadData();
        }
        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenTestWindow(1);
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenTestWindow(2);
        }

        private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenTestWindow(3);
        }

        private void issuDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalApplicationID = (int)ctrlDataGrid1.GetCurrentRow().Cells[0].Value;
            frmIssuDrivingLicense frm = new frmIssuDrivingLicense(LocalApplicationID);
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalApplicationID = (int)ctrlDataGrid1.GetCurrentRow().Cells[0].Value;
            if (MessageBox.Show($"Are you sure you want to delete this application {LocalApplicationID}?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(LocalApplicationID);
            _LoadData();

        }

        public delegate void BakcToApplicationsFormHandler();
        public event BakcToApplicationsFormHandler BakcToApplicationsForm;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BakcToApplicationsForm?.Invoke();
        }
    }
}
