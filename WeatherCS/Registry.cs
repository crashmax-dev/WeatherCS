using Microsoft.Win32;

namespace WeatherCS
{
    public static class Registry
    {
        public static void SetRegistry(string key, string value)
        {
            using (RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\" + MainForm.APP_NAME))
            {
                if (reg.GetValue(key) == null)
                {
                    reg.SetValue(key, value);
                }
                else if (reg.GetValue(key).ToString() != value)
                {
                    reg.SetValue(key, value);
                }
            }
        }

        public static string GetRegistry(string key)
        {
            using (RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\" + MainForm.APP_NAME))
                if (reg.GetValue(key) != null)
                    return reg.GetValue(key).ToString();
                else
                    return null;
        }

        public static void RestoreRegistry()
        {
            using (RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\" + MainForm.APP_NAME))
            {
                if (reg != null)
                {
                    Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(@"Software\" + MainForm.APP_NAME);
                }
            }

            using (RegistryKey run = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run"))
            {
                if (run.GetValue(MainForm.APP_NAME) != null)
                    run.DeleteValue(MainForm.APP_NAME);
                SetRegistry("autorun", "True");
                
            }
        }

        public static void RegistryEnableAutorun()
        {
            SetRegistry("autorun", "True");
            using (RegistryKey r = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                r.SetValue(MainForm.APP_NAME, MainForm.EXECUTABLE_PATH + " /minimized");
        }

        public static void RegistryDisableAutorun() {
            SetRegistry("autorun", "False");
            using (RegistryKey r = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                r.DeleteValue(MainForm.APP_NAME);
        }
    }
}
