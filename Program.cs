using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            // Check for registry keys, if not found set defaults.
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PassGenerator");
            if (key == null) {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PassGenerator");
                key.SetValue("Bank", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*+=");
                key.SetValue("Length", 4);
                key.SetValue("History", string.Empty);
                key.Close();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
