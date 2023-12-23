using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace MusicPlayer
{
    // Represents the main form of the music player application
    public partial class MediaPlayerControlForm : Form
    {
        // Fields for track information
        private string trackId;
        private string trackName;
        private string artistName;
        private string trackPoster;
        private string trackPreviewUrl;
        private int trackDuration;

        // Timer for updating the progress bar
        private Timer updateTimer;

        // NAudio components for audio playback
        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;

        // Constructor for MediaPlayerControlForm
        public MediaPlayerControlForm(string trackId)
        {
            InitializeComponent();
            this.trackId = trackId;

            // Initialize NAudio components
            waveOutEvent = new WaveOutEvent();
            waveOutEvent.PlaybackStopped += WaveOutEvent_PlaybackStopped;

            // Initialize Timer for updating the progress bar
            updateTimer = new Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateProgressBar;
        }

        // Event handler for the form load event
        private async void MediaPlayerControlForm_Load(object sender, EventArgs e)
        {
            // Load the track information when the form is loaded
            LoadNewTrack(trackId);
        }

        // Load new track information based on the provided track ID
        public async void LoadNewTrack(string trackId)
        {
            // Dispose of existing audio resources
            DisposeAudioResources();
            updateTimer.Start();

            // Update the track ID
            this.trackId = trackId;
            playPauseBtn.Image = Resource1.play;

            // Check if the track ID is empty
            if (string.IsNullOrEmpty(trackId))
                return;

            // Stop playback if currently playing
            if (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                waveOutEvent.Stop();
            }

            // Dispose of existing audio file reader
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
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
            // Check if the track preview URL is empty
            if (string.IsNullOrEmpty(trackPreviewUrl))
                return;

            // If an audio file reader exists
            if (audioFileReader != null)
            {
                // If currently playing, pause; otherwise, play
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
            // If no audio file reader exists, create one and start playback
            else
            {
                audioFileReader = new AudioFileReader(trackPreviewUrl);
                waveOutEvent.Init(audioFileReader);

                waveOutEvent.Play();

                playPauseBtn.Image = Resource1.pause;

                int totalDuration = (int)audioFileReader.TotalTime.TotalSeconds;
                trackProgressBar.Maximum = totalDuration;
            }
        }

        // Event handler for the playback stopped event
        private void WaveOutEvent_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Checks if the playback stopped because it reached the end of the track
            if (e.Exception == null)
            {
                // Updates the icon to play
                playPauseBtn.Image = Resource1.play;
                updateTimer.Stop();
                // Resets the progress bar to the beginning
                trackProgressBar.Value = 0;
            }
        }

        // Event handler for updating the progress bar
        private void UpdateProgressBar(object sender, EventArgs e)
        {
            // If an audio file reader exists and playback is ongoing
            if (audioFileReader != null && waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                int currentPosition = (int)audioFileReader.CurrentTime.TotalSeconds;

                // Update the progress bar value with smooth transition
                if (InvokeRequired)
                {
                    Invoke(new Action(() => trackProgressBar.Value = currentPosition));
                }
                else
                {
                    trackProgressBar.Value = currentPosition;
                }
            }
        }

        // Cleanup resources when the form is closed
        private void MediaPlayerControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisposeAudioResources();
        }

        // Dispose of audio resources
        public void DisposeAudioResources()
        {
            // If the WaveOutEvent exists
            if (waveOutEvent != null)
            {
                // Stop playback if currently playing or paused
                if (waveOutEvent.PlaybackState == PlaybackState.Playing || waveOutEvent.PlaybackState == PlaybackState.Paused)
                {
                    waveOutEvent.Stop();
                }

                // Dispose of the WaveOutEvent
                waveOutEvent.Dispose();
                updateTimer.Stop();
                updateTimer.Dispose();
            }

            // If the AudioFileReader exists
            if (audioFileReader != null)
            {
                // Dispose of the AudioFileReader
                audioFileReader.Dispose();
                updateTimer.Stop();
                updateTimer.Dispose();
            }
        }
    }
}
