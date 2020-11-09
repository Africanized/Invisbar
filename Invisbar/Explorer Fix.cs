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
                Console.WriteLine("Restarting Explorer...\n");
                foreach (Process proc in Process.GetProcessesByName("explorer"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured..");
#if DEBUG
                Console.WriteLine(ex);
#endif      
            }
            
        }

        public static void regkey(string keypath, string keyname, string keyvalue)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(keypath);
            key.SetValue(keyname, keyvalue, RegistryValueKind.DWord);
            key.Close();
        }
    }
}
