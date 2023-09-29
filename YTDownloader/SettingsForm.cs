using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace YTDownloader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SlideFromBottom(Control control)
        {
            var originalTop = control.Top;
            var originalColor = control.ForeColor;

            var transition = new Transition(new TransitionType_Deceleration(300));
            transition.add(control, "Top", originalTop);
            transition.add(control, "ForeColor", originalColor);

            control.ForeColor = Color.FromArgb(0, BackColor);
            control.Top = originalTop + 25;

            transition.run();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.darkMode) DarkMode.AutoDarkMode(this);

            if (Properties.Settings.Default.mica)
            {
                BackColor = Color.Black;
                Dwm.AutoExtendFrameIntoClientArea(Handle);
                Dwm.ApplyMicaBackdropToWindow(Handle);
            }

            MaximumSize = MinimumSize = Size;

            micaCheckBox.Visible = Properties.Settings.Default.darkMode;

            titleLabel.Visible = false;
            settingsPanel.Visible = false;

            Task.Delay(40).GetAwaiter().OnCompleted(() =>
            {
                titleLabel.Visible = true;
                SlideFromBottom(titleLabel);
            });
            Task.Delay(170).GetAwaiter().OnCompleted(() =>
            {
                settingsPanel.Visible = true;
                SlideFromBottom(settingsPanel);
            });

            downloadThumbnailsCheckBox.Checked = Properties.Settings.Default.downloadThumbnails;
            showExtensionMessageCheckBox.Checked = Properties.Settings.Default.showExtensionMessage;
            darkModeCheckBox.Checked = Properties.Settings.Default.darkMode;

            showNotificationCheckBox.Checked = Properties.Settings.Default.showNotification;
            micaCheckBox.Checked = Properties.Settings.Default.mica;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.downloadThumbnails = downloadThumbnailsCheckBox.Checked;
            Properties.Settings.Default.showExtensionMessage = showExtensionMessageCheckBox.Checked;

            if (!Properties.Settings.Default.darkMode && darkModeCheckBox.Checked)
            {
                MessageBox.Show("Tryb ciemny zostanie zaaplikowany po restarcie aplikacji.");
            }
            Properties.Settings.Default.darkMode = darkModeCheckBox.Checked;

            Properties.Settings.Default.showNotification = showNotificationCheckBox.Checked;
            Properties.Settings.Default.mica = darkModeCheckBox.Checked && micaCheckBox.Checked;

            Properties.Settings.Default.Save();
        }

        private void darkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            micaCheckBox.Visible = ((CheckBox)sender).Checked;
        }
    }
}
