using DVLD.Licenses;
using DVLD.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainV2 : Form
    {
        //Applications
        void _OpenApplicationsForm()
        {
            frmApplications frm = new frmApplications();
            frm.OpenApplicationTypes += _OpenApplicationTypes;
            frm.OpenManageTestTypes += _OpenManageTestTypes;
            frm.OpenDrivingLicenseServices += _OpenDrivingLicenseServices;
            frm.OpenManageLocalApplications += _OpenManageLocalApplications;
            frm.OpenManageInternationalApplications += _OpenManageInternationalApplications;
            frm.OpenDetainLicenses += _OpenDetainLicenses;
            _OpenForm(frm);
        }
        private void btnApplications_Click(object sender, EventArgs e)
        {
            _OpenApplicationsForm();
        }
        void _OpenApplicationTypes()
        {
            frmApplicationTypes frm = new frmApplicationTypes();
            frm.BackToApplicationTypes += _OpenApplicationsForm;
            _OpenForm(frm);
        }
        void _OpenManageTestTypes()
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.BackToApplicationsForm += _OpenApplicationsForm;
            _OpenForm(frm);
        }
        private void _OpenDrivingLicenseServices()
        {
            frmDrivingLicenseServices frm = new frmDrivingLicenseServices();
            frm.BackToApplicationsForm += _OpenApplicationsForm;
            frm.OpenAddNewLocalLicenseForm += _OpenAddNewLocalLicenseForm;
            frm.OpenAddNewInternationalLicenseForm += _OpenAddNewInternationalLicenseForm;
            frm.OpenReplacementForm += _ReplacementForm;
            frm.OpenRenewForm += _ReNewForm;
            _OpenForm(frm);
        }
        void _OpenAddNewLocalLicenseForm()
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(clsApplicationTypes.NewLocalDrivingLicenseService);
            frm.BackToDrivingLicenseServicesForm += _OpenDrivingLicenseServices;
            _OpenForm(frm);
        }
        void _OpenAddNewInternationalLicenseForm()
        {
            frmNewInternationalDrivingLicense frm = new frmNewInternationalDrivingLicense();
            frm.BackToDrivingLicenseServices += _OpenDrivingLicenseServices;
            _OpenForm(frm);
        }
        void _ReplacementForm()
        {
            frmReplacementLicense frm = new frmReplacementLicense();
            frm.Back += _OpenDrivingLicenseServices;
            _OpenForm(frm);
        }
        void _ReNewForm()
        {
            frmRenewLicense frm = new frmRenewLicense();
            frm.Back += _OpenDrivingLicenseServices;
            _OpenForm(frm);
        }


        // // Manage Applications
        void _OpenManageLocalApplications()
        {
            frmManageLocalDrivingLicenseApplications frm = new frmManageLocalDrivingLicenseApplications();
            frm.BakcToApplicationsForm += _OpenApplicationsForm;
            _OpenForm(frm);
        }
        void _OpenManageInternationalApplications()
        {
            frmManageInternationalLicenses frm = new frmManageInternationalLicenses();
            frm.BakcToApplicationsForm += _OpenApplicationsForm;
            _OpenForm(frm);
        }

        // // Detain Licenses
        void _OpenDetainLicenses()
        {
            frmDetainLicenseScreen frm = new frmDetainLicenseScreen();
            frm.BackToApplicationsForm += _OpenApplicationsForm;
            frm.OpenDetainScreen += _OpenDetainScreen;
            frm.OpenReleaseScreen += _OpenReleaseScreen;
            frm.OpenManageDetainScreen += _OpenManageDetainScreen;
            _OpenForm(frm);
        }
        void _OpenDetainScreen()
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.BackToDetainReleaseScreen += _OpenDetainLicenses;
            _OpenForm(frm);
        }
        void _OpenReleaseScreen()
        {
            frmReleaseDetaindLicense frm = new frmReleaseDetaindLicense();
            frm.BackToDetainReleaseScreen += _OpenDetainLicenses;
            _OpenForm(frm);
        }
        void _OpenManageDetainScreen()
        {
            frmManageDetainedLicenses frm = new frmManageDetainedLicenses();
            frm.BackToDetainReleaseScreen += _OpenDetainLicenses;
            _OpenForm(frm);
        }
    }
}
