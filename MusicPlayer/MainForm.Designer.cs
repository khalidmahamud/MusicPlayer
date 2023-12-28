namespace MusicPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            supportButton = new Button();
            playlistFormSelectBtn = new Button();
            localMusicFormSelectBtn = new Button();
            exitButton = new Button();
            searchFormSelectBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            searchPageSelectPanel = new Panel();
            homeFormSelectBtn = new Button();
            homePageSelectPanel = new Panel();
            pictureBox1 = new PictureBox();
            splitContainer3 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            searchPageSelectPanel.SuspendLayout();
            homePageSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ActiveCaptionText;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1370, 743);
            splitContainer1.SplitterDistance = 626;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(18, 18, 18);
            splitContainer2.Panel1.Controls.Add(supportButton);
            splitContainer2.Panel1.Controls.Add(playlistFormSelectBtn);
            splitContainer2.Panel1.Controls.Add(localMusicFormSelectBtn);
            splitContainer2.Panel1.Controls.Add(exitButton);
            splitContainer2.Panel1.Controls.Add(searchFormSelectBtn);
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1370, 626);
            splitContainer2.SplitterDistance = 268;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // supportButton
            // 
            supportButton.BackColor = Color.FromArgb(18, 18, 18);
            supportButton.Cursor = Cursors.Hand;
            supportButton.Dock = DockStyle.Top;
            supportButton.FlatAppearance.BorderSize = 0;
            supportButton.FlatStyle = FlatStyle.Flat;
            supportButton.Font = new Font("Segoe UI", 15F);
            supportButton.ForeColor = Color.White;
            supportButton.Image = (Image)resources.GetObject("supportButton.Image");
            supportButton.ImageAlign = ContentAlignment.MiddleLeft;
            supportButton.Location = new Point(0, 386);
            supportButton.Margin = new Padding(0);
            supportButton.Name = "supportButton";
            supportButton.Padding = new Padding(30, 0, 0, 0);
            supportButton.Size = new Size(268, 77);
            supportButton.TabIndex = 3;
            supportButton.Text = "     Support";
            supportButton.TextAlign = ContentAlignment.MiddleLeft;
            supportButton.UseVisualStyleBackColor = false;
            supportButton.Click += supportButton_Click;
            // 
            // playlistFormSelectBtn
            // 
            playlistFormSelectBtn.BackColor = Color.FromArgb(18, 18, 18);
            playlistFormSelectBtn.Cursor = Cursors.Hand;
            playlistFormSelectBtn.Dock = DockStyle.Top;
            playlistFormSelectBtn.FlatAppearance.BorderSize = 0;
            playlistFormSelectBtn.FlatStyle = FlatStyle.Flat;
            playlistFormSelectBtn.Font = new Font("Segoe UI", 15F);
            playlistFormSelectBtn.ForeColor = Color.White;
            playlistFormSelectBtn.Image = (Image)resources.GetObject("playlistFormSelectBtn.Image");
            playlistFormSelectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            playlistFormSelectBtn.Location = new Point(0, 309);
            playlistFormSelectBtn.Margin = new Padding(0);
            playlistFormSelectBtn.Name = "playlistFormSelectBtn";
            playlistFormSelectBtn.Padding = new Padding(30, 0, 0, 0);
            playlistFormSelectBtn.Size = new Size(268, 77);
            playlistFormSelectBtn.TabIndex = 3;
            playlistFormSelectBtn.Text = "     Playlist";
            playlistFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            playlistFormSelectBtn.UseVisualStyleBackColor = false;
            playlistFormSelectBtn.Click += playlistFormSelectBtn_Click;
            // 
            // localMusicFormSelectBtn
            // 
            localMusicFormSelectBtn.BackColor = Color.FromArgb(18, 18, 18);
            localMusicFormSelectBtn.Cursor = Cursors.Hand;
            localMusicFormSelectBtn.Dock = DockStyle.Top;
            localMusicFormSelectBtn.FlatAppearance.BorderSize = 0;
            localMusicFormSelectBtn.FlatStyle = FlatStyle.Flat;
            localMusicFormSelectBtn.Font = new Font("Segoe UI", 15F);
            localMusicFormSelectBtn.ForeColor = Color.White;
            localMusicFormSelectBtn.Image = (Image)resources.GetObject("localMusicFormSelectBtn.Image");
            localMusicFormSelectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            localMusicFormSelectBtn.Location = new Point(0, 232);
            localMusicFormSelectBtn.Margin = new Padding(0);
            localMusicFormSelectBtn.Name = "localMusicFormSelectBtn";
            localMusicFormSelectBtn.Padding = new Padding(30, 0, 0, 0);
            localMusicFormSelectBtn.Size = new Size(268, 77);
            localMusicFormSelectBtn.TabIndex = 2;
            localMusicFormSelectBtn.Text = "     Local Files";
            localMusicFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            localMusicFormSelectBtn.UseVisualStyleBackColor = false;
            localMusicFormSelectBtn.Click += localMusicFormSelectBtn_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(18, 18, 18);
            exitButton.Cursor = Cursors.Hand;
            exitButton.Dock = DockStyle.Bottom;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 15F);
            exitButton.ForeColor = Color.White;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.ImageAlign = ContentAlignment.MiddleLeft;
            exitButton.Location = new Point(0, 549);
            exitButton.Margin = new Padding(0);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(30, 0, 0, 0);
            exitButton.Size = new Size(268, 77);
            exitButton.TabIndex = 1;
            exitButton.Text = "     Exit";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // searchFormSelectBtn
            // 
            searchFormSelectBtn.BackColor = Color.FromArgb(18, 18, 18);
            searchFormSelectBtn.Cursor = Cursors.Hand;
            searchFormSelectBtn.Dock = DockStyle.Top;
            searchFormSelectBtn.FlatAppearance.BorderSize = 0;
            searchFormSelectBtn.FlatStyle = FlatStyle.Flat;
            searchFormSelectBtn.Font = new Font("Segoe UI", 15F);
            searchFormSelectBtn.ForeColor = Color.White;
            searchFormSelectBtn.Image = (Image)resources.GetObject("searchFormSelectBtn.Image");
            searchFormSelectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchFormSelectBtn.Location = new Point(0, 155);
            searchFormSelectBtn.Margin = new Padding(0);
            searchFormSelectBtn.Name = "searchFormSelectBtn";
            searchFormSelectBtn.Padding = new Padding(30, 0, 0, 0);
            searchFormSelectBtn.Size = new Size(268, 77);
            searchFormSelectBtn.TabIndex = 0;
            searchFormSelectBtn.Text = "     Search";
            searchFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchFormSelectBtn.UseVisualStyleBackColor = false;
            searchFormSelectBtn.Click += searchFormSelectBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(searchPageSelectPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(homePageSelectPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(268, 155);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // searchPageSelectPanel
            // 
            searchPageSelectPanel.Controls.Add(homeFormSelectBtn);
            searchPageSelectPanel.Dock = DockStyle.Fill;
            searchPageSelectPanel.Location = new Point(0, 77);
            searchPageSelectPanel.Margin = new Padding(0);
            searchPageSelectPanel.Name = "searchPageSelectPanel";
            searchPageSelectPanel.Size = new Size(268, 78);
            searchPageSelectPanel.TabIndex = 1;
            // 
            // homeFormSelectBtn
            // 
            homeFormSelectBtn.BackColor = Color.FromArgb(18, 18, 18);
            homeFormSelectBtn.Cursor = Cursors.Hand;
            homeFormSelectBtn.Dock = DockStyle.Fill;
            homeFormSelectBtn.FlatAppearance.BorderSize = 0;
            homeFormSelectBtn.FlatStyle = FlatStyle.Flat;
            homeFormSelectBtn.Font = new Font("Segoe UI", 15F);
            homeFormSelectBtn.ForeColor = Color.Transparent;
            homeFormSelectBtn.Image = (Image)resources.GetObject("homeFormSelectBtn.Image");
            homeFormSelectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeFormSelectBtn.Location = new Point(0, 0);
            homeFormSelectBtn.Margin = new Padding(0);
            homeFormSelectBtn.Name = "homeFormSelectBtn";
            homeFormSelectBtn.Padding = new Padding(30, 0, 0, 0);
            homeFormSelectBtn.Size = new Size(268, 78);
            homeFormSelectBtn.TabIndex = 0;
            homeFormSelectBtn.Text = "     Home";
            homeFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            homeFormSelectBtn.UseVisualStyleBackColor = false;
            homeFormSelectBtn.Click += homeFromSelectBtn_Click;
            // 
            // homePageSelectPanel
            // 
            homePageSelectPanel.Controls.Add(pictureBox1);
            homePageSelectPanel.Dock = DockStyle.Fill;
            homePageSelectPanel.Location = new Point(0, 0);
            homePageSelectPanel.Margin = new Padding(0);
            homePageSelectPanel.Name = "homePageSelectPanel";
            homePageSelectPanel.Size = new Size(268, 77);
            homePageSelectPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MaximumSize = new Size(272, 77);
            pictureBox1.MinimumSize = new Size(272, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(30, 0, 0, 0);
            pictureBox1.Size = new Size(272, 77);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "Logo1";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel2);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(flowLayoutPanel3);
            splitContainer3.Size = new Size(1097, 626);
            splitContainer3.SplitterDistance = 716;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.AppWorkspace;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.MinimumSize = new Size(650, 600);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(716, 626);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(18, 18, 18);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(376, 626);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 743);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(949, 667);
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vibe";
            FormClosed += MainForm_FormClosed;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            searchPageSelectPanel.ResumeLayout(false);
            homePageSelectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel homePageSelectPanel;
        private Button homeFormSelectBtn;
        private Panel searchPageSelectPanel;
        private PictureBox pictureBox1;
        private Button searchFormSelectBtn;
        private Button localMusicFormSelectBtn;
        private Button exitButton;
        private Button supportButton;
        private Button playlistFormSelectBtn;
    }
}