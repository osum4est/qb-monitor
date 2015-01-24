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
    public partial class FrmSetDirectory : Form
    {
        public FrmSetDirectory()
        {
            InitializeComponent();
        }

        public string GetDirectory()
        {
            return tbDirectory.Text;
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
