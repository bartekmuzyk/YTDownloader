using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTDownloader
{
    internal static class DarkMode
    {
        // https://stackoverflow.com/a/62811758/13040404
        private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }

        public static void AutoDarkMode(Control control)
        {
            if (control is Form)
            {
                UseImmersiveDarkMode(control.Handle, true);
                control.BackColor = Color.FromArgb(32, 32, 32);
                control.ForeColor = Color.FromArgb(220, 220, 220);
            }

            try
            {
                control.Controls.OfType<StatusStrip>().First().BackColor = Color.FromArgb(40, 40, 40);
            }
            catch (InvalidOperationException) { }

            foreach (var button in control.Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
                button.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
                button.BackColor = Color.FromArgb(45, 45, 45);
                ControlDecoration.MakeControlRounded(button);
            }

            foreach (var textBox in control.Controls.OfType<TextBox>())
            {
                textBox.BackColor = Color.FromArgb(55, 55, 55);
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.ForeColor = Color.White;
                ControlDecoration.MakeControlRounded(textBox, 1, 1, 1, 3, 2);
            }

            foreach (var comboBox in control.Controls.OfType<ComboBox>())
            {
                comboBox.FlatStyle = FlatStyle.Flat;
                comboBox.BackColor = Color.FromArgb(45, 45, 45);
                comboBox.ForeColor = Color.White;
                ControlDecoration.MakeControlRounded(comboBox, 3, 0, 3, 3);
            }

            foreach (var progressBar in control.Controls.OfType<ProgressBar>())
            {
                progressBar.BackColor = Color.FromArgb(45, 45, 45);
            }

            foreach (var panel in control.Controls.OfType<Panel>()) AutoDarkMode(panel);

            foreach (var groupBox in control.Controls.OfType<GroupBox>())
            {
                groupBox.ForeColor = Color.FromArgb(220, 220, 220);
                AutoDarkMode(groupBox);
            }
        }
    }
}
