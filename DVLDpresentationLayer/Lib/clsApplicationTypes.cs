using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    public static class clsApplicationTypes
    {
        public static int NewLocalDrivingLicenseService { get {  return 1; } }
        public static int RenewLicenseService { get {  return 2; } }
        public static int ReplacementForALostDrivingLicense { get {  return 3; } }
        public static int ReplacementForADamagedDrivingLicense { get {  return 4; } }
        public static int ReleaseDetainedDrivingLicsense { get {  return 5; } }
        public static int NewInternationalLicense { get {  return 6; } }
    }
}
