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
        }

        private void AdminViewUserForm_Load(object sender, EventArgs e)
        {
            //show datagridview
            userDataGridView.DataSource = SqlDatabase.CreateDataGridTable("MusicPlayerUserTable");
        }
    }
}
