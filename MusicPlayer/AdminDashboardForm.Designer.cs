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
            ((System.ComponentModel.ISupportInitialize)userProfilepictureBox).BeginInit();
            SuspendLayout();
            // 
            // messageButton
            // 
            messageButton.BackgroundImageLayout = ImageLayout.None;
            messageButton.Image = (Image)resources.GetObject("messageButton.Image");
            messageButton.Location = new Point(22, 28);
            messageButton.Name = "messageButton";
            messageButton.Size = new Size(81, 57);
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
            changePhotoLinkLabel.Location = new Point(832, 182);
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
            userProfilepictureBox.Location = new Point(850, 28);
            userProfilepictureBox.Name = "userProfilepictureBox";
            userProfilepictureBox.Size = new Size(146, 146);
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
            changePasswordButton.Location = new Point(882, 273);
            changePasswordButton.Margin = new Padding(0);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(101, 60);
            changePasswordButton.TabIndex = 22;
            changePasswordButton.Text = "change password";
            changePasswordButton.TextAlign = ContentAlignment.TopCenter;
            changePasswordButton.UseVisualStyleBackColor = false;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(224, 224, 224);
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Location = new Point(872, 229);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(180, 23);
            emailTextBox.TabIndex = 17;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(795, 227);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(71, 25);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email: ";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 146, 188);
            ClientSize = new Size(1116, 743);
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
    }
}