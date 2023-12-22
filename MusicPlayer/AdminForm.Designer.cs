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
            userInfoDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userInfoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userInfoDataGridView
            // 
            userInfoDataGridView.BackgroundColor = Color.FromArgb(255, 23, 0);
            userInfoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userInfoDataGridView.Location = new Point(114, 153);
            userInfoDataGridView.Name = "userInfoDataGridView";
            userInfoDataGridView.RowHeadersWidth = 51;
            userInfoDataGridView.Size = new Size(517, 285);
            userInfoDataGridView.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 36);
            ClientSize = new Size(800, 450);
            Controls.Add(userInfoDataGridView);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)userInfoDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView userInfoDataGridView;
    }
}