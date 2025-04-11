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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Access = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            linkLabel4 = new LinkLabel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            Access.Location = new Point(655, 515);
            Access.Margin = new Padding(9);
            Access.Name = "Access";
            Access.Size = new Size(275, 52);
            Access.TabIndex = 3;
            Access.Text = "Access";
            Access.UseVisualStyleBackColor = false;
            Access.Click += Access_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(444, 96);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Password";
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(245, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(444, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 31);
            textBox2.TabIndex = 1;
            textBox2.Tag = "Login";
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Leave += textBox2_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(787, 61);
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
            checkBox1.Location = new Point(357, 538);
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
            linkLabel2.Location = new Point(832, 37);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(98, 25);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "NEW USER";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
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
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.Transparent;
            linkLabel4.Location = new Point(832, 86);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(95, 25);
            linkLabel4.TabIndex = 15;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "More Info.";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            linkLabel4.DoubleClick += linkLabel4_DoubleClick;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(902, 0);
            button1.Name = "button1";
            button1.Size = new Size(28, 34);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 567);
            Controls.Add(button1);
            Controls.Add(linkLabel4);
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
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private LinkLabel linkLabel4;
        private Button button1;
    }
}
