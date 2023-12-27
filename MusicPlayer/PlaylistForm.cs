using Microsoft.Data.SqlClient;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class PlaylistForm : Form
    {
        private readonly MainForm mainForm;
        private CreatePlaylistForm createPlaylistForm;
        private string email;
        private List<string> playlistNames;
        private List<string> playlistIDs;
        private List<string> trackIDs;

        public PlaylistForm(MainForm mainForm, string email)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.email = email;
            this.playlistNames = new List<string>();
            this.playlistIDs = new List<string>();
            this.trackIDs = new List<string>();
        }

        private void CreateNewPlaylistBtn_Click(object sender, EventArgs e)
        {
            createPlaylistForm = new CreatePlaylistForm(mainForm, email);
            createPlaylistForm.Show(mainForm);
            mainForm.Enabled = false;
        }

        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            LoadPlaylists();
        }

        private void LoadPlaylists()
        {
            playlistNames.Clear();

            using (SqlConnection connection = Connection())
            {
                connection.Open();

                string query = "SELECT playlistID, playlistName FROM PlaylistTable WHERE email = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string playlistID = reader["playlistID"].ToString();
                            string playlistName = reader["playlistName"].ToString();
                            playlistIDs.Add(playlistID);
                            playlistNames.Add(playlistName);
                        }
                    }
                }
            }
            DisplayPlaylists();
        }

        public void DisplayPlaylists()
        {
            // Clear existing panels from the playlistLIstPanel
            playlistLIstPanel.Controls.Clear();

            // Iterate through playlist names and create panels dynamically
            for (int i = 0; i < playlistNames.Count; i++)
            {
                Panel newPanel = CreatePlaylistPanel(playlistNames[i], playlistIDs[i], i, PlaylistPanel_Click);
                playlistLIstPanel.Controls.Add(newPanel);
            }
        }

        private Panel CreatePlaylistPanel(string playlistName, string playlistID, int index, EventHandler panelClickEvent)
        {
            Panel newPanel = new Panel
            {
                Name = $"panelResult{index}",
                Height = 68,
                Width = playlistLIstPanel.Width,
                AutoSize = false,
                AutoScroll = false,
                BackColor = Color.FromArgb(40, 40, 40),
                Cursor = Cursors.Hand,
                Padding = new Padding(3),
                Tag = playlistID,
                Location = new Point(0, (index) * 70)
            };

            Label nameLabel = new Label();
            nameLabel.Text = $"{index + 1}. {playlistName}";
            nameLabel.ForeColor = Color.White;
            nameLabel.Font = new Font("Segoe UI", 15);
            nameLabel.AutoSize = true;
            nameLabel.Tag = playlistID;
            nameLabel.Location = new System.Drawing.Point(10, 15);

            newPanel.Controls.Add(nameLabel);

            // Attach the click event handler to the panel and its controls
            newPanel.Click += panelClickEvent;
            nameLabel.Click += panelClickEvent;

            return newPanel;
        }

        private string GetPlaylistIdFromSender(object sender)
        {
            // Use a switch statement to identify the type of the clicked control
            return sender switch
            {
                Panel clickedPanel => (string)clickedPanel?.Tag ?? string.Empty,
                Label clickedLabel => (string)clickedLabel?.Tag ?? string.Empty,
            };
        }

        private void PlaylistPanel_Click(object sender, EventArgs e)
        {
            playlistMusicListPanel.Visible = true;
            string playlistID = GetPlaylistIdFromSender(sender);

            using (SqlConnection connection = Connection())
            {
                connection.Open();

                string query = "SELECT trackID FROM PlaylistTrackTable WHERE playlistID = @PlaylistID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlaylistID", playlistID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string trackID = reader["trackID"].ToString();
                            trackIDs.Add(trackID);
                        }
                    }
                }
            }

            DisplayPlaylistTracks();
        }

        // Displays search results in the result panel
        private async Task DisplayPlaylistTracks()
        {
            try
            {
                // Get Spotify client configuration
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                    int panelIndex = 1;

                    // Iterate through paginated search results
                    for (int i = 0; i < trackIDs.Count; i++)
                    { 
                        // Set and display the search result
                        await SetSearchResult(trackIDs[i], panelIndex);
                        //loadingTrackIconBox.Location = new Point(0, panelIndex * 100);

                        panelIndex++;
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Sets a single search result in the result panel
        private async Task SetSearchResult(string trackID, int panelIndex)
        {
            // Get metadata for the track
            TrackMetadata trackInfo = new TrackMetadata(trackID, false);
            await trackInfo.SetOnlineTrackMetadata();

            // Extract necessary information
            string trackId = trackID;
            string trackName = TrackMetadata.trackName;
            string artistName = TrackMetadata.artistName;
            object trackPoster = TrackMetadata.trackPoster;

            // Create and add a panel for the search result
            Panel newPanel = CreateResultPanel(trackId, trackName, artistName, trackPoster, panelIndex, ResultPanel_Click);
            //newPanel.Dock = DockStyle.Top;
            musicListPanel.Controls.Add(newPanel);
        }


        // Creates a result panel for a track
        private Panel CreateResultPanel(string trackId, string trackName, string artistName, object trackPoster, int index, EventHandler panelClickEvent)
        {
            // Create a new panel for the search result
            Panel newPanel = new Panel
            {
                Name = $"panelResult{index}",
                Height = 100,
                Width = musicListPanel.Width - 20,
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

        // Clears existing panels from the search result panel
        private void ClearPanels()
        {
            // Get panels to remove
            var panelsToRemove = musicListPanel.Controls.OfType<Panel>().Where(p => p.Name.StartsWith("panelResult")).ToList();

            // Remove each panel and dispose of it
            foreach (var panel in panelsToRemove)
            {
                musicListPanel.Controls.Remove(panel);
                panel.Dispose();
            }
        }

        public static SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Projects\Music Player\MusicPlayer\Data\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
            return con;
        }

        public static async Task<SpotifyClientConfig> StartAuthentication()
        {
            return SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("600ba51cf6464b29b90edc07050e54d9", "9a6802e6a09248808dce71025df7ae97"));
        }
    }
}
