namespace MusicPlayer
{
    partial class ResetPasswordForm
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
            emailLabel = new Label();
            sendOtpButton = new Button();
            cancelButton = new Button();
            resetpassLabel = new Label();
            emailTextBox = new TextBox();
            verifyLabel = new Label();
            verifyTextBox = new TextBox();
            verifyButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 213);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 37);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(24, 89);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(119, 20);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Enter you email: ";
            // 
            // sendOtpButton
            // 
            sendOtpButton.Location = new Point(99, 166);
            sendOtpButton.Name = "sendOtpButton";
            sendOtpButton.Size = new Size(94, 29);
            sendOtpButton.TabIndex = 2;
            sendOtpButton.Text = "send OTP";
            sendOtpButton.UseVisualStyleBackColor = true;
            sendOtpButton.Click += sendOtpButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(199, 166);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // resetpassLabel
            // 
            resetpassLabel.AutoSize = true;
            resetpassLabel.Font = new Font("Sitka Banner Semibold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetpassLabel.Location = new Point(12, 9);
            resetpassLabel.Name = "resetpassLabel";
            resetpassLabel.Size = new Size(157, 33);
            resetpassLabel.TabIndex = 4;
            resetpassLabel.Text = "Reset password";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(149, 89);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(189, 27);
            emailTextBox.TabIndex = 5;
            // 
            // verifyLabel
            // 
            verifyLabel.AutoSize = true;
            verifyLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verifyLabel.Location = new Point(58, 88);
            verifyLabel.Name = "verifyLabel";
            verifyLabel.Size = new Size(70, 25);
            verifyLabel.TabIndex = 6;
            verifyLabel.Text = "Verify:  ";
            verifyLabel.Visible = false;
            // 
            // verifyTextBox
            // 
            verifyTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verifyTextBox.Location = new Point(134, 85);
            verifyTextBox.Name = "verifyTextBox";
            verifyTextBox.Size = new Size(119, 31);
            verifyTextBox.TabIndex = 7;
            verifyTextBox.Visible = false;
            // 
            // verifyButton
            // 
            verifyButton.Location = new Point(84, 166);
            verifyButton.Name = "verifyButton";
            verifyButton.Size = new Size(76, 29);
            verifyButton.TabIndex = 8;
            verifyButton.Text = "verify";
            verifyButton.UseVisualStyleBackColor = true;
            verifyButton.Visible = false;
            verifyButton.Click += verifyButton_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 250);
            Controls.Add(verifyButton);
            Controls.Add(verifyTextBox);
            Controls.Add(verifyLabel);
            Controls.Add(emailTextBox);
            Controls.Add(resetpassLabel);
            Controls.Add(cancelButton);
            Controls.Add(sendOtpButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(emailLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label emailLabel;
        private Button sendOtpButton;
        private Button cancelButton;
        private Label resetpassLabel;
        private TextBox emailTextBox;
        private Label verifyLabel;
        private TextBox verifyTextBox;
        private Button verifyButton;
    }
}