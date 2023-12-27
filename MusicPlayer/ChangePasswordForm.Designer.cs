namespace MusicPlayer
{
    partial class ChangePasswordForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            confirmButton = new Button();
            newPasswordLabel = new Label();
            retypePasswordLabel = new Label();
            backButton = new Button();
            newPasswordTextBox = new TextBox();
            retypeNewPasswordBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(247, 40, 57);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.ForeColor = Color.PowderBlue;
            flowLayoutPanel1.Location = new Point(0, 356);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(320, 62);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(247, 40, 57);
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(173, 272);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(110, 40);
            confirmButton.TabIndex = 5;
            confirmButton.Text = "CONFIRM";
            confirmButton.TextAlign = ContentAlignment.TopCenter;
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += saveButton_Click;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            newPasswordLabel.ForeColor = Color.Black;
            newPasswordLabel.Location = new Point(29, 101);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(139, 25);
            newPasswordLabel.TabIndex = 6;
            newPasswordLabel.Text = "New Password:";
            newPasswordLabel.Click += newPasswordLabel_Click;
            // 
            // retypePasswordLabel
            // 
            retypePasswordLabel.AutoSize = true;
            retypePasswordLabel.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            retypePasswordLabel.ForeColor = Color.Black;
            retypePasswordLabel.Location = new Point(29, 166);
            retypePasswordLabel.Name = "retypePasswordLabel";
            retypePasswordLabel.Size = new Size(212, 25);
            retypePasswordLabel.TabIndex = 8;
            retypePasswordLabel.Text = "Confirm New Password:";
            // 
            // backButton
            // 
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(29, 272);
            backButton.Name = "backButton";
            backButton.Size = new Size(110, 40);
            backButton.TabIndex = 9;
            backButton.Text = "CANCEL";
            backButton.TextAlign = ContentAlignment.TopCenter;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Font = new Font("Nirmala UI", 12F);
            newPasswordTextBox.Location = new Point(29, 129);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(254, 34);
            newPasswordTextBox.TabIndex = 10;
            // 
            // retypeNewPasswordBox
            // 
            retypeNewPasswordBox.Font = new Font("Nirmala UI", 12F);
            retypeNewPasswordBox.Location = new Point(29, 194);
            retypeNewPasswordBox.Name = "retypeNewPasswordBox";
            retypeNewPasswordBox.Size = new Size(254, 34);
            retypeNewPasswordBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 40, 57);
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(240, 31);
            label1.TabIndex = 12;
            label1.Text = "CHANGE PASSWORD";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(320, 418);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(confirmButton);
            Controls.Add(retypeNewPasswordBox);
            Controls.Add(newPasswordTextBox);
            Controls.Add(retypePasswordLabel);
            Controls.Add(newPasswordLabel);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.FromArgb(247, 40, 57);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button saveButton;
        private Button confirmButton;
        private Label newPasswordLabel;
        private Label retypePasswordLabel;
        private Button backButton;
        private TextBox newPasswordTextBox;
        private TextBox retypeNewPasswordBox;
        private Label label1;
    }
}