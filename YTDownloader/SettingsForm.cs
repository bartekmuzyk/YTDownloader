using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTDownloader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            MaximumSize = MinimumSize = Size;

            downloadThumbnailsCheckBox.Checked = Properties.Settings.Default.downloadThumbnails;
            showExtensionMessageCheckBox.Checked = Properties.Settings.Default.showExtensionMessage;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.downloadThumbnails = downloadThumbnailsCheckBox.Checked;
            Properties.Settings.Default.showExtensionMessage = showExtensionMessageCheckBox.Checked;

            Properties.Settings.Default.Save();
        }
    }
}
