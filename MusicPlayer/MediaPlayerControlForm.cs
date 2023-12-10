using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MediaPlayerControlForm : Form
    {
        private string trackId;
        private string trackName;
        private string artistName;
        private string trackPoster;

        // Constructor for MediaPlayerControlForm
        public MediaPlayerControlForm(string trackId)
        {
            InitializeComponent();
            this.trackId = trackId;
        }

        // Event handler for the form load event
        private async void MediaPlayerControlForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trackId))
                return;

            // Display a loading image while fetching metadata
            trackPosterBox.Image = Resource1.loading;

            try
            {
                // Instantiate and asynchronously set track metadata
                TrackMetadata trackInfo = new TrackMetadata(trackId);
                await trackInfo.SetMetadata();

                // Assign metadata values
                trackName = TrackMetadata.trackName;
                artistName = TrackMetadata.artistName;
                trackPoster = TrackMetadata.trackPoster;

                // Set the ImageLocation property after metadata has been retrieved
                trackPosterBox.ImageLocation = trackPoster;
                trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;
                trackNameLabel.Text = trackName;
                artistNameLabel.Text = artistName;

                // Adjust font size based on track name length
                trackNameLabel.Font = new Font("Segoe UI", trackName.Length > 25 ? 11 : 14);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
