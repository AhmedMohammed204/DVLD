using DetainedLicensesBusinessLayer;
using DriversBusinessLayer;
using DVLD.Properties;
using LicenseClassesBusinessLayer;
using LicensesBusinessLayer;
using PeopleBusinessLayer;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlLicenseInfo : UserControl
    {
        clsPerson person;
        clsLisenceClass LisenceClass;
        clsLicense License;
        clsDriver Driver;


        public clsPerson Person { get { return this.person; } }
        public clsLisenceClass lisenceClass { get { return this.LisenceClass; } }
        public clsLicense license { get { return this.License; } }
        public clsDriver driver { get { return this.Driver; } }


        public ctrlLicenseInfo()
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
        string GetIssueReeason(int Reason)
        {
            switch(Reason)
            {
                case 1:
                    return "First Time";
                case 2:
                    return "Renew License";
                case 3:
                    return "Damaged License";
                case 4:
                    return "Lost License";
                default:
                    return "";
            }
        }
        void FillLicenseData()
        {
            lblClassName.Text = LisenceClass.ClassName;
            lblLicenseID.Text = License.LicenseID.ToString();
            lblIssueDate.Text = License.IssueDate.ToShortDateString();
            lblIssueReason.Text = GetIssueReeason( License.IssueReason);
            lblNote.Text = License.Notes == null ? "No notes" : License.Notes;
            lblIsActive.Text = License.IsActive.ToString();
            lblExpirationDate.Text = License.ExpirationDate.ToShortDateString();
            lblDriverID.Text = License.DriverID.ToString();
            LoadDetaindLicense();
        }
        void LoadDetaindLicense()
        {
            if(clsDetain.isDetainExistByLicenseID(License.LicenseID))
                lblIsDetaind.Text = "Yes";
            else
                lblIsDetaind.Text = "No";
        }
        private void FillData()
        {
            FillPersonData();
            FillLicenseData();
        }
        public void LoadLicense(int LicenseID)
        {
            License = clsLicense.Find(LicenseID);
            if (License == null)
            {
                MessageBox.Show("License doesn't found");
                return;
            }
            Driver = clsDriver.Find(License.DriverID);
            person = clsPerson.Find(Driver.PersonID);
            LisenceClass = clsLisenceClass.Find(License.LicenseClass);
            FillData();
        }
    }
}
