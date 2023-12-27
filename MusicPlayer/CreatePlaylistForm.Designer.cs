namespace MusicPlayer
{
    partial class CreatePlaylistForm
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
            panel1 = new Panel();
            confirmBtn = new Button();
            backBtn = new Button();
            newPlaylistNameText = new TextBox();
            newPlaylistNameLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(confirmBtn);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(newPlaylistNameText);
            panel1.Controls.Add(newPlaylistNameLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(568, 362);
            panel1.TabIndex = 0;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.FromArgb(247, 40, 57);
            confirmBtn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(224, 231);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(114, 41);
            confirmBtn.TabIndex = 5;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.White;
            backBtn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            backBtn.ForeColor = Color.FromArgb(40, 40, 40);
            backBtn.Location = new Point(69, 231);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(114, 41);
            backBtn.TabIndex = 4;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // newPlaylistNameText
            // 
            newPlaylistNameText.Font = new Font("Segoe UI", 13F);
            newPlaylistNameText.Location = new Point(69, 170);
            newPlaylistNameText.Name = "newPlaylistNameText";
            newPlaylistNameText.Size = new Size(420, 36);
            newPlaylistNameText.TabIndex = 2;
            // 
            // newPlaylistNameLabel
            // 
            newPlaylistNameLabel.AutoSize = true;
            newPlaylistNameLabel.Font = new Font("Segoe UI", 13F);
            newPlaylistNameLabel.ForeColor = Color.White;
            newPlaylistNameLabel.Location = new Point(69, 118);
            newPlaylistNameLabel.Name = "newPlaylistNameLabel";
            newPlaylistNameLabel.Size = new Size(142, 30);
            newPlaylistNameLabel.TabIndex = 1;
            newPlaylistNameLabel.Text = "Playlist Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 0;
            label1.Text = "Create New Playlist";
            // 
            // CreatePlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(568, 362);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreatePlaylistForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePlaylistForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button backBtn;
        private TextBox newPlaylistNameText;
        private Label newPlaylistNameLabel;
        private Label label1;
        private Button confirmBtn;
    }
}