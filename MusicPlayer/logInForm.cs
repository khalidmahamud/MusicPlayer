using Microsoft.Data.SqlClient;
using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace MusicPlayer
{
    public partial class logInForm : Form

    {
        public logInForm()
        {
            InitializeComponent();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
        }
        private void logInButton_Click(object sender, EventArgs e)
        {

            if (emailTextBox.Text == "" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Username and Password are empty, login failed!");
                passwordTextBox.Focus();
            }
            else
            {
                //verify admin login
                if (SqlDatabase.VerifyLogin("adminTable", emailTextBox.Text, passwordTextBox.Text))
                {
                    MessageBox.Show("Admin Login successful");
                    AdminForm obj = new AdminForm();
                    obj.Show();
                    this.Hide();
                }
                //verify user login
                else
                {
                    if (SqlDatabase.VerifyLogin("MusicPlayerUserTable", emailTextBox.Text, passwordTextBox.Text))
                    {
                        MessageBox.Show("user Login successful");
                        MainForm obj = new MainForm(emailTextBox.Text);
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("invalid login");
                    }
                }
            }

        }


        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm s1 = new SignUpForm();
            s1.Show();
            this.Hide();
        }

        private void logInForm_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {
            ResetPasswordForm rs = new ResetPasswordForm();
            rs.Show();
        }
        

    }
}
