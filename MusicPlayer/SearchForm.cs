using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

namespace MusicPlayer
{
    public partial class SearchForm : Form
    {
        // Reference to the main form
        private readonly MainForm mainForm;

        // Constructor
        public SearchForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Configure the appearance of the search result panel
            ConfigureSearchResultPanel();
        }

        // Configures the search result panel appearance
        private void ConfigureSearchResultPanel()
        {
            searchResultPanel.HorizontalScroll.Maximum = 0;
            searchResultPanel.AutoScroll = false;
            searchResultPanel.VerticalScroll.Visible = false;
            searchResultPanel.AutoScroll = true;
        }

        // Handles key down event in the search box
        private async void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Initiate the search when Enter key is pressed
                await PerformSearch();
            }
        }

        // Handles search button click event
        private async void Search_Btn_Click(object sender, EventArgs e)
        {
            // Initiate the search when the search button is clicked
            await PerformSearch();
        }

        // Performs the Spotify search and displays the results
        private async Task PerformSearch()
        {
            try
            {
                // Show loading indicator while searching
                ShowLoading();

                // Get Spotify client configuration
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                // Perform search for tracks
                var result = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.Track, searchBox.Text));

                // Display search results
                await DisplaySearchResults(result);

                // Clear any existing panels
                ClearPanels();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Displays search results in the result panel
        private async Task DisplaySearchResults(SpotifyAPI.Web.SearchResponse result)
        {
            try
            {
                // Get Spotify client configuration
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                // Check if the search result is not null
                if (result != null)
                {
                    int panelIndex = 1;

                    // Iterate through paginated search results
                    await foreach (var item in spotify.Paginate(result.Tracks, (t) => t.Tracks))
                    {
                        // Check if the track has a preview URL
                        if (item.PreviewUrl == null)
                            continue;

                        // Set and display the search result
                        await SetSearchResult(item, panelIndex);
                        //loadingTrackIconBox.Location = new Point(0, panelIndex * 100);

                        panelIndex++;

                        // Display up to 20 results
                        if (panelIndex == 20) break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Sets a single search result in the result panel
        private async Task SetSearchResult(FullTrack item, int panelIndex)
        {
            // Show loading indicator while setting search result
            ShowLoading();

            // Get metadata for the track
            TrackMetadata trackInfo = new TrackMetadata(item.Id, false);
            await trackInfo.SetOnlineTrackMetadata();

            // Extract necessary information
            string trackId = item.Id;
            string trackName = TrackMetadata.trackName;
            string artistName = TrackMetadata.artistName;
            object trackPoster = TrackMetadata.trackPoster;

            // Hide loading indicator after setting the search result
            HideLoading();

            // Create and add a panel for the search result
            Panel newPanel = CreateResultPanel(trackId, trackName, artistName, trackPoster, panelIndex, ResultPanel_Click);
            //newPanel.Dock = DockStyle.Top;
            searchResultPanel.Controls.Add(newPanel);
        }

        // Handles the click event on a result panel
        private void ResultPanel_Click(object sender, EventArgs e)
        {
            // Get the track ID from the clicked control and open related forms
            string trackId = GetTrackIdFromSender(sender);
            mainForm.OpenMusicInfoForm(trackId, false);
            mainForm.OpenMediaPlayerControlForm(trackId, false);
        }

        // Retrieves track ID from the clicked control
        private string GetTrackIdFromSender(object sender)
        {
            // Use a switch statement to identify the type of the clicked control
            return sender switch
            {
                Panel clickedPanel => (string)clickedPanel?.Tag ?? string.Empty,
                Label clickedLabel => (string)clickedLabel?.Tag ?? string.Empty,
                PictureBox clickedPictureBox => (string)clickedPictureBox?.Tag ?? string.Empty,
                Button clickedButton => (string)clickedButton?.Tag ?? string.Empty,
                _ => string.Empty,
            };
        }

        // Creates a result panel for a track
        private Panel CreateResultPanel(string trackId, string trackName, string artistName, object trackPoster, int index, EventHandler panelClickEvent)
        {
            // Create a new panel for the search result
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

            // Create a table layout for organizing controls within the panel
            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 4
            };

            // Set up row and column styles for the table layout
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));

            // Create a PictureBox for displaying the track image
            PictureBox imageBox = new PictureBox();
            imageBox.Name = $"pictureBoxResult{index}";
            imageBox.ImageLocation = trackPoster.ToString();
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.Dock = DockStyle.Fill;
            imageBox.Tag = trackId;
            // Add the PictureBox to the table layout
            tableLayout.Controls.Add(imageBox, 0, 0);
            tableLayout.SetRowSpan(imageBox, 4);

            // Create a Label for displaying the track name
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
            // Add the Label to the table layout
            tableLayout.Controls.Add(trackLabel, 1, 1);

            // Create a Label for displaying the artist name
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
            // Add the Label to the table layout
            tableLayout.Controls.Add(artistLabel, 1, 2);

            // Create a Button for playing the track
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
            // Add the Button to the table layout
            tableLayout.Controls.Add(playButton, 2, 1);
            tableLayout.SetRowSpan(playButton, 2);

            // Add the table layout to the main panel
            newPanel.Controls.Add(tableLayout);

            // Attach the click event handler to the panel and its controls
            newPanel.Click += panelClickEvent;
            trackLabel.Click += panelClickEvent;
            artistLabel.Click += panelClickEvent;
            imageBox.Click += panelClickEvent;
            playButton.Click += panelClickEvent;

            return newPanel;
        }

        // Clears existing panels from the search result panel
        private void ClearPanels()
        {
            // Get panels to remove
            var panelsToRemove = searchResultPanel.Controls.OfType<Panel>().Where(p => p.Name.StartsWith("panelResult")).ToList();

            // Remove each panel and dispose of it
            foreach (var panel in panelsToRemove)
            {
                searchResultPanel.Controls.Remove(panel);
                panel.Dispose();
            }
        }

        // Handles click event on the rock genre button
        private async void rockBtn_Click(object sender, EventArgs e)
        {
            // Initiate a genre-based search
            await SearchByGenre(rockBtn.Tag.ToString());
        }

        // Handles click event on the classic genre button
        private async void classicBtn_Click(object sender, EventArgs e)
        {
            // Initiate a genre-based search
            await SearchByGenre(classicBtn.Tag.ToString());
        }

        // Handles click event on the country genre button
        private async void countryBtn_Click(object sender, EventArgs e)
        {
            // Initiate a genre-based search
            await SearchByGenre(countryBtn.Tag.ToString());
        }

        // Handles click event on the jazz genre button
        private async void jazzBtn_Click(object sender, EventArgs e)
        {
            // Initiate a genre-based search
            await SearchByGenre(jazzBtn.Tag.ToString());
        }

        // Handles click event on the folk genre button
        private async void folkBtn_Click(object sender, EventArgs e)
        {
            // Initiate a genre-based search
            await SearchByGenre(folkBtn.Tag.ToString());
        }

        // Handles click event on the rap genre button
        private async void rapBtn_Click(object sender, EventArgs e)
        {
            // Initiate a genre-based search
            await SearchByGenre(rapBtn.Tag.ToString());
        }

        // Handles click event on the pop genre button
        private async void popBtn_Click(object sender, EventArgs e)
        {
            // Initiate a genre-based search
            await SearchByGenre(popBtn.Tag.ToString());
        }

        // Handles click event on the metal genre button
        private async void metalBtn_Click(object sender, EventArgs e)
        {
            // Initiate a genre-based search
            await SearchByGenre(metalBtn.Tag.ToString());
        }

        // Initiates a genre-based search
        public async Task SearchByGenre(string genre)
        {
            try
            {
                // Show loading indicator while searching
                ShowLoading();

                // Get Spotify client configuration
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                // Perform a genre-based search
                var result = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.Playlist, genre));

                // Check if there are any playlists in the search results
                if (result?.Playlists?.Items?.Count > 0)
                {
                    // Get the ID of the first playlist in the search results
                    var playlistId = result.Playlists.Items[0].Id;

                    // Get tracks from the playlist
                    var playlistTracks = await spotify.Playlists.Get(playlistId);

                    // Check if there are any tracks in the playlist
                    if (playlistTracks?.Tracks?.Items != null)
                    {
                        int panelIndex = 1;

                        // Iterate through tracks in the playlist
                        foreach (PlaylistTrack<IPlayableItem> item in playlistTracks.Tracks.Items)
                        {
                            // Check if the track is a FullTrack and has a preview URL
                            if (item?.Track is FullTrack track)
                            {
                                if (track.PreviewUrl == null)
                                    continue;

                                // Set and display the search result
                                await SetSearchResult(track, panelIndex);

                                panelIndex++;

                                // Display up to 20 results
                                if (panelIndex == 20) break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No tracks found in the playlist.");
                    }
                }
                else
                {
                    Console.WriteLine("No playlists found in the search results.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Hide loading indicator after search is complete
                HideLoading();
            }
        }

        // Initiates Spotify authentication
        public static async Task<SpotifyClientConfig> StartAuthentication()
        {
            return SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("600ba51cf6464b29b90edc07050e54d9", "9a6802e6a09248808dce71025df7ae97"));
        }

        // Shows the loading indicator
        private void ShowLoading()
        {
            searchResultPanel.Visible = true;
            loadingTrackIconBox.Visible = true;
            loadingTrackIconBox.Dock = DockStyle.Bottom;
        }

        // Hides the loading indicator
        private void HideLoading()
        {
            loadingTrackIconBox.Visible = false;
        }
    }
}
