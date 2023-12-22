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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //show datagridview
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Projects\Music Player\MusicPlayer\Data\MusicPlayerUserDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand sql = new SqlCommand("select * from MusicPlayerUserTable", con);
            DataTable dt = new DataTable();
            SqlDataReader sdr = sql.ExecuteReader();
            dt.Load(sdr);

            userInfoDataGridView.DataSource = dt;
            con.Close();

            

        }

    }
}
