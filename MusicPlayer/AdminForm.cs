using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class AdminForm : Form
    {
        private Form activeForm;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        private Form InitializeForm(Form form, Button button, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);

            return form;
        }
        // Activates a form, clears the panel, sets up the form, and highlights the corresponding button
        private void ActivateForm(Form form, Button button, Panel panel)
        {
            panel.Controls.Clear();
            activeForm = InitializeForm(form, button, panel);
            activeForm.Show();

            if (button != null)
            {
                HighlightActiveButton(button);
            }
        }
        private void HighlightActiveButton(Button activeButton)
        {
            //searchFormSelectBtn.BackColor = homeFormSelectBtn.BackColor = localMusicFormSelectBtn.BackColor = Color.FromArgb(18, 18, 18);
            activeButton.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewUserButton_Click(object sender, EventArgs e)
        {
            ActivateForm(new AdminViewUserForm(), viewUserButton, splitContainer1.Panel2);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            ActivateForm(new AdminDashboardForm(), dashboardButton, splitContainer1.Panel2);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
