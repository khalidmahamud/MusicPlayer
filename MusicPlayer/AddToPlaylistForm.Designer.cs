namespace MusicPlayer
{
    partial class AddToPlaylistForm
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
            playlistPanel = new Panel();
            backBtn = new Button();
            SuspendLayout();
            // 
            // playlistPanel
            // 
            playlistPanel.BackColor = Color.Black;
            playlistPanel.Dock = DockStyle.Top;
            playlistPanel.Location = new Point(20, 20);
            playlistPanel.Name = "playlistPanel";
            playlistPanel.Padding = new Padding(20);
            playlistPanel.Size = new Size(542, 265);
            playlistPanel.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.White;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(240, 302);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(102, 40);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // AddToPlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 353);
            Controls.Add(backBtn);
            Controls.Add(playlistPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddToPlaylistForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddToPlaylistForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel playlistPanel;
        private Button backBtn;
    }
}