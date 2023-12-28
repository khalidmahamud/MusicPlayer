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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            customPanel1 = new CustomComponents.CustomPanel();
            userNameTextBox = new TextBox();
            userSelectBtn = new Button();
            greetingLabel = new Label();
            customPanel2 = new CustomComponents.CustomPanel();
            popularNowBox4 = new PictureBox();
            popularNowBox3 = new PictureBox();
            popularNowBox2 = new PictureBox();
            popularNowBox1 = new PictureBox();
            recommendedBox4 = new PictureBox();
            recommendedBox3 = new PictureBox();
            recommendedBox2 = new PictureBox();
            recommendedBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)popularNowBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popularNowBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popularNowBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popularNowBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recommendedBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recommendedBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recommendedBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recommendedBox1).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(userNameTextBox);
            customPanel1.Controls.Add(userSelectBtn);
            customPanel1.Controls.Add(greetingLabel);
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
            userNameTextBox.Location = new Point(368, 28);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(253, 31);
            userNameTextBox.TabIndex = 5;
            userNameTextBox.Text = "user";
            userNameTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // userSelectBtn
            // 
            userSelectBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            userSelectBtn.BackColor = SystemColors.ActiveCaptionText;
            userSelectBtn.Cursor = Cursors.Hand;
            userSelectBtn.FlatAppearance.BorderSize = 0;
            userSelectBtn.FlatStyle = FlatStyle.Flat;
            userSelectBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userSelectBtn.ForeColor = Color.Transparent;
            userSelectBtn.Image = (Image)resources.GetObject("userSelectBtn.Image");
            userSelectBtn.Location = new Point(624, 20);
            userSelectBtn.Margin = new Padding(0);
            userSelectBtn.Name = "userSelectBtn";
            userSelectBtn.Size = new Size(52, 49);
            userSelectBtn.TabIndex = 4;
            userSelectBtn.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(userSelectBtn, "View profile");
            userSelectBtn.UseVisualStyleBackColor = false;
            userSelectBtn.Click += UserSelectBtn_Click;
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.BackColor = Color.Transparent;
            greetingLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greetingLabel.ForeColor = Color.Transparent;
            greetingLabel.Location = new Point(12, 20);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(214, 38);
            greetingLabel.TabIndex = 1;
            greetingLabel.Text = "Good Morning!";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = SystemColors.ActiveCaptionText;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(popularNowBox4);
            customPanel2.Controls.Add(popularNowBox3);
            customPanel2.Controls.Add(popularNowBox2);
            customPanel2.Controls.Add(popularNowBox1);
            customPanel2.Controls.Add(recommendedBox4);
            customPanel2.Controls.Add(recommendedBox3);
            customPanel2.Controls.Add(recommendedBox2);
            customPanel2.Controls.Add(recommendedBox1);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(label3);
            customPanel2.Cursor = Cursors.Hand;
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
            // popularNowBox4
            // 
            popularNowBox4.Image = (Image)resources.GetObject("popularNowBox4.Image");
            popularNowBox4.Location = new Point(548, 316);
            popularNowBox4.Name = "popularNowBox4";
            popularNowBox4.Size = new Size(128, 125);
            popularNowBox4.SizeMode = PictureBoxSizeMode.Zoom;
            popularNowBox4.TabIndex = 13;
            popularNowBox4.TabStop = false;
            // 
            // popularNowBox3
            // 
            popularNowBox3.Image = (Image)resources.GetObject("popularNowBox3.Image");
            popularNowBox3.Location = new Point(376, 316);
            popularNowBox3.Name = "popularNowBox3";
            popularNowBox3.Size = new Size(128, 125);
            popularNowBox3.SizeMode = PictureBoxSizeMode.Zoom;
            popularNowBox3.TabIndex = 12;
            popularNowBox3.TabStop = false;
            // 
            // popularNowBox2
            // 
            popularNowBox2.Image = (Image)resources.GetObject("popularNowBox2.Image");
            popularNowBox2.Location = new Point(203, 316);
            popularNowBox2.Name = "popularNowBox2";
            popularNowBox2.Size = new Size(128, 125);
            popularNowBox2.SizeMode = PictureBoxSizeMode.Zoom;
            popularNowBox2.TabIndex = 11;
            popularNowBox2.TabStop = false;
            // 
            // popularNowBox1
            // 
            popularNowBox1.Image = (Image)resources.GetObject("popularNowBox1.Image");
            popularNowBox1.Location = new Point(25, 316);
            popularNowBox1.Name = "popularNowBox1";
            popularNowBox1.Size = new Size(128, 125);
            popularNowBox1.SizeMode = PictureBoxSizeMode.Zoom;
            popularNowBox1.TabIndex = 10;
            popularNowBox1.TabStop = false;
            // 
            // recommendedBox4
            // 
            recommendedBox4.Image = (Image)resources.GetObject("recommendedBox4.Image");
            recommendedBox4.Location = new Point(548, 65);
            recommendedBox4.Name = "recommendedBox4";
            recommendedBox4.Size = new Size(128, 122);
            recommendedBox4.SizeMode = PictureBoxSizeMode.Zoom;
            recommendedBox4.TabIndex = 9;
            recommendedBox4.TabStop = false;
            // 
            // recommendedBox3
            // 
            recommendedBox3.Image = (Image)resources.GetObject("recommendedBox3.Image");
            recommendedBox3.Location = new Point(376, 65);
            recommendedBox3.Name = "recommendedBox3";
            recommendedBox3.Size = new Size(128, 125);
            recommendedBox3.SizeMode = PictureBoxSizeMode.Zoom;
            recommendedBox3.TabIndex = 8;
            recommendedBox3.TabStop = false;
            // 
            // recommendedBox2
            // 
            recommendedBox2.Image = (Image)resources.GetObject("recommendedBox2.Image");
            recommendedBox2.Location = new Point(203, 59);
            recommendedBox2.Name = "recommendedBox2";
            recommendedBox2.Size = new Size(128, 128);
            recommendedBox2.SizeMode = PictureBoxSizeMode.Zoom;
            recommendedBox2.TabIndex = 7;
            recommendedBox2.TabStop = false;
            // 
            // recommendedBox1
            // 
            recommendedBox1.Image = (Image)resources.GetObject("recommendedBox1.Image");
            recommendedBox1.Location = new Point(25, 62);
            recommendedBox1.Name = "recommendedBox1";
            recommendedBox1.Size = new Size(128, 125);
            recommendedBox1.SizeMode = PictureBoxSizeMode.Zoom;
            recommendedBox1.TabIndex = 6;
            recommendedBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 250);
            label2.Name = "label2";
            label2.Size = new Size(167, 35);
            label2.TabIndex = 4;
            label2.Text = "Popular Now";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(190, 35);
            label3.TabIndex = 0;
            label3.Text = "Recommended";
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
            ((System.ComponentModel.ISupportInitialize)popularNowBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)popularNowBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)popularNowBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)popularNowBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)recommendedBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)recommendedBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)recommendedBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)recommendedBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private Label greetingLabel;
        private CustomComponents.CustomPanel customPanel2;
        private Button userSelectBtn;
        private Label label3;
        private TextBox userNameTextBox;
        private ToolTip toolTip1;
        private Label label2;
        private PictureBox popularNowBox4;
        private PictureBox popularNowBox3;
        private PictureBox popularNowBox2;
        private PictureBox popularNowBox1;
        private PictureBox recommendedBox4;
        private PictureBox recommendedBox3;
        private PictureBox recommendedBox2;
        private PictureBox recommendedBox1;
    }
}