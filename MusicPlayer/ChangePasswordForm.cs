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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\New folder\MusicPlayer\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();



            SqlCommand sq3 = new SqlCommand("update MusicPlayerUserTable set password=@password where email=@email", con);
        
            sq3.Parameters.AddWithValue("@email", userEmail);
            sq3.Parameters.AddWithValue("@password", newPasswordTexBox.Text);
            sq3.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("your password has been changed!");
            this.Hide();
        }
    }
}
