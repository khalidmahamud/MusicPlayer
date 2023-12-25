using SpotifyAPI.Web;
using System;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace MusicPlayer
{
    public partial class LocalMusicForm : Form
    {
        private readonly MainForm mainform;
        private const string MusicDirectory = @"C:\Users\DELL\Music";
        string[] musicFiles;

        public LocalMusicForm(MainForm mainform)
        {
            InitializeComponent();
            LoadLocalMusic();

            this.mainform = mainform;
        }

        private void LoadLocalMusic()
        {
            LoadMusicFiles(MusicDirectory);
        }

        private void LoadMusicFiles(string path)
        {
            try
            {
                string[] musicFiles = Directory.GetFiles(path, "*.mp3");

                ClearPanels();

                if (musicFiles != null)
                {
                    int panelIndex = 1;

                    foreach (var filePath in musicFiles)
                    {
    
                        TrackMetadata trackInfo = new TrackMetadata(filePath, true);
                        trackInfo.SetLocalTrackMetadata();

                        string trackId = filePath;
                        string trackName = TrackMetadata.trackName;
                        string artistName = TrackMetadata.artistName;
                        object trackPoster = TrackMetadata.trackPoster;

                        Panel newPanel = CreateLocalFilePanel(filePath, trackId, trackName, artistName, trackPoster, panelIndex, localMusicFile_Click);
                        localMusicFilesPanel.Controls.Add(newPanel);

                        panelIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Directory does not exist");
            }
        }

        private void localMusicFile_Click(object sender, EventArgs e)
        {
            string trackPath = GetTrackIdFromSender(sender);
            mainform.OpenMusicInfoForm(trackPath, true);
            mainform.OpenMediaPlayerControlForm(trackPath, true);
        }

        private string GetTrackIdFromSender(object sender)
        {
            return sender switch
            {
                Panel clickedPanel => (string)clickedPanel?.Tag ?? string.Empty,
                Label clickedLabel => (string)clickedLabel?.Tag ?? string.Empty,
                PictureBox clickedPictureBox => (string)clickedPictureBox?.Tag ?? string.Empty,
                Button clickedButton => (string)clickedButton?.Tag ?? string.Empty,
                _ => string.Empty,
            };
        }


        private Panel CreateLocalFilePanel(string trackPath, string trackId, string trackName, string artistName, object trackPoster, int index, EventHandler panelClickEvent)
        {
            Panel newPanel = new Panel
            {
                Name = $"panelResult{index}",
                Height = 100,
                Width = localMusicFilesPanel.Width - 20,
                AutoSize = false,
                AutoScroll = false,
                BackColor = Color.FromArgb(18, 18, 18),
                Cursor = Cursors.Hand,
                Tag = trackPath,
                Location = new Point(0, (index - 1) * 100)
            };

            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 4
            };

            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));

            // PictureBox for the image on the left
            PictureBox imageBox = new PictureBox();
            imageBox.Name = $"pictureBoxResult{index}";
            imageBox.Image = (Image)trackPoster;
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.Dock = DockStyle.Fill;
            imageBox.Tag = trackPath;
            // Adds controls to the table layout panel
            tableLayout.Controls.Add(imageBox, 0, 0);
            tableLayout.SetRowSpan(imageBox, 4);

            // Label for the track name in the second column
            Label trackLabel = new Label();
            trackLabel.Name = $"labelTrack{index}";
            trackLabel.Text = trackName;
            trackLabel.AutoSize = false;
            trackLabel.Font = new Font("Calibre", trackName.Length > 25 ? 13 : 16);
            trackLabel.ForeColor = Color.White;
            trackLabel.Dock = DockStyle.Fill;
            trackLabel.TextAlign = ContentAlignment.BottomLeft;
            trackLabel.Padding = new Padding(5, 5, 5, 5);
            trackLabel.Tag = trackPath;
            // Adds controls to the table layout panel
            tableLayout.Controls.Add(trackLabel, 1, 1);

            // Label for the artist name in the second column
            Label artistLabel = new Label();
            artistLabel.Name = $"labelArtist{index}";
            artistLabel.Text = "Song - " + artistName;
            artistLabel.AutoSize = false;
            artistLabel.Font = new Font("Arial", 12);
            artistLabel.ForeColor = Color.White;
            artistLabel.Dock = DockStyle.Fill;
            artistLabel.TextAlign = ContentAlignment.TopLeft;
            artistLabel.Padding = new Padding(7, 5, 5, 5);
            artistLabel.Tag = trackPath;
            // Adds controls to the table layout panel
            tableLayout.Controls.Add(artistLabel, 1, 2);

            // Button for play in the third column
            Button playButton = new Button();
            playButton.Name = $"buttonPlay{index}";
            playButton.Image = Resource1.play;
            playButton.ImageAlign = ContentAlignment.MiddleCenter;
            playButton.Dock = DockStyle.Left;
            playButton.FlatAppearance.BorderSize = 0;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.BackColor = Color.FromArgb(18, 18, 18);
            playButton.ForeColor = Color.FromArgb(0, 0, 0);
            playButton.Tag = trackId;
            // Adds controls to the table layout panel
            tableLayout.Controls.Add(playButton, 2, 1);
            tableLayout.SetRowSpan(playButton, 2);

            // Adds table layout panel to the main panel
            newPanel.Controls.Add(tableLayout);

            // Attaches the click event handler
            newPanel.Click += panelClickEvent;
            trackLabel.Click += panelClickEvent;
            artistLabel.Click += panelClickEvent;
            imageBox.Click += panelClickEvent;
            playButton.Click += panelClickEvent;

            return newPanel;
        }

        private void ClearPanels()
        {
            var panelsToRemove = localMusicFilesPanel.Controls.OfType<Panel>().Where(p => p.Name.StartsWith("panelResult")).ToList();
            foreach (var panel in panelsToRemove)
            {
                localMusicFilesPanel.Controls.Remove(panel);
                panel.Dispose();
            }
        }
    }
}
