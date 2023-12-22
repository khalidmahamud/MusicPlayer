namespace MusicPlayer
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            customPanel1 = new CustomComponents.CustomPanel();
            userNameTextBox = new TextBox();
            homeFormSelectBtn = new Button();
            label1 = new Label();
            customPanel2 = new CustomComponents.CustomPanel();
            label3 = new Label();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(userNameTextBox);
            customPanel1.Controls.Add(homeFormSelectBtn);
            customPanel1.Controls.Add(label1);
            customPanel1.Dock = DockStyle.Top;
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = SystemColors.ActiveCaptionText;
            customPanel1.GradientTopColor = SystemColors.ActiveCaptionText;
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(705, 106);
            customPanel1.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = SystemColors.ActiveCaptionText;
            userNameTextBox.BorderStyle = BorderStyle.None;
            userNameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.ForeColor = SystemColors.Window;
            userNameTextBox.Location = new Point(507, 28);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(114, 31);
            userNameTextBox.TabIndex = 5;
            userNameTextBox.Text = "user";
            userNameTextBox.TextAlign = HorizontalAlignment.Right;
            userNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // homeFormSelectBtn
            // 
            homeFormSelectBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            homeFormSelectBtn.BackColor = SystemColors.ActiveCaptionText;
            homeFormSelectBtn.Cursor = Cursors.Hand;
            homeFormSelectBtn.FlatAppearance.BorderSize = 0;
            homeFormSelectBtn.FlatStyle = FlatStyle.Flat;
            homeFormSelectBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeFormSelectBtn.ForeColor = Color.Transparent;
            homeFormSelectBtn.Image = (Image)resources.GetObject("homeFormSelectBtn.Image");
            homeFormSelectBtn.Location = new Point(624, 20);
            homeFormSelectBtn.Margin = new Padding(0);
            homeFormSelectBtn.Name = "homeFormSelectBtn";
            homeFormSelectBtn.Size = new Size(52, 49);
            homeFormSelectBtn.TabIndex = 4;
            homeFormSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            homeFormSelectBtn.UseVisualStyleBackColor = false;
            homeFormSelectBtn.Click += homeFormSelectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(214, 38);
            label1.TabIndex = 1;
            label1.Text = "Good Morning!";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = SystemColors.ActiveCaptionText;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(label3);
            customPanel2.Dock = DockStyle.Fill;
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(40, 40, 40);
            customPanel2.GradientTopColor = SystemColors.ActiveCaptionText;
            customPanel2.Location = new Point(0, 106);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(705, 475);
            customPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 0;
            label3.Text = "Popular Now";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(705, 581);
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            Name = "HomeForm";
            Text = "Home";
            Load += HomeForm_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private Label label1;
        private CustomComponents.CustomPanel customPanel2;
        private Button homeFormSelectBtn;
        private Label label3;
        private TextBox userNameTextBox;
    }
}