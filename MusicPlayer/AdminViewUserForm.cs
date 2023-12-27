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
    public partial class AdminViewUserForm : Form
    {
        public AdminViewUserForm()
        {
            InitializeComponent();
            //show datagridview
            userDataGridView.DataSource = SqlDatabase.CreateDataGridTable("MusicPlayerUserTable");
        }

        private void AdminViewUserForm_Load(object sender, EventArgs e)
        {
            
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            if(archiveButton.Text == "view current users")
            {
                userDataGridView.DataSource = SqlDatabase.CreateDataGridTable("MusicPlayerUserTable");
                archiveButton.Text = "view archived users";
            }
            else
            {
                userDataGridView.DataSource = SqlDatabase.CreateDataGridTable("ArchivedTable");
                archiveButton.Text = "view current users";

            }
            
        }
    }
}
