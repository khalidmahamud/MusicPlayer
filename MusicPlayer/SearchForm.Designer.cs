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
            roundedPanel1 = new CustomPanel.RoundedPanel();
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
            roundedPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(panel1);
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
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(searchResultPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 20, 0, 0);
            panel1.Size = new Size(683, 507);
            panel1.TabIndex = 0;
            // 
            // searchResultPanel
            // 
            searchResultPanel.AutoSize = true;
            searchResultPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchResultPanel.BackColor = SystemColors.ActiveCaptionText;
            searchResultPanel.Dock = DockStyle.Fill;
            searchResultPanel.FlowDirection = FlowDirection.TopDown;
            searchResultPanel.Location = new Point(0, 20);
            searchResultPanel.Name = "searchResultPanel";
            searchResultPanel.Size = new Size(683, 487);
            searchResultPanel.TabIndex = 0;
            searchResultPanel.WrapContents = false;
            searchResultPanel.Paint += searchResultPanel_Paint;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button searchBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox searchBox;
        private CustomPanel.RoundedPanel roundedPanel1;
        private FlowLayoutPanel searchResultPanel;
    }
}
