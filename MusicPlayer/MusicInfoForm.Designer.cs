namespace MusicPlayer
{
    partial class MusicInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicInfoForm));
            splitContainer1 = new SplitContainer();
            trackPosterBox = new PictureBox();
            artistNameTextBox = new TextBox();
            artistNameLabel = new Label();
            songNameTextBox = new TextBox();
            songNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackPosterBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 20);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(trackPosterBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(18, 18, 18);
            splitContainer1.Panel2.Controls.Add(artistNameTextBox);
            splitContainer1.Panel2.Controls.Add(artistNameLabel);
            splitContainer1.Panel2.Controls.Add(songNameTextBox);
            splitContainer1.Panel2.Controls.Add(songNameLabel);
            splitContainer1.Size = new Size(382, 608);
            splitContainer1.SplitterDistance = 310;
            splitContainer1.TabIndex = 0;
            // 
            // trackPosterBox
            // 
            trackPosterBox.BackColor = Color.FromArgb(18, 18, 18);
            trackPosterBox.Dock = DockStyle.Fill;
            trackPosterBox.Image = (Image)resources.GetObject("trackPosterBox.Image");
            trackPosterBox.ImageLocation = "";
            trackPosterBox.InitialImage = null;
            trackPosterBox.Location = new Point(0, 0);
            trackPosterBox.Name = "trackPosterBox";
            trackPosterBox.Size = new Size(382, 310);
            trackPosterBox.SizeMode = PictureBoxSizeMode.CenterImage;
            trackPosterBox.TabIndex = 1;
            trackPosterBox.TabStop = false;
            trackPosterBox.Click += trackPosterBox_Click;
            // 
            // artistNameTextBox
            // 
            artistNameTextBox.BackColor = Color.FromArgb(18, 18, 18);
            artistNameTextBox.BorderStyle = BorderStyle.None;
            artistNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            artistNameTextBox.ForeColor = Color.Red;
            artistNameTextBox.Location = new Point(92, 72);
            artistNameTextBox.Name = "artistNameTextBox";
            artistNameTextBox.Size = new Size(227, 27);
            artistNameTextBox.TabIndex = 3;
            // 
            // artistNameLabel
            // 
            artistNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            artistNameLabel.ForeColor = SystemColors.HighlightText;
            artistNameLabel.Location = new Point(16, 70);
            artistNameLabel.Name = "artistNameLabel";
            artistNameLabel.Size = new Size(140, 36);
            artistNameLabel.TabIndex = 2;
            artistNameLabel.Text = "Artist:";
            artistNameLabel.Visible = false;
            // 
            // songNameTextBox
            // 
            songNameTextBox.BackColor = Color.FromArgb(18, 18, 18);
            songNameTextBox.BorderStyle = BorderStyle.None;
            songNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            songNameTextBox.ForeColor = Color.Red;
            songNameTextBox.Location = new Point(152, 32);
            songNameTextBox.Name = "songNameTextBox";
            songNameTextBox.Size = new Size(217, 27);
            songNameTextBox.TabIndex = 1;
            songNameTextBox.TextChanged += songNameTextBox_TextChanged;
            // 
            // songNameLabel
            // 
            songNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songNameLabel.ForeColor = SystemColors.HighlightText;
            songNameLabel.Location = new Point(16, 32);
            songNameLabel.Name = "songNameLabel";
            songNameLabel.Size = new Size(140, 36);
            songNameLabel.TabIndex = 0;
            songNameLabel.Text = "Song name: ";
            songNameLabel.Visible = false;
            // 
            // MusicInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(382, 628);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicInfoForm";
            Padding = new Padding(0, 20, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += MusicInfoForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackPosterBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox trackPosterBox;
        private Label songNameLabel;
        private TextBox songNameTextBox;
        private TextBox artistNameTextBox;
        private Label artistNameLabel;
    }
}