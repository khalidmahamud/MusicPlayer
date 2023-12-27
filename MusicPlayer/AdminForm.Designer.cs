namespace MusicPlayer
{
    partial class AdminForm
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
            splitContainer1 = new SplitContainer();
            exitButton = new Button();
            updateUserButton = new Button();
            dashboardButton = new Button();
            removeUser = new Button();
            addUserButton = new Button();
            viewUserButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(exitButton);
            splitContainer1.Panel1.Controls.Add(updateUserButton);
            splitContainer1.Panel1.Controls.Add(dashboardButton);
            splitContainer1.Panel1.Controls.Add(removeUser);
            splitContainer1.Panel1.Controls.Add(addUserButton);
            splitContainer1.Panel1.Controls.Add(viewUserButton);
            splitContainer1.Size = new Size(1370, 743);
            splitContainer1.SplitterDistance = 257;
            splitContainer1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Maroon;
            exitButton.Font = new Font("Segoe UI", 13.8F);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(0, 663);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(254, 68);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // updateUserButton
            // 
            updateUserButton.BackColor = Color.FromArgb(25, 28, 36);
            updateUserButton.Font = new Font("Segoe UI", 13.8F);
            updateUserButton.ForeColor = Color.White;
            updateUserButton.Location = new Point(0, 445);
            updateUserButton.Name = "updateUserButton";
            updateUserButton.Size = new Size(254, 68);
            updateUserButton.TabIndex = 5;
            updateUserButton.Text = "update user";
            updateUserButton.UseVisualStyleBackColor = false;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(25, 28, 36);
            dashboardButton.Font = new Font("Segoe UI", 13.8F);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Location = new Point(0, 149);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(254, 68);
            dashboardButton.TabIndex = 4;
            dashboardButton.Text = "dashboard";
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // removeUser
            // 
            removeUser.BackColor = Color.Maroon;
            removeUser.Font = new Font("Segoe UI", 13.8F);
            removeUser.ForeColor = Color.White;
            removeUser.Location = new Point(0, 371);
            removeUser.Name = "removeUser";
            removeUser.Size = new Size(254, 68);
            removeUser.TabIndex = 3;
            removeUser.Text = "  remove user";
            removeUser.UseVisualStyleBackColor = false;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.FromArgb(25, 28, 36);
            addUserButton.Font = new Font("Segoe UI", 13.8F);
            addUserButton.ForeColor = Color.White;
            addUserButton.Location = new Point(0, 297);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(254, 68);
            addUserButton.TabIndex = 2;
            addUserButton.Text = "add user";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // viewUserButton
            // 
            viewUserButton.BackColor = Color.FromArgb(25, 28, 36);
            viewUserButton.Font = new Font("Segoe UI", 13.8F);
            viewUserButton.ForeColor = Color.White;
            viewUserButton.Location = new Point(0, 223);
            viewUserButton.Name = "viewUserButton";
            viewUserButton.Size = new Size(254, 68);
            viewUserButton.TabIndex = 1;
            viewUserButton.Text = "view users";
            viewUserButton.UseVisualStyleBackColor = false;
            viewUserButton.Click += viewUserButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 36);
            ClientSize = new Size(1370, 743);
            Controls.Add(splitContainer1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private Button viewUserButton;
        private Button addUserButton;
        private Button removeUser;
        private Button dashboardButton;
        private Button updateUserButton;
        private Button exitButton;
    }
}