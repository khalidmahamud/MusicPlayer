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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            searchBtn = new Button();
            searchBox = new TextBox();
            panel1 = new Panel();
            searchResultPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(14, 24, 72);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(597, 673);
            splitContainer1.SplitterDistance = 100;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 24, 72);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 100);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(55, 65, 81);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(30, 23);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(2);
            panel3.Size = new Size(535, 60);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(13, 18, 47);
            panel4.Controls.Add(searchBtn);
            panel4.Controls.Add(searchBox);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 11F);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(2, 2);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(531, 56);
            panel4.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(13, 18, 47);
            searchBtn.Dock = DockStyle.Right;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(460, 5);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(66, 46);
            searchBtn.TabIndex = 1;
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += Search_Btn_Click;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            searchBox.BackColor = Color.FromArgb(13, 18, 47);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Font = new Font("Segoe UI", 15F);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(8, 8);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(422, 34);
            searchBox.TabIndex = 0;
            searchBox.KeyDown += SearchBox_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 24, 72);
            panel1.Controls.Add(searchResultPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 572);
            panel1.TabIndex = 0;
            // 
            // searchResultPanel
            // 
            searchResultPanel.AutoScroll = true;
            searchResultPanel.AutoScrollMargin = new Size(1, 1);
            searchResultPanel.AutoScrollMinSize = new Size(1, 1);
            searchResultPanel.BackColor = Color.FromArgb(14, 24, 72);
            searchResultPanel.Location = new Point(30, 21);
            searchResultPanel.Name = "searchResultPanel";
            searchResultPanel.Size = new Size(567, 528);
            searchResultPanel.TabIndex = 0;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 673);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchForm";
            ShowInTaskbar = false;
            Text = "Search";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel searchResultPanel;
        private Panel panel3;
        private Panel panel4;
        private Button searchBtn;
        private TextBox searchBox;
    }
}
