namespace Hakaton
{
    partial class sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            clr_btn = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox_password2 = new TextBox();
            textBox_login2 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            clr_btn.Location = new Point(154, 148);
            clr_btn.Name = "clr_btn";
            clr_btn.Size = new Size(108, 32);
            clr_btn.TabIndex = 24;
            clr_btn.Text = "Очистить";
            clr_btn.UseVisualStyleBackColor = false;
            clr_btn.Click += clr_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(242, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(242, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 53);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 20;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 17);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 19;
            label1.Text = "Логин";
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
            button1.Location = new Point(4, 148);
            button1.Name = "button1";
            button1.Size = new Size(144, 32);
            button1.TabIndex = 18;
            button1.Text = "Создать аккаунт";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox_password2
            // 
            textBox_password2.Location = new Point(77, 54);
            textBox_password2.Name = "textBox_password2";
            textBox_password2.Size = new Size(159, 23);
            textBox_password2.TabIndex = 17;
            // 
            // textBox_login2
            // 
            textBox_login2.Location = new Point(74, 61);
            textBox_login2.Name = "textBox_login2";
            textBox_login2.Size = new Size(159, 23);
            textBox_login2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 6);
            label3.Name = "label3";
            label3.Size = new Size(179, 32);
            label3.TabIndex = 25;
            label3.Text = "Регистрация";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_password2);
            panel1.Location = new Point(-3, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 98);
            panel1.TabIndex = 26;
            // 
            // sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(272, 187);
            Controls.Add(label3);
            Controls.Add(clr_btn);
            Controls.Add(button1);
            Controls.Add(textBox_login2);
            Controls.Add(panel1);
            MinimizeBox = false;
            Name = "sign_up";
            Text = "sign_up";
            Load += sign_up_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clr_btn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox_password2;
        private TextBox textBox_login2;
        private Label label3;
        private Panel panel1;
    }
}