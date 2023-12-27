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

namespace MusicPlayer
{
    public partial class CreatePlaylistForm : Form
    {
        private readonly MainForm mainForm;
        private string newPlaylistName;
        private string playlistID;
        private string email;

        private static readonly Random random = new Random();
        public CreatePlaylistForm(MainForm mainForm, string email)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.email = email;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Hide();
            this.Dispose();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            newPlaylistName = newPlaylistNameText.Text;

            if (string.IsNullOrEmpty(newPlaylistName))
            {
                MessageBox.Show("Please enter a name");
            }
            else
            {
                playlistID = GenerateRandomPlaylistId();
                InsertData(playlistID, newPlaylistName, email);
                MessageBox.Show($"Successfully created {newPlaylistName}");
                mainForm.Enabled = true;
                mainForm.ReloadPlaylistForm();
                this.Hide();
                this.Dispose();
            }
        }

        public static void InsertData(string playlistID, string playlistName, string email)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("insert into PlaylistTable(playlistID,playlistName,email) values (@playlistID,@playlistName,@email)", con);

            sql.Parameters.AddWithValue("@playlistID", playlistID);
            sql.Parameters.AddWithValue("@playlistName", playlistName);
            sql.Parameters.AddWithValue("@email", email);
            sql.ExecuteNonQuery();
            con.Close();
        }

        public static SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Projects\Music Player\MusicPlayer\Data\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
            return con;
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
    }
}
