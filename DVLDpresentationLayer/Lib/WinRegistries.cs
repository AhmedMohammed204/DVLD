using Microsoft.Win32;

namespace DVLD
{
    public class WinRegistries
    {
        private readonly string _KeyPath;
        public readonly string ApplicationName;
        public readonly enHKEY HKEY;
        public enum enHKEY { HKEY_CURRENT_USER, HKEY_LOCAL_MACHINE }

        public WinRegistries(string applicationName, enHKEY HKEY)
        {
            ApplicationName = applicationName;
            this.HKEY = HKEY;
            _KeyPath = $@"{HKEY}\SOFTWARE\{applicationName}";
        }

        public bool SetVelue(string ValueName, string ValueData)
        {
            bool IsDone = false;
            try
            {
                Registry.SetValue(_KeyPath, ValueName, ValueData, RegistryValueKind.String);
                IsDone = true;
            }
            catch 
            {

            }
            return IsDone;
        }
        public string Get(string ValueName)
        {

            return Get(_KeyPath, ValueName);
        }
        public static string Get(string KeyPath, string ValueName)
        {
            try
            {
                string value = Registry.GetValue(KeyPath, ValueName, null) as string;
                return value;
            }
            catch
            {

                return null;
            }
        }
    }
}
