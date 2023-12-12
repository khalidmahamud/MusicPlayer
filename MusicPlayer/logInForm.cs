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
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();
        }
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Username and Password are empty, login failed!");
                passwordTextBox.Focus();
            }
            else
            {
                MainForm m1 = new MainForm();
                m1.Show();
                this.Hide();

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

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm s1 = new SignUpForm();
            s1.Show();
            this.Hide();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
