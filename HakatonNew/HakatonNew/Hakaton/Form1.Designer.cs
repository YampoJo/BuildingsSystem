namespace Hakaton
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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox_password = new TextBox();
            textBox_login = new TextBox();
            linkLabel1 = new LinkLabel();
            clr_btn = new Button();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(234, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(234, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 57);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 11;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 10;
            label1.Text = "Логин";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(14, 153);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 9;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(97, 57);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(131, 23);
            textBox_password.TabIndex = 8;
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(97, 22);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(131, 23);
            textBox_login.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Silver;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(74, 192);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 19);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Создать аккаунт";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // clr_btn
            // 
            clr_btn.BackColor = Color.White;
            clr_btn.FlatAppearance.BorderColor = Color.Black;
            clr_btn.FlatAppearance.MouseDownBackColor = Color.Gray;
            clr_btn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            clr_btn.FlatStyle = FlatStyle.Flat;
            clr_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clr_btn.ForeColor = Color.Black;
            clr_btn.Location = new Point(133, 153);
            clr_btn.Name = "clr_btn";
            clr_btn.Size = new Size(107, 31);
            clr_btn.TabIndex = 15;
            clr_btn.Text = "Очистить";
            clr_btn.UseVisualStyleBackColor = false;
            clr_btn.Click += clr_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_login);
            panel1.Location = new Point(-14, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 98);
            panel1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(85, 10);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 28;
            label3.Text = "Войти";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(252, 223);
            Controls.Add(label3);
            Controls.Add(clr_btn);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox_password;
        private TextBox textBox_login;
        private LinkLabel linkLabel1;
        private Button clr_btn;
        private Panel panel1;
        private Label label3;
    }
}