using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace MusicPlayer
{
    public partial class MediaPlayerControlForm : Form
    {
        private string trackId;
        private string trackName;
        private string artistName;
        private string trackPoster;
        private string trackPreviewUrl;
        private int trackDuration;

        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;


        // Constructor for MediaPlayerControlForm
        public MediaPlayerControlForm(string trackId)
        {
            InitializeComponent();
            this.trackId = trackId;


            // Initialize NAudio components
            waveOutEvent = new WaveOutEvent();
        }

        // Event handler for the form load event
        private async void MediaPlayerControlForm_Load(object sender, EventArgs e)
        {
            LoadNewTrack(trackId); 
        }

        public async void LoadNewTrack(string trackId)
        {
            DisposeAudioResources();
            
            // Update trackId
            this.trackId = trackId;

            playPauseBtn.Image = Resource1.play;

            if (string.IsNullOrEmpty(trackId))
                return;

            if (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                waveOutEvent.Stop();
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null; // Set audioFileReader to null
            }

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
                trackDuration = TrackMetadata.trackDuration;
                trackPreviewUrl = TrackMetadata.trackPreviewURL;

                // Set the ImageLocation property after metadata has been retrieved
                trackPosterBox.ImageLocation = trackPoster;
                trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;
                trackNameLabel.Text = trackName;
                artistNameLabel.Text = artistName;

                // Set the maximum value of the progress bar based on the track duration
                trackProgressBar.Maximum = trackDuration;

                // Adjust font size based on track name length
                trackNameLabel.Font = new Font("Segoe UI", trackName.Length > 25 ? 11 : 14);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Event handler for the playPauseBtn click event
        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trackPreviewUrl))
                return;

            if (audioFileReader != null)
            {
                if (waveOutEvent.PlaybackState == PlaybackState.Playing)
                {
                    waveOutEvent.Pause();

                    playPauseBtn.Image = Resource1.play;
                }
                else
                {
                    waveOutEvent.Play();

                    playPauseBtn.Image = Resource1.pause;
                }
            } 
            else
            {
                audioFileReader = new AudioFileReader(trackPreviewUrl);
                waveOutEvent.Init(audioFileReader);
                trackProgressBar.Value = 0;

                waveOutEvent.Play();

                playPauseBtn.Image = Resource1.pause;
;            }
        }

        // Cleanup resources when the form is closed
        private void MediaPlayerControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisposeAudioResources();
        }

        public void DisposeAudioResources()
        {
            if (waveOutEvent != null)
            {
                if (waveOutEvent.PlaybackState == PlaybackState.Playing || waveOutEvent.PlaybackState == PlaybackState.Paused)
                {
                    waveOutEvent.Stop();
                }

                waveOutEvent.Dispose();
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
            }
        }

    }
}
