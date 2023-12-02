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
        private string trackId = "";
        public MediaPlayerControlForm(string trackId)
        {
            InitializeComponent();

            this.trackId = trackId;
        }
    }
}
