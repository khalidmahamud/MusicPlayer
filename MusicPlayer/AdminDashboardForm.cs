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
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            // Replace the URL with the Gmail URL
            string gmailUrl = "https://mail.google.com/mail/u/0/#inbox";

            // Open the default web browser with the Gmail URL
            Process.Start(new ProcessStartInfo(gmailUrl) { UseShellExecute = true });
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
                SqlDatabase.UpdateProfilePicture("adminTable","ashfaqhoq27@gmail.com", imageData);

                // Update the user profile data
                //LoadUserProfile();
            }
        }
    }
}
