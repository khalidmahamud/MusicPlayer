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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendOtpButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please enter an email");
            }
            else if (!IsGmailAddress(emailTextBox.Text))
            {
                MessageBox.Show("Enter correct email.");
            }
            else if (!SqlDatabase.IsExistingEmail("MusicPlayerUserTable",emailTextBox.Text))
            {
                MessageBox.Show("You do not have any account. Click the sign up button to create an account.");
            }
            else
            {
                GenerateOTP.sendOTP(emailTextBox.Text);
                emailLabel.Visible = false;
                emailTextBox.Visible = false;
                sendOtpButton.Visible = false;
                verifyLabel.Visible = true;
                verifyTextBox.Visible = true;
                verifyButton.Visible = true;
            }
            
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            if(GenerateOTP.VerifyOTP(emailTextBox.Text,verifyTextBox.Text))
            {
                MessageBox.Show("Account verification successful!");
                this.Hide();
                ChangePasswordForm form = new ChangePasswordForm(emailTextBox.Text);
                form.Show();
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
    }
}
