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
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

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
            // else
            // {
            // MainForm m1 = new MainForm();
            // m1.Show();
            // this.Hide();

            // }

            //verify admin login
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\New folder\MusicPlayer\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sql = new SqlCommand("select COUNT(*) from adminTable where email=@email AND password=@password", con);

                sql.Parameters.AddWithValue("@email", emailTextBox.Text);
                sql.Parameters.AddWithValue("@password", passwordTextBox.Text);

                int result = (int)sql.ExecuteScalar(); //executes the query and return a result
                con.Close();

                if (result == 1)
                {
                    MessageBox.Show("Admin Login successful");
                    AdminForm obj = new AdminForm();
                    obj.Show();
                    this.Hide();
                }

                //verify user login
                else
                {
                    SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\New folder\MusicPlayer\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
                    con1.Open();
                    SqlCommand sql1 = new SqlCommand("select COUNT(*) from MusicPlayerUserTable where email=@email AND password=@password", con1);

                    sql1.Parameters.AddWithValue("@email", emailTextBox.Text);
                    sql1.Parameters.AddWithValue("@password", passwordTextBox.Text);

                    int result1 = (int)sql1.ExecuteScalar(); //executes the query and return a result
                    con1.Close();

                    if (result1 == 1)
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

        private void logInForm_Load(object sender, EventArgs e)
        {
            //insert admin information in adminTable
            /*SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\New folder\MusicPlayer\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
            con1.Open();

            SqlCommand sql1 = new SqlCommand("insert into adminTable(email,password) values (@email,@password)", con1);


            sql1.Parameters.AddWithValue("@email", "ashfaqhoq27@gmail.com");
            sql1.Parameters.AddWithValue("@password", "hello*M123");
            sql1.ExecuteNonQuery();
            con1.Close();*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        

    }
}
