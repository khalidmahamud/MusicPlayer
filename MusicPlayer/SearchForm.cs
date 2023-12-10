using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace MusicPlayer
{
    public partial class SearchForm : Form
    {
        private MainForm mainForm;
        public SearchForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            searchResultPanel.HorizontalScroll.Maximum = 0;
            searchResultPanel.AutoScroll = false;
            searchResultPanel.VerticalScroll.Visible = false;
            searchResultPanel.AutoScroll = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Calls search method
                await PerformSearch();
            }
        }

        private async void Search_Btn_Click(object sender, EventArgs e)
        {
            // Calls search method
            await PerformSearch();
        }

        private async Task PerformSearch()
        {
            try
            {
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                var result = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.Track, searchBox.Text));

                // Clears existing panels and labels
                ClearPanels();

                if (result != null)
                {
                    int panelIndex = 1;

                    await foreach (var item in spotify.Paginate(result.Tracks, (t) => t.Tracks))
                    {
                        if (item.PreviewUrl == null)
                        {
                            continue; // Skips if track preview is nulll
                        }

                        TrackMetadata trackInfo = new TrackMetadata(item.Id);
                        await trackInfo.SetMetadata();

                        string trackId = item.Id;
                        string trackName = TrackMetadata.trackName;
                        string artistName = TrackMetadata.artistName;
                        string trackPoster = TrackMetadata.trackPoster;

                        // Creates a new panel and label dynamically
                        Panel newPanel = CreateResultPanel(trackId, trackName, artistName, trackPoster, panelIndex, ResultPanel_Click);
                        newPanel.AutoSize = false;


                        // Adds the new panel to the main panel
                        searchResultPanel.Controls.Add(newPanel);

                        panelIndex++;

                        if (panelIndex == 20) break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ResultPanel_Click(object sender, EventArgs e)
        {
            string trackId = "";

            if (sender is Panel)
            {
                Panel clickedPanel = (Panel)sender;
                trackId = (string)clickedPanel.Tag;
            }
            else if (sender is Label)
            {
                Label clickedLabel = (Label)sender;
                trackId = (string)clickedLabel.Tag;
            }
            else if (sender is PictureBox)
            {
                PictureBox clickedPictureBox = (PictureBox)sender;
                trackId = (string)clickedPictureBox.Tag;
            }
            else if (sender is Button)
            {
                Button clickedButton = (Button)sender;
                trackId = (string)clickedButton.Tag;

                //mainForm.OpenMediaPlayerControlForm(trackId);
            }

            mainForm.OpenMusicInfoForm(trackId);
            mainForm.OpenMediaPlayerControlForm(trackId);
        }

        private Panel CreateResultPanel(string trackId, string trackName, string artistName, string trackPoster, int index, EventHandler panelClickEvent)
        {
            // Create the main panel
            Panel newPanel = new Panel();
            newPanel.Name = $"panelResult{index}";
            newPanel.Height = 100;
            newPanel.Width = searchResultPanel.Width - 20;
            newPanel.AutoSize = false;
            newPanel.AutoScroll = false;
            newPanel.BackColor = Color.FromArgb(18, 18, 18);
            newPanel.Cursor = Cursors.Hand;
            newPanel.Tag = trackId;

            int panelYPosition = (index - 1) * newPanel.Height;
            newPanel.Location = new Point(0, panelYPosition);

            // Create the table layout panel
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.ColumnCount = 3;
            tableLayout.RowCount = 4;
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
            playButton.ForeColor = Color.FromArgb(0,0,0);
            playButton.Tag = trackId;
            // Adda controls to the table layout panel
            tableLayout.Controls.Add(playButton, 2, 1);
            tableLayout.SetRowSpan(playButton, 2);

            // Adds table layout panel to the main panel
            newPanel.Controls.Add(tableLayout);

            // Attach the click event handler
            newPanel.Click += panelClickEvent;
            trackLabel.Click += panelClickEvent;
            artistLabel.Click += panelClickEvent;
            imageBox.Click += panelClickEvent;
            playButton.Click += panelClickEvent;

            return newPanel;
        }



        // Clear existing panels
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
            var config = SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("600ba51cf6464b29b90edc07050e54d9", "9a6802e6a09248808dce71025df7ae97"));

            return config;
        }

        private void searchResultPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
