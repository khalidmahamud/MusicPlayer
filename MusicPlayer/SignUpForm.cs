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

namespace MusicPlayer
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click_1(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || gmailTextBox.Text == "" || passwordTextBox.Text == "" || confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Username or Password or gmail  is empty, signin failed!");
            }
            else if (!IsGmailAddress(gmailTextBox.Text))
            {
                MessageBox.Show("Enter correct gmail.");
                gmailTextBox.Focus();
            }
            else if (!IsStrongPassword(passwordTextBox.Text))
            {
                MessageBox.Show("Use strong password.");
                passwordTextBox.Focus();
            }
            else if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password doesnot match!!.");
                passwordTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Successfully Signed in.");
                logInForm l1 = new logInForm();
                l1.Show();
                this.Hide();
            }
        }
        static bool IsGmailAddress(string email)
        {
            // Gmail address pattern
            string gmailPattern = @"^[a-zA-Z0-9._%+-]+@([Gg][Mm][Aa][Ii][Ll]\.[Cc][Oo][Mm])$";

            // Create a Regex object
            Regex regex = new Regex(gmailPattern);

            // Check if the email matches the pattern
            return regex.IsMatch(email);
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

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            userNameTextBox.Text = "";
            gmailTextBox.Text = "";
            passwordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
            comboBox1.Text = "";

        }

        private void createLabel_Click_1(object sender, EventArgs e)
        {
            logInForm l2 = new logInForm();
            l2.Show();
            this.Hide();
        }



        private void showPasswordCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
                confirmPasswordTextBox.PasswordChar = '\0';

            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                confirmPasswordTextBox.PasswordChar = '*';
            }
        }

        
    }
}
