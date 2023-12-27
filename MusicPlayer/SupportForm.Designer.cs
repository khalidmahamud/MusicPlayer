namespace MusicPlayer
{
    partial class SupportForm
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
            queryTextBox = new RichTextBox();
            sendButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 274);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(561, 60);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // queryTextBox
            // 
            queryTextBox.BackColor = Color.Teal;
            queryTextBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            queryTextBox.Location = new Point(65, 46);
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(413, 78);
            queryTextBox.TabIndex = 1;
            queryTextBox.Text = "For any query, contact us by emailing!";
            queryTextBox.TextChanged += richTextBox1_TextChanged;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(159, 178);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(117, 51);
            sendButton.TabIndex = 2;
            sendButton.Text = "send email";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(282, 178);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(117, 51);
            closeButton.TabIndex = 3;
            closeButton.Text = "close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // SupportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 334);
            Controls.Add(closeButton);
            Controls.Add(sendButton);
            Controls.Add(queryTextBox);
            Controls.Add(flowLayoutPanel1);
            Name = "SupportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupportForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private RichTextBox queryTextBox;
        private Button sendButton;
        private Button closeButton;
    }
}