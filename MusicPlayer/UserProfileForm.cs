using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class UserProfileForm : Form
    {
        private MainForm mainForm;
        private string userEmail;

        private static UserProfileForm instance;


        private UserProfileForm(MainForm mainform, string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            this.mainForm = mainform;
        }

        // Define a public method to get the instance (singleton pattern)
        public static UserProfileForm GetInstance(MainForm mainForm, string userEmail)
        {
            // If the instance is null, create a new instance
            if (instance == null)
            {
                instance = new UserProfileForm(mainForm, userEmail);
            }

            // Return the instance
            return instance;
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            // Load user profile data when the form is loaded
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            using (SqlConnection con = SqlDatabase.Connection())
            {
                con.Open();

                string query = "SELECT * FROM MusicPlayerUserTable WHERE email=@email";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", userEmail);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Access the columns by name or index
                            nameTextBox.Text = reader["name"].ToString();
                            emailTextBox.Text = reader["email"].ToString();
                            genderTextBox.Text = reader["gender"].ToString();

                            string result = reader["dateOfBirth"].ToString();
                            string userDob = result.Split(' ')[0];
                            birthdateTextBox.Text = userDob;

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

        private void homeFormSelectBtn_Click(object sender, EventArgs e)
        {
            // Hide the UserProfileForm
            mainForm.Hide();

            // Show the LoginForm
            logInForm obj = new logInForm();
            obj.Show();
        }

        private void changePasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordForm rs = new ResetPasswordForm();
            rs.Show();
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
                SqlDatabase.UpdateProfilePicture(userEmail, imageData);

                // Update the user profile data
                LoadUserProfile();
            }
        }

        private void editLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime result = DateTime.Parse(birthdateTextBox.Text);
            UpdateUserInfoForm form = new UpdateUserInfoForm(nameTextBox.Text, emailTextBox.Text, genderTextBox.Text, result);

            // Subscribe to the FormClosed event to be notified when the UpdateUserInfoForm is closed
            form.Show();

            form.FormClosed += (s, args) => LoadUserProfile();
        }
    }
}
