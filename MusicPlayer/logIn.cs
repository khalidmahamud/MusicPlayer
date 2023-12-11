﻿using System;
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
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            SignUp s1 = new SignUp();
            s1.Show();
            this.Hide();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(showPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            { 
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
