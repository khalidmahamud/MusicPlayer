namespace MusicPlayer
{
    partial class logInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInForm));
            customPanel1 = new CustomComponents.CustomPanel();
            resetPasswordLabel = new Label();
            label2 = new Label();
            emailTextBox = new TextBox();
            userNameLabel = new Label();
            label1 = new Label();
            clearButton = new Button();
            passwordTextBox = new TextBox();
            logInButton = new Button();
            showPasswordCheckBox = new CheckBox();
            passwordLabel = new Label();
            label7 = new Label();
            customPanel2 = new CustomComponents.CustomPanel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(resetPasswordLabel);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(emailTextBox);
            customPanel1.Controls.Add(userNameLabel);
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(clearButton);
            customPanel1.Controls.Add(passwordTextBox);
            customPanel1.Controls.Add(logInButton);
            customPanel1.Controls.Add(showPasswordCheckBox);
            customPanel1.Controls.Add(passwordLabel);
            customPanel1.Dock = DockStyle.Left;
            customPanel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customPanel1.ForeColor = Color.FromArgb(164, 165, 169);
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.White;
            customPanel1.GradientTopColor = Color.White;
            customPanel1.Location = new Point(0, 0);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(330, 500);
            customPanel1.TabIndex = 2;
            // 
            // resetPasswordLabel
            // 
            resetPasswordLabel.AutoSize = true;
            resetPasswordLabel.BackColor = Color.White;
            resetPasswordLabel.Cursor = Cursors.Hand;
            resetPasswordLabel.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetPasswordLabel.ForeColor = Color.FromArgb(247, 40, 57);
            resetPasswordLabel.Location = new Point(113, 405);
            resetPasswordLabel.Name = "resetPasswordLabel";
            resetPasswordLabel.Size = new Size(103, 17);
            resetPasswordLabel.TabIndex = 44;
            resetPasswordLabel.Text = "Reset Password";
            resetPasswordLabel.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 388);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 44;
            label2.Text = "Forgot your password?";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.White;
            emailTextBox.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = SystemColors.ActiveCaptionText;
            emailTextBox.Location = new Point(41, 152);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(247, 30);
            emailTextBox.TabIndex = 45;
            emailTextBox.Text = "exf";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.White;
            userNameLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            userNameLabel.ForeColor = Color.FromArgb(0, 0, 64);
            userNameLabel.Location = new Point(41, 125);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(54, 23);
            userNameLabel.TabIndex = 44;
            userNameLabel.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 40, 57);
            label1.Location = new Point(41, 57);
            label1.Name = "label1";
            label1.Size = new Size(220, 38);
            label1.TabIndex = 34;
            label1.Text = "Getting Started";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            clearButton.ForeColor = Color.FromArgb(247, 40, 57);
            clearButton.Location = new Point(41, 303);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(114, 40);
            clearButton.TabIndex = 41;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(41, 223);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(247, 30);
            passwordTextBox.TabIndex = 45;
            passwordTextBox.Text = "er5";
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.FromArgb(247, 40, 57);
            logInButton.Cursor = Cursors.Hand;
            logInButton.FlatAppearance.BorderSize = 0;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            logInButton.ForeColor = Color.FromArgb(230, 231, 233);
            logInButton.Location = new Point(174, 303);
            logInButton.Margin = new Padding(3, 4, 3, 4);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(114, 40);
            logInButton.TabIndex = 40;
            logInButton.Text = "SIGN IN";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.BackColor = Color.White;
            showPasswordCheckBox.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPasswordCheckBox.Location = new Point(163, 265);
            showPasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(125, 21);
            showPasswordCheckBox.TabIndex = 39;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = false;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.White;
            passwordLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(0, 0, 64);
            passwordLabel.Location = new Point(41, 196);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(84, 23);
            passwordLabel.TabIndex = 35;
            passwordLabel.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(247, 40, 57);
            label7.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(407, 345);
            label7.Name = "label7";
            label7.Size = new Size(152, 17);
            label7.TabIndex = 42;
            label7.Text = "Don't have an account?";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.Transparent;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(pictureBox1);
            customPanel2.Controls.Add(label5);
            customPanel2.Controls.Add(label4);
            customPanel2.Controls.Add(button1);
            customPanel2.Controls.Add(customPanel1);
            customPanel2.Controls.Add(label7);
            customPanel2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customPanel2.ForeColor = Color.FromArgb(164, 165, 169);
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(247, 40, 57);
            customPanel2.GradientTopColor = Color.FromArgb(247, 40, 57);
            customPanel2.Location = new Point(211, 86);
            customPanel2.Margin = new Padding(3, 4, 3, 4);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(640, 500);
            customPanel2.TabIndex = 46;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(407, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 71);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(247, 40, 57);
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(393, 152);
            label5.Name = "label5";
            label5.Size = new Size(175, 38);
            label5.TabIndex = 48;
            label5.Text = "VIBE MUSIC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(247, 40, 57);
            label4.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(355, 226);
            label4.Name = "label4";
            label4.Size = new Size(249, 27);
            label4.TabIndex = 47;
            label4.Text = "Explore Music And More!";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.FromArgb(247, 40, 57);
            button1.Location = new Point(427, 375);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 46;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // logInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1080, 684);
            Controls.Add(customPanel2);
            DoubleBuffered = true;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "logInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "logIn";
            Load += logInForm_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private TextBox emailTextBox;
        private Label userNameLabel;
        private Label label1;
        private Label label7;
        private Button clearButton;
        private TextBox passwordTextBox;
        private Button logInButton;
        private CheckBox showPasswordCheckBox;
        private Label passwordLabel;
        private CustomComponents.CustomPanel customPanel2;
        private Label label2;
        private Label resetPasswordLabel;
        private Button button1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}