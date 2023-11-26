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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode.Tag is Form SearchForm)
            {
                splitContainer1.Panel2.Controls.Clear();

                SearchForm.TopLevel = false;
                SearchForm.FormBorderStyle = FormBorderStyle.None;
                SearchForm.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(SearchForm);

                SearchForm.Show();
            }
            else if (selectedNode.Tag is Form MainForm) 
            {
                splitContainer1.Panel2.Controls.Clear();

                MainForm.TopLevel = false;
                MainForm.FormBorderStyle = FormBorderStyle.None;
                MainForm.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(MainForm);

                MainForm.Show();
            }
        }
    }
}
