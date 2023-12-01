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
            customPanel1 = new CustomPanel.CustomPanel();
            customPanel2 = new CustomPanel.CustomPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            searchBox = new TextBox();
            searchBtn = new Button();
            panel1 = new Panel();
            searchResultPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(14, 24, 72);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(20, 20);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(customPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(683, 588);
            splitContainer1.SplitterDistance = 58;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(55, 65, 81);
            customPanel1.BorderRadius = 50;
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 0F;
            customPanel1.GradientBottomColor = Color.FromArgb(55, 65, 81);
            customPanel1.GradientTopColor = Color.FromArgb(55, 65, 81);
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(2);
            customPanel1.Size = new Size(683, 58);
            customPanel1.TabIndex = 0;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(13, 18, 47);
            customPanel2.BorderRadius = 50;
            customPanel2.Controls.Add(tableLayoutPanel1);
            customPanel2.Dock = DockStyle.Fill;
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(13, 18, 47);
            customPanel2.GradientTopColor = Color.FromArgb(13, 18, 47);
            customPanel2.Location = new Point(2, 2);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(10, 5, 10, 5);
            customPanel2.Size = new Size(679, 54);
            customPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(13, 18, 47);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.5549F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4450951F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(searchBtn, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 0, 0, 0);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(659, 44);
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
            tableLayoutPanel2.Size = new Size(562, 38);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(13, 18, 47);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Dock = DockStyle.Fill;
            searchBox.Font = new Font("Segoe UI", 15F);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(3, 2);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search...";
            searchBox.Size = new Size(556, 34);
            searchBox.TabIndex = 1;
            searchBox.KeyDown += SearchBox_KeyDown;
            // 
            // searchBtn
            // 
            searchBtn.Dock = DockStyle.Fill;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(578, 0);
            searchBtn.Margin = new Padding(0);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(81, 44);
            searchBtn.TabIndex = 1;
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += Search_Btn_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(14, 24, 72);
            panel1.Controls.Add(searchResultPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 20, 0, 0);
            panel1.Size = new Size(683, 529);
            panel1.TabIndex = 0;
            // 
            // searchResultPanel
            // 
            searchResultPanel.AutoSize = true;
            searchResultPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchResultPanel.BackColor = Color.FromArgb(14, 24, 72);
            searchResultPanel.Dock = DockStyle.Fill;
            searchResultPanel.FlowDirection = FlowDirection.TopDown;
            searchResultPanel.Location = new Point(0, 20);
            searchResultPanel.Name = "searchResultPanel";
            searchResultPanel.Size = new Size(683, 509);
            searchResultPanel.TabIndex = 0;
            searchResultPanel.WrapContents = false;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 24, 72);
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
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private FlowLayoutPanel searchResultPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button searchBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox searchBox;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel2;
    }
}
