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
        private Form activeForm;  // Tracks the active form

        public MainForm()
        {
            InitializeComponent();
            activeForm = new HomeForm();  // Sets the default active form
        }

        private void searchFormSelectBtn_Click(object sender, EventArgs e)
        {
            ActivateForm(new SearchForm(this), searchFormSelectBtn);
        }

        private void homeFromSelectBtn_Click(object sender, EventArgs e)
        {
            ActivateForm(new HomeForm(), homeFormSelectBtn);
        }

        private void ActivateForm(Form form, Button button)
        {
            splitContainer2.Panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainer2.Panel1.Controls.Add(form);

            form.Show();

            // Highlights the active button
            activeForm = form;
            HighlightActiveButton(button);
        }

        public void OpenMusicInfoForm(string trackId)
        {
            MusicInfoForm musicInfoForm = new MusicInfoForm(trackId);

            musicInfoForm.TopLevel = false;
            musicInfoForm.FormBorderStyle = FormBorderStyle.None;
            musicInfoForm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(musicInfoForm);

            musicInfoForm.Show();
        }

        private void HighlightActiveButton(Button activeButton)
        {
            // Resets the appearance of all buttons
            searchFormSelectBtn.BackColor = Color.FromArgb(13, 18, 47);
            homeFormSelectBtn.BackColor = Color.FromArgb(13, 18, 47);

            // Highlights the active button
            activeButton.BackColor = Color.FromArgb(14, 24, 72);
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }

}
