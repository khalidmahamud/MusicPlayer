namespace MusicPlayer
{
    partial class MediaPlayerControlForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            artistNameLabel = new Label();
            trackPosterBox = new PictureBox();
            trackNameLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            forwardBtn = new Button();
            playPauseBtn = new Button();
            backwardBtn = new Button();
            trackProgressBar = new CustomComponents.CustomProgressBar();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackPosterBox).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.24124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.75876F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 342F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1342, 94);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.9211826F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.07882F));
            tableLayoutPanel2.Controls.Add(artistNameLabel, 1, 1);
            tableLayoutPanel2.Controls.Add(trackPosterBox, 0, 0);
            tableLayoutPanel2.Controls.Add(trackNameLabel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(406, 88);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // artistNameLabel
            // 
            artistNameLabel.AutoSize = true;
            artistNameLabel.Dock = DockStyle.Fill;
            artistNameLabel.Font = new Font("Segoe UI", 11F);
            artistNameLabel.ForeColor = SystemColors.ScrollBar;
            artistNameLabel.Location = new Point(92, 44);
            artistNameLabel.Name = "artistNameLabel";
            artistNameLabel.Size = new Size(311, 44);
            artistNameLabel.TabIndex = 3;
            // 
            // trackPosterBox
            // 
            trackPosterBox.BackColor = Color.FromArgb(18, 18, 18);
            trackPosterBox.Dock = DockStyle.Fill;
            trackPosterBox.Location = new Point(3, 3);
            trackPosterBox.Name = "trackPosterBox";
            tableLayoutPanel2.SetRowSpan(trackPosterBox, 2);
            trackPosterBox.Size = new Size(83, 82);
            trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;
            trackPosterBox.TabIndex = 1;
            trackPosterBox.TabStop = false;
            // 
            // trackNameLabel
            // 
            trackNameLabel.AutoSize = true;
            trackNameLabel.Dock = DockStyle.Fill;
            trackNameLabel.Font = new Font("Segoe UI", 14F);
            trackNameLabel.ForeColor = Color.White;
            trackNameLabel.Location = new Point(92, 0);
            trackNameLabel.Name = "trackNameLabel";
            trackNameLabel.Size = new Size(311, 44);
            trackNameLabel.TabIndex = 2;
            trackNameLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(forwardBtn, 3, 1);
            tableLayoutPanel3.Controls.Add(playPauseBtn, 2, 1);
            tableLayoutPanel3.Controls.Add(backwardBtn, 1, 1);
            tableLayoutPanel3.Controls.Add(trackProgressBar, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(415, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(581, 88);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // forwardBtn
            // 
            forwardBtn.Cursor = Cursors.Hand;
            forwardBtn.Dock = DockStyle.Fill;
            forwardBtn.FlatAppearance.BorderSize = 0;
            forwardBtn.FlatStyle = FlatStyle.Flat;
            forwardBtn.Image = Properties.Resources.forward;
            forwardBtn.ImageAlign = ContentAlignment.MiddleRight;
            forwardBtn.Location = new Point(323, 7);
            forwardBtn.Name = "forwardBtn";
            forwardBtn.Size = new Size(54, 44);
            forwardBtn.TabIndex = 3;
            forwardBtn.UseVisualStyleBackColor = true;
            // 
            // playPauseBtn
            // 
            playPauseBtn.Cursor = Cursors.Hand;
            playPauseBtn.Dock = DockStyle.Fill;
            playPauseBtn.FlatAppearance.BorderSize = 0;
            playPauseBtn.FlatStyle = FlatStyle.Flat;
            playPauseBtn.Image = Properties.Resources.play;
            playPauseBtn.Location = new Point(263, 7);
            playPauseBtn.Name = "playPauseBtn";
            playPauseBtn.Size = new Size(54, 44);
            playPauseBtn.TabIndex = 2;
            playPauseBtn.UseVisualStyleBackColor = true;
            playPauseBtn.Click += playPauseBtn_Click;
            // 
            // backwardBtn
            // 
            backwardBtn.Cursor = Cursors.Hand;
            backwardBtn.Dock = DockStyle.Fill;
            backwardBtn.FlatAppearance.BorderSize = 0;
            backwardBtn.FlatStyle = FlatStyle.Flat;
            backwardBtn.Image = Properties.Resources.backward;
            backwardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            backwardBtn.Location = new Point(203, 7);
            backwardBtn.Name = "backwardBtn";
            backwardBtn.Size = new Size(54, 44);
            backwardBtn.TabIndex = 1;
            backwardBtn.UseVisualStyleBackColor = true;
            // 
            // trackProgressBar
            // 
            trackProgressBar.ChannelColor = Color.White;
            trackProgressBar.ChannelHeight = 6;
            tableLayoutPanel3.SetColumnSpan(trackProgressBar, 5);
            trackProgressBar.Dock = DockStyle.Top;
            trackProgressBar.ForeBackColor = Color.RoyalBlue;
            trackProgressBar.ForeColor = Color.White;
            trackProgressBar.Location = new Point(3, 57);
            trackProgressBar.Name = "trackProgressBar";
            trackProgressBar.ShowMaximun = false;
            trackProgressBar.ShowValue = CustomComponents.TextPosition.None;
            trackProgressBar.Size = new Size(575, 14);
            trackProgressBar.SliderColor = Color.FromArgb(247, 40, 51);
            trackProgressBar.SliderHeight = 10;
            trackProgressBar.SymbolAfter = "";
            trackProgressBar.SymbolBefore = "";
            trackProgressBar.TabIndex = 4;
            // 
            // MediaPlayerControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1382, 114);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MediaPlayerControlForm";
            Padding = new Padding(20, 10, 20, 10);
            Text = "Form1";
            Load += MediaPlayerControlForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackPosterBox).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label artistNameLabel;
        private PictureBox trackPosterBox;
        private Label trackNameLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button backwardBtn;
        private Button forwardBtn;
        private Button playPauseBtn;
        public CustomComponents.CustomProgressBar trackProgressBar;
    }
}