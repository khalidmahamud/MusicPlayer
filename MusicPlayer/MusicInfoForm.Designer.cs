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
            customPanel1 = new CustomPanel.CustomPanel();
            trackPosterBox = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            trackDurationLabel = new Label();
            artistNameLabel = new Label();
            trackNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackPosterBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 20);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(customPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(18, 18, 18);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(362, 588);
            splitContainer1.SplitterDistance = 299;
            splitContainer1.TabIndex = 0;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(18, 18, 18);
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(trackPosterBox);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(18, 18, 18);
            customPanel1.GradientTopColor = Color.FromArgb(18, 18, 18);
            customPanel1.Location = new Point(0, 0);
            customPanel1.Margin = new Padding(10);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(362, 299);
            customPanel1.TabIndex = 0;
            // 
            // trackPosterBox
            // 
            trackPosterBox.BackColor = Color.FromArgb(18, 18, 18);
            trackPosterBox.Dock = DockStyle.Fill;
            trackPosterBox.Image = (Image)resources.GetObject("trackPosterBox.Image");
            trackPosterBox.InitialImage = null;
            trackPosterBox.Location = new Point(0, 0);
            trackPosterBox.Name = "trackPosterBox";
            trackPosterBox.Size = new Size(362, 299);
            trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;
            trackPosterBox.TabIndex = 0;
            trackPosterBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(trackDurationLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(artistNameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(trackNameLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(362, 122);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // trackDurationLabel
            // 
            trackDurationLabel.AutoSize = true;
            trackDurationLabel.Dock = DockStyle.Fill;
            trackDurationLabel.Font = new Font("Segoe UI", 14F);
            trackDurationLabel.ForeColor = Color.White;
            trackDurationLabel.Location = new Point(3, 84);
            trackDurationLabel.Name = "trackDurationLabel";
            trackDurationLabel.Size = new Size(356, 38);
            trackDurationLabel.TabIndex = 2;
            trackDurationLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // artistNameLabel
            // 
            artistNameLabel.AutoSize = true;
            artistNameLabel.Dock = DockStyle.Fill;
            artistNameLabel.Font = new Font("Segoe UI", 13F);
            artistNameLabel.ForeColor = Color.White;
            artistNameLabel.Location = new Point(3, 48);
            artistNameLabel.Name = "artistNameLabel";
            artistNameLabel.Size = new Size(356, 36);
            artistNameLabel.TabIndex = 0;
            artistNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackNameLabel
            // 
            trackNameLabel.AutoSize = true;
            trackNameLabel.Dock = DockStyle.Fill;
            trackNameLabel.Font = new Font("Segoe UI", 15F);
            trackNameLabel.ForeColor = Color.FromArgb(247, 41, 57);
            trackNameLabel.Location = new Point(3, 0);
            trackNameLabel.Name = "trackNameLabel";
            trackNameLabel.Size = new Size(356, 48);
            trackNameLabel.TabIndex = 1;
            trackNameLabel.TextAlign = ContentAlignment.BottomCenter;
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
            Padding = new Padding(10, 20, 10, 20);
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += MusicInfoForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackPosterBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private CustomPanel.CustomPanel customPanel1;
        private PictureBox trackPosterBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label trackNameLabel;
        private Label artistNameLabel;
        private Label trackDurationLabel;
    }
}