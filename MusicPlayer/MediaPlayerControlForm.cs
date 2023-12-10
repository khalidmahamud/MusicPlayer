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
    public partial class MediaPlayerControlForm : Form
    {
        private string trackId;
        private string trackName;
        private string artistName;
        private string trackPoster;

        public MediaPlayerControlForm(string trackId)
        {
            InitializeComponent();

            this.trackId = trackId;
        }

        private async void MediaPlayerControlForm_Load(object sender, EventArgs e)
        {
            TrackMetadata trackInfo = new TrackMetadata(this.trackId);
            await trackInfo.SetMetadata();

            // Assigns metadata values
            this.trackName = TrackMetadata.trackName;
            this.artistName = TrackMetadata.artistName;
            this.trackPoster = TrackMetadata.trackPoster;
            //int totalMilliseconds = TrackMetadata.trackDuration;

            // Formats track duration into minutes:seconds format
            //int trackDuration = totalMilliseconds / 1000;
            //int minutes = trackDuration / 60;
            //int seconds = trackDuration % 60;
            //string formattedTime = $"{minutes}:{seconds:D2}";

            // Sets the ImageLocation property after metadata has been retrieved
            trackPosterBox.ImageLocation = this.trackPoster;
            trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;
            trackNameLabel.Text = this.trackName;
            artistNameLabel.Text = this.artistName;
            //trackDurationLabel.Text = formattedTime;

            trackNameLabel.Font = new Font("Segoe UI", this.trackName.Length > 25 ? 11 : 14);
        }
    }
}
