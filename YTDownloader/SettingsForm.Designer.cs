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
            this.label1 = new System.Windows.Forms.Label();
            this.downloadThumbnailsCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showExtensionMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ustawienia YouTube Downloader";
            // 
            // downloadThumbnailsCheckBox
            // 
            this.downloadThumbnailsCheckBox.AutoSize = true;
            this.downloadThumbnailsCheckBox.Checked = true;
            this.downloadThumbnailsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downloadThumbnailsCheckBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downloadThumbnailsCheckBox.Location = new System.Drawing.Point(12, 54);
            this.downloadThumbnailsCheckBox.Name = "downloadThumbnailsCheckBox";
            this.downloadThumbnailsCheckBox.Size = new System.Drawing.Size(125, 20);
            this.downloadThumbnailsCheckBox.TabIndex = 1;
            this.downloadThumbnailsCheckBox.Text = "Pobieraj miniaturki";
            this.downloadThumbnailsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(186, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ustawienia zostaną zapisane po zamknięciu tego okna.";
            // 
            // showExtensionMessageCheckBox
            // 
            this.showExtensionMessageCheckBox.AutoSize = true;
            this.showExtensionMessageCheckBox.Checked = true;
            this.showExtensionMessageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showExtensionMessageCheckBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showExtensionMessageCheckBox.Location = new System.Drawing.Point(12, 80);
            this.showExtensionMessageCheckBox.Name = "showExtensionMessageCheckBox";
            this.showExtensionMessageCheckBox.Size = new System.Drawing.Size(265, 20);
            this.showExtensionMessageCheckBox.TabIndex = 3;
            this.showExtensionMessageCheckBox.Text = "Pokazuj komunikat o rozszerzeniu przy starcie";
            this.showExtensionMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 180);
            this.Controls.Add(this.showExtensionMessageCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downloadThumbnailsCheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox downloadThumbnailsCheckBox;
        private Label label2;
        private CheckBox showExtensionMessageCheckBox;
    }
}