using AngleSharp.Common;
using Microsoft.Toolkit.Uwp.Notifications;
using Syroot.Windows.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using YoutubeExplode;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Videos.Streams;

namespace YTDownloader
{
    public partial class Form1 : Form
    {
        private const string GITHUB_REPO_URL = "https://github.com/bartekmuzyk/YTDownloader";

        private YoutubeClient _ytClient = new();

        private StreamManifest? _currentStreamManifest = null;

        private IOrderedEnumerable<IStreamInfo>? _availableStreams = null;

        private IStreamInfo? _chosenStream = null;

        private CancellationTokenSource? _downloadCancellationTokenSource = null;

        private bool downloadInProgress
        {
            get => _downloadCancellationTokenSource != null;
        }

        private bool _downloadCancelled = false;

        private enum DownloadMode
        {
            VideoAndAudio,
            VideoOnly,
            AudioOnly
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.darkMode) DarkMode.AutoDarkMode(this);

            ControlDecoration.MakeControlRounded(dlProgressBar, 1);

            MaximumSize = MinimumSize = Size;

            try
            {
                URLProtocol.RegisterProtocol();
                Properties.Settings.Default.showExtensionMessage = false;
            }
            catch (UnauthorizedAccessException)
            {
                if (Properties.Settings.Default.showExtensionMessage)
                {
                    MessageBox.Show("Mo¿esz jednorazowo uruchomiæ aplikacjê jako administrator. To pozwoli na wykonanie zmian w rejestrze potrzebnych do poprawnego dzia³ania wtyczki do przegl¹darki Google Chrome. Mo¿esz wy³¹czyæ ten komunikat w ustawieniach.", "Informacja dotycz¹ca wtyczki", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            Properties.Settings.Default.Save();

            var url = URLProtocol.GetPassedArgument();

            if (url == null && Environment.GetCommandLineArgs().Length > 1)
            {
                url = Environment.GetCommandLineArgs()[1];
            }

            if (url == $"{URLProtocol.PROTOCOL_NAME}:")
            {
                url = null;
            }

            if (url != null)
            {
                urlInput.Text = url;
                BeginSearch();
            }

            ToastNotificationManagerCompat.OnActivated += ToastNotificationManagerCompat_OnActivated;
        }

        private void ToastNotificationManagerCompat_OnActivated(ToastNotificationActivatedEventArgsCompat e)
        {
            Invoke(() =>
            {
                Show();
                WindowState = FormWindowState.Normal;
                BringToFront();
                TopMost = true;
                Focus();
                TopMost = false;
            });
        }

        private void SetLoadingVisible(bool visible)
        {
            loadingIcon.Visible = loadingText.Visible = visible;
        }

        private void ResetControls()
        {
            titleLabel.Text = channelLabel.Text = string.Empty;
            thumbnailBox.Image = null;
            dlConfigBox.Visible = false;
            successMessagePanel.Visible = false;
            dlModeChooser.SelectedItem = null;
            dlQualityChooser.Items.Clear();
            downloadButton.Enabled = false;
            dlProgressBar.Value = 0;
            dlProgressDescription.Text = "Wybierz tryb";
        }

        private void BeginSearch()
        {
            var urlToSearch = urlInput.Text.Trim();

            if (urlToSearch.Length == 0)
            {
                MessageBox.Show("Podaj odpowiedni adres URL", "Brak adresu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            urlInput.Enabled = false;
            searchBtn.Enabled = false;

            ResetControls();
            titleLabel.Text = "Wyszukiwanie...";

            try
            {
                var getVideoTask = _ytClient.Videos.GetAsync(urlToSearch);

                getVideoTask.GetAwaiter().OnCompleted(() =>
                {
                    try
                    {
                        var videoInfo = getVideoTask.Result;

                        titleLabel.Text = videoInfo.Title;
                        channelLabel.Text = videoInfo.Author.ChannelTitle;

                        if (Properties.Settings.Default.downloadThumbnails)
                        {
                            var thumbnails = videoInfo.Thumbnails.OrderByDescending(thumbnail => thumbnail.Resolution.Area);
                            var thumbnailLoadedSuccessfully = false;

                            foreach (var thumbnail in thumbnails)
                            {
                                try
                                {
                                    thumbnailBox.Load(thumbnail.Url);
                                    thumbnailLoadedSuccessfully = true;
                                    break;
                                }
                                catch (ArgumentException)
                                {
                                    continue;
                                }
                            }

                            if (!thumbnailLoadedSuccessfully)
                            {
                                MessageBox.Show("Nie uda³o siê za³adowaæ miniaturki. Pobieranie filmu powinno jednak nadal dzia³aæ.", "B³¹d podczas ³adowania miniaturki", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        SetLoadingVisible(true);

                        var getManifestTask = _ytClient.Videos.Streams.GetManifestAsync(urlToSearch);

                        getManifestTask.GetAwaiter().OnCompleted(() =>
                        {
                            _currentStreamManifest = getManifestTask.Result;
                            dlConfigBox.Visible = true;
                            SetLoadingVisible(false);
                        });
                    }
                    catch (VideoUnavailableException)
                    {
                        MessageBox.Show("Nie mo¿na odnaleŸæ filmu pod podanym adresem URL. Upewnij siê, ¿e film nie jest prywatny.", "Nie odnaleziono filmu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetControls();
                    }
                });
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Niepoprawny adres URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetControls();
            }

            urlInput.Enabled = true;
            searchBtn.Enabled = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            BeginSearch();
        }

        private void SetAvailableStreams(IOrderedEnumerable<MuxedStreamInfo> streams)
        {
            _availableStreams = streams;

            var friendlyStreamNames = streams.Select(stream =>
                $"{stream.Container.Name} {stream.VideoQuality.Label} {stream.Size}"
            ).ToArray();
            dlQualityChooser.Items.Add("Najlepszy strumieñ");
            dlQualityChooser.Items.AddRange(friendlyStreamNames);
        }

        private void SetAvailableStreams(IOrderedEnumerable<IVideoStreamInfo> streams)
        {
            _availableStreams = streams;

            var friendlyStreamNames = streams.Select(stream =>
                $"{stream.Container.Name} {stream.VideoQuality.Label} {stream.Size}"
            ).ToArray();
            dlQualityChooser.Items.Add("Najlepsza jakoœæ wideo");
            dlQualityChooser.Items.AddRange(friendlyStreamNames);
        }

        private void SetAvailableStreams(IOrderedEnumerable<IAudioStreamInfo> streams)
        {
            _availableStreams = streams;

            var friendlyStreamNames = streams.Select(stream =>
                $"{stream.Container.Name} (bitrate {stream.Bitrate}) {stream.Size}"
            ).ToArray();
            dlQualityChooser.Items.Add("Najlepsza jakoœæ audio");
            dlQualityChooser.Items.AddRange(friendlyStreamNames);
        }

        private void dlModeChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ((ComboBox)sender).SelectedIndex;

            if (selectedIndex == -1) return;

            var mode = (DownloadMode)selectedIndex;

            dlQualityChooser.Items.Clear();
            dlProgressDescription.Text = "Wybierz jakoœæ";

            switch (mode)
            {
                case DownloadMode.VideoAndAudio:
                    {
                        var streams = _currentStreamManifest!.GetMuxedStreams().OrderByDescending(stream => stream.VideoResolution.Area);
                        SetAvailableStreams(streams);
                    }
                    break;
                case DownloadMode.VideoOnly:
                    {
                        var streams = _currentStreamManifest!.GetVideoOnlyStreams().OrderByDescending(stream => stream.VideoResolution.Area);
                        SetAvailableStreams(streams);
                    }
                    break;
                case DownloadMode.AudioOnly:
                    {
                        var streams = _currentStreamManifest!.GetAudioOnlyStreams().OrderByDescending(stream => stream.Bitrate.BitsPerSecond);
                        SetAvailableStreams(streams);
                    }
                    break;
            }

            dlQualityChooser.Enabled = true;
            dlQualityChooser.SelectedIndex = 0;
        }

        private void dlQualityChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qualityIndex = ((ComboBox)sender).SelectedIndex;

            _chosenStream = qualityIndex == 0 ?
                _availableStreams!.GetWithHighestBitrate()
                :
                _availableStreams!.GetItemByIndex(qualityIndex - 1);

            downloadButton.Enabled = true;
            dlProgressDescription.Text = "Gotowy! Kliknij \"Pobierz\", aby rozpocz¹æ pobieranie.";
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            var self = (Button)sender;

            if (_downloadCancellationTokenSource != null)
            {
                _downloadCancelled = true;
                _downloadCancellationTokenSource.Cancel();
                self.Text = "Pobierz";

                return;
            }

            saveFileDialog.InitialDirectory = KnownFolders.Downloads.ExpandedPath;
            var extension = _chosenStream!.Container.Name;
            saveFileDialog.Filter = $"Plik {extension.ToUpper()}|*.{extension}";
            saveFileDialog.FileName = new Regex("[<>:\"/\\\\|?*]").Replace(titleLabel.Text, "-");  // Remove Windows illegal file name characters
            var dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                self.Text = "Anuluj";
            }
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var targetPath = Path.GetFullPath(((SaveFileDialog)sender).FileName);

            _downloadCancellationTokenSource = new CancellationTokenSource();
            _downloadCancelled = false;
            searchBtn.Enabled = false;

            var downloadTask = _ytClient.Videos.Streams.DownloadAsync(
                _chosenStream!,
                targetPath,
                new ProgressReportReceiver(progress =>
                {
                    var progressAsPercentage = (int)Math.Ceiling(progress * 100d);
                    dlProgressDescription.Text = $"Pobieranie... ({progressAsPercentage}%)";

                    if (progressAsPercentage < 100)
                    {
                        // Workaround to disable smooth value change animation in progress bar
                        dlProgressBar.Value = progressAsPercentage + 1;
                    }
                    dlProgressBar.Value = progressAsPercentage;
                }),
                _downloadCancellationTokenSource.Token
            ).AsTask();

            downloadTask.GetAwaiter().OnCompleted(() =>
            {
                _downloadCancellationTokenSource.Dispose();
                _downloadCancellationTokenSource = null;
                searchBtn.Enabled = true;

                if (_downloadCancelled)
                {
                    File.Delete(targetPath);
                    dlProgressBar.Value = 0;
                    dlProgressDescription.Text = "Anulowano pobieranie.";
                    return;
                }

                new ToastContentBuilder()
                    .AddText("YouTube Downloader zakoñczy³ pobieranie")
                    .AddText("Kliknij tutaj, aby przywo³aæ okno.")
                    .Show();

                successMessagePathLabel.Text = targetPath;
                successMessagePanel.Visible = true;
                dlConfigBox.Visible = false;
                dlProgressDescription.Text = "Pobieranie zakoñczone sukcesem";
                downloadButton.Text = "Pobierz";
            });
        }

        private void successMessageCloseButton_Click(object sender, EventArgs e)
        {
            successMessagePanel.Visible = false;
            dlConfigBox.Visible = true;
        }

        private void settingsBtn_MouseHover(object sender, EventArgs e)
        {
            settingsLabel.Visible = true;
        }

        private void settingsBtn_MouseLeave(object sender, EventArgs e)
        {
            settingsLabel.Visible = false;
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            BrowserOpener.OpenUrl(GITHUB_REPO_URL);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (downloadInProgress)
            {
                var result = MessageBox.Show("Zamkniêcie przerwie pobieranie. Czy na pewno chcesz wyjœæ z aplikacji?", "Pobieranie w toku", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            if (!e.Cancel)
            {
                ToastNotificationManagerCompat.Uninstall();
            }
        }
    }
}