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
            this.urlInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.thumbnailBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.channelLabel = new System.Windows.Forms.Label();
            this.dlConfigBox = new System.Windows.Forms.GroupBox();
            this.dlProgressDescription = new System.Windows.Forms.Label();
            this.dlProgressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.dlQualityChooser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dlModeChooser = new System.Windows.Forms.ComboBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.loadingIcon = new System.Windows.Forms.PictureBox();
            this.loadingText = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.successMessagePanel = new System.Windows.Forms.Panel();
            this.successMessageCloseButton = new System.Windows.Forms.Button();
            this.successMessagePathLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).BeginInit();
            this.dlConfigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).BeginInit();
            this.successMessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlInput
            // 
            this.urlInput.Location = new System.Drawing.Point(12, 27);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(433, 23);
            this.urlInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres URL filmu YouTube";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.Location = new System.Drawing.Point(352, 56);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(93, 28);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Wyszukaj";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.Location = new System.Drawing.Point(12, 85);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(160, 90);
            this.thumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnailBox.TabIndex = 3;
            this.thumbnailBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(178, 85);
            this.titleLabel.MaximumSize = new System.Drawing.Size(280, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 26);
            this.titleLabel.TabIndex = 4;
            // 
            // channelLabel
            // 
            this.channelLabel.AutoEllipsis = true;
            this.channelLabel.AutoSize = true;
            this.channelLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.channelLabel.Location = new System.Drawing.Point(178, 115);
            this.channelLabel.MaximumSize = new System.Drawing.Size(280, 16);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(0, 16);
            this.channelLabel.TabIndex = 5;
            // 
            // dlConfigBox
            // 
            this.dlConfigBox.Controls.Add(this.dlProgressDescription);
            this.dlConfigBox.Controls.Add(this.dlProgressBar);
            this.dlConfigBox.Controls.Add(this.label3);
            this.dlConfigBox.Controls.Add(this.dlQualityChooser);
            this.dlConfigBox.Controls.Add(this.label2);
            this.dlConfigBox.Controls.Add(this.dlModeChooser);
            this.dlConfigBox.Controls.Add(this.downloadButton);
            this.dlConfigBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dlConfigBox.Location = new System.Drawing.Point(12, 181);
            this.dlConfigBox.Name = "dlConfigBox";
            this.dlConfigBox.Size = new System.Drawing.Size(433, 130);
            this.dlConfigBox.TabIndex = 6;
            this.dlConfigBox.TabStop = false;
            this.dlConfigBox.Text = "Konfiguracja pobierania";
            this.dlConfigBox.Visible = false;
            // 
            // dlProgressDescription
            // 
            this.dlProgressDescription.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dlProgressDescription.Location = new System.Drawing.Point(6, 81);
            this.dlProgressDescription.Name = "dlProgressDescription";
            this.dlProgressDescription.Size = new System.Drawing.Size(421, 17);
            this.dlProgressDescription.TabIndex = 6;
            this.dlProgressDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dlProgressBar
            // 
            this.dlProgressBar.Location = new System.Drawing.Point(6, 101);
            this.dlProgressBar.Name = "dlProgressBar";
            this.dlProgressBar.Size = new System.Drawing.Size(421, 23);
            this.dlProgressBar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(146, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jakość";
            // 
            // dlQualityChooser
            // 
            this.dlQualityChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dlQualityChooser.DropDownWidth = 210;
            this.dlQualityChooser.Enabled = false;
            this.dlQualityChooser.FormattingEnabled = true;
            this.dlQualityChooser.Location = new System.Drawing.Point(146, 47);
            this.dlQualityChooser.Name = "dlQualityChooser";
            this.dlQualityChooser.Size = new System.Drawing.Size(182, 25);
            this.dlQualityChooser.TabIndex = 3;
            this.dlQualityChooser.SelectedIndexChanged += new System.EventHandler(this.dlQualityChooser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tryb";
            // 
            // dlModeChooser
            // 
            this.dlModeChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dlModeChooser.FormattingEnabled = true;
            this.dlModeChooser.Items.AddRange(new object[] {
            "Wideo + audio",
            "Tylko wideo",
            "Tylko audio"});
            this.dlModeChooser.Location = new System.Drawing.Point(9, 47);
            this.dlModeChooser.Name = "dlModeChooser";
            this.dlModeChooser.Size = new System.Drawing.Size(121, 25);
            this.dlModeChooser.TabIndex = 1;
            this.dlModeChooser.SelectedIndexChanged += new System.EventHandler(this.dlModeChooser_SelectedIndexChanged);
            // 
            // downloadButton
            // 
            this.downloadButton.Enabled = false;
            this.downloadButton.Location = new System.Drawing.Point(343, 14);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(87, 62);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Pobierz";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // loadingIcon
            // 
            this.loadingIcon.Image = global::YTDownloader.Properties.Resources.loading;
            this.loadingIcon.Location = new System.Drawing.Point(178, 140);
            this.loadingIcon.Name = "loadingIcon";
            this.loadingIcon.Size = new System.Drawing.Size(35, 35);
            this.loadingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingIcon.TabIndex = 7;
            this.loadingIcon.TabStop = false;
            this.loadingIcon.Visible = false;
            // 
            // loadingText
            // 
            this.loadingText.AutoSize = true;
            this.loadingText.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadingText.Location = new System.Drawing.Point(219, 136);
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(158, 42);
            this.loadingText.TabIndex = 8;
            this.loadingText.Text = "Pobieranie informacji\r\no strumieniach...";
            this.loadingText.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Zapisz pobrany strumień do";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // successMessagePanel
            // 
            this.successMessagePanel.Controls.Add(this.successMessageCloseButton);
            this.successMessagePanel.Controls.Add(this.successMessagePathLabel);
            this.successMessagePanel.Controls.Add(this.label6);
            this.successMessagePanel.Controls.Add(this.label5);
            this.successMessagePanel.Controls.Add(this.label4);
            this.successMessagePanel.Location = new System.Drawing.Point(12, 181);
            this.successMessagePanel.Name = "successMessagePanel";
            this.successMessagePanel.Size = new System.Drawing.Size(433, 130);
            this.successMessagePanel.TabIndex = 9;
            this.successMessagePanel.Visible = false;
            // 
            // successMessageCloseButton
            // 
            this.successMessageCloseButton.Location = new System.Drawing.Point(142, 101);
            this.successMessageCloseButton.Name = "successMessageCloseButton";
            this.successMessageCloseButton.Size = new System.Drawing.Size(149, 23);
            this.successMessageCloseButton.TabIndex = 4;
            this.successMessageCloseButton.Text = "Wróć do konfiguracji";
            this.successMessageCloseButton.UseVisualStyleBackColor = true;
            this.successMessageCloseButton.Click += new System.EventHandler(this.successMessageCloseButton_Click);
            // 
            // successMessagePathLabel
            // 
            this.successMessagePathLabel.AutoEllipsis = true;
            this.successMessagePathLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.successMessagePathLabel.Location = new System.Drawing.Point(0, 53);
            this.successMessagePathLabel.Name = "successMessagePathLabel";
            this.successMessagePathLabel.Size = new System.Drawing.Size(433, 40);
            this.successMessagePathLabel.TabIndex = 3;
            this.successMessagePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(433, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pobrany plik został zapisany w:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pobieranie zakończone sukcesem!";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 316);
            this.Controls.Add(this.successMessagePanel);
            this.Controls.Add(this.loadingText);
            this.Controls.Add(this.loadingIcon);
            this.Controls.Add(this.dlConfigBox);
            this.Controls.Add(this.channelLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.thumbnailBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "YouTube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).EndInit();
            this.dlConfigBox.ResumeLayout(false);
            this.dlConfigBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).EndInit();
            this.successMessagePanel.ResumeLayout(false);
            this.successMessagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}