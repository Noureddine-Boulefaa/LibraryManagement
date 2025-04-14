using LibraryManagment_business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment.Global_Classes
{
    internal class clsGlobal
    {
        public static clsAdmin CurrentAdmin;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string KeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\LibraryManagment";
            if (WriteKeyValueToRegistry(KeyPath, "Username", Username) && WriteKeyValueToRegistry(KeyPath, "Password", Password))
            {
                return true;

            }
            return false;
        }

        public static bool GetStoredCredential(ref string Username,ref string Password)
        {
            string KeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\LibraryManagment";
            return (ReadValueFromRegistry(KeyPath, "Username", ref Username) && ReadValueFromRegistry(KeyPath, "Password", ref Password));
        }

        private static bool WriteKeyValueToRegistry(string KeyPath,string ValueName,string ValueData)
        {
            try
            {
                if(!string.IsNullOrEmpty(KeyPath))
                {
                    Registry.SetValue(KeyPath, ValueName, ValueData, RegistryValueKind.String);
                    return true;
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return false;
        }

        private static bool ReadValueFromRegistry(string KeyPath, string ValueName,ref string ValueData)
        {
            
            try
            {
                if (!string.IsNullOrEmpty(KeyPath))
                {
                    ValueData = Registry.GetValue(KeyPath, ValueName, null) as string;
                    return true;
                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }

        private static string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
