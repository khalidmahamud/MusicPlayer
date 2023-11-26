namespace MusicPlayer
{
    partial class SearchFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFrom));
            panel1 = new Panel();
            searchResultPanel = new FlowLayoutPanel();
            searchBtn = new Button();
            searchBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(searchResultPanel);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(searchBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 439);
            panel1.TabIndex = 0;
            // 
            // searchResultPanel
            // 
            searchResultPanel.BackColor = Color.White;
            searchResultPanel.Location = new Point(0, 48);
            searchResultPanel.Name = "searchResultPanel";
            searchResultPanel.Size = new Size(517, 387);
            searchResultPanel.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.White;
            searchBtn.BackgroundImage = (Image)resources.GetObject("searchBtn.BackgroundImage");
            searchBtn.BackgroundImageLayout = ImageLayout.Center;
            searchBtn.FlatAppearance.BorderColor = Color.White;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            searchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            searchBtn.FlatStyle = FlatStyle.Popup;
            searchBtn.Location = new Point(460, -4);
            searchBtn.Margin = new Padding(0);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(57, 36);
            searchBtn.TabIndex = 6;
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Segoe UI", 13F);
            searchBox.Location = new Point(3, -4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(454, 36);
            searchBox.TabIndex = 5;
            searchBox.KeyDown += SearchBox_KeyDown;
            // 
            // SearchFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 449);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "SearchFrom";
            Padding = new Padding(5);
            ShowInTaskbar = false;
            Text = "Search";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel searchResultPanel;
        private Button searchBtn;
        private TextBox searchBox;
    }
}
