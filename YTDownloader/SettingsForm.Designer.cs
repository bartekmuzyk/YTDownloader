namespace YTDownloader
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            downloadThumbnailsCheckBox = new CheckBox();
            label2 = new Label();
            showExtensionMessageCheckBox = new CheckBox();
            darkModeCheckBox = new CheckBox();
            showNotificationCheckBox = new CheckBox();
            settingsPanel = new Panel();
            micaCheckBox = new CheckBox();
            settingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(385, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Ustawienia YouTube Downloader";
            // 
            // downloadThumbnailsCheckBox
            // 
            downloadThumbnailsCheckBox.AutoSize = true;
            downloadThumbnailsCheckBox.Checked = true;
            downloadThumbnailsCheckBox.CheckState = CheckState.Checked;
            downloadThumbnailsCheckBox.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            downloadThumbnailsCheckBox.Location = new Point(3, 3);
            downloadThumbnailsCheckBox.Name = "downloadThumbnailsCheckBox";
            downloadThumbnailsCheckBox.Size = new Size(125, 20);
            downloadThumbnailsCheckBox.TabIndex = 1;
            downloadThumbnailsCheckBox.Text = "Pobieraj miniaturki";
            downloadThumbnailsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 207);
            label2.Name = "label2";
            label2.Size = new Size(301, 16);
            label2.TabIndex = 2;
            label2.Text = "Ustawienia zostaną zapisane po zamknięciu tego okna.";
            // 
            // showExtensionMessageCheckBox
            // 
            showExtensionMessageCheckBox.AutoSize = true;
            showExtensionMessageCheckBox.Checked = true;
            showExtensionMessageCheckBox.CheckState = CheckState.Checked;
            showExtensionMessageCheckBox.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showExtensionMessageCheckBox.Location = new Point(3, 29);
            showExtensionMessageCheckBox.Name = "showExtensionMessageCheckBox";
            showExtensionMessageCheckBox.Size = new Size(265, 20);
            showExtensionMessageCheckBox.TabIndex = 3;
            showExtensionMessageCheckBox.Text = "Pokazuj komunikat o rozszerzeniu przy starcie";
            showExtensionMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // darkModeCheckBox
            // 
            darkModeCheckBox.AutoSize = true;
            darkModeCheckBox.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            darkModeCheckBox.Location = new Point(3, 55);
            darkModeCheckBox.Name = "darkModeCheckBox";
            darkModeCheckBox.Size = new Size(89, 20);
            darkModeCheckBox.TabIndex = 4;
            darkModeCheckBox.Text = "Tryb ciemny";
            darkModeCheckBox.UseVisualStyleBackColor = true;
            darkModeCheckBox.CheckedChanged += darkModeCheckBox_CheckedChanged;
            // 
            // showNotificationCheckBox
            // 
            showNotificationCheckBox.AutoSize = true;
            showNotificationCheckBox.Checked = true;
            showNotificationCheckBox.CheckState = CheckState.Checked;
            showNotificationCheckBox.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showNotificationCheckBox.Location = new Point(3, 81);
            showNotificationCheckBox.Name = "showNotificationCheckBox";
            showNotificationCheckBox.Size = new Size(285, 20);
            showNotificationCheckBox.TabIndex = 5;
            showNotificationCheckBox.Text = "Pokaż powiadomienie po zakończeniu pobierania";
            showNotificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // settingsPanel
            // 
            settingsPanel.Controls.Add(micaCheckBox);
            settingsPanel.Controls.Add(downloadThumbnailsCheckBox);
            settingsPanel.Controls.Add(showNotificationCheckBox);
            settingsPanel.Controls.Add(showExtensionMessageCheckBox);
            settingsPanel.Controls.Add(darkModeCheckBox);
            settingsPanel.Location = new Point(12, 44);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(475, 132);
            settingsPanel.TabIndex = 6;
            // 
            // micaCheckBox
            // 
            micaCheckBox.AutoSize = true;
            micaCheckBox.Location = new Point(98, 56);
            micaCheckBox.Name = "micaCheckBox";
            micaCheckBox.Size = new Size(81, 19);
            micaCheckBox.TabIndex = 6;
            micaCheckBox.Text = "Efekt Mica";
            micaCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 232);
            Controls.Add(settingsPanel);
            Controls.Add(label2);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ustawienia";
            FormClosed += SettingsForm_FormClosed;
            Load += SettingsForm_Load;
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private CheckBox downloadThumbnailsCheckBox;
        private Label label2;
        private CheckBox showExtensionMessageCheckBox;
        private CheckBox darkModeCheckBox;
        private CheckBox showNotificationCheckBox;
        private Panel settingsPanel;
        private CheckBox micaCheckBox;
    }
}