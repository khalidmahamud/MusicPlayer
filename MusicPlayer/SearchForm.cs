using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

namespace MusicPlayer
{
    public partial class SearchFrom : Form
    {
        public SearchFrom()
        {
            InitializeComponent();

            searchResultPanel.HorizontalScroll.Enabled = false;
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

                var result = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.Track, searchBox.Text)
                {
                    Market = "BD"
                });

                // Clears existing panels and labels
                ClearPanels();

                if (result != null)
                {
                    int panelIndex = 1;

                    await foreach (var item in spotify.Paginate(result.Tracks, (t) => t.Tracks))
                    {

                        TrackMetadata trackInfo = new TrackMetadata(item.Id);
                        await trackInfo.SetMetadata();

                        string trackName = TrackMetadata.trackName;
                        string artistName = TrackMetadata.artistName;
                        string trackPoster = TrackMetadata.trackPoster;

                        // Creates a new panel and label dynamically
                        Panel newPanel = CreateResultPanel(trackName, artistName, trackPoster, panelIndex);

                        // Add the new panel to the main panel
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

        private Panel CreateResultPanel(string trackName, string artistName, string trackPoster, int index)
        {
            Panel newPanel = new Panel();
            Label trackLabel = new Label();
            Label artistLabel = new Label();
            PictureBox imageBox = new PictureBox();

            newPanel.Name = $"panelResult{index}";
            newPanel.Height = 100;  // Adjust as needed, considering padding
            newPanel.Width = 470;   // Adjust as needed, considering padding
            newPanel.AutoSize = true;
            newPanel.BackColor = Color.FromArgb(240, 240, 240);
            //newPanel.BorderStyle = BorderStyle.FixedSingle;

            int panelYPosition = (index - 1) * newPanel.Height;
            newPanel.Location = new Point(0, panelYPosition);

            // PictureBox for the image on the left
            imageBox.Name = $"pictureBoxResult{index}";
            imageBox.ImageLocation = trackPoster;  // Set the image location
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.Width = 100;  // Adjust the width as needed
            imageBox.Height = newPanel.Height;

            // Label for the track name on the right top
            trackLabel.Name = $"labelTrack{index}";
            trackLabel.Text = trackName;
            trackLabel.AutoSize = false;
            trackLabel.Font = new Font("Calibre", trackName.Length > 25 ? 13 : 16);
            trackLabel.Width = newPanel.Width - imageBox.Width;
            trackLabel.Height = 40;  // Adjust the height as needed
            trackLabel.Location = new Point(imageBox.Width, 0);
            trackLabel.TextAlign = ContentAlignment.BottomLeft;
            trackLabel.Location = new Point(120, 5);

            // Label for the artist name on the right bottom
            artistLabel.Name = $"labelArtist{index}";
            artistLabel.Text = "Song - " + artistName;
            artistLabel.AutoSize = false;
            artistLabel.Font = new Font("Arial", 12);
            artistLabel.Width = newPanel.Width - imageBox.Width;
            artistLabel.Height = 40;  // Adjust the height as needed
            artistLabel.Location = new Point(imageBox.Width, newPanel.Height - artistLabel.Height);
            artistLabel.TextAlign = ContentAlignment.TopLeft;
            artistLabel.Location = new Point(120, 60);

            // Add controls to the panel
            newPanel.Controls.Add(imageBox);
            newPanel.Controls.Add(trackLabel);
            newPanel.Controls.Add(artistLabel);

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
    }
}
