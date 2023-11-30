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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
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
            splitContainer1.Size = new Size(382, 608);
            splitContainer1.SplitterDistance = 310;
            splitContainer1.TabIndex = 0;
            // 
            // trackPosterBox
            // 
            trackPosterBox.BackColor = Color.FromArgb(13, 18, 47);
            trackPosterBox.Dock = DockStyle.Fill;
            trackPosterBox.Image = (Image)resources.GetObject("trackPosterBox.Image");
            trackPosterBox.ImageLocation = "";
            trackPosterBox.Location = new Point(0, 0);
            trackPosterBox.Name = "trackPosterBox";
            trackPosterBox.Size = new Size(382, 310);
            trackPosterBox.SizeMode = PictureBoxSizeMode.Zoom;
            trackPosterBox.TabIndex = 0;
            trackPosterBox.TabStop = false;
            // 
            // MusicInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 18, 47);
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackPosterBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox trackPosterBox;
    }
}