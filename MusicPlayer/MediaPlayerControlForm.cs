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

        private Timer updateTimer; // Timer for updating the progress bar

        // Constructor for MediaPlayerControlForm
        public MediaPlayerControlForm(string trackId)
        {
            InitializeComponent();
            this.trackId = trackId;

            // Initialize NAudio components
            waveOutEvent = new WaveOutEvent();

            // Initialize the timer
            updateTimer = new Timer();
            updateTimer.Interval = 100; // Set the interval for updating the progress bar
            updateTimer.Tick += UpdateTimer_Tick;
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
            // Toggle play/pause
            if (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                waveOutEvent.Pause();
                updateTimer.Stop(); // Stop the timer when paused
            }
            else
            {
                if (audioFileReader == null)
                {
                    // Create an AudioFileReader from the track preview URL
                    audioFileReader = new AudioFileReader(trackPreviewUrl);
                    waveOutEvent.Init(audioFileReader);
                    trackProgressBar.Value = 0; // Reset progress bar value
                }

                waveOutEvent.Play();
                updateTimer.Start(); // Start the timer when playing
            }
        }

        // Event handler for the update timer tick
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Update the progress bar based on the current position of the audio
            if (audioFileReader != null)
            {
                trackProgressBar.Value = (int)audioFileReader.CurrentTime.TotalSeconds;
            }
        }

        // Cleanup resources when the form is closed
        private void MediaPlayerControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dispose of NAudio components
            waveOutEvent.Dispose();
            audioFileReader?.Dispose();

            // Stop and dispose of the timer
            updateTimer.Stop();
            updateTimer.Dispose();
        }
    }
}
