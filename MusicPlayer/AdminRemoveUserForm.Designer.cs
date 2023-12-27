namespace MusicPlayer
{
    partial class AdminRemoveUserForm
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
            userListBox = new ListBox();
            label1 = new Label();
            removeButton = new Button();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // userListBox
            // 
            userListBox.BackColor = SystemColors.ScrollBar;
            userListBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userListBox.FormattingEnabled = true;
            userListBox.ItemHeight = 25;
            userListBox.Location = new Point(133, 118);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(328, 279);
            userListBox.TabIndex = 30;
            userListBox.SelectedIndexChanged += userListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 40);
            label1.Name = "label1";
            label1.Size = new Size(592, 31);
            label1.TabIndex = 31;
            label1.Text = "Please select the user email from the list box to remove ";
            // 
            // removeButton
            // 
            removeButton.Location = new Point(243, 414);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(118, 42);
            removeButton.TabIndex = 32;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-69, 438);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 33;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(133, 146, 189);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.DarkSlateGray;
            richTextBox1.Location = new Point(517, 233);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(490, 120);
            richTextBox1.TabIndex = 34;
            richTextBox1.Text = "Note: [The user will be removed from the database but the informations of the user will move to an archived database]";
            // 
            // AdminRemoveUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(133, 146, 189);
            ClientSize = new Size(1116, 743);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(removeButton);
            Controls.Add(label1);
            Controls.Add(userListBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminRemoveUserForm";
            Text = "AdminRemoveUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox userListBox;
        private Label label1;
        private Button removeButton;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}