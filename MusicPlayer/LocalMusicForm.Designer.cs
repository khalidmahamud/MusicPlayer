namespace MusicPlayer
{
    partial class LocalMusicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalMusicForm));
            panel1 = new Panel();
            openFileBtn = new Button();
            openFolderBtn = new Button();
            localMusicFilesPanel = new FlowLayoutPanel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(openFileBtn);
            panel1.Controls.Add(openFolderBtn);
            panel1.Controls.Add(localMusicFilesPanel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(705, 581);
            panel1.TabIndex = 0;
            // 
            // openFileBtn
            // 
            openFileBtn.Cursor = Cursors.Hand;
            openFileBtn.FlatAppearance.BorderSize = 0;
            openFileBtn.FlatStyle = FlatStyle.Flat;
            openFileBtn.Font = new Font("Segoe UI", 12F);
            openFileBtn.ForeColor = Color.White;
            openFileBtn.Image = (Image)resources.GetObject("openFileBtn.Image");
            openFileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openFileBtn.Location = new Point(572, 27);
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(113, 47);
            openFileBtn.TabIndex = 4;
            openFileBtn.Text = "      File";
            openFileBtn.TextAlign = ContentAlignment.MiddleLeft;
            openFileBtn.UseVisualStyleBackColor = true;
            openFileBtn.Click += openFileBtn_Click;
            // 
            // openFolderBtn
            // 
            openFolderBtn.Cursor = Cursors.Hand;
            openFolderBtn.FlatAppearance.BorderSize = 0;
            openFolderBtn.FlatStyle = FlatStyle.Flat;
            openFolderBtn.Font = new Font("Segoe UI", 12F);
            openFolderBtn.ForeColor = Color.White;
            openFolderBtn.Image = (Image)resources.GetObject("openFolderBtn.Image");
            openFolderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openFolderBtn.Location = new Point(457, 27);
            openFolderBtn.Name = "openFolderBtn";
            openFolderBtn.Size = new Size(109, 47);
            openFolderBtn.TabIndex = 3;
            openFolderBtn.Text = "      Folder";
            openFolderBtn.TextAlign = ContentAlignment.MiddleLeft;
            openFolderBtn.UseVisualStyleBackColor = true;
            openFolderBtn.Click += openFolderBtn_Click;
            // 
            // localMusicFilesPanel
            // 
            localMusicFilesPanel.Dock = DockStyle.Bottom;
            localMusicFilesPanel.Location = new Point(20, 92);
            localMusicFilesPanel.Name = "localMusicFilesPanel";
            localMusicFilesPanel.Size = new Size(665, 469);
            localMusicFilesPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(213, 54);
            label1.TabIndex = 1;
            label1.Text = "Local Files";
            // 
            // LocalMusicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(705, 581);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LocalMusicForm";
            Text = "LocalMusicForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel localMusicFilesPanel;
        private Label label1;
        private Button openFileBtn;
        private Button openFolderBtn;
    }
}