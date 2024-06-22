using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    /// <summary>
    /// Write and get from windows registry
    /// </summary>
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
        /// <summary>
        /// Set value on registry
        /// </summary>
        /// <param name="ValueName">name of your value</param>
        /// <param name="ValueData">data of your value</param>
        /// <returns></returns>
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
        /// <summary>
        /// get value data
        /// </summary>
        /// <param name="ValueName">value name to find value data on it</param>
        /// <returns>string of value data</returns>
        public string Get(string ValueName)
        {

            return Get(_KeyPath, ValueName);
        }
        /// <summary>
        /// get value data
        /// </summary>
        /// <param name="KeyPath">key path on registry</param>
        /// <param name="ValueName">value name to find value data on it</param>
        /// <returns>string of value data</returns>
        public static string Get(string KeyPath, string ValueName)
        {
            try
            {
                string value = Registry.GetValue(KeyPath, ValueName, null) as string;
                return value;
            }
            catch (Exception ex) 
            {
                clsErrorHandling.HandleError(ex);
                return null;
            }
        }
    }
}
