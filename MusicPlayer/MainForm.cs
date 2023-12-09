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
        MediaPlayerControlForm mediaPlayerControlForm = new MediaPlayerControlForm("");
        public MainForm()
        {
            InitializeComponent();
            activeForm = new HomeForm();  // Sets the default active form
            ActivateForm(activeForm, homeFormSelectBtn);

            // Adds the medialPlayerControlForm
            mediaPlayerControlForm.TopLevel = false;
            mediaPlayerControlForm.FormBorderStyle = FormBorderStyle.None;
            mediaPlayerControlForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(mediaPlayerControlForm);
            mediaPlayerControlForm.Show();
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
            splitContainer3.Panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainer3.Panel1.Controls.Add(form);

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
            splitContainer3.Panel2.Controls.Clear();
            splitContainer3.Panel2.Controls.Add(musicInfoForm);

            musicInfoForm.Show();
        }

        //public void OpenMediaPlayerControlForm(string trackId)
        //{
        //    MediaPlayerControlForm mediaPlayerControl = new MediaPlayerControlForm(trackId);

        //    mediaPlayerControl.TopLevel = false;
        //    mediaPlayerControl.FormBorderStyle = FormBorderStyle.None;
        //    mediaPlayerControl.Dock = DockStyle.Fill;
        //    splitContainer1.Panel2.Controls.Clear();
        //    splitContainer1.Panel2.Controls.Add(mediaPlayerControl);

        //    mediaPlayerControl.Show();
        //}

        private void HighlightActiveButton(Button activeButton)
        {
            // Resets the appearance of all buttons
            searchFormSelectBtn.BackColor = Color.FromArgb(18,18,18);
            homeFormSelectBtn.BackColor = Color.FromArgb(18, 18, 18);

            // Highlights the active button
            activeButton.BackColor = Color.FromArgb(40,40,40);
        }
    }
}
