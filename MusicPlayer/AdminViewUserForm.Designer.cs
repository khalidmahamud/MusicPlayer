namespace MusicPlayer
{
    partial class AdminViewUserForm
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
            userDataGridView = new DataGridView();
            archiveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(2, 107);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(1113, 634);
            userDataGridView.TabIndex = 1;
            // 
            // archiveButton
            // 
            archiveButton.Location = new Point(12, 29);
            archiveButton.Name = "archiveButton";
            archiveButton.Size = new Size(201, 63);
            archiveButton.TabIndex = 2;
            archiveButton.Text = "view archived users";
            archiveButton.UseVisualStyleBackColor = true;
            archiveButton.Click += archiveButton_Click;
            // 
            // AdminViewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 743);
            Controls.Add(archiveButton);
            Controls.Add(userDataGridView);
            Name = "AdminViewUserForm";
            Text = "AdminViewUserForm";
            Load += AdminViewUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataGridView;
        private Button archiveButton;
    }
}