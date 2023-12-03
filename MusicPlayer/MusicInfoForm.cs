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
    public partial class MusicInfoForm : Form
    {
        private string trackId;
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
            TrackMetadata trackInfo = new TrackMetadata(this.trackId);
            await trackInfo.SetMetadata();

            // Assign metadata values
            this.trackName = TrackMetadata.trackName;
            this.artistName = TrackMetadata.artistName;
            this.trackPoster = TrackMetadata.trackPoster;

            // Set the ImageLocation property after metadata has been retrieved
            trackPosterBox.ImageLocation = this.trackPoster;
            trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;

            songNameLabel.Visible = true;
            artistNameLabel.Visible = true;
            songNameTextBox.Text = this.trackName;
            artistNameTextBox.Text = this.artistName;
        }

        private void trackPosterBox_Click(object sender, EventArgs e)
        {

        }

        private void songNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
