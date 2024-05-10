using DVLD.Licenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new frmManageDetainedLicenses());
            //Application.Run(new frmReplacementLicense());
            //Application.Run(new MainV2());
            //Application.Run(new frmManageDrivers());
            //Application.Run(new frmManageLocalDrivingLicenseApplications());
            //Application.Run(new frmIssuDrivingLicense(41));
            //Application.Run(new frmVisionTest(31));
            //Application.Run(new frmNewInternationalDrivingLicense());
            //Application.Run(new frmTest());

        }
    }
}
