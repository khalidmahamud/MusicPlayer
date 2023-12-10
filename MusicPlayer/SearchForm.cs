using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace MusicPlayer
{
    public partial class SearchForm : Form
    {
        private readonly MainForm mainForm;

        public SearchForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            ConfigureSearchResultPanel();
        }

        private void ConfigureSearchResultPanel()
        {
            searchResultPanel.HorizontalScroll.Maximum = 0;
            searchResultPanel.AutoScroll = false;
            searchResultPanel.VerticalScroll.Visible = false;
            searchResultPanel.AutoScroll = true;
        }

        private async void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await PerformSearch();
            }
        }

        private async void Search_Btn_Click(object sender, EventArgs e)
        {
            await PerformSearch();
        }

        private async Task PerformSearch()
        {
            try
            {
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                var result = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.Track, searchBox.Text));

                ClearPanels();

                if (result != null)
                {
                    int panelIndex = 1;

                    await foreach (var item in spotify.Paginate(result.Tracks, (t) => t.Tracks))
                    {
                        if (item.PreviewUrl == null)
                            continue;

                        TrackMetadata trackInfo = new TrackMetadata(item.Id);
                        await trackInfo.SetMetadata();

                        string trackId = item.Id;
                        string trackName = TrackMetadata.trackName;
                        string artistName = TrackMetadata.artistName;
                        string trackPoster = TrackMetadata.trackPoster;

                        Panel newPanel = CreateResultPanel(trackId, trackName, artistName, trackPoster, panelIndex, ResultPanel_Click);
                        searchResultPanel.Controls.Add(newPanel);

                        panelIndex++;

                        if (panelIndex == 20) break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                // Handle exception as needed (e.g., show an error message)
            }
        }

        private void ResultPanel_Click(object sender, EventArgs e)
        {
            string trackId = GetTrackIdFromSender(sender);
            mainForm.OpenMusicInfoForm(trackId);
            mainForm.OpenMediaPlayerControlForm(trackId);
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


        private Panel CreateResultPanel(string trackId, string trackName, string artistName, string trackPoster, int index, EventHandler panelClickEvent)
        {
            Panel newPanel = new Panel
            {
                Name = $"panelResult{index}",
                Height = 100,
                Width = searchResultPanel.Width - 20,
                AutoSize = false,
                AutoScroll = false,
                BackColor = Color.FromArgb(18, 18, 18),
                Cursor = Cursors.Hand,
                Tag = trackId,
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
            imageBox.ImageLocation = trackPoster;
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.Dock = DockStyle.Fill;
            imageBox.Tag = trackId;
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
            trackLabel.Tag = trackId;
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
            artistLabel.Tag = trackId;
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
            var panelsToRemove = searchResultPanel.Controls.OfType<Panel>().Where(p => p.Name.StartsWith("panelResult")).ToList();
            foreach (var panel in panelsToRemove)
            {
                searchResultPanel.Controls.Remove(panel);
                panel.Dispose();
            }
        }

        public static async Task<SpotifyClientConfig> StartAuthentication()
        {
            return SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("600ba51cf6464b29b90edc07050e54d9", "9a6802e6a09248808dce71025df7ae97"));
        }
    }
}
