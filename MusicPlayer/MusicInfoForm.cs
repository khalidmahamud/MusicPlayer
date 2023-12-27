using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TagLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MusicPlayer
{
    public partial class MusicInfoForm : Form
    {
        private string track;
        private bool isLocal;
        private bool isInFavourite = false;
        private string trackName = "";
        private string artistName = "";
        private object trackPoster;
        private int totalMilliSeconds;
        private List<string> playlistNames;
        private string email;

        public MusicInfoForm(string track, bool isLocal)
        {
            InitializeComponent();
            this.track = track;
            this.isLocal = isLocal;
            this.playlistNames = new List<string>();
        }

        private async void MusicInfoForm_Load(object sender, EventArgs e)
        {
            await UpdateMusicInfo(track, isLocal);
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public async Task UpdateMusicInfo(string track, bool isLocal)
        {
            this.track = track;
            this.isLocal = isLocal;
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


            trackNameLabel.Text = trackName;
            artistNameLabel.Text = artistName;
            trackDurationLabel.Text = formattedTime;

            trackNameLabel.Font = new Font("Segoe UI", trackName.Length > 25 ? 13 : 16);
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

        private void addLoveBtn_Click(object sender, EventArgs e)
        {
            // Not applicable if local track
            if (!isLocal)
            {
                if (!isInFavourite)
                {
                    isInFavourite = true;
                    addLoveBtn.Image = Resource1.heartFilled;
                }
                else
                {
                    isInFavourite = false;
                    addLoveBtn.Image = Resource1.heart;
                }
            }
            else
            {
                MessageBox.Show("Not availble for local files.");
            }
        }

        private void addToPlaylistBtn_Click(object sender, EventArgs e)
        {
            // Not applicable if local track
            if (!isLocal)
            {
                AddToPlaylistForm addToPlaylistForm = new AddToPlaylistForm(track, email);
                addToPlaylistForm.Show();
            }
            else
            {
                MessageBox.Show("Not available for local files");
            }
        }
    }
}
