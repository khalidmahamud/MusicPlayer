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
            flowLayoutPanel1 = new FlowLayoutPanel();
            homePageSelectPanel = new Panel();
            homeFormSelectBtn = new Button();
            searchPageSelectPanel = new Panel();
            searchFormSelectBtn = new Button();
            splitContainer2 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            homePageSelectPanel.SuspendLayout();
            searchPageSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(14, 24, 72);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1262, 673);
            splitContainer1.SplitterDistance = 290;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(13, 18, 47);
            flowLayoutPanel1.Controls.Add(homePageSelectPanel);
            flowLayoutPanel1.Controls.Add(searchPageSelectPanel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(290, 673);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // homePageSelectPanel
            // 
            homePageSelectPanel.Controls.Add(homeFormSelectBtn);
            homePageSelectPanel.Dock = DockStyle.Top;
            homePageSelectPanel.Location = new Point(3, 3);
            homePageSelectPanel.Name = "homePageSelectPanel";
            homePageSelectPanel.Size = new Size(323, 65);
            homePageSelectPanel.TabIndex = 1;
            // 
            // homeFormSelectBtn
            // 
            homeFormSelectBtn.BackColor = Color.FromArgb(13, 18, 47);
            homeFormSelectBtn.Cursor = Cursors.Hand;
            homeFormSelectBtn.Dock = DockStyle.Fill;
            homeFormSelectBtn.FlatAppearance.BorderSize = 0;
            homeFormSelectBtn.FlatStyle = FlatStyle.Flat;
            homeFormSelectBtn.Font = new Font("Segoe UI", 13F);
            homeFormSelectBtn.ForeColor = Color.White;
            homeFormSelectBtn.Image = (Image)resources.GetObject("homeFormSelectBtn.Image");
            homeFormSelectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeFormSelectBtn.Location = new Point(0, 0);
            homeFormSelectBtn.Name = "homeFormSelectBtn";
            homeFormSelectBtn.Padding = new Padding(20, 0, 0, 0);
            homeFormSelectBtn.Size = new Size(323, 65);
            homeFormSelectBtn.TabIndex = 0;
            homeFormSelectBtn.Text = "       Home";
            homeFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            homeFormSelectBtn.UseVisualStyleBackColor = false;
            homeFormSelectBtn.Click += homeFromSelectBtn_Click;
            // 
            // searchPageSelectPanel
            // 
            searchPageSelectPanel.Controls.Add(searchFormSelectBtn);
            searchPageSelectPanel.Cursor = Cursors.Hand;
            searchPageSelectPanel.Dock = DockStyle.Top;
            searchPageSelectPanel.Location = new Point(3, 74);
            searchPageSelectPanel.Name = "searchPageSelectPanel";
            searchPageSelectPanel.Size = new Size(323, 66);
            searchPageSelectPanel.TabIndex = 0;
            // 
            // searchFormSelectBtn
            // 
            searchFormSelectBtn.BackColor = Color.FromArgb(13, 18, 47);
            searchFormSelectBtn.Dock = DockStyle.Fill;
            searchFormSelectBtn.FlatAppearance.BorderSize = 0;
            searchFormSelectBtn.FlatStyle = FlatStyle.Flat;
            searchFormSelectBtn.Font = new Font("Segoe UI", 13F);
            searchFormSelectBtn.ForeColor = Color.White;
            searchFormSelectBtn.Image = (Image)resources.GetObject("searchFormSelectBtn.Image");
            searchFormSelectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchFormSelectBtn.Location = new Point(0, 0);
            searchFormSelectBtn.Name = "searchFormSelectBtn";
            searchFormSelectBtn.Padding = new Padding(20, 0, 0, 0);
            searchFormSelectBtn.Size = new Size(323, 66);
            searchFormSelectBtn.TabIndex = 0;
            searchFormSelectBtn.Text = "       Search";
            searchFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchFormSelectBtn.UseVisualStyleBackColor = false;
            searchFormSelectBtn.Click += searchFormSelectBtn_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(14, 24, 72);
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(flowLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(13, 18, 47);
            splitContainer2.Size = new Size(971, 673);
            splitContainer2.SplitterDistance = 597;
            splitContainer2.SplitterWidth = 1;
            splitContainer2.TabIndex = 0;
            splitContainer2.SplitterMoved += splitContainer2_SplitterMoved;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(14, 24, 72);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(597, 673);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "Main Form";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            homePageSelectPanel.ResumeLayout(false);
            searchPageSelectPanel.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button searchFormSelectBtn;
        private Panel searchPageSelectPanel;
        private Panel homePageSelectPanel;
        private Button homeFormSelectBtn;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}