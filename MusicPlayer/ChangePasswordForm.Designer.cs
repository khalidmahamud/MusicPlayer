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
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(178, 27, 11);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.ForeColor = Color.PowderBlue;
            flowLayoutPanel1.Location = new Point(0, 188);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 62);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.Location = new Point(109, 143);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(110, 40);
            confirmButton.TabIndex = 5;
            confirmButton.Text = "confirm";
            confirmButton.TextAlign = ContentAlignment.TopCenter;
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += saveButton_Click;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordLabel.ForeColor = Color.White;
            newPasswordLabel.Location = new Point(65, 45);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(147, 28);
            newPasswordLabel.TabIndex = 6;
            newPasswordLabel.Text = "new password:";
            newPasswordLabel.Click += newPasswordLabel_Click;
            // 
            // retypePasswordLabel
            // 
            retypePasswordLabel.AutoSize = true;
            retypePasswordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retypePasswordLabel.ForeColor = Color.White;
            retypePasswordLabel.Location = new Point(0, 81);
            retypePasswordLabel.Name = "retypePasswordLabel";
            retypePasswordLabel.Size = new Size(223, 28);
            retypePasswordLabel.TabIndex = 8;
            retypePasswordLabel.Text = "retype new password:  ";
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(225, 143);
            backButton.Name = "backButton";
            backButton.Size = new Size(73, 40);
            backButton.TabIndex = 9;
            backButton.Text = "Back";
            backButton.TextAlign = ContentAlignment.TopCenter;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(234, 49);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(154, 27);
            newPasswordTextBox.TabIndex = 10;
            // 
            // retypeNewPasswordBox
            // 
            retypeNewPasswordBox.Location = new Point(234, 82);
            retypeNewPasswordBox.Name = "retypeNewPasswordBox";
            retypeNewPasswordBox.Size = new Size(154, 27);
            retypeNewPasswordBox.TabIndex = 11;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(178, 27, 11);
            ClientSize = new Size(400, 250);
            Controls.Add(retypeNewPasswordBox);
            Controls.Add(newPasswordTextBox);
            Controls.Add(confirmButton);
            Controls.Add(backButton);
            Controls.Add(retypePasswordLabel);
            Controls.Add(newPasswordLabel);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.Red;
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
    }
}