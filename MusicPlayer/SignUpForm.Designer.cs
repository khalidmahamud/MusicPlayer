namespace MusicPlayer
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            customPanel1 = new CustomComponents.CustomPanel();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            clearButton = new Button();
            gmailLabel = new Label();
            signUpButton = new Button();
            genderComboBox = new ComboBox();
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
            alreadyLabel = new Label();
            customPanel2 = new CustomComponents.CustomPanel();
            vibeMusicLabel = new Label();
            exploreMusicLabel = new Label();
            signinButton = new Button();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(dateTimePicker1);
            customPanel1.Controls.Add(clearButton);
            customPanel1.Controls.Add(gmailLabel);
            customPanel1.Controls.Add(signUpButton);
            customPanel1.Controls.Add(genderComboBox);
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
            customPanel1.Dock = DockStyle.Right;
            customPanel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customPanel1.ForeColor = Color.FromArgb(164, 165, 169);
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.White;
            customPanel1.GradientTopColor = Color.White;
            customPanel1.Location = new Point(310, 0);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(330, 500);
            customPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(178, 193);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 53;
            label2.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(230, 231, 233);
            dateTimePicker1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(175, 220);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 30);
            dateTimePicker1.TabIndex = 50;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.ForeColor = Color.FromArgb(247, 40, 57);
            clearButton.Location = new Point(42, 410);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(114, 40);
            clearButton.TabIndex = 63;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click_1;
            // 
            // gmailLabel
            // 
            gmailLabel.AutoSize = true;
            gmailLabel.BackColor = Color.White;
            gmailLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            gmailLabel.ForeColor = Color.Black;
            gmailLabel.Location = new Point(42, 132);
            gmailLabel.Name = "gmailLabel";
            gmailLabel.Size = new Size(54, 23);
            gmailLabel.TabIndex = 49;
            gmailLabel.Text = "Email";
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(247, 40, 57);
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.FlatAppearance.BorderSize = 0;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.ForeColor = Color.FromArgb(230, 231, 233);
            signUpButton.Location = new Point(179, 410);
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(114, 40);
            signUpButton.TabIndex = 62;
            signUpButton.Text = "SIGN UP";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click_1;
            // 
            // genderComboBox
            // 
            genderComboBox.BackColor = Color.White;
            genderComboBox.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female", "Others" });
            genderComboBox.Location = new Point(42, 219);
            genderComboBox.Margin = new Padding(3, 4, 3, 4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(114, 31);
            genderComboBox.TabIndex = 48;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.BackColor = Color.White;
            confirmPasswordLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            confirmPasswordLabel.ForeColor = Color.Black;
            confirmPasswordLabel.Location = new Point(42, 316);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(155, 23);
            confirmPasswordLabel.TabIndex = 59;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // gmailTextBox
            // 
            gmailTextBox.BackColor = Color.White;
            gmailTextBox.Font = new Font("Nirmala UI", 10.2F);
            gmailTextBox.Location = new Point(42, 159);
            gmailTextBox.Margin = new Padding(3, 4, 3, 4);
            gmailTextBox.Multiline = true;
            gmailTextBox.Name = "gmailTextBox";
            gmailTextBox.Size = new Size(247, 30);
            gmailTextBox.TabIndex = 47;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Font = new Font("Nirmala UI", 10.2F);
            passwordTextBox.Location = new Point(42, 282);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(247, 30);
            passwordTextBox.TabIndex = 58;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.White;
            genderLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            genderLabel.ForeColor = Color.Black;
            genderLabel.Location = new Point(42, 193);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(68, 23);
            genderLabel.TabIndex = 46;
            genderLabel.Text = "Gender";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = Color.White;
            confirmPasswordTextBox.Font = new Font("Nirmala UI", 10.2F);
            confirmPasswordTextBox.Location = new Point(42, 343);
            confirmPasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            confirmPasswordTextBox.Multiline = true;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(247, 30);
            confirmPasswordTextBox.TabIndex = 60;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = Color.White;
            userNameTextBox.Font = new Font("Nirmala UI", 10.2F);
            userNameTextBox.Location = new Point(42, 98);
            userNameTextBox.Margin = new Padding(3, 4, 3, 4);
            userNameTextBox.Multiline = true;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(247, 30);
            userNameTextBox.TabIndex = 45;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.BackColor = Color.White;
            showPasswordCheckBox.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPasswordCheckBox.Location = new Point(164, 381);
            showPasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(125, 21);
            showPasswordCheckBox.TabIndex = 61;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = false;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged_1;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.White;
            userNameLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            userNameLabel.ForeColor = Color.Black;
            userNameLabel.Location = new Point(42, 71);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(57, 23);
            userNameLabel.TabIndex = 44;
            userNameLabel.Text = "Name";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.White;
            passwordLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(42, 255);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(84, 23);
            passwordLabel.TabIndex = 57;
            passwordLabel.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 40, 57);
            label1.Location = new Point(42, 20);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 34;
            label1.Text = "SIGNUP FORM";
            label1.Click += label1_Click;
            // 
            // alreadyLabel
            // 
            alreadyLabel.AutoSize = true;
            alreadyLabel.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alreadyLabel.ForeColor = Color.White;
            alreadyLabel.Location = new Point(70, 337);
            alreadyLabel.Name = "alreadyLabel";
            alreadyLabel.Size = new Size(165, 17);
            alreadyLabel.TabIndex = 64;
            alreadyLabel.Text = "Already have an account?";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(247, 40, 57);
            customPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(vibeMusicLabel);
            customPanel2.Controls.Add(exploreMusicLabel);
            customPanel2.Controls.Add(signinButton);
            customPanel2.Controls.Add(customPanel1);
            customPanel2.Controls.Add(alreadyLabel);
            customPanel2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customPanel2.ForeColor = Color.FromArgb(164, 165, 169);
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(247, 40, 57);
            customPanel2.GradientTopColor = Color.FromArgb(247, 40, 57);
            customPanel2.Location = new Point(211, 70);
            customPanel2.Margin = new Padding(3, 4, 3, 4);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(640, 500);
            customPanel2.TabIndex = 66;
            // 
            // vibeMusicLabel
            // 
            vibeMusicLabel.AutoSize = true;
            vibeMusicLabel.BackColor = Color.FromArgb(247, 40, 57);
            vibeMusicLabel.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vibeMusicLabel.ForeColor = Color.WhiteSmoke;
            vibeMusicLabel.Location = new Point(70, 152);
            vibeMusicLabel.Name = "vibeMusicLabel";
            vibeMusicLabel.Size = new Size(175, 38);
            vibeMusicLabel.TabIndex = 66;
            vibeMusicLabel.Text = "VIBE MUSIC";
            // 
            // exploreMusicLabel
            // 
            exploreMusicLabel.AutoSize = true;
            exploreMusicLabel.BackColor = Color.FromArgb(247, 40, 57);
            exploreMusicLabel.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            exploreMusicLabel.ForeColor = Color.WhiteSmoke;
            exploreMusicLabel.Location = new Point(35, 239);
            exploreMusicLabel.Name = "exploreMusicLabel";
            exploreMusicLabel.Size = new Size(249, 27);
            exploreMusicLabel.TabIndex = 65;
            exploreMusicLabel.Text = "Explore Music And More!";
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.White;
            signinButton.Cursor = Cursors.Hand;
            signinButton.FlatAppearance.BorderSize = 0;
            signinButton.ForeColor = Color.FromArgb(247, 40, 57);
            signinButton.Location = new Point(100, 362);
            signinButton.Margin = new Padding(3, 4, 3, 4);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(114, 40);
            signinButton.TabIndex = 64;
            signinButton.Text = "SIGN IN";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += button1_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1101, 674);
            Controls.Add(customPanel2);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private Label label1;
        private TextBox gmailTextBox;
        private Label genderLabel;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Label gmailLabel;
        private ComboBox genderComboBox;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label alreadyLabel;
        private Button clearButton;
        private Button signUpButton;
        private Label confirmPasswordLabel;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTextBox;
        private CheckBox showPasswordCheckBox;
        private Label passwordLabel;
        private CustomComponents.CustomPanel customPanel2;
        private Button signinButton;
        private Label exploreMusicLabel;
        private Label vibeMusicLabel;
    }
}