using Microsoft.Data.SqlClient;
using SpotifyAPI.Web;
using System;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace MusicPlayer
{
    public partial class HomeForm : Form
    {
        private string userEmail;
        private readonly MainForm mainForm;

        DateTime currentTime = DateTime.Now;

        // Define a private static instance variable
        private static HomeForm instance;

        // Define a private constructor to prevent external instantiation
        private HomeForm(MainForm mainForm, string userEmail)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.userEmail = userEmail;

            greetingLabel.Text = GetGreeting(currentTime);
        }

        // Define a public method to get the instance (singleton pattern)
        public static HomeForm GetInstance(MainForm mainForm, string userEmail)
        {
            // If the instance is null, create a new instance
            if (instance == null)
            {
                instance = new HomeForm(mainForm, userEmail);
            }

            // Return the instance
            return instance;
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            LoadUserName();
            await LoadRecommended();
            await LoadPopularNow();
        }

        public void LoadUserName()
        {
            //show user name at the top
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Projects\Music Player\MusicPlayer\Data\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con1.Open();

                string query = "SELECT name FROM MusicPlayerUserTable WHERE email=@email";
                SqlCommand sql1 = new SqlCommand(query, con1);

                sql1.Parameters.AddWithValue("@email", userEmail);

                using (SqlDataReader reader = sql1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Access the columns by name or index
                        string userName = reader["name"].ToString();
                        string firstName = ExtractFirstName(userName);
                        userNameTextBox.Text = firstName;
                    }
                    else
                    {
                        // User not found
                    }
                }
                con1.Close();

            }
        }

        private async Task LoadRecommended()
        {
            await LoadMusicBox("recommendedBox", "37i9dQZF1DX794NyvTu6nv");
        }

        private async Task LoadPopularNow()
        {
            await LoadMusicBox("popularNowBox", "37i9dQZF1DX6R7QUWePReA");
        }

        private async Task LoadMusicBox(string type, string playlistID)
        {
            try
            {
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                var result = await spotify.Playlists.Get(playlistID);

                if (result?.Tracks?.Items != null)
                {
                    int panelIndex = 1;

                    // Iterate through tracks in the playlist
                    foreach (PlaylistTrack<IPlayableItem> item in result.Tracks.Items)
                    {
                        // Check if the track is a FullTrack and has a preview URL
                        if (item?.Track is FullTrack track)
                        {
                            if (track.PreviewUrl == null)
                                continue;

                            // Set and display the search result
                            await SetMusicBox(track, panelIndex, type, musicBox_Clicked);

                            panelIndex++;

                            // Display up to 20 results
                            if (panelIndex > 4) break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No tracks found in the playlist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

        private void musicBox_Clicked(object sender, EventArgs e)
        {
            // Get the track ID from the clicked control and open related forms
            string trackId = GetTrackIdFromSender(sender);
            mainForm.OpenMusicInfoForm(trackId, false);
            mainForm.OpenMediaPlayerControlForm(trackId, false);
        }

        private string GetTrackIdFromSender(object sender)
        {
            // Use a switch statement to identify the type of the clicked control
            return sender switch
            {
                PictureBox clickedPictureBox => (string)clickedPictureBox?.Tag ?? string.Empty,
            };
        }

        private async Task SetMusicBox(FullTrack item, int panelIndex, string type, EventHandler panelClickEvent)
        {
            try
            {
                // Get metadata for the track
                TrackMetadata trackInfo = new TrackMetadata(item.Id, false);
                await trackInfo.SetOnlineTrackMetadata();

                // Extract necessary information
                string trackId = item.Id;
                object trackPoster = TrackMetadata.trackPoster;

                // Get the PictureBox control dynamically based on panelIndex
                PictureBox pictureBox = Controls.Find($"{type + panelIndex}", true).FirstOrDefault() as PictureBox;

                if (pictureBox != null && trackPoster != null)
                {
                    if (trackPoster is string imageUrl)
                    {
                        // If trackPoster is a string (URL), set the ImageLocation property
                        pictureBox.ImageLocation = imageUrl;
                    }
                    else if (trackPoster is Image image)
                    {
                        // If trackPoster is an Image object, set the Image property
                        pictureBox.Image = image;
                    }

                    // Set PictureBox properties (you may need to adjust these based on your requirements)
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Tag = trackId; // You can set the Tag property if needed

                    pictureBox.Click += panelClickEvent;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UserSelectBtn_Click(object sender, EventArgs e)
        {
            mainForm.OpenUserProfileForm();
        }

        public static async Task<SpotifyClientConfig> StartAuthentication()
        {
            return SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("600ba51cf6464b29b90edc07050e54d9", "9a6802e6a09248808dce71025df7ae97"));
        }

        static string ExtractFirstName(string fullName)
        {
            // Split the full name into words
            string[] words = fullName.Split(' ');

            // Take the first word
            string firstName = words.Length > 0 ? words[0] : string.Empty;

            // Check for common prefixes and remove them
            string[] prefixes = { "Mr", "Ms", "Mrs", "Dr", "Md" };
            if (Array.Exists(prefixes, prefix => firstName.Equals(prefix, StringComparison.OrdinalIgnoreCase)))
            {
                if (words.Length > 1)
                {
                    firstName = words[1];
                }
                else
                {
                    // Handle the case where there's only a prefix and no first name
                    firstName = string.Empty;
                }
            }

            return firstName;
        }

        static string GetGreeting(DateTime time)
        {
            int hour = time.Hour;

            if (hour >= 5 && hour < 12)
            {
                return "Good Morning";
            }
            else if (hour >= 12 && hour < 17)
            {
                return "Good Afternoon";
            }
            else if (hour >= 17 && hour < 21)
            {
                return "Good Evening";
            }
            else
            {
                return "Good Night";
            }
        }
    }
}
