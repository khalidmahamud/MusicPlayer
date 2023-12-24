using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using TagLib;
using Timer = System.Windows.Forms.Timer;

namespace MusicPlayer
{
    // Represents the main form of the music player application
    public partial class MediaPlayerControlForm : Form
    {
        private readonly MainForm mainForm;

        // Fields for track information
        private string trackId;
        private string trackName;
        private string artistName;
        private object trackPoster;
        private string trackPreviewUrl;
        private int totalMilliSeconds;

        // Timer for updating the progress bar
        private Timer updateTimer;

        // NAudio components for audio playback
        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;

        // Constructor for MediaPlayerControlForm
        public MediaPlayerControlForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Initialize NAudio components
            InitializeAudioComponents();
        }

        // Initializes NAudio components
        private void InitializeAudioComponents()
        {
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
            await LoadNewTrack(trackId);
        }

        // Load new track information based on the provided track ID
        public async Task LoadNewTrack(string trackId)
        {
            // Dispose of existing audio resources
            DisposeAudioResources();

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
                updateTimer.Stop();
            }

            // Dispose of existing audio file reader
            audioFileReader?.Dispose();

            // Display a loading image while fetching metadata
            trackPosterBox.Image = Resource1.loading;

            try
            {
                // Instantiate and asynchronously set track metadata
                TrackMetadata trackInfo = new TrackMetadata(trackId, false);
                await trackInfo.SetOnlineTrackMetadata();

                // Assign metadata values
                AssignMetadataValues();

                // Set the ImageLocation property after metadata has been retrieved
                SetMetadataUI();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Assigns metadata values from the TrackMetadata instance
        private void AssignMetadataValues()
        {
            // Assign metadata values
            trackName = TrackMetadata.trackName;
            artistName = TrackMetadata.artistName;
            trackPoster = TrackMetadata.trackPoster;
            totalMilliSeconds = TrackMetadata.totalMilliSeconds;
            trackPreviewUrl = TrackMetadata.trackPreviewURL;
        }

        // Sets UI elements based on metadata values
        private void SetMetadataUI()
        {
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

            // Set the maximum value of the progress bar based on the track duration
            trackProgressBar.Maximum = totalMilliSeconds;

            // Adjust font size based on track name length
            trackNameLabel.Font = new Font("Segoe UI", trackName.Length > 25 ? 11 : 14);
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

        // Event handler for the playPauseBtn click event
        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trackPreviewUrl) && (audioFileReader == null || waveOutEvent.PlaybackState == PlaybackState.Stopped))
            {
                // If no URL is provided, open a dialog to choose a local music file
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Audio Files|*.mp3;*.wav|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // User selected a local file
                    string selectedFilePath = openFileDialog.FileName;

                    // Update MusicInfoForm
                    mainForm.OpenMusicInfoForm(selectedFilePath, true);

                    // Retrieve metadata for the local file
                    TrackMetadata trackInfo = new TrackMetadata(selectedFilePath, true);
                    trackInfo.SetLocalTrackMetadata();

                    AssignMetadataValues();

                    // Set UI elements based on metadata values
                    SetMetadataUI();

                    // Initialize and play the local file
                    PlayLocalTrack(selectedFilePath);
                }

                return;
            }

            // If an audio file reader exists
            if (audioFileReader != null)
            {
                // If currently playing, pause; otherwise, play
                TogglePlayback();
            }
            // If no audio file reader exists, create one and start playback
            else
            {
                // Initialize and play the Spotify preview URL
                PlayOnlineTrack(trackPreviewUrl);
            }
        }

        // Toggles playback between play and pause
        private void TogglePlayback()
        {
            if (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                waveOutEvent.Pause();
                playPauseBtn.Image = Resource1.play;
            }
            else if (waveOutEvent.PlaybackState == PlaybackState.Stopped)
            {
                PlayOnlineTrack(trackPreviewUrl);
            }
            else
            {
                waveOutEvent.Play();
                playPauseBtn.Image = Resource1.pause;
            }
        }

        // Play a local track
        private void PlayLocalTrack(string filePath)
        {
            audioFileReader = new AudioFileReader(filePath);
            waveOutEvent.Init(audioFileReader);

            waveOutEvent.Play();
            updateTimer.Start();

            playPauseBtn.Image = Resource1.pause;

            int totalDuration = (int)audioFileReader.TotalTime.TotalSeconds;
            trackProgressBar.Maximum = totalDuration;
        }

        // Play an online track
        private void PlayOnlineTrack(string previewUrl)
        {
            audioFileReader = new AudioFileReader(previewUrl);
            waveOutEvent.Init(audioFileReader);

            waveOutEvent.Play();
            updateTimer.Start();

            playPauseBtn.Image = Resource1.pause;

            int totalDuration = (int)audioFileReader.TotalTime.TotalSeconds;
            trackProgressBar.Maximum = totalDuration;
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
            }

            // If the AudioFileReader exists
            audioFileReader?.Dispose();
        }
    }
}
