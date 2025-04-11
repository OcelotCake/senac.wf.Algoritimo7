namespace WF.login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            Access = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 567);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(255, 197);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Access
            // 
            Access.BackColor = SystemColors.ControlDark;
            Access.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            Access.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            Access.FlatStyle = FlatStyle.Popup;
            Access.Font = new Font("Segoe UI Variable Text Semibold", 14F, FontStyle.Underline);
            Access.Location = new Point(654, 506);
            Access.Margin = new Padding(9);
            Access.Name = "Access";
            Access.Size = new Size(275, 52);
            Access.TabIndex = 2;
            Access.Text = "Access";
            Access.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(444, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 31);
            textBox1.TabIndex = 6;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(444, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 31);
            textBox2.TabIndex = 7;
            textBox2.Tag = "Login";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(778, 89);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Help Logging in.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.FlatAppearance.MouseDownBackColor = Color.Yellow;
            checkBox1.Location = new Point(357, 523);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(185, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Are you a veteran?";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(357, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 10;
            label1.Text = "USER";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Location = new Point(799, 30);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(98, 25);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "NEW USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(357, 105);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, 294);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 567);
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Access);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Access;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private Label label1;
        private LinkLabel linkLabel2;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
