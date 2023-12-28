namespace MusicPlayer
{
    partial class UpdateUserInfoForm
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
            backButton = new Button();
            saveButton = new Button();
            dobLabel = new Label();
            dobDateTimePicker = new DateTimePicker();
            emailLabel = new Label();
            genderComboBox = new ComboBox();
            emailTextBox = new TextBox();
            genderLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.FromArgb(247, 40, 57);
            backButton.Location = new Point(47, 317);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(114, 40);
            backButton.TabIndex = 63;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(247, 40, 57);
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(180, 317);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(114, 40);
            saveButton.TabIndex = 62;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.BackColor = Color.White;
            dobLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            dobLabel.ForeColor = Color.Black;
            dobLabel.Location = new Point(179, 215);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(115, 23);
            dobLabel.TabIndex = 71;
            dobLabel.Text = "Date of Birth";
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.CalendarMonthBackground = Color.FromArgb(230, 231, 233);
            dobDateTimePicker.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobDateTimePicker.Format = DateTimePickerFormat.Short;
            dobDateTimePicker.Location = new Point(180, 242);
            dobDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(114, 30);
            dobDateTimePicker.TabIndex = 70;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.White;
            emailLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            emailLabel.ForeColor = Color.Black;
            emailLabel.Location = new Point(47, 154);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 23);
            emailLabel.TabIndex = 69;
            emailLabel.Text = "Email";
            // 
            // genderComboBox
            // 
            genderComboBox.BackColor = Color.White;
            genderComboBox.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female", "Others" });
            genderComboBox.Location = new Point(47, 241);
            genderComboBox.Margin = new Padding(3, 4, 3, 4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(114, 31);
            genderComboBox.TabIndex = 68;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.White;
            emailTextBox.Font = new Font("Nirmala UI", 10.2F);
            emailTextBox.Location = new Point(47, 181);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(247, 30);
            emailTextBox.TabIndex = 67;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.White;
            genderLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            genderLabel.ForeColor = Color.Black;
            genderLabel.Location = new Point(47, 215);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(68, 23);
            genderLabel.TabIndex = 66;
            genderLabel.Text = "Gender";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.White;
            nameTextBox.Font = new Font("Nirmala UI", 10.2F);
            nameTextBox.Location = new Point(47, 120);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(247, 30);
            nameTextBox.TabIndex = 65;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.White;
            nameLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(47, 93);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 23);
            nameLabel.TabIndex = 64;
            nameLabel.Text = "Name";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(247, 40, 57);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 385);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(356, 72);
            flowLayoutPanel1.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 40, 57);
            label1.Location = new Point(94, 28);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 73;
            label1.Text = "UPDATE INFO";
            // 
            // UpdateUserInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(356, 457);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dobLabel);
            Controls.Add(backButton);
            Controls.Add(saveButton);
            Controls.Add(dobDateTimePicker);
            Controls.Add(nameTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(genderComboBox);
            Controls.Add(genderLabel);
            Controls.Add(emailTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateUserInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateUserInfoForm";
            Load += UpdateUserInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveButton;
        private Label dobLabel;
        private DateTimePicker dobDateTimePicker;
        private Label emailLabel;
        private ComboBox genderComboBox;
        private TextBox emailTextBox;
        private Label genderLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button backButton;
        private Label label1;
    }
}