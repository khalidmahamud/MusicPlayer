using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicPlayer
{
    public partial class ChangePasswordForm : Form
    {
        private string userEmail;
        public ChangePasswordForm(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == "")
            {
                MessageBox.Show("password field cannot be empty!");
            }
            else if (!IsStrongPassword(newPasswordTextBox.Text))
            {
                MessageBox.Show("Use strong password.");
            }
            else if (newPasswordTextBox.Text != retypeNewPasswordBox.Text)
            {
                MessageBox.Show("Password doesnot match!!.");
            }
            else
            {
                SqlDatabase.UpdatePassword(userEmail, newPasswordTextBox.Text);
                this.Hide();
            }         
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void newPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        static bool IsStrongPassword(string password)
        {
            // Password pattern
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{6,}$";

            // Create a Regex object
            Regex regex = new Regex(passwordPattern);

            // Check if the password matches the pattern
            return regex.IsMatch(password);
        }
    }
}
