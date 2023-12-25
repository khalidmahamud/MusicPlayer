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
            SqlConnection con1 = SqlDatabase.Connection();
            con1.Open();

            string query = "SELECT * FROM MusicPlayerUserTable WHERE email=@email";
            SqlCommand sql1 = new SqlCommand(query, con1);

            sql1.Parameters.AddWithValue("@email", userEmail);

            SqlDataReader reader = sql1.ExecuteReader();
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
                if (reader["photo"] as byte[] != null)
                {
                    byte[] userImage = reader["photo"] as byte[];
                    MemoryStream m = new MemoryStream(userImage);
                    userProfilepictureBox.Image = Image.FromStream(m);
                }

            }
            con1.Close();
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

            this.Hide(); // Hide the UserProfileForm
            MainForm mainForm = this.Owner as MainForm;
            if (mainForm != null)
            {
                mainForm.Close(); // Close the MainForm
            }
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
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);

                // Upload the profile picture to the database
                SqlDatabase.UpdateProfilePicture(userEmail, imageData);
            }
        }

        private void editLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime result = DateTime.Parse(birthdateTextBox.Text);
            UpdateUserInfoForm form = new UpdateUserInfoForm(nameTextBox.Text, emailTextBox.Text, genderTextBox.Text,
                    result);
            form.Show();
        }
    }
}
