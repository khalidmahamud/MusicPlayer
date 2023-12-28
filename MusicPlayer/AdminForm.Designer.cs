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
            loginButton = new Button();
            exitButton = new Button();
            dashboardButton = new Button();
            removeUser = new Button();
            viewUserButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            userInfoDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userInfoDataGridView).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(loginButton);
            splitContainer1.Panel1.Controls.Add(exitButton);
            splitContainer1.Panel1.Controls.Add(dashboardButton);
            splitContainer1.Panel1.Controls.Add(removeUser);
            splitContainer1.Panel1.Controls.Add(viewUserButton);
            splitContainer1.Size = new Size(1370, 743);
            splitContainer1.SplitterDistance = 257;
            splitContainer1.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(25, 28, 36);
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Segoe UI", 13.8F);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(0, 371);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(254, 68);
            loginButton.TabIndex = 7;
            loginButton.Text = "go to login page";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Maroon;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Segoe UI", 13.8F);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(0, 663);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(254, 68);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(25, 28, 36);
            dashboardButton.Cursor = Cursors.Hand;
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
            removeUser.Cursor = Cursors.Hand;
            removeUser.Font = new Font("Segoe UI", 13.8F);
            removeUser.ForeColor = Color.White;
            removeUser.Location = new Point(0, 297);
            removeUser.Name = "removeUser";
            removeUser.Size = new Size(254, 68);
            removeUser.TabIndex = 3;
            removeUser.Text = "  remove user";
            removeUser.UseVisualStyleBackColor = false;
            removeUser.Click += removeUser_Click;
            // 
            // viewUserButton
            // 
            viewUserButton.BackColor = Color.FromArgb(25, 28, 36);
            viewUserButton.Cursor = Cursors.Hand;
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
            ClientSize = new Size(800, 450);
            Controls.Add(userInfoDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button removeUser;
        private Button dashboardButton;
        private Button exitButton;
        private Button loginButton;
    }
}