using ApplicationsBusinessLayer;
using LicensesBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public static class clsSave
    {

        public static bool SaveApplication(ref int applicationID, ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1,Label lblApplicationDate, Label Fees)
        {

            clsApplication application = new clsApplication();

            application.ApplicantPersonID = ctrlLicenseInfoWithFilter1.LicenseInfo.Person.PersonID;
            application.ApplicationTypeID = clsApplicationTypes.RenewLicenseService;
            application.ApplicationStatus = 3;
            application.LastStatusDate = Convert.ToDateTime(lblApplicationDate.Text);
            application.ApplicationDate = Convert.ToDateTime(lblApplicationDate.Text);
            application.PaidFees = Convert.ToInt32(Fees.Text);
            application.CreatedByUserID = 1;

            if (!application.Save())
            {
                MessageBox.Show("There was a problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            applicationID = application.ApplicationID;
            return true;
        }
        public static bool SaveApplication(ref int applicationID, ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1, DateTime ApplicationDate, int Fees)
        {
            Label lblApplicationDate = new Label();
            lblApplicationDate.Text = ApplicationDate.ToShortDateString();
            Label lblFees = new Label();
            lblFees.Text = Fees.ToString();
            return clsSave.SaveApplication(ref applicationID, ctrlLicenseInfoWithFilter1, lblApplicationDate, lblFees);
        }
        public static bool UnActiveOldLicense(clsLicense OldLicense)
        {
            OldLicense.IsActive = false;

            if (!OldLicense.Save())
            {
                MessageBox.Show("There was a problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool AddNewLicense(ref int NewLicenseID, int ApplicationID, byte Reason, ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1
            , int LicenseClassID, DateTime ExpirationDate,  Label txtNotes ,Label lblLicenseFees)
        {
            clsLicense NewLicense = new clsLicense();
            NewLicense.ApplicationID = ApplicationID;
            NewLicense.DriverID = ctrlLicenseInfoWithFilter1.LicenseInfo.driver.DriverID;
            NewLicense.LicenseClass = LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = ExpirationDate;
            NewLicense.Notes = txtNotes.Text;
            NewLicense.PaidFees = Convert.ToInt32(lblLicenseFees.Text);
            NewLicense.IsActive = true;
            NewLicense.IssueReason = Reason;
            NewLicense.CreatedByUserID = clsGlobal.User.UserID;

            if (!NewLicense.Save())
            {
                MessageBox.Show("There was a problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show($"License Issued Seccussfully! with ID = {NewLicense.LicenseID}", "Done");
                ctrlLicenseInfoWithFilter1.Enabled = false;
                NewLicenseID = NewLicense.LicenseID;
                return true;
            }
        }
    }

}
