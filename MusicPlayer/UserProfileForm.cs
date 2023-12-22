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
    public partial class UserProfileForm : Form
    {
        private string userEmail;
        public UserProfileForm(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Projects\Music Player\MusicPlayer\Data\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con1.Open();

                string query = "SELECT * FROM MusicPlayerUserTable WHERE email=@email";
                SqlCommand sql1 = new SqlCommand(query, con1);

                sql1.Parameters.AddWithValue("@email", userEmail);

                using (SqlDataReader reader = sql1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Access the columns by name or index
                        string userName = reader["name"].ToString();
                        nameTextBox.Text = userName;
                        string userEmail = reader["email"].ToString();
                        emailTextBox.Text = userEmail;
                        string userGender = reader["gender"].ToString();
                        genderTextBox.Text = userGender;
                        string result = reader["dateOfBirth"].ToString();
                        string userDob = result.Split(' ')[0];
                        birthdateTextBox.Text = userDob;
                    }
                }
                con1.Close();

            }
        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeFormSelectBtn_Click(object sender, EventArgs e)
        {
            logInForm obj = new logInForm();
            obj.Show();
            this.Hide();
        }

        private void changePasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(userEmail);
            form.Show();
        }
    }
}
