using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class HomeForm : Form
    {
        private string userEmail;
        private readonly MainForm mainForm;

        // Define a private static instance variable
        private static HomeForm instance;

        // Define a private constructor to prevent external instantiation
        private HomeForm(MainForm mainForm, string userEmail)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.userEmail = userEmail;
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

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadUserName();
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
                userNameTextBox.Text = userName;
            }
            else
            {
                // User not found
            }
        }
        con1.Close();

    }
}

        private void UserSelectBtn_Click(object sender, EventArgs e)
        {
            mainForm.OpenUserProfileForm();
        }
    }
}
