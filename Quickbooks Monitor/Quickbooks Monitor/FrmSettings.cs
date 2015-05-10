using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quickbooks_Monitor
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            cbAuto.Checked = Settings.Current.autoSearch;
            tbDirectory.Text = Settings.Current.directory;
            cbMinimized.Checked = Settings.Current.startMinimized;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Current.autoSearch = cbAuto.Checked;
            Settings.Current.startMinimized = cbMinimized.Checked;
            Settings.Current.openAll = cbOpenAll.Checked;
            Settings.Current.directory = tbDirectory.Text;

            XmlHandler.Current.Write(Settings.Current);

            Application.Restart();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            DialogResult result = fb.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbDirectory.Text = fb.SelectedPath.ToString();
            }
        }
    }
}
