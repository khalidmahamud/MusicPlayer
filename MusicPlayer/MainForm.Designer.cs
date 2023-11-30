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
            tableLayoutPanel1 = new TableLayoutPanel();
            searchPageSelectPanel = new Panel();
            searchFormSelectBtn = new Button();
            homePageSelectPanel = new Panel();
            homeFormSelectBtn = new Button();
            splitContainer3 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            searchPageSelectPanel.SuspendLayout();
            homePageSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel4);
            splitContainer1.Size = new Size(1382, 743);
            splitContainer1.SplitterDistance = 628;
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
            splitContainer2.Panel1.BackColor = Color.FromArgb(13, 18, 47);
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1382, 628);
            splitContainer2.SplitterDistance = 272;
            splitContainer2.TabIndex = 0;
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
            tableLayoutPanel1.Size = new Size(272, 154);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // searchPageSelectPanel
            // 
            searchPageSelectPanel.Controls.Add(searchFormSelectBtn);
            searchPageSelectPanel.Dock = DockStyle.Fill;
            searchPageSelectPanel.Location = new Point(0, 77);
            searchPageSelectPanel.Margin = new Padding(0);
            searchPageSelectPanel.Name = "searchPageSelectPanel";
            searchPageSelectPanel.Size = new Size(272, 77);
            searchPageSelectPanel.TabIndex = 1;
            // 
            // searchFormSelectBtn
            // 
            searchFormSelectBtn.BackColor = Color.FromArgb(13, 18, 47);
            searchFormSelectBtn.Cursor = Cursors.Hand;
            searchFormSelectBtn.Dock = DockStyle.Fill;
            searchFormSelectBtn.FlatAppearance.BorderSize = 0;
            searchFormSelectBtn.FlatStyle = FlatStyle.Flat;
            searchFormSelectBtn.Font = new Font("Segoe UI", 15F);
            searchFormSelectBtn.ForeColor = Color.White;
            searchFormSelectBtn.Image = (Image)resources.GetObject("searchFormSelectBtn.Image");
            searchFormSelectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchFormSelectBtn.Location = new Point(0, 0);
            searchFormSelectBtn.Margin = new Padding(0);
            searchFormSelectBtn.Name = "searchFormSelectBtn";
            searchFormSelectBtn.Padding = new Padding(30, 0, 0, 0);
            searchFormSelectBtn.Size = new Size(272, 77);
            searchFormSelectBtn.TabIndex = 0;
            searchFormSelectBtn.Text = "     Search";
            searchFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchFormSelectBtn.UseVisualStyleBackColor = false;
            searchFormSelectBtn.Click += searchFormSelectBtn_Click;
            // 
            // homePageSelectPanel
            // 
            homePageSelectPanel.Controls.Add(homeFormSelectBtn);
            homePageSelectPanel.Dock = DockStyle.Fill;
            homePageSelectPanel.Location = new Point(0, 0);
            homePageSelectPanel.Margin = new Padding(0);
            homePageSelectPanel.Name = "homePageSelectPanel";
            homePageSelectPanel.Size = new Size(272, 77);
            homePageSelectPanel.TabIndex = 0;
            // 
            // homeFormSelectBtn
            // 
            homeFormSelectBtn.BackColor = Color.FromArgb(13, 18, 47);
            homeFormSelectBtn.Cursor = Cursors.Hand;
            homeFormSelectBtn.Dock = DockStyle.Fill;
            homeFormSelectBtn.FlatAppearance.BorderSize = 0;
            homeFormSelectBtn.FlatStyle = FlatStyle.Flat;
            homeFormSelectBtn.Font = new Font("Segoe UI", 15F);
            homeFormSelectBtn.ForeColor = Color.White;
            homeFormSelectBtn.Image = (Image)resources.GetObject("homeFormSelectBtn.Image");
            homeFormSelectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeFormSelectBtn.Location = new Point(0, 0);
            homeFormSelectBtn.Margin = new Padding(0);
            homeFormSelectBtn.Name = "homeFormSelectBtn";
            homeFormSelectBtn.Padding = new Padding(30, 0, 0, 0);
            homeFormSelectBtn.Size = new Size(272, 77);
            homeFormSelectBtn.TabIndex = 0;
            homeFormSelectBtn.Text = "     Home";
            homeFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            homeFormSelectBtn.UseVisualStyleBackColor = false;
            homeFormSelectBtn.Click += homeFromSelectBtn_Click;
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
            splitContainer3.Size = new Size(1106, 628);
            splitContainer3.SplitterDistance = 723;
            splitContainer3.SplitterWidth = 1;
            splitContainer3.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(14, 24, 72);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(723, 628);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.Wheat;
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(382, 628);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.Black;
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(1382, 114);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 743);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(950, 670);
            Name = "MainForm";
            Text = "Spotify";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            searchPageSelectPanel.ResumeLayout(false);
            homePageSelectPanel.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel homePageSelectPanel;
        private Button homeFormSelectBtn;
        private Panel searchPageSelectPanel;
        private Button searchFormSelectBtn;
    }
}