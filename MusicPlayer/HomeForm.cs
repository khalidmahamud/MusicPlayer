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

    public partial class HomeForm : Form
    {
        private string userEmail;
        private readonly MainForm mainForm;
        public HomeForm(MainForm mainForm, string userEmail)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.userEmail = userEmail;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //show user name at the top
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\New folder\MusicPlayer\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30"))
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homeFormSelectBtn_Click(object sender, EventArgs e)
        {

            mainForm.OpenUserProfileForm();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
