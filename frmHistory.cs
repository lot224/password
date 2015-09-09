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
    public partial class frmHistory : Form {
        public frmHistory() {
            InitializeComponent();
        }

        private void frmHistory_Load(object sender, EventArgs e) {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PassGenerator");
            string History = (string)key.GetValue("History");
            if (History.Length > 0)
                listItems.Items.AddRange(History.Split('|'));
        }

        private void bntClear_Click(object sender, EventArgs e) {

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("PassGenerator", true);
            if (key == null) {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PassGenerator");
            }

            key.SetValue("History", string.Empty);
            key.Close();
            listItems.Items.Clear();
        }

        private void bntClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
