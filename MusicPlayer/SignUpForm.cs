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
                MessageBox.Show("Username or Password or gmail  is empty, sign in failed!");
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
                //insert data into database
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Projects\Music Player\MusicPlayer\Data\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                SqlCommand sql = new SqlCommand("insert into MusicPlayerUserTable(name,email,gender,dateOfBirth,password) values (@name,@email,@gender,@dateOfBirth,@password)", con);

                sql.Parameters.AddWithValue("@name", userNameTextBox.Text);
                sql.Parameters.AddWithValue("@email", gmailTextBox.Text);
                sql.Parameters.AddWithValue("@gender", genderComboBox.Text);
                sql.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                sql.Parameters.AddWithValue("@password", passwordTextBox.Text);
                sql.ExecuteNonQuery();
                con.Close();
                //open mainform
                MessageBox.Show("Successfully Signed in.");
                MainForm obj = new MainForm(gmailTextBox.Text);
                obj.Show();
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
            genderComboBox.Text = "";

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

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logInForm l2 = new logInForm();
            l2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm s1 = new AdminForm();
            s1.Show();
            this.Hide();
        }

        private void gmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
