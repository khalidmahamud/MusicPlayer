namespace MusicPlayer
{
    partial class PlaylistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistForm));
            panel1 = new Panel();
            playlistLIstPanel = new Panel();
            createPlaylistBtn = new Button();
            label1 = new Label();
            playlistMusicListPanel = new Panel();
            label2 = new Label();
            musicListPanel = new Panel();
            panel1.SuspendLayout();
            playlistMusicListPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(playlistMusicListPanel);
            panel1.Controls.Add(playlistLIstPanel);
            panel1.Controls.Add(createPlaylistBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(716, 626);
            panel1.TabIndex = 0;
            // 
            // playlistLIstPanel
            // 
            playlistLIstPanel.Location = new Point(23, 121);
            playlistLIstPanel.Name = "playlistLIstPanel";
            playlistLIstPanel.Size = new Size(670, 482);
            playlistLIstPanel.TabIndex = 3;
            // 
            // createPlaylistBtn
            // 
            createPlaylistBtn.Cursor = Cursors.Hand;
            createPlaylistBtn.FlatAppearance.BorderSize = 0;
            createPlaylistBtn.FlatStyle = FlatStyle.Flat;
            createPlaylistBtn.Font = new Font("Segoe UI", 11F);
            createPlaylistBtn.ForeColor = Color.White;
            createPlaylistBtn.Image = (Image)resources.GetObject("createPlaylistBtn.Image");
            createPlaylistBtn.ImageAlign = ContentAlignment.MiddleLeft;
            createPlaylistBtn.Location = new Point(470, 23);
            createPlaylistBtn.Name = "createPlaylistBtn";
            createPlaylistBtn.Size = new Size(223, 38);
            createPlaylistBtn.TabIndex = 2;
            createPlaylistBtn.Text = "    Create New Playlist";
            createPlaylistBtn.UseVisualStyleBackColor = true;
            createPlaylistBtn.Click += CreateNewPlaylistBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(135, 46);
            label1.TabIndex = 1;
            label1.Text = "Playlist";
            // 
            // playlistMusicListPanel
            // 
            playlistMusicListPanel.Controls.Add(musicListPanel);
            playlistMusicListPanel.Controls.Add(label2);
            playlistMusicListPanel.Dock = DockStyle.Fill;
            playlistMusicListPanel.Location = new Point(20, 20);
            playlistMusicListPanel.Name = "playlistMusicListPanel";
            playlistMusicListPanel.Size = new Size(676, 586);
            playlistMusicListPanel.TabIndex = 4;
            playlistMusicListPanel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(135, 46);
            label2.TabIndex = 0;
            label2.Text = "Playlist";
            // 
            // musicListPanel
            // 
            musicListPanel.Location = new Point(3, 90);
            musicListPanel.Name = "musicListPanel";
            musicListPanel.Size = new Size(673, 496);
            musicListPanel.TabIndex = 1;
            // 
            // PlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(716, 626);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlaylistForm";
            Text = "PlaylistForm";
            Load += PlaylistForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            playlistMusicListPanel.ResumeLayout(false);
            playlistMusicListPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button createPlaylistBtn;
        private Panel playlistLIstPanel;
        private Panel playlistMusicListPanel;
        private Panel musicListPanel;
        private Label label2;
    }
}