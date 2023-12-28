using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MusicPlayer
{
    public partial class AddToPlaylistForm : Form
    {
        private static AddToPlaylistForm instance;

        private CreatePlaylistForm createPlaylistForm;
        private readonly MainForm mainForm;

        private static readonly Random random = new Random();
        private List<string> playlistNames;
        private List<string> playlistIDs;
        private string email;
        private string trackID;
        private AddToPlaylistForm(string trackID, string email)
        {
            InitializeComponent();
            this.playlistNames = new List<string>();
            this.playlistIDs = new List<string>();
            this.email = email;
            this.trackID = trackID;
            ShowPlayList();
        }

        // Define a public method to get the instance (singleton pattern)
        public static AddToPlaylistForm GetInstance(string trackID, string email)
        {
            // If the instance is null, create a new instance
            if (instance == null)
            {
                instance = new AddToPlaylistForm(trackID, email);
            }

            // Return the instance
            return instance;
        }

        public void ShowPlayList()
        {
            ClearPanels();
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

                            playlistNames.Add(playlistName);
                            playlistIDs.Add(playlistID);
                        }
                    }
                }
            }
            DisplayPlaylists();
        }

        public void DisplayPlaylists()
        {
            // Iterate through playlist names and create panels dynamically
            for (int i = 0; i < playlistNames.Count; i++)
            {
                Panel newPanel = CreatePlaylistPanel(playlistNames[i], playlistIDs[i], i, PlaylistPanel_Click);
                playlistPanel.Controls.Add(newPanel);
            }
        }

        private Panel CreatePlaylistPanel(string playlistName, string playlistID, int index, EventHandler panelClickEvent)
        {
            Panel newPanel = new Panel
            {
                Name = $"panelResult{index}",
                Height = 68,
                Width = playlistPanel.Width,
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
            nameLabel.Location = new System.Drawing.Point(10, 15);
            nameLabel.Tag = playlistID;

            newPanel.Controls.Add(nameLabel);

            // Attach the click event handler to the panel and its controls
            newPanel.Click += panelClickEvent;
            nameLabel.Click += panelClickEvent;

            return newPanel;
        }

        private void PlaylistPanel_Click(object sender, EventArgs e)
        {
            string playlistID = GetPlaylistIdFromSender(sender);

            string playlistTrackID = GenerateRandomPlaylistId();
            InsertData(playlistTrackID, playlistID, trackID);
            MessageBox.Show($"Successfully added track");
            this.Hide();
        }

        // Retrieves track ID from the clicked control
        private string GetPlaylistIdFromSender(object sender)
        {
            // Use a switch statement to identify the type of the clicked control
            return sender switch
            {
                Panel clickedPanel => (string)clickedPanel?.Tag ?? string.Empty,
                Label clickedLabel => (string)clickedLabel?.Tag ?? string.Empty,
            };
        }

        public static void InsertData(string playlistTrackID, string playlistID, string trackID)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("insert into PlaylistTrackTable(playlistTrackID, playlistID, trackID) values (@playlistTrackID, @playlistID, @trackID)", con);

            sql.Parameters.AddWithValue("@playlistTrackID", playlistTrackID);
            sql.Parameters.AddWithValue("@playlistID", playlistID);
            sql.Parameters.AddWithValue("@trackID", trackID);
            sql.ExecuteNonQuery();
            con.Close();
        }


        public static SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Projects\Music Player\MusicPlayer\Data\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
            return con;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static string GenerateRandomPlaylistId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] playlistId = new char[14];

            for (int i = 0; i < playlistId.Length; i++)
            {
                playlistId[i] = chars[random.Next(chars.Length)];
            }

            return new string(playlistId);
        }

        private void CreateNewPlaylistBtn_Click(object sender, EventArgs e)
        {
            createPlaylistForm = new CreatePlaylistForm(email);
            createPlaylistForm.Show();
        }

        private void ClearPanels()
        {
            playlistNames.Clear();
            playlistIDs.Clear();
            playlistPanel.Controls.Clear();
        }
    }
}
