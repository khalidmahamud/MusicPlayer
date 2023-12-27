using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicPlayer
{
    internal class SqlDatabase
    {
        public static SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Projects\Music Player\MusicPlayer\Data\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
            return con;
        }
        public static bool VerifyLogin(string tableName, string email, string password)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("select COUNT(*) from " + tableName + " where email=@email AND password=@password", con);

            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@password", password);

            int result = (int)sql.ExecuteScalar(); //executes the query and return a result
            con.Close();
            return result > 0;
        }
        public static void InsertData(string name, string email, string gender, DateTime value, string password)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("insert into MusicPlayerUserTable(name,email,gender,dateOfBirth,password) values (@name,@email,@gender,@dateOfBirth,@password)", con);

            sql.Parameters.AddWithValue("@name", name);
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@gender", gender);
            sql.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = value;
            sql.Parameters.AddWithValue("@password", password);
            sql.ExecuteNonQuery();
            con.Close();
        }
        public static void InsertData(string tableName, string email)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("insert into " + tableName + "(email) values (@email)", con);


            sql.Parameters.AddWithValue("@email", email);
            sql.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable CreateDataGridTable(string tableName)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("select * from MusicPlayerUserTable", con);
            DataTable dt = new DataTable();
            SqlDataReader sdr = sql.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public static bool AreRowsInDatabase(string tableName)
        {
            SqlConnection con = Connection();
            con.Open();
            string query = "SELECT COUNT(*) FROM " + tableName;
            using (SqlCommand sq = new SqlCommand(query, con))
            {
                int rowCount = Convert.ToInt32(sq.ExecuteScalar());
                // Check if there are any rows
                return rowCount > 0;
            }
        }
        public static void DeleteData(string tableName, string email)
        {
            SqlConnection con = Connection();
            con.Open();

            SqlCommand sq = new SqlCommand("delete from " + tableName + " where email=@email", con);
            sq.Parameters.AddWithValue("@email", email);

            sq.ExecuteNonQuery();
            con.Close();
        }
        public static string CheckLoggedin(string tableName)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("select top 1 email from LoggedinTable", con);
            object result = sql.ExecuteScalar(); //executes the query and return a result
            con.Close();
            if (result != null)
            {
                return result.ToString(); // Assuming the column is of string type
            }
            else
            {

                return null;
            }
        }
        public static void UpdateProfilePicture(string tableName, string email, byte[] imageData)
        {
            SqlConnection con = Connection();
            con.Open();

            SqlCommand sql = new SqlCommand("update "+tableName+" set photo=@photo where email=@email", con);
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@photo", imageData);
            int result = sql.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Profile picture updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update profile picture. Try again.");
            }
            con.Close();
        }
        public static void UpdatePassword(string email, string newPassword)
        {
            SqlConnection con = Connection();
            con.Open();

            SqlCommand sq3 = new SqlCommand("update MusicPlayerUserTable set password=@password where email=@email", con);

            sq3.Parameters.AddWithValue("@email", email);
            sq3.Parameters.AddWithValue("@password", newPassword);
            sq3.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("your password has been changed!");
        }
        public static bool IsExistingEmail(string tableName, string email)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("select COUNT(*) from " + tableName + " where email=@email", con);

            sql.Parameters.AddWithValue("@email", email);

            int result = (int)sql.ExecuteScalar(); //executes the query and return a result
            con.Close();
            return result > 0;
        }
        public static void UpdateData(string name, string email, string gender, DateTime value)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlCommand sql = new SqlCommand("update MusicPlayerUserTable set name=@name,gender=@gender,dateOfBirth=@dateOfBirth where email=@email", con);

            sql.Parameters.AddWithValue("@name", name);
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@gender", gender);
            sql.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = value;
            sql.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("your information has been changed!");
        }
    }
}
