namespace MusicPlayer
{
    partial class SignUp
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
            customPanel1 = new CustomPanel.CustomPanel();
            createLabel = new Label();
            label2 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            clearButton = new Button();
            gmailLabel = new Label();
            signUpButton = new Button();
            comboBox1 = new ComboBox();
            confirmPasswordLabel = new Label();
            gmailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            genderLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            showPasswordCheckBox = new CheckBox();
            userNameLabel = new Label();
            passwordLabel = new Label();
            label1 = new Label();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(createLabel);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(label7);
            customPanel1.Controls.Add(dateTimePicker1);
            customPanel1.Controls.Add(clearButton);
            customPanel1.Controls.Add(gmailLabel);
            customPanel1.Controls.Add(signUpButton);
            customPanel1.Controls.Add(comboBox1);
            customPanel1.Controls.Add(confirmPasswordLabel);
            customPanel1.Controls.Add(gmailTextBox);
            customPanel1.Controls.Add(passwordTextBox);
            customPanel1.Controls.Add(genderLabel);
            customPanel1.Controls.Add(confirmPasswordTextBox);
            customPanel1.Controls.Add(userNameTextBox);
            customPanel1.Controls.Add(showPasswordCheckBox);
            customPanel1.Controls.Add(userNameLabel);
            customPanel1.Controls.Add(passwordLabel);
            customPanel1.Controls.Add(label1);
            customPanel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customPanel1.ForeColor = Color.FromArgb(164, 165, 169);
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.Black;
            customPanel1.GradientTopColor = Color.Black;
            customPanel1.Location = new Point(333, 12);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(358, 487);
            customPanel1.TabIndex = 1;
            // 
            // createLabel
            // 
            createLabel.AutoSize = true;
            createLabel.ForeColor = Color.FromArgb(247, 40, 57);
            createLabel.Location = new Point(134, 423);
            createLabel.Name = "createLabel";
            createLabel.Size = new Size(89, 17);
            createLabel.TabIndex = 65;
            createLabel.Text = "Back to login";
            createLabel.Click += createLabel_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 160);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 53;
            label2.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 394);
            label7.Name = "label7";
            label7.Size = new Size(165, 17);
            label7.TabIndex = 64;
            label7.Text = "Already have an account?";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(186, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 25);
            dateTimePicker1.TabIndex = 50;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(230, 231, 233);
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.FromArgb(247, 40, 57);
            clearButton.Location = new Point(70, 350);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 30);
            clearButton.TabIndex = 63;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click_1;
            // 
            // gmailLabel
            // 
            gmailLabel.AutoSize = true;
            gmailLabel.Location = new Point(67, 101);
            gmailLabel.Name = "gmailLabel";
            gmailLabel.Size = new Size(44, 17);
            gmailLabel.TabIndex = 49;
            gmailLabel.Text = "Gmail";
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(247, 40, 57);
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.FlatAppearance.BorderSize = 0;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.ForeColor = Color.FromArgb(230, 231, 233);
            signUpButton.Location = new Point(186, 350);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(100, 30);
            signUpButton.TabIndex = 62;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Others" });
            comboBox1.Location = new Point(70, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 25);
            comboBox1.TabIndex = 48;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(70, 269);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(120, 17);
            confirmPasswordLabel.TabIndex = 59;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // gmailTextBox
            // 
            gmailTextBox.BackColor = Color.FromArgb(230, 231, 233);
            gmailTextBox.BorderStyle = BorderStyle.None;
            gmailTextBox.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gmailTextBox.Location = new Point(70, 121);
            gmailTextBox.Multiline = true;
            gmailTextBox.Name = "gmailTextBox";
            gmailTextBox.Size = new Size(216, 25);
            gmailTextBox.TabIndex = 47;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(230, 231, 233);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(70, 238);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(216, 28);
            passwordTextBox.TabIndex = 58;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(70, 160);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(52, 17);
            genderLabel.TabIndex = 46;
            genderLabel.Text = "Gender";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = Color.FromArgb(230, 231, 233);
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.Location = new Point(70, 289);
            confirmPasswordTextBox.Multiline = true;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(216, 28);
            confirmPasswordTextBox.TabIndex = 60;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = Color.FromArgb(230, 231, 233);
            userNameTextBox.BorderStyle = BorderStyle.None;
            userNameTextBox.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.Location = new Point(70, 76);
            userNameTextBox.Multiline = true;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(216, 22);
            userNameTextBox.TabIndex = 45;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(164, 323);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(122, 21);
            showPasswordCheckBox.TabIndex = 61;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged_1;
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
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(70, 218);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(66, 17);
            passwordLabel.TabIndex = 57;
            passwordLabel.Text = "Password";
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
            label1.Click += label1_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 551);
            Controls.Add(customPanel1);
            Name = "SignUp";
            Text = "SignUp";
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel.CustomPanel customPanel1;
        private Label label1;
        private TextBox gmailTextBox;
        private Label genderLabel;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Label gmailLabel;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label createLabel;
        private Label label7;
        private Button clearButton;
        private Button signUpButton;
        private Label confirmPasswordLabel;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTextBox;
        private CheckBox showPasswordCheckBox;
        private Label passwordLabel;
    }
}