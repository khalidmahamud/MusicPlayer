using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadUserProfile();
            PopulateListBox();
        }
        private void PopulateListBox()
        {
            SqlConnection con = SqlDatabase.Connection();
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MusicPlayerUserTable", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Clear the ListBox before populating it
                userListBox.Items.Clear();

                while (reader.Read())
                {
                    // Assuming you have a column named 'ColumnName' in your table
                    // Change the index or column name based on your actual data structure
                    string listItem = reader["email"].ToString();

                    // Add the item to the ListBox
                    userListBox.Items.Add(listItem);
                }
            }
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            // Replace the URL with the Gmail URL
            string gmailUrl = "https://mail.google.com/mail/u/0/#inbox";

            // Open the default web browser with the Gmail URL
            Process.Start(new ProcessStartInfo(gmailUrl) { UseShellExecute = true });
        }
        private void LoadUserProfile()
        {
            using (SqlConnection con = SqlDatabase.Connection())
            {
                con.Open();

                string query = "SELECT * FROM adminTable WHERE email=@email";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", "ashfaqhoq27@gmail.com");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Access the columns by name or index

                            emailTextBox.Text = reader["email"].ToString();

                            if (reader["photo"] is byte[] userImage && userImage.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(userImage))
                                {
                                    userProfilepictureBox.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }

                con.Close();
            }
        }

        private void changePhotoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Image",
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in PictureBox
                userProfilepictureBox.Image = Image.FromFile(openFileDialog.FileName);

                // Read the image file into a byte array
                byte[] imageData;
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                }

                // Upload the profile picture to the database
                SqlDatabase.UpdateProfilePicture("adminTable", "ashfaqhoq27@gmail.com", imageData);

                // Update the user profile data
                LoadUserProfile();
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm("ashfaqhoq27@gmail.com");
        }

        private void loginButtton_Click(object sender, EventArgs e)
        {

        }

        private void composeButton_Click(object sender, EventArgs e)
        {
            // Replace the URL with the Gmail URL
            string gmailUrl = "https://mail.google.com/mail/u/0/#inbox?compose=new";

            // Open the default web browser with the Gmail URL
            Process.Start(new ProcessStartInfo(gmailUrl) { UseShellExecute = true });
        
        }
    }
}
