using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Drawing;
using System.Windows.Forms;
using TagLib;

namespace MusicPlayer
{
    public partial class MusicInfoForm : Form
    {
        private readonly string track;
        private bool isLocal;
        private string trackName = "";
        private string artistName = "";
        private object trackPoster;
        private int totalMilliSeconds;

        public MusicInfoForm(string track, bool isLocal)
        {
            InitializeComponent();
            this.track = track;
            this.isLocal = isLocal;
        }

        private async void MusicInfoForm_Load(object sender, EventArgs e)
        {
            await UpdateMusicInfo(track, isLocal);
        }

        public async Task UpdateMusicInfo(string track, bool isLocal)
        {
            trackPosterBox.Image = Resource1.loading;

            if (isLocal)
            {
                // Handle local track metadata
                UpdateLocalTrackMetadata(track);
            }
            else
            {
                // Handle online track metadata
                await UpdateOnlineTrackMetadata(track);
            }

            // Formats track duration into minutes:seconds format
            int trackDuration = totalMilliSeconds / 1000;
            int minutes = trackDuration / 60;
            int seconds = trackDuration % 60;
            string formattedTime = $"{minutes}:{seconds:D2}";

            // Sets the ImageLocation property after metadata has been retrieved
            if (trackPoster is string imageUrl)
            {
                trackPosterBox.ImageLocation = trackPoster.ToString();
            }
            else if (trackPoster is object image)
            {
                trackPosterBox.Image = (Image)trackPoster;
            }
            trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;
            trackNameLabel.Text = trackName;
            artistNameLabel.Text = artistName;
            trackDurationLabel.Text = formattedTime;

            trackNameLabel.Font = new Font("Segoe UI", trackName.Length > 25 ? 13 : 16);
        }

        private void UpdateLocalTrackMetadata(string localFilePath)
        {
            // Retrieve metadata for the local file
            TrackMetadata trackInfo = new TrackMetadata(localFilePath, false);
            trackInfo.SetLocalTrackMetadata();

            // Assign online metadata values
            trackName = TrackMetadata.trackName;
            artistName = TrackMetadata.artistName;
            trackPoster = TrackMetadata.trackPoster;
            totalMilliSeconds = TrackMetadata.totalMilliSeconds;
        }

        private async Task UpdateOnlineTrackMetadata(string trackId)
        {
            TrackMetadata trackInfo = new TrackMetadata(trackId, false);
            await trackInfo.SetOnlineTrackMetadata();

            // Assign online metadata values
            trackName = TrackMetadata.trackName;
            artistName = TrackMetadata.artistName;
            trackPoster = TrackMetadata.trackPoster;
            totalMilliSeconds = TrackMetadata.totalMilliSeconds;
        }
    }
}
