using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        // Tracks the currently active form in the main split container
        private Form activeForm;
        private string userEmail;

        // Represents the MediaPlayerControlForm instance used in the application
        private static MediaPlayerControlForm mediaPlayerControlForm;
        private static MusicInfoForm musicInfoForm;
        private static UserProfileForm userProfileForm;
        private static PlaylistForm playlistForm;

        // Constructor for the MainForm class
        public MainForm(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;

            // Set the default active form to HomeForm and initialize it
            HomeForm homeFormInstance = HomeForm.GetInstance(this, userEmail);
            activeForm = InitializeForm(homeFormInstance, homeFormSelectBtn, splitContainer3.Panel1);
            ActivateForm(activeForm, homeFormSelectBtn, splitContainer3.Panel1);

            // Initialize the MediaPlayerControlForm and set it up
            mediaPlayerControlForm = InitializeMediaPlayerControlForm();
        }

        // Initializes a form with common properties and adds it to a specified panel
        private Form InitializeForm(Form form, Button button, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);

            return form;
        }

        // Initializes the MediaPlayerControlForm and sets up its properties
        private MediaPlayerControlForm InitializeMediaPlayerControlForm()
        {
            var mediaPlayerControl = new MediaPlayerControlForm(this);
            mediaPlayerControl.TopLevel = false;
            mediaPlayerControl.FormBorderStyle = FormBorderStyle.None;
            mediaPlayerControl.Dock = DockStyle.Fill;
            mediaPlayerControl.Show();
            splitContainer1.Panel2.Controls.Add(mediaPlayerControl);

            return mediaPlayerControl;
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

        // Opens the MusicInfoForm for a specified trackId
        public void OpenMusicInfoForm(string track, bool isLocal)
        {
            if (musicInfoForm == null)
            {
                musicInfoForm = new MusicInfoForm(track, isLocal);
                musicInfoForm.SetEmail(userEmail);
                ActivateForm(musicInfoForm, null, splitContainer3.Panel2);
            }
            else
            {
                musicInfoForm.UpdateMusicInfo(track, isLocal);
                musicInfoForm.SetEmail(userEmail);
            }
        }

        // Opens the MediaPlayerControlForm for a specified trackId
        public void OpenMediaPlayerControlForm(string track, bool isLocal)
        {
            if (mediaPlayerControlForm == null)
            {
                mediaPlayerControlForm = new MediaPlayerControlForm(this);
                ActivateForm(mediaPlayerControlForm, null, splitContainer1.Panel2);
            }
            else
            {
                mediaPlayerControlForm.LoadNewTrack(track, isLocal);
            }
        }

        // Highlights the active button and resets the appearance of other buttons
        private void HighlightActiveButton(Button activeButton)
        {
            searchFormSelectBtn.BackColor = homeFormSelectBtn.BackColor = localMusicFormSelectBtn.BackColor = Color.FromArgb(18, 18, 18);
            activeButton.BackColor = Color.FromArgb(40, 40, 40);
        }

        // Event handler for the searchFormSelectBtn button click event
        private void searchFormSelectBtn_Click(object sender, EventArgs e)
        {
            ActivateForm(new SearchForm(this), searchFormSelectBtn, splitContainer3.Panel1);
        }

        // Event handler for the homeFromSelectBtn button click event
        private void homeFromSelectBtn_Click(object sender, EventArgs e)
        {
            HomeForm homeFormInstance = HomeForm.GetInstance(this, userEmail);
            ActivateForm(homeFormInstance, homeFormSelectBtn, splitContainer3.Panel1);
        }

        // Event handler for the localMuiscFormSelectBtn button click event
        private void localMusicFormSelectBtn_Click(object sender, EventArgs e)
        {
            ActivateForm(new LocalMusicForm(this), localMusicFormSelectBtn, splitContainer3.Panel1);
        }

        private void playlistFormSelectBtn_Click(object sender, EventArgs e)
        {
            ActivateForm(new PlaylistForm(this, userEmail), playlistFormSelectBtn, splitContainer3.Panel1);
        }

        // Opens the MusicInfoForm for a specified trackId
        public void OpenUserProfileForm()
        {
            UserProfileForm userProfileFormInstance = UserProfileForm.GetInstance(this, userEmail);
            ActivateForm(userProfileFormInstance, null, splitContainer3.Panel2);
        }

        public void ReloadPlaylistForm()
        {
            if (playlistForm == null)
            {
                playlistForm = new PlaylistForm(this, userEmail);
                ActivateForm(playlistForm, null, splitContainer3.Panel1);
            }
            else
            {
                playlistForm.DisplayPlaylists();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit application?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlDatabase.InsertData("LoggedinTable", userEmail);
                System.Windows.Forms.Application.Exit();
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
