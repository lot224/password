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
    public partial class frmOptions : Form {
        public frmOptions() {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e) {

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PassGenerator");

            string Bank = (string)key.GetValue("Bank");
            int Length = (int)key.GetValue("Length");

            txtBank.Text = Bank;
            numLength.Value = Length;
        }

        private void bntSave_Click(object sender, EventArgs e) {
            if (txtBank.Text.Length == 0) return;

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PassGenerator",true);
            if (key == null) {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PassGenerator");
            }

            key.SetValue("Bank", txtBank.Text);
            key.SetValue("Length", (int)numLength.Value);
            key.Close();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtBank_TextChanged(object sender, EventArgs e) {
            bntSave.Enabled = txtBank.Text.Length > 0;
        }
    }
}
