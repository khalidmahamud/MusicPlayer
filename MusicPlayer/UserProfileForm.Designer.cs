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
            pictureBox1 = new PictureBox();
            changePhotoLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(24, 234);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(117, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Your Name: ";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(38, 38, 38);
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Segoe UI", 13.2000008F);
            nameTextBox.ForeColor = Color.White;
            nameTextBox.Location = new Point(150, 228);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(180, 30);
            nameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(38, 38, 38);
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Segoe UI", 13.2000008F);
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Location = new Point(97, 271);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(180, 30);
            emailTextBox.TabIndex = 3;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 277);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 2;
            label1.Text = "Email: ";
            // 
            // genderTextBox
            // 
            genderTextBox.BackColor = Color.FromArgb(38, 38, 38);
            genderTextBox.BorderStyle = BorderStyle.None;
            genderTextBox.Font = new Font("Segoe UI", 13.2000008F);
            genderTextBox.ForeColor = Color.White;
            genderTextBox.Location = new Point(110, 353);
            genderTextBox.Name = "genderTextBox";
            genderTextBox.Size = new Size(180, 30);
            genderTextBox.TabIndex = 7;
            genderTextBox.TextChanged += genderTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 359);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 6;
            label2.Text = "Gender:";
            // 
            // birthdateTextBox
            // 
            birthdateTextBox.BackColor = Color.FromArgb(38, 38, 38);
            birthdateTextBox.BorderStyle = BorderStyle.None;
            birthdateTextBox.Font = new Font("Segoe UI", 13.2000008F);
            birthdateTextBox.ForeColor = Color.White;
            birthdateTextBox.Location = new Point(158, 310);
            birthdateTextBox.Name = "birthdateTextBox";
            birthdateTextBox.Size = new Size(180, 30);
            birthdateTextBox.TabIndex = 5;
            birthdateTextBox.TextChanged += birthdateTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 316);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth:";
            // 
            // signOutButton
            // 
            signOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            signOutButton.BackColor = Color.FromArgb(255, 40, 16);
            signOutButton.Cursor = Cursors.Hand;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(131, 467);
            signOutButton.Margin = new Padding(0);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(105, 45);
            signOutButton.TabIndex = 9;
            signOutButton.Text = "Sign out";
            signOutButton.TextAlign = ContentAlignment.MiddleLeft;
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += homeFormSelectBtn_Click;
            // 
            // editLinkLabel
            // 
            editLinkLabel.AutoSize = true;
            editLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editLinkLabel.LinkColor = Color.FromArgb(255, 23, 0);
            editLinkLabel.Location = new Point(52, 431);
            editLinkLabel.Name = "editLinkLabel";
            editLinkLabel.Size = new Size(98, 25);
            editLinkLabel.TabIndex = 10;
            editLinkLabel.TabStop = true;
            editLinkLabel.Text = "Edit profile";
            // 
            // changePasswordLinkLabel
            // 
            changePasswordLinkLabel.AutoSize = true;
            changePasswordLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changePasswordLinkLabel.LinkColor = Color.FromArgb(255, 23, 0);
            changePasswordLinkLabel.Location = new Point(156, 431);
            changePasswordLinkLabel.Name = "changePasswordLinkLabel";
            changePasswordLinkLabel.Size = new Size(154, 25);
            changePasswordLinkLabel.TabIndex = 11;
            changePasswordLinkLabel.TabStop = true;
            changePasswordLinkLabel.Text = "Change password";
            changePasswordLinkLabel.LinkClicked += changePasswordLinkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // changePhotoLinkLabel
            // 
            changePhotoLinkLabel.AutoSize = true;
            changePhotoLinkLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            changePhotoLinkLabel.LinkColor = Color.FromArgb(255, 23, 0);
            changePhotoLinkLabel.Location = new Point(79, 177);
            changePhotoLinkLabel.Name = "changePhotoLinkLabel";
            changePhotoLinkLabel.Size = new Size(186, 25);
            changePhotoLinkLabel.TabIndex = 13;
            changePhotoLinkLabel.TabStop = true;
            changePhotoLinkLabel.Text = "Change/upload photo";
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(364, 581);
            Controls.Add(changePhotoLinkLabel);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private LinkLabel changePhotoLinkLabel;
    }
}