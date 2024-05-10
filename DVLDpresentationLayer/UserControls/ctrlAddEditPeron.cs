using CountriesBusinessLayer;
using DVLD.Properties;
using PeopleBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlAddEditPeron : UserControl
    {
        enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private string _ImagePath;
        private int _PersonID;
        private clsPerson _Person;
        private bool _RemoveImage;


        private void _LoadCountries()
        {
            cbCountries.Items.Clear();
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow Row in dtCountries.Rows)
            {
                cbCountries.Items.Add(Row["CountryName"]);
            }
        }
        private void _LoadDateTimePicker()
        {
            DateTime Today = DateTime.Now;
            dtpDateOfBirth.MaxDate = new DateTime(Today.Year - 18, Today.Month, Today.Day);
            dtpDateOfBirth.MinDate = new DateTime(Today.Year - 70, Today.Month, Today.Day);
        }
        private void _LoadButtons()
        {
            ctrlButtonSave.btnTxt = "Save";
            ctrlButtonClose.btnTxt = "Close";
        }

        private void _LoadData()
        {
            _RemoveImage = false;
            _LoadButtons();
            _LoadDateTimePicker();
            _LoadCountries();
            txtFirstName.Focus();

            if (_Mode == enMode.AddNew)
            {
                rbMale.Checked = true;
                _Person = new clsPerson();
                cbCountries.SelectedItem = "Jordan";
                return;
            }

            _Person = clsPerson.Find(_PersonID);
            
            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            
            cbCountries.SelectedItem = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            if (_Person.ImagePath != null)
            {
                pbAvatar.ImageLocation = _Person.ImagePath;
                _ImagePath = _Person.ImagePath;
                linkRemove.Visible = true;
            }
        }
        public ctrlAddEditPeron()
        {

            InitializeComponent();
            this.BackColor = clsColors.LightColor;
        }
        private void _SetDefaultImage()
        {
            if (pbAvatar.ImageLocation != null)
                return;

            if (rbMale.Checked)
                pbAvatar.Image = Resources.Unknown_man;
            else
                pbAvatar.Image = Resources.Unknown_woman;
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            _SetDefaultImage();
        }
        private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Select any photo";
            openFileDialog1.Filter = "GPG files (*.gpg)|*.gpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.ImageLocation = openFileDialog1.FileName;
                _ImagePath = openFileDialog1.FileName;
                linkRemove.Visible = true;
                _RemoveImage = false;
            }
        }
        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbAvatar.ImageLocation = null;
            linkRemove.Visible = false;
            _RemoveImage = true;
            pbAvatar.ImageLocation = null;
            _SetDefaultImage();
        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            string Txt = txtNationalNo.Text;
            if (clsPerson.isPersonExist(Txt))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "National No is already in use");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, "");
            }
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string Txt = txtPhone.Text;

            if (!int.TryParse(Txt, out int value))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Only numbers are alowed!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }
        private byte _GetPersonGender()
        {
            if (rbFemale.Checked)
                return 1;

            return 0;
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string Email = txtEmail.Text;

            if (string.IsNullOrEmpty(Email))
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
                return;
            }

            if (!Email.EndsWith("@gmail.com"))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email is not valid");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }


        public void LoadPerson(int PersonID)
        {
            _PersonID = PersonID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
            _LoadData();
        }
        public event Action<bool> onClickClose;
        protected virtual void ClickClose(bool Clicked)
        {
            Action<bool> handler = onClickClose;
            if (handler != null)
            {
                handler(Clicked);
            }
        }
        
    

        public event Action<int> OnPersonAdded;
        protected virtual void PersonAdded(int PersonID)
        {
            Action<int> handler = OnPersonAdded;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        private void ctrlButtonSave_OnButtonClick(Button obj)
        {
            string ImagePath = null;

            if (_RemoveImage && _Person.ImagePath != null)
            {
                try
                {
                    File.Delete(_Person.ImagePath);

                }
                catch { }
            }    

            if (pbAvatar.ImageLocation != null && pbAvatar.ImageLocation == _ImagePath && !_RemoveImage)
            {
                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(_ImagePath);

                string destinationPath = Path.Combine(@"C:\DVLD-People_Images", newFileName);
                // Copy the file to the destination
                File.Copy(_ImagePath, destinationPath);
                ImagePath = destinationPath;
            }
            string FirstName = txtFirstName.Text;
            string SecondName = txtSecondName.Text;
            string ThirdName = txtThirdName.Text;
            string LastName = txtLastName.Text;
            string Email = txtEmail.Text;
            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            string NationalNo = txtNationalNo.Text;
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(SecondName) ||
                string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Phone) ||
                string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(NationalNo))
            {
                MessageBox.Show("You have to fill all gaps", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Person.FirstName = FirstName;
            _Person.SecondName = SecondName;
            _Person.ThirdName = ThirdName;
            _Person.LastName = LastName;
            _Person.Phone = Phone;
            _Person.Address = Address;
            _Person.NationalNo = NationalNo;
            _Person.Email = Email;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gendor = _GetPersonGender();
            _Person.NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;
            
            

            _Person.ImagePath = ImagePath;


            if (!_Person.Save())
            {
                MessageBox.Show("Error, We couldn't save persons data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadPerson(_Person.PersonID);
            if(OnPersonAdded != null)
                OnPersonAdded(_Person.PersonID);
        }


        public delegate void CloseWindowHandler();
        public event CloseWindowHandler CloseWindow;
        private void ctrlButtonClose_OnButtonClick(Button obj)
        {

            CloseWindow?.Invoke();


            if (onClickClose != null)
                onClickClose(true);
        }

    }
}
