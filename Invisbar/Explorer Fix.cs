using System;
using Microsoft.Win32;
using System.Diagnostics;

namespace Invisbar
{
    class Explorer_Fix
    {
        public static void restart()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("explorer"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void regkey(string keypath, string keyname, string keyvalue)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(keypath);
            key.SetValue(keyname, keyvalue, RegistryValueKind.DWord);
            key.Close();
        }
    }
}
