using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // Replace the URL with the Gmail URL
            string gmailUrl = "https://mail.google.com/mail/u/0/?fs=1&to=ashfaqhoq27@gmail.com&tf=cm";

            // Open the default web browser with the Gmail URL
            Process.Start(new ProcessStartInfo(gmailUrl) { UseShellExecute = true });
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
