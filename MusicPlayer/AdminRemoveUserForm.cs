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

namespace MusicPlayer
{
    public partial class AdminRemoveUserForm : Form
    {
        public string email;
        public string name;
        public string gender;
        public DateTime birthdate;
        public string password;
        public AdminRemoveUserForm()
        {
            InitializeComponent();
            PopulateListBox();
        }
        private void PopulateListBox()
        {
            SqlConnection con = SqlDatabase.Connection();
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MusicPlayerUserTable", con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Clear the ListBox before populating it
                userListBox.Items.Clear();

                while (reader.Read())
                {
                    string listItem = reader["email"].ToString();

                    // Add the item to the ListBox
                    userListBox.Items.Add(listItem);
                }
            }
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (userListBox.SelectedIndex != -1)
            {
                // Get the selected item
                email = userListBox.SelectedItem.ToString();

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(email == null) 
            {
                MessageBox.Show("Please select an user to remove!.");
            }
            else
            {
                // Ask for confirmation using a MessageBox
                DialogResult result = MessageBox.Show($"Are you sure you want to remove {email}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                // Check the user's response
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = SqlDatabase.Connection();
                    con.Open();
                    string query = "SELECT * FROM MusicPlayerUserTable WHERE email=@email";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Access the columns by name or index
                            name = reader["name"].ToString();
                            gender = reader["gender"].ToString();
                            birthdate = Convert.ToDateTime(reader["dateOfBirth"]);
                            password = reader["password"].ToString();
                        }
                    }
                    con.Close();


                    SqlDatabase.InsertDataArchived(name, email, gender, birthdate, password);
                    SqlDatabase.DeleteData("MusicPlayerUserTable", email);
                    // User clicked Yes, perform the removal operation
                    // Replace this with your actual removal logic
                    MessageBox.Show($"Removed {email}!", "Operation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // User clicked No or Cancel, do nothing or handle accordingly
                }
            }
            
        }
    }
}
