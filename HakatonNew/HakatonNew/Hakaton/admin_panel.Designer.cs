namespace Hakaton
{
    partial class admin_panel
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            delAdmin_btn = new Button();
            saveAdmin_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(341, 15);
            label1.TabIndex = 0;
            label1.Text = "КОНСОЛЬ ВСЕГО ЗА 500 РУБЛЕЙ НА RUNNY WORLD /CASE!!!";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(417, 246);
            dataGridView1.TabIndex = 1;
            // 
            // delAdmin_btn
            // 
            delAdmin_btn.Location = new Point(459, 68);
            delAdmin_btn.Name = "delAdmin_btn";
            delAdmin_btn.Size = new Size(124, 58);
            delAdmin_btn.TabIndex = 2;
            delAdmin_btn.Text = "Удалить";
            delAdmin_btn.UseVisualStyleBackColor = true;
            delAdmin_btn.Click += delAdmin_btn_Click;
            // 
            // saveAdmin_btn
            // 
            saveAdmin_btn.Location = new Point(459, 132);
            saveAdmin_btn.Name = "saveAdmin_btn";
            saveAdmin_btn.Size = new Size(124, 58);
            saveAdmin_btn.TabIndex = 3;
            saveAdmin_btn.Text = "Сохранить";
            saveAdmin_btn.UseVisualStyleBackColor = true;
            saveAdmin_btn.Click += saveAdmin_btn_Click;
            // 
            // admin_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 350);
            Controls.Add(saveAdmin_btn);
            Controls.Add(delAdmin_btn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "admin_panel";
            Text = "admin_panel";
            Load += admin_panel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button delAdmin_btn;
        private Button saveAdmin_btn;
    }
}