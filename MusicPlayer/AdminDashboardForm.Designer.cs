namespace MusicPlayer
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            messageButton = new Button();
            changePhotoLinkLabel = new LinkLabel();
            userProfilepictureBox = new PictureBox();
            changePasswordButton = new Button();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            composeButton = new Button();
            userListBox = new ListBox();
            viewLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)userProfilepictureBox).BeginInit();
            SuspendLayout();
            // 
            // messageButton
            // 
            messageButton.BackgroundImageLayout = ImageLayout.None;
            messageButton.Image = (Image)resources.GetObject("messageButton.Image");
            messageButton.Location = new Point(22, 28);
            messageButton.Name = "messageButton";
            messageButton.Size = new Size(90, 61);
            messageButton.TabIndex = 0;
            messageButton.Text = "messages";
            messageButton.TextImageRelation = TextImageRelation.ImageAboveText;
            messageButton.UseVisualStyleBackColor = false;
            messageButton.Click += messageButton_Click;
            // 
            // changePhotoLinkLabel
            // 
            changePhotoLinkLabel.ActiveLinkColor = Color.White;
            changePhotoLinkLabel.AutoSize = true;
            changePhotoLinkLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            changePhotoLinkLabel.LinkColor = Color.White;
            changePhotoLinkLabel.Location = new Point(727, 347);
            changePhotoLinkLabel.Name = "changePhotoLinkLabel";
            changePhotoLinkLabel.Size = new Size(186, 25);
            changePhotoLinkLabel.TabIndex = 26;
            changePhotoLinkLabel.TabStop = true;
            changePhotoLinkLabel.Text = "Change/upload photo";
            changePhotoLinkLabel.LinkClicked += changePhotoLinkLabel_LinkClicked;
            // 
            // userProfilepictureBox
            // 
            userProfilepictureBox.Image = (Image)resources.GetObject("userProfilepictureBox.Image");
            userProfilepictureBox.Location = new Point(689, 95);
            userProfilepictureBox.Name = "userProfilepictureBox";
            userProfilepictureBox.Size = new Size(277, 249);
            userProfilepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilepictureBox.TabIndex = 25;
            userProfilepictureBox.TabStop = false;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            changePasswordButton.BackColor = Color.FromArgb(255, 40, 16);
            changePasswordButton.Cursor = Cursors.Hand;
            changePasswordButton.FlatAppearance.BorderSize = 0;
            changePasswordButton.FlatStyle = FlatStyle.Flat;
            changePasswordButton.Font = new Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changePasswordButton.ForeColor = Color.White;
            changePasswordButton.ImageAlign = ContentAlignment.TopRight;
            changePasswordButton.Location = new Point(727, 539);
            changePasswordButton.Margin = new Padding(0);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(155, 39);
            changePasswordButton.TabIndex = 22;
            changePasswordButton.Text = "change password";
            changePasswordButton.TextAlign = ContentAlignment.TopCenter;
            changePasswordButton.UseVisualStyleBackColor = false;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(131, 146, 188);
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Location = new Point(727, 442);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(331, 25);
            emailTextBox.TabIndex = 17;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(649, 442);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(78, 25);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email: ";
            // 
            // composeButton
            // 
            composeButton.BackgroundImageLayout = ImageLayout.None;
            composeButton.Image = (Image)resources.GetObject("composeButton.Image");
            composeButton.Location = new Point(130, 28);
            composeButton.Name = "composeButton";
            composeButton.Size = new Size(90, 61);
            composeButton.TabIndex = 28;
            composeButton.Text = "compose";
            composeButton.TextImageRelation = TextImageRelation.ImageAboveText;
            composeButton.UseVisualStyleBackColor = false;
            composeButton.Click += composeButton_Click;
            // 
            // userListBox
            // 
            userListBox.BackColor = SystemColors.ScrollBar;
            userListBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userListBox.FormattingEnabled = true;
            userListBox.ItemHeight = 25;
            userListBox.Location = new Point(149, 188);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(267, 279);
            userListBox.TabIndex = 29;
            // 
            // viewLabel
            // 
            viewLabel.AutoSize = true;
            viewLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewLabel.Location = new Point(149, 148);
            viewLabel.Name = "viewLabel";
            viewLabel.Size = new Size(210, 28);
            viewLabel.TabIndex = 30;
            viewLabel.Text = "View all users(email): ";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 146, 188);
            ClientSize = new Size(1116, 743);
            Controls.Add(viewLabel);
            Controls.Add(userListBox);
            Controls.Add(composeButton);
            Controls.Add(changePhotoLinkLabel);
            Controls.Add(userProfilepictureBox);
            Controls.Add(changePasswordButton);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(messageButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)userProfilepictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button messageButton;
        private LinkLabel changePhotoLinkLabel;
        private PictureBox userProfilepictureBox;
        private LinkLabel changePasswordLinkLabel;
        private LinkLabel editLinkLabel;
        private Button changePasswordButton;
        private TextBox emailTextBox;
        private Label emailLabel;
        private Button composeButton;
        private ListBox userListBox;
        private Label viewLabel;
    }
}