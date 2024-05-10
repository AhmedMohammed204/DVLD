using DriversBusinessLayer;
using DVLD.Properties;
using InternationalLicensesBusinessLayer;
using LicensesBusinessLayer;
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

namespace DVLD.UserControls
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        clsPerson person;
        clsDriver driver;
        clsInternationalLicense internationalLicense;
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
            this.BackColor = clsColors.MidColor;
        }
        string GetFullNameData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{person.FirstName} {person.SecondName} ");
            sb.Append(person.ThirdName == null ? string.Empty : person.ThirdName);
            sb.Append(person.LastName);
            return sb.ToString();
        }
        void SetPersonImage()
        {
            if (person.ImagePath != null)
            {
                pbPersonPicture.ImageLocation = person.ImagePath;
                return;
            }
            if (person.Gendor == 'M')
            {
                pbPersonPicture.Image = Resources.Unknown_man;
            }
            else
            {
                pbPersonPicture.Image = Resources.Unknown_woman;
            }
        }
        void FillPersonData()
        {
            lblName.Text = GetFullNameData();
            lblNationalNo.Text = person.NationalNo.ToString();
            lblGender.Text = person.Gendor == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
            SetPersonImage();
        }
        
        void FillLicenseDate()
        {
            lblInternationalLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = internationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = internationalLicense.IssueDate.ToShortDateString();
            lblExpirationDate.Text = internationalLicense.ExpirationDate.ToShortDateString();
            lblApplicationID.Text = internationalLicense.ApplicationID.ToString();
            lblIsActive.Text = internationalLicense.IsActive.ToString();
            lblDriverID.Text = internationalLicense.DriverID.ToString();
        }
        void FillData()
        {
            FillPersonData();
            FillLicenseDate();
        }
        public void LoadLicenseInfo(int internationalLicenseID)
        {
            internationalLicense = clsInternationalLicense.Find(internationalLicenseID);
            if(internationalLicense == null)
            {
                MessageBox.Show("License doesn't found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            driver = clsDriver.Find(internationalLicense.DriverID);
            person = clsPerson.Find(driver.PersonID);
            FillData();


        }
    }
}
