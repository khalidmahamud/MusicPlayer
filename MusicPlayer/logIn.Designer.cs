namespace MusicPlayer
{
    partial class logIn
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
            customPanel1 = new CustomComponents.CustomPanel();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            createAccountLabel = new Label();
            label1 = new Label();
            label7 = new Label();
            clearButton = new Button();
            passwordTextBox = new TextBox();
            logInButton = new Button();
            showPasswordCheckBox = new CheckBox();
            passwordLabel = new Label();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(userNameTextBox);
            customPanel1.Controls.Add(userNameLabel);
            customPanel1.Controls.Add(createAccountLabel);
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(label7);
            customPanel1.Controls.Add(clearButton);
            customPanel1.Controls.Add(passwordTextBox);
            customPanel1.Controls.Add(logInButton);
            customPanel1.Controls.Add(showPasswordCheckBox);
            customPanel1.Controls.Add(passwordLabel);
            customPanel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customPanel1.ForeColor = Color.FromArgb(164, 165, 169);
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.Black;
            customPanel1.GradientTopColor = Color.Black;
            customPanel1.Location = new Point(239, 43);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(332, 374);
            customPanel1.TabIndex = 2;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = Color.FromArgb(230, 231, 233);
            userNameTextBox.BorderStyle = BorderStyle.None;
            userNameTextBox.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.Location = new Point(70, 76);
            userNameTextBox.Multiline = true;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(216, 30);
            userNameTextBox.TabIndex = 45;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(67, 56);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(69, 17);
            userNameLabel.TabIndex = 44;
            userNameLabel.Text = "Username";
            // 
            // createAccountLabel
            // 
            createAccountLabel.AutoSize = true;
            createAccountLabel.ForeColor = Color.FromArgb(247, 40, 57);
            createAccountLabel.Location = new Point(129, 290);
            createAccountLabel.Name = "createAccountLabel";
            createAccountLabel.Size = new Size(101, 17);
            createAccountLabel.TabIndex = 43;
            createAccountLabel.Text = "Create Account";
            createAccountLabel.Click += createAccountLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 40, 57);
            label1.Location = new Point(36, 14);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 34;
            label1.Text = "Get Started";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 261);
            label7.Name = "label7";
            label7.Size = new Size(152, 17);
            label7.TabIndex = 42;
            label7.Text = "Don't have an account?";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(230, 231, 233);
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.FromArgb(247, 40, 57);
            clearButton.Location = new Point(65, 217);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 30);
            clearButton.TabIndex = 41;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(230, 231, 233);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(67, 144);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(216, 28);
            passwordTextBox.TabIndex = 36;
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.FromArgb(247, 40, 57);
            logInButton.Cursor = Cursors.Hand;
            logInButton.FlatAppearance.BorderSize = 0;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.ForeColor = Color.FromArgb(230, 231, 233);
            logInButton.Location = new Point(181, 217);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(100, 30);
            logInButton.TabIndex = 40;
            logInButton.Text = "Log in";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(161, 190);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(122, 21);
            showPasswordCheckBox.TabIndex = 39;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(67, 124);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(66, 17);
            passwordLabel.TabIndex = 35;
            passwordLabel.Text = "Password";
            // 
            // logIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 513);
            Controls.Add(customPanel1);
            Name = "logIn";
            Text = "logIn";
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Label createAccountLabel;
        private Label label1;
        private Label label7;
        private Button clearButton;
        private TextBox passwordTextBox;
        private Button logInButton;
        private CheckBox showPasswordCheckBox;
        private Label passwordLabel;
    }
}