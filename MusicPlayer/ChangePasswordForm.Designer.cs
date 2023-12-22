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
            currentPasswordLabel = new Label();
            currentPasswordTextBox = new TextBox();
            newPasswordTexBox = new TextBox();
            confirmButton = new Button();
            newPasswordLabel = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(178, 27, 11);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.ForeColor = Color.PowderBlue;
            flowLayoutPanel1.Location = new Point(0, 258);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(431, 62);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // currentPasswordLabel
            // 
            currentPasswordLabel.AutoSize = true;
            currentPasswordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentPasswordLabel.ForeColor = Color.White;
            currentPasswordLabel.Location = new Point(31, 72);
            currentPasswordLabel.Name = "currentPasswordLabel";
            currentPasswordLabel.Size = new Size(180, 28);
            currentPasswordLabel.TabIndex = 1;
            currentPasswordLabel.Text = "current password: ";
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.BackColor = Color.FromArgb(178, 27, 11);
            currentPasswordTextBox.BorderStyle = BorderStyle.None;
            currentPasswordTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentPasswordTextBox.ForeColor = Color.White;
            currentPasswordTextBox.Location = new Point(217, 69);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.Size = new Size(150, 27);
            currentPasswordTextBox.TabIndex = 2;
            // 
            // newPasswordTexBox
            // 
            newPasswordTexBox.BackColor = Color.FromArgb(178, 27, 11);
            newPasswordTexBox.BorderStyle = BorderStyle.None;
            newPasswordTexBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordTexBox.ForeColor = Color.White;
            newPasswordTexBox.Location = new Point(185, 104);
            newPasswordTexBox.Name = "newPasswordTexBox";
            newPasswordTexBox.Size = new Size(150, 27);
            newPasswordTexBox.TabIndex = 4;
            newPasswordTexBox.TextChanged += textBox2_TextChanged;
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.Location = new Point(161, 223);
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
            newPasswordLabel.Location = new Point(31, 104);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(153, 28);
            newPasswordLabel.TabIndex = 6;
            newPasswordLabel.Text = "new password: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 159);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 8;
            label1.Text = "retype new password: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(178, 27, 11);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(248, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 7;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(178, 27, 11);
            ClientSize = new Size(431, 320);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(newPasswordLabel);
            Controls.Add(confirmButton);
            Controls.Add(newPasswordTexBox);
            Controls.Add(currentPasswordTextBox);
            Controls.Add(currentPasswordLabel);
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
        private Label currentPasswordLabel;
        private TextBox currentPasswordTextBox;
        private TextBox newPasswordTexBox;
        private Button saveButton;
        private Label newPasswordLabel;
        private Button confirmButton;
        private Label label1;
        private TextBox textBox1;
    }
}