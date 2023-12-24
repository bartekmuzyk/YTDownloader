namespace YTDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            urlInput = new TextBox();
            label1 = new Label();
            searchBtn = new Button();
            thumbnailBox = new PictureBox();
            titleLabel = new Label();
            channelLabel = new Label();
            dlConfigBox = new GroupBox();
            dlProgressDescription = new Label();
            dlProgressBar = new ProgressBar();
            label3 = new Label();
            dlQualityChooser = new ComboBox();
            label2 = new Label();
            dlModeChooser = new ComboBox();
            downloadButton = new Button();
            loadingIcon = new PictureBox();
            loadingText = new Label();
            saveFileDialog = new SaveFileDialog();
            successMessagePanel = new Panel();
            successMessageCloseButton = new Button();
            successMessagePathLabel = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            githubLink = new ToolStripStatusLabel();
            settingsBtn = new Button();
            settingsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)thumbnailBox).BeginInit();
            dlConfigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingIcon).BeginInit();
            successMessagePanel.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // urlInput
            // 
            urlInput.Location = new Point(14, 36);
            urlInput.Margin = new Padding(3, 4, 3, 4);
            urlInput.Name = "urlInput";
            urlInput.Size = new Size(494, 27);
            urlInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 1;
            label1.Text = "Adres URL filmu YouTube";
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtn.Location = new Point(402, 75);
            searchBtn.Margin = new Padding(3, 4, 3, 4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(106, 37);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Wyszukaj";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // thumbnailBox
            // 
            thumbnailBox.Location = new Point(14, 113);
            thumbnailBox.Margin = new Padding(3, 4, 3, 4);
            thumbnailBox.Name = "thumbnailBox";
            thumbnailBox.Size = new Size(183, 120);
            thumbnailBox.SizeMode = PictureBoxSizeMode.Zoom;
            thumbnailBox.TabIndex = 3;
            thumbnailBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoEllipsis = true;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Variable Display Semib", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(203, 113);
            titleLabel.MaximumSize = new Size(320, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 32);
            titleLabel.TabIndex = 4;
            // 
            // channelLabel
            // 
            channelLabel.AutoEllipsis = true;
            channelLabel.AutoSize = true;
            channelLabel.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            channelLabel.Location = new Point(203, 153);
            channelLabel.MaximumSize = new Size(320, 21);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new Size(0, 20);
            channelLabel.TabIndex = 5;
            // 
            // dlConfigBox
            // 
            dlConfigBox.Controls.Add(dlProgressDescription);
            dlConfigBox.Controls.Add(dlProgressBar);
            dlConfigBox.Controls.Add(label3);
            dlConfigBox.Controls.Add(dlQualityChooser);
            dlConfigBox.Controls.Add(label2);
            dlConfigBox.Controls.Add(dlModeChooser);
            dlConfigBox.Controls.Add(downloadButton);
            dlConfigBox.Font = new Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dlConfigBox.Location = new Point(14, 241);
            dlConfigBox.Margin = new Padding(3, 4, 3, 4);
            dlConfigBox.Name = "dlConfigBox";
            dlConfigBox.Padding = new Padding(3, 4, 3, 4);
            dlConfigBox.Size = new Size(495, 173);
            dlConfigBox.TabIndex = 6;
            dlConfigBox.TabStop = false;
            dlConfigBox.Text = "Konfiguracja pobierania";
            dlConfigBox.Visible = false;
            // 
            // dlProgressDescription
            // 
            dlProgressDescription.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dlProgressDescription.Location = new Point(7, 108);
            dlProgressDescription.Name = "dlProgressDescription";
            dlProgressDescription.Size = new Size(481, 23);
            dlProgressDescription.TabIndex = 6;
            dlProgressDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // dlProgressBar
            // 
            dlProgressBar.Location = new Point(7, 135);
            dlProgressBar.Margin = new Padding(3, 4, 3, 4);
            dlProgressBar.Name = "dlProgressBar";
            dlProgressBar.Size = new Size(481, 31);
            dlProgressBar.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(167, 24);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 4;
            label3.Text = "Jakość";
            // 
            // dlQualityChooser
            // 
            dlQualityChooser.DropDownStyle = ComboBoxStyle.DropDownList;
            dlQualityChooser.DropDownWidth = 210;
            dlQualityChooser.Enabled = false;
            dlQualityChooser.FormattingEnabled = true;
            dlQualityChooser.Location = new Point(167, 63);
            dlQualityChooser.Margin = new Padding(3, 4, 3, 4);
            dlQualityChooser.Name = "dlQualityChooser";
            dlQualityChooser.Size = new Size(207, 29);
            dlQualityChooser.TabIndex = 3;
            dlQualityChooser.SelectedIndexChanged += dlQualityChooser_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 24);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 2;
            label2.Text = "Tryb";
            // 
            // dlModeChooser
            // 
            dlModeChooser.DropDownStyle = ComboBoxStyle.DropDownList;
            dlModeChooser.FormattingEnabled = true;
            dlModeChooser.Items.AddRange(new object[] { "Wideo + audio", "Tylko wideo", "Tylko audio" });
            dlModeChooser.Location = new Point(10, 63);
            dlModeChooser.Margin = new Padding(3, 4, 3, 4);
            dlModeChooser.Name = "dlModeChooser";
            dlModeChooser.Size = new Size(138, 29);
            dlModeChooser.TabIndex = 1;
            dlModeChooser.SelectedIndexChanged += dlModeChooser_SelectedIndexChanged;
            // 
            // downloadButton
            // 
            downloadButton.Enabled = false;
            downloadButton.Location = new Point(392, 19);
            downloadButton.Margin = new Padding(3, 4, 3, 4);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(99, 83);
            downloadButton.TabIndex = 0;
            downloadButton.Text = "Pobierz";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // loadingIcon
            // 
            loadingIcon.Image = Properties.Resources.loading;
            loadingIcon.Location = new Point(203, 187);
            loadingIcon.Margin = new Padding(3, 4, 3, 4);
            loadingIcon.Name = "loadingIcon";
            loadingIcon.Size = new Size(40, 47);
            loadingIcon.SizeMode = PictureBoxSizeMode.Zoom;
            loadingIcon.TabIndex = 7;
            loadingIcon.TabStop = false;
            loadingIcon.Visible = false;
            // 
            // loadingText
            // 
            loadingText.AutoSize = true;
            loadingText.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadingText.Location = new Point(250, 181);
            loadingText.Name = "loadingText";
            loadingText.Size = new Size(197, 54);
            loadingText.TabIndex = 8;
            loadingText.Text = "Pobieranie informacji\r\no strumieniach...";
            loadingText.Visible = false;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Title = "Zapisz pobrany strumień do";
            saveFileDialog.FileOk += saveFileDialog_FileOk;
            // 
            // successMessagePanel
            // 
            successMessagePanel.Controls.Add(successMessageCloseButton);
            successMessagePanel.Controls.Add(successMessagePathLabel);
            successMessagePanel.Controls.Add(label6);
            successMessagePanel.Controls.Add(label5);
            successMessagePanel.Controls.Add(label4);
            successMessagePanel.Location = new Point(14, 241);
            successMessagePanel.Margin = new Padding(3, 4, 3, 4);
            successMessagePanel.Name = "successMessagePanel";
            successMessagePanel.Size = new Size(495, 173);
            successMessagePanel.TabIndex = 9;
            successMessagePanel.Visible = false;
            // 
            // successMessageCloseButton
            // 
            successMessageCloseButton.Location = new Point(162, 129);
            successMessageCloseButton.Margin = new Padding(3, 4, 3, 4);
            successMessageCloseButton.Name = "successMessageCloseButton";
            successMessageCloseButton.Size = new Size(170, 36);
            successMessageCloseButton.TabIndex = 4;
            successMessageCloseButton.Text = "Wróć do konfiguracji";
            successMessageCloseButton.UseVisualStyleBackColor = true;
            successMessageCloseButton.Click += successMessageCloseButton_Click;
            // 
            // successMessagePathLabel
            // 
            successMessagePathLabel.AutoEllipsis = true;
            successMessagePathLabel.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            successMessagePathLabel.Location = new Point(0, 71);
            successMessagePathLabel.Name = "successMessagePathLabel";
            successMessagePathLabel.Size = new Size(495, 53);
            successMessagePathLabel.TabIndex = 3;
            successMessagePathLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 41);
            label6.Name = "label6";
            label6.Size = new Size(495, 33);
            label6.TabIndex = 2;
            label6.Text = "Pobrany plik został zapisany w:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 4);
            label5.Name = "label5";
            label5.Size = new Size(442, 36);
            label5.TabIndex = 1;
            label5.Text = "Pobieranie zakończone sukcesem!";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 4);
            label4.Name = "label4";
            label4.Size = new Size(57, 40);
            label4.TabIndex = 0;
            label4.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, githubLink });
            statusStrip1.Location = new Point(0, 422);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(522, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.RightToLeft = RightToLeft.No;
            toolStripStatusLabel1.Size = new Size(38, 20);
            toolStripStatusLabel1.Text = "v3.4";
            // 
            // githubLink
            // 
            githubLink.BackColor = Color.Transparent;
            githubLink.Image = Properties.Resources.github;
            githubLink.IsLink = true;
            githubLink.Name = "githubLink";
            githubLink.Size = new Size(76, 20);
            githubLink.Text = "GitHub";
            githubLink.Click += githubLink_Click;
            // 
            // settingsBtn
            // 
            settingsBtn.Font = new Font("Segoe Fluent Icons", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            settingsBtn.Location = new Point(362, 75);
            settingsBtn.Margin = new Padding(3, 4, 3, 4);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(37, 37);
            settingsBtn.TabIndex = 11;
            settingsBtn.Text = "";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            settingsBtn.MouseLeave += settingsBtn_MouseLeave;
            settingsBtn.MouseHover += settingsBtn_MouseHover;
            // 
            // settingsLabel
            // 
            settingsLabel.Font = new Font("Segoe UI Variable Small Semibol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            settingsLabel.Location = new Point(14, 82);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(342, 24);
            settingsLabel.TabIndex = 12;
            settingsLabel.Text = "Ustawienia";
            settingsLabel.TextAlign = ContentAlignment.MiddleRight;
            settingsLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(522, 448);
            Controls.Add(settingsLabel);
            Controls.Add(settingsBtn);
            Controls.Add(statusStrip1);
            Controls.Add(successMessagePanel);
            Controls.Add(loadingText);
            Controls.Add(loadingIcon);
            Controls.Add(dlConfigBox);
            Controls.Add(channelLabel);
            Controls.Add(titleLabel);
            Controls.Add(searchBtn);
            Controls.Add(thumbnailBox);
            Controls.Add(label1);
            Controls.Add(urlInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YouTube Downloader";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)thumbnailBox).EndInit();
            dlConfigBox.ResumeLayout(false);
            dlConfigBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loadingIcon).EndInit();
            successMessagePanel.ResumeLayout(false);
            successMessagePanel.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlInput;
        private Label label1;
        private Button searchBtn;
        private PictureBox thumbnailBox;
        private Label titleLabel;
        private Label channelLabel;
        private GroupBox dlConfigBox;
        private Button downloadButton;
        private Label label2;
        private ComboBox dlModeChooser;
        private Label label3;
        private ComboBox dlQualityChooser;
        private ProgressBar dlProgressBar;
        private Label dlProgressDescription;
        private PictureBox loadingIcon;
        private Label loadingText;
        private SaveFileDialog saveFileDialog;
        private Panel successMessagePanel;
        private Label successMessagePathLabel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button successMessageCloseButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel githubLink;
        private Button settingsBtn;
        private Label settingsLabel;
    }
}