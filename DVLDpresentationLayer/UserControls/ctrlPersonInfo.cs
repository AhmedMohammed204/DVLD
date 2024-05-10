using CountriesBusinessLayer;
using DVLD.Properties;
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

namespace DVLD
{
    public partial class ctrlPersonInfo : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        clsPerson person;
        private int _PersonID;
        private void _SetAvatarImage()
        {

            if(person.ImagePath != null)
            {
                pbAvatar.ImageLocation = person.ImagePath;
                return;
            }

            if (person.Gendor == 0)
                pbAvatar.Image = Resources.Unknown_man;
            else
                pbAvatar.Image = Resources.Unknown_woman;
        }
        public ctrlPersonInfo()
        {
            InitializeComponent();
            this.BackColor = clsColors.LightColor;

        }

        string PersonFullName()
        {
            return $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
        }
        void _LoadGenderLables()
        {
            if (person.Gendor == 0)
                lblGendor.Text = "Male";
            else
                lblGendor.Text = "Female";
        }
        void _LoadData()
        {
            if (person == null)
                return;

            _SetAvatarImage();
            lblPersonID.Text = person.PersonID.ToString();
            lblName.Text = PersonFullName();
            lblNationalNo.Text = person.NationalNo;
            _LoadGenderLables();
            lblEmail.Text = person.Email;
            lblAddress.Text = person.Address;
            lblDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
            lblPhone.Text = person.Phone;
            lblCountry.Text = clsCountry.Find(person.NationalityCountryID).CountryName;
        }
        public void LoadPerson(int PersonID)
        {
            _PersonID = PersonID;
            if(!clsPerson.isPersonExist(_PersonID))
            {
                MessageBox.Show("Person doesn't found");
                return;
            }
            person = clsPerson.Find(_PersonID);
            _LoadData();
            if (OnPersonSelected != null && person != null)
                OnPersonSelected(_PersonID);

        }
        public void LoadPerson(string NationalNo)
        {
            
            if(!clsPerson.isPersonExist(NationalNo))
            {
                MessageBox.Show("Person doesn't found");
                return;
            }
            person = clsPerson.Find(NationalNo);
            _PersonID = person.PersonID;
            _LoadData();
            
            if (OnPersonSelected != null && person != null)
                OnPersonSelected(_PersonID);
        }


        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void linkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_PersonID == 0)
                return;
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();
            person = clsPerson.Find(_PersonID);
            _LoadData();

        }

        
    }
}
