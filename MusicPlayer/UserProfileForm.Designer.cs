namespace MusicPlayer
{
    partial class UserProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            nameLabel = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            label1 = new Label();
            genderTextBox = new TextBox();
            label2 = new Label();
            birthdateTextBox = new TextBox();
            label3 = new Label();
            signOutButton = new Button();
            editLinkLabel = new LinkLabel();
            changePasswordLinkLabel = new LinkLabel();
            userProfilepictureBox = new PictureBox();
            changePhotoLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)userProfilepictureBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 10.8F);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(24, 237);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(67, 22);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name: ";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(18, 18, 18);
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            nameTextBox.ForeColor = Color.White;
            nameTextBox.Location = new Point(128, 237);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(208, 21);
            nameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(18, 18, 18);
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Location = new Point(128, 279);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(208, 21);
            emailTextBox.TabIndex = 3;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 279);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 2;
            label1.Text = "Email: ";
            // 
            // genderTextBox
            // 
            genderTextBox.BackColor = Color.FromArgb(18, 18, 18);
            genderTextBox.BorderStyle = BorderStyle.None;
            genderTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            genderTextBox.ForeColor = Color.White;
            genderTextBox.Location = new Point(128, 363);
            genderTextBox.Name = "genderTextBox";
            genderTextBox.Size = new Size(115, 21);
            genderTextBox.TabIndex = 7;
            genderTextBox.TextChanged += genderTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 362);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 6;
            label2.Text = "Gender:";
            // 
            // birthdateTextBox
            // 
            birthdateTextBox.BackColor = Color.FromArgb(18, 18, 18);
            birthdateTextBox.BorderStyle = BorderStyle.None;
            birthdateTextBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            birthdateTextBox.ForeColor = Color.White;
            birthdateTextBox.Location = new Point(128, 319);
            birthdateTextBox.Name = "birthdateTextBox";
            birthdateTextBox.Size = new Size(115, 21);
            birthdateTextBox.TabIndex = 5;
            birthdateTextBox.TextChanged += birthdateTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 319);
            label3.Name = "label3";
            label3.Size = new Size(95, 22);
            label3.TabIndex = 4;
            label3.Text = "Birth Date:";
            // 
            // signOutButton
            // 
            signOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            signOutButton.BackColor = Color.FromArgb(247, 40, 57);
            signOutButton.Cursor = Cursors.Hand;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(128, 487);
            signOutButton.Margin = new Padding(0);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(100, 37);
            signOutButton.TabIndex = 9;
            signOutButton.Text = "SIGN OUT";
            signOutButton.TextAlign = ContentAlignment.MiddleLeft;
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += homeFormSelectBtn_Click;
            // 
            // editLinkLabel
            // 
            editLinkLabel.ActiveLinkColor = Color.FromArgb(247, 40, 57);
            editLinkLabel.AutoSize = true;
            editLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editLinkLabel.LinkColor = Color.FromArgb(247, 40, 57);
            editLinkLabel.Location = new Point(52, 431);
            editLinkLabel.Name = "editLinkLabel";
            editLinkLabel.Size = new Size(97, 25);
            editLinkLabel.TabIndex = 10;
            editLinkLabel.TabStop = true;
            editLinkLabel.Text = "Edit Profile";
            editLinkLabel.LinkClicked += editLinkLabel_LinkClicked;
            // 
            // changePasswordLinkLabel
            // 
            changePasswordLinkLabel.ActiveLinkColor = Color.FromArgb(247, 40, 57);
            changePasswordLinkLabel.AutoSize = true;
            changePasswordLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changePasswordLinkLabel.LinkColor = Color.FromArgb(247, 40, 57);
            changePasswordLinkLabel.Location = new Point(156, 431);
            changePasswordLinkLabel.Name = "changePasswordLinkLabel";
            changePasswordLinkLabel.Size = new Size(152, 25);
            changePasswordLinkLabel.TabIndex = 11;
            changePasswordLinkLabel.TabStop = true;
            changePasswordLinkLabel.Text = "Change Password";
            changePasswordLinkLabel.LinkClicked += changePasswordLinkLabel_LinkClicked;
            // 
            // userProfilepictureBox
            // 
            userProfilepictureBox.Image = (Image)resources.GetObject("userProfilepictureBox.Image");
            userProfilepictureBox.Location = new Point(101, 28);
            userProfilepictureBox.Name = "userProfilepictureBox";
            userProfilepictureBox.Size = new Size(146, 146);
            userProfilepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilepictureBox.TabIndex = 12;
            userProfilepictureBox.TabStop = false;
            // 
            // changePhotoLinkLabel
            // 
            changePhotoLinkLabel.ActiveLinkColor = Color.FromArgb(247, 40, 57);
            changePhotoLinkLabel.AutoSize = true;
            changePhotoLinkLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changePhotoLinkLabel.LinkColor = Color.FromArgb(247, 40, 57);
            changePhotoLinkLabel.Location = new Point(85, 177);
            changePhotoLinkLabel.Name = "changePhotoLinkLabel";
            changePhotoLinkLabel.Size = new Size(182, 23);
            changePhotoLinkLabel.TabIndex = 13;
            changePhotoLinkLabel.TabStop = true;
            changePhotoLinkLabel.Text = "Change/Upload Photo";
            changePhotoLinkLabel.LinkClicked += changePhotoLinkLabel_LinkClicked;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(364, 581);
            Controls.Add(changePhotoLinkLabel);
            Controls.Add(userProfilepictureBox);
            Controls.Add(changePasswordLinkLabel);
            Controls.Add(editLinkLabel);
            Controls.Add(signOutButton);
            Controls.Add(genderTextBox);
            Controls.Add(label2);
            Controls.Add(birthdateTextBox);
            Controls.Add(label3);
            Controls.Add(emailTextBox);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "UserProfileForm";
            Text = " ";
            Load += UserProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)userProfilepictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private Label label1;
        private TextBox genderTextBox;
        private Label label2;
        private TextBox birthdateTextBox;
        private Label label3;
        private Button signOutButton;
        private LinkLabel editLinkLabel;
        private LinkLabel changePasswordLinkLabel;
        private PictureBox userProfilepictureBox;
        private LinkLabel changePhotoLinkLabel;
    }
}