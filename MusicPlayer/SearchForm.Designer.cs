namespace MusicPlayer
{
    partial class SearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            splitContainer1 = new SplitContainer();
            roundedPanel1 = new CustomComponents.RoundedPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            searchBox = new TextBox();
            searchBtn = new Button();
            genreListPanel = new Panel();
            metalPanel = new Panel();
            metalBtn = new Button();
            popPanel = new Panel();
            popBtn = new Button();
            rapPanel = new Panel();
            rapBtn = new Button();
            folkPanel = new Panel();
            folkBtn = new Button();
            jazzPanel = new Panel();
            jazzBtn = new Button();
            countryPanel = new Panel();
            countryBtn = new Button();
            classicPanel = new Panel();
            classicBtn = new Button();
            rockPanel = new Panel();
            rockBtn = new Button();
            loadingTrackIconBox = new PictureBox();
            searchResultPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            genreListPanel.SuspendLayout();
            metalPanel.SuspendLayout();
            popPanel.SuspendLayout();
            rapPanel.SuspendLayout();
            folkPanel.SuspendLayout();
            jazzPanel.SuspendLayout();
            countryPanel.SuspendLayout();
            classicPanel.SuspendLayout();
            rockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingTrackIconBox).BeginInit();
            searchResultPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(247, 40, 57);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(20, 20);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(roundedPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(genreListPanel);
            splitContainer1.Size = new Size(683, 588);
            splitContainer1.SplitterDistance = 80;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = SystemColors.ActiveCaptionText;
            roundedPanel1.BackgroundColor = Color.FromArgb(18, 18, 18);
            roundedPanel1.BorderColor = SystemColors.ActiveCaptionText;
            roundedPanel1.BorderWidth = 2F;
            roundedPanel1.Controls.Add(tableLayoutPanel1);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(15);
            roundedPanel1.Radius = 10;
            roundedPanel1.Size = new Size(683, 80);
            roundedPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.5549F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4450951F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(searchBtn, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 0, 0, 0);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(653, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(searchBox, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(13, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(556, 44);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(18, 18, 18);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Dock = DockStyle.Fill;
            searchBox.Font = new Font("Segoe UI", 15F);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(3, 5);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search...";
            searchBox.Size = new Size(550, 34);
            searchBox.TabIndex = 1;
            searchBox.KeyDown += SearchBox_KeyDown;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(18, 18, 18);
            searchBtn.Dock = DockStyle.Fill;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(572, 0);
            searchBtn.Margin = new Padding(0);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(81, 50);
            searchBtn.TabIndex = 1;
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += Search_Btn_Click;
            // 
            // genreListPanel
            // 
            genreListPanel.AutoSize = true;
            genreListPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            genreListPanel.BackColor = SystemColors.ActiveCaptionText;
            genreListPanel.Controls.Add(searchResultPanel);
            genreListPanel.Controls.Add(metalPanel);
            genreListPanel.Controls.Add(popPanel);
            genreListPanel.Controls.Add(rapPanel);
            genreListPanel.Controls.Add(folkPanel);
            genreListPanel.Controls.Add(jazzPanel);
            genreListPanel.Controls.Add(countryPanel);
            genreListPanel.Controls.Add(classicPanel);
            genreListPanel.Controls.Add(rockPanel);
            genreListPanel.Dock = DockStyle.Fill;
            genreListPanel.Location = new Point(0, 0);
            genreListPanel.Name = "genreListPanel";
            genreListPanel.Padding = new Padding(0, 20, 0, 0);
            genreListPanel.Size = new Size(683, 507);
            genreListPanel.TabIndex = 0;
            // 
            // metalPanel
            // 
            metalPanel.Controls.Add(metalBtn);
            metalPanel.Location = new Point(524, 200);
            metalPanel.Name = "metalPanel";
            metalPanel.Size = new Size(156, 144);
            metalPanel.TabIndex = 8;
            // 
            // metalBtn
            // 
            metalBtn.Dock = DockStyle.Fill;
            metalBtn.FlatAppearance.BorderSize = 0;
            metalBtn.FlatStyle = FlatStyle.Flat;
            metalBtn.Font = new Font("Segoe UI", 15F);
            metalBtn.ForeColor = Color.White;
            metalBtn.Location = new Point(0, 0);
            metalBtn.Name = "metalBtn";
            metalBtn.Padding = new Padding(0, 0, 0, 5);
            metalBtn.Size = new Size(156, 144);
            metalBtn.TabIndex = 1;
            metalBtn.Tag = "metal";
            metalBtn.Text = "Metal";
            metalBtn.TextAlign = ContentAlignment.BottomCenter;
            metalBtn.UseVisualStyleBackColor = true;
            metalBtn.Click += metalBtn_Click;
            // 
            // popPanel
            // 
            popPanel.Controls.Add(popBtn);
            popPanel.Location = new Point(348, 200);
            popPanel.Name = "popPanel";
            popPanel.Size = new Size(156, 144);
            popPanel.TabIndex = 7;
            // 
            // popBtn
            // 
            popBtn.Dock = DockStyle.Fill;
            popBtn.FlatAppearance.BorderSize = 0;
            popBtn.FlatStyle = FlatStyle.Flat;
            popBtn.Font = new Font("Segoe UI", 15F);
            popBtn.ForeColor = Color.White;
            popBtn.Location = new Point(0, 0);
            popBtn.Name = "popBtn";
            popBtn.Padding = new Padding(0, 0, 0, 5);
            popBtn.Size = new Size(156, 144);
            popBtn.TabIndex = 1;
            popBtn.Tag = "pop";
            popBtn.Text = "Pop";
            popBtn.TextAlign = ContentAlignment.BottomCenter;
            popBtn.UseVisualStyleBackColor = true;
            popBtn.Click += popBtn_Click;
            // 
            // rapPanel
            // 
            rapPanel.Controls.Add(rapBtn);
            rapPanel.Location = new Point(175, 200);
            rapPanel.Name = "rapPanel";
            rapPanel.Size = new Size(156, 144);
            rapPanel.TabIndex = 6;
            // 
            // rapBtn
            // 
            rapBtn.Dock = DockStyle.Fill;
            rapBtn.FlatAppearance.BorderSize = 0;
            rapBtn.FlatStyle = FlatStyle.Flat;
            rapBtn.Font = new Font("Segoe UI", 15F);
            rapBtn.ForeColor = Color.White;
            rapBtn.Location = new Point(0, 0);
            rapBtn.Name = "rapBtn";
            rapBtn.Padding = new Padding(0, 0, 0, 5);
            rapBtn.Size = new Size(156, 144);
            rapBtn.TabIndex = 1;
            rapBtn.Tag = "rap";
            rapBtn.Text = "Rap";
            rapBtn.TextAlign = ContentAlignment.BottomCenter;
            rapBtn.UseVisualStyleBackColor = true;
            rapBtn.Click += rapBtn_Click;
            // 
            // folkPanel
            // 
            folkPanel.Controls.Add(folkBtn);
            folkPanel.Location = new Point(3, 200);
            folkPanel.Name = "folkPanel";
            folkPanel.Size = new Size(156, 144);
            folkPanel.TabIndex = 5;
            // 
            // folkBtn
            // 
            folkBtn.Dock = DockStyle.Fill;
            folkBtn.FlatAppearance.BorderSize = 0;
            folkBtn.FlatStyle = FlatStyle.Flat;
            folkBtn.Font = new Font("Segoe UI", 15F);
            folkBtn.ForeColor = Color.White;
            folkBtn.Location = new Point(0, 0);
            folkBtn.Name = "folkBtn";
            folkBtn.Padding = new Padding(0, 0, 0, 5);
            folkBtn.Size = new Size(156, 144);
            folkBtn.TabIndex = 1;
            folkBtn.Tag = "folk";
            folkBtn.Text = "Folk";
            folkBtn.TextAlign = ContentAlignment.BottomCenter;
            folkBtn.UseVisualStyleBackColor = true;
            folkBtn.Click += folkBtn_Click;
            // 
            // jazzPanel
            // 
            jazzPanel.Controls.Add(jazzBtn);
            jazzPanel.Location = new Point(524, 36);
            jazzPanel.Name = "jazzPanel";
            jazzPanel.Size = new Size(156, 144);
            jazzPanel.TabIndex = 4;
            // 
            // jazzBtn
            // 
            jazzBtn.Dock = DockStyle.Fill;
            jazzBtn.FlatAppearance.BorderSize = 0;
            jazzBtn.FlatStyle = FlatStyle.Flat;
            jazzBtn.Font = new Font("Segoe UI", 15F);
            jazzBtn.ForeColor = Color.White;
            jazzBtn.Location = new Point(0, 0);
            jazzBtn.Name = "jazzBtn";
            jazzBtn.Padding = new Padding(0, 0, 0, 5);
            jazzBtn.Size = new Size(156, 144);
            jazzBtn.TabIndex = 1;
            jazzBtn.Tag = "jazz";
            jazzBtn.Text = "Jazz";
            jazzBtn.TextAlign = ContentAlignment.BottomCenter;
            jazzBtn.UseVisualStyleBackColor = true;
            jazzBtn.Click += jazzBtn_Click;
            // 
            // countryPanel
            // 
            countryPanel.Controls.Add(countryBtn);
            countryPanel.Location = new Point(348, 36);
            countryPanel.Name = "countryPanel";
            countryPanel.Size = new Size(156, 144);
            countryPanel.TabIndex = 3;
            // 
            // countryBtn
            // 
            countryBtn.Dock = DockStyle.Fill;
            countryBtn.FlatAppearance.BorderSize = 0;
            countryBtn.FlatStyle = FlatStyle.Flat;
            countryBtn.Font = new Font("Segoe UI", 15F);
            countryBtn.ForeColor = Color.White;
            countryBtn.Location = new Point(0, 0);
            countryBtn.Name = "countryBtn";
            countryBtn.Padding = new Padding(0, 0, 0, 5);
            countryBtn.Size = new Size(156, 144);
            countryBtn.TabIndex = 1;
            countryBtn.Tag = "country";
            countryBtn.Text = "Country";
            countryBtn.TextAlign = ContentAlignment.BottomCenter;
            countryBtn.UseVisualStyleBackColor = true;
            countryBtn.Click += countryBtn_Click;
            // 
            // classicPanel
            // 
            classicPanel.Controls.Add(classicBtn);
            classicPanel.Location = new Point(175, 36);
            classicPanel.Name = "classicPanel";
            classicPanel.Size = new Size(156, 144);
            classicPanel.TabIndex = 1;
            // 
            // classicBtn
            // 
            classicBtn.Dock = DockStyle.Fill;
            classicBtn.FlatAppearance.BorderSize = 0;
            classicBtn.FlatStyle = FlatStyle.Flat;
            classicBtn.Font = new Font("Segoe UI", 15F);
            classicBtn.ForeColor = Color.White;
            classicBtn.Location = new Point(0, 0);
            classicBtn.Name = "classicBtn";
            classicBtn.Padding = new Padding(0, 0, 0, 5);
            classicBtn.Size = new Size(156, 144);
            classicBtn.TabIndex = 1;
            classicBtn.Tag = "classic";
            classicBtn.Text = "Classic";
            classicBtn.TextAlign = ContentAlignment.BottomCenter;
            classicBtn.UseVisualStyleBackColor = true;
            classicBtn.Click += classicBtn_Click;
            // 
            // rockPanel
            // 
            rockPanel.Controls.Add(rockBtn);
            rockPanel.Location = new Point(3, 36);
            rockPanel.Name = "rockPanel";
            rockPanel.Size = new Size(156, 144);
            rockPanel.TabIndex = 0;
            // 
            // rockBtn
            // 
            rockBtn.Dock = DockStyle.Fill;
            rockBtn.FlatAppearance.BorderSize = 0;
            rockBtn.FlatStyle = FlatStyle.Flat;
            rockBtn.Font = new Font("Segoe UI", 15F);
            rockBtn.ForeColor = Color.White;
            rockBtn.Location = new Point(0, 0);
            rockBtn.Name = "rockBtn";
            rockBtn.Padding = new Padding(0, 0, 0, 5);
            rockBtn.Size = new Size(156, 144);
            rockBtn.TabIndex = 0;
            rockBtn.Tag = "rock";
            rockBtn.Text = "Rock";
            rockBtn.TextAlign = ContentAlignment.BottomCenter;
            rockBtn.UseVisualStyleBackColor = true;
            rockBtn.Click += rockBtn_Click;
            // 
            // loadingTrackIconBox
            // 
            loadingTrackIconBox.Image = (Image)resources.GetObject("loadingTrackIconBox.Image");
            loadingTrackIconBox.Location = new Point(-3, 0);
            loadingTrackIconBox.Margin = new Padding(0);
            loadingTrackIconBox.Name = "loadingTrackIconBox";
            loadingTrackIconBox.Size = new Size(683, 177);
            loadingTrackIconBox.SizeMode = PictureBoxSizeMode.CenterImage;
            loadingTrackIconBox.TabIndex = 2;
            loadingTrackIconBox.TabStop = false;
            loadingTrackIconBox.Visible = false;
            // 
            // searchResultPanel
            // 
            searchResultPanel.Controls.Add(loadingTrackIconBox);
            searchResultPanel.Dock = DockStyle.Fill;
            searchResultPanel.Location = new Point(0, 20);
            searchResultPanel.Name = "searchResultPanel";
            searchResultPanel.Size = new Size(683, 487);
            searchResultPanel.TabIndex = 9;
            searchResultPanel.Visible = false;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(723, 628);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchForm";
            Padding = new Padding(20);
            ShowInTaskbar = false;
            Text = "Search";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            genreListPanel.ResumeLayout(false);
            metalPanel.ResumeLayout(false);
            popPanel.ResumeLayout(false);
            rapPanel.ResumeLayout(false);
            folkPanel.ResumeLayout(false);
            jazzPanel.ResumeLayout(false);
            countryPanel.ResumeLayout(false);
            classicPanel.ResumeLayout(false);
            rockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loadingTrackIconBox).EndInit();
            searchResultPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel genreListPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button searchBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox searchBox;
        private CustomComponents.RoundedPanel roundedPanel1;
        private Panel metalPanel;
        private Panel popPanel;
        private Panel rapPanel;
        private Panel folkPanel;
        private Panel jazzPanel;
        private Panel countryPanel;
        private Panel classicPanel;
        private Button metalBtn;
        private Button popBtn;
        private Button rapBtn;
        private Button folkBtn;
        private Button jazzBtn;
        private Button countryBtn;
        private Button classicBtn;
        private Panel rockPanel;
        private Button rockBtn;
        private PictureBox loadingTrackIconBox;
        private Panel searchResultPanel;
    }
}
