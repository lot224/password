using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password {
    public partial class frmMain : Form {

        string characterBank = string.Empty;
        decimal passwordLength = 4;

        public frmMain() {
            InitializeComponent();
            getSettings();
        }

        private void getSettings() {

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PassGenerator");

            string Bank = (string)key.GetValue("Bank");
            int Length = (int)key.GetValue("Length");

            characterBank= Bank;
            passwordLength = Length;

            lblPassword_Click(null, null);
        }


        private void mnuOptions_Click(object sender, EventArgs e) {
            frmOptions options = new frmOptions();
            DialogResult nResult = options.ShowDialog();

            if (nResult == DialogResult.OK) {
                getSettings();
                lblPassword_Click(null, null);
            }
        }

        private void lblPassword_Click(object sender, EventArgs e) {
            
            if (e is System.Windows.Forms.MouseEventArgs && ((System.Windows.Forms.MouseEventArgs)e).Button == MouseButtons.Right) {
                System.Windows.Forms.MouseEventArgs m = (System.Windows.Forms.MouseEventArgs)e;
                contextMenu.Show(lblPassword, m.X, m.Y);
            } else {
                char[] chars = characterBank.ToCharArray();

                string nResult = string.Empty;

                Random rnd = new Random();

                for (int i = 0; i < passwordLength; i++) {
                    nResult += chars[rnd.Next(0, chars.Length)];
                }

                lblPassword.Text = nResult;
                Clipboard.SetData(DataFormats.StringFormat, nResult);
                UpdateHistory(nResult);
            }
        }

        private void UpdateHistory(string password) {

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PassGenerator", true);
            if (key == null) {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PassGenerator");
            }

            string History = (string)key.GetValue("History");

            List<string> items = new List<string>();
            if (History != null)
                items.AddRange(History.Split('|'));

            items.Reverse();
            items.Add(password);
            items.Reverse();

            History = string.Join("|", (from x in items select x).Take(10));

            key.SetValue("History", History);
            key.Close();
        }

        private void mnuHistory_Click(object sender, EventArgs e) {
            frmHistory history = new frmHistory();
            history.ShowDialog();
        }
    }
}
