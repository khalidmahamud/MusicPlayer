using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        // Tracks the currently active form in the main split container
        private Form activeForm;

        // Represents the MediaPlayerControlForm instance used in the application
        private MediaPlayerControlForm mediaPlayerControlForm;

        // Constructor for the MainForm class
        public MainForm()
        {
            InitializeComponent();

            // Set the default active form to HomeForm and initialize it
            activeForm = InitializeForm(new HomeForm(), homeFormSelectBtn, splitContainer3.Panel1);

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
            var mediaPlayerControl = new MediaPlayerControlForm("");
            mediaPlayerControl.TopLevel = false;
            mediaPlayerControl.FormBorderStyle = FormBorderStyle.None;
            mediaPlayerControl.Dock = DockStyle.Fill;
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
        public void OpenMusicInfoForm(string trackId)
        {
            var musicInfoForm = new MusicInfoForm(trackId);
            ActivateForm(musicInfoForm, null, splitContainer3.Panel2);
        }

        // Opens the MediaPlayerControlForm for a specified trackId
        public void OpenMediaPlayerControlForm(string trackId)
        {
            // Activates the MediaPlayerControlForm, clears the panel, and sets up the form
            ActivateForm(new MediaPlayerControlForm(trackId), null, splitContainer1.Panel2);
        }

        // Highlights the active button and resets the appearance of other buttons
        private void HighlightActiveButton(Button activeButton)
        {
            searchFormSelectBtn.BackColor = homeFormSelectBtn.BackColor = Color.FromArgb(18, 18, 18);
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
            ActivateForm(new HomeForm(), homeFormSelectBtn, splitContainer3.Panel1);
        }    
    }
}
