using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicInfoForm : Form
    {
        private readonly string trackId;
        private string trackName = "";
        private string artistName = "";
        private string trackPoster = "";

        public MusicInfoForm(string trackId)
        {
            InitializeComponent();
            this.trackId = trackId;
        }

        private async void MusicInfoForm_Load(object sender, EventArgs e)
        {
            UpdateMusicInfo(trackId);
        }

        public async void UpdateMusicInfo(string trackId)
        {
            trackPosterBox.Image = Resource1.loading;

            TrackMetadata trackInfo = new TrackMetadata(trackId);
            await trackInfo.SetMetadata();

            // Assigns metadata values
            trackName = TrackMetadata.trackName;
            artistName = TrackMetadata.artistName;
            trackPoster = TrackMetadata.trackPoster;

            // Formats track duration into minutes:seconds format
            int totalMilliseconds = TrackMetadata.trackDuration;
            int trackDuration = totalMilliseconds / 1000;
            int minutes = trackDuration / 60;
            int seconds = trackDuration % 60;
            string formattedTime = $"{minutes}:{seconds:D2}";

            // Sets the ImageLocation property after metadata has been retrieved
            trackPosterBox.ImageLocation = trackPoster;
            trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;
            trackNameLabel.Text = trackName;
            artistNameLabel.Text = artistName;
            trackDurationLabel.Text = formattedTime;

            trackNameLabel.Font = new Font("Segoe UI", trackName.Length > 25 ? 13 : 16);
        } 
    }
}
