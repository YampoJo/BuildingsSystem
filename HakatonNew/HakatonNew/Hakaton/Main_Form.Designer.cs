namespace Hakaton
{
    partial class Main_Form
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
            dataGridView1 = new DataGridView();
            textBox_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_building_name = new TextBox();
            label3 = new Label();
            textBox_addres = new TextBox();
            label4 = new Label();
            textBox_year_of_construction = new TextBox();
            label5 = new Label();
            textBox_condition = new TextBox();
            label6 = new Label();
            textBox_number_of_floors = new TextBox();
            label7 = new Label();
            textBox_number_of_kv = new TextBox();
            label8 = new Label();
            textBox_general_building_material = new TextBox();
            label9 = new Label();
            textBox_cadastral_number = new TextBox();
            label10 = new Label();
            textBox_area = new TextBox();
            label11 = new Label();
            textBox_count_of_persons = new TextBox();
            ref_btn = new Button();
            new_btn = new Button();
            textBox_search = new TextBox();
            button1 = new Button();
            save_btn = new Button();
            change_btn = new Button();
            menuStrip1 = new MenuStrip();
            управлениеToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tlsUserStatus = new ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1168, 239);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(151, 364);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(200, 23);
            textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 364);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 393);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Название здания";
            // 
            // textBox_building_name
            // 
            textBox_building_name.Location = new Point(151, 393);
            textBox_building_name.Name = "textBox_building_name";
            textBox_building_name.Size = new Size(200, 23);
            textBox_building_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 422);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Адрес";
            // 
            // textBox_addres
            // 
            textBox_addres.Location = new Point(151, 422);
            textBox_addres.Name = "textBox_addres";
            textBox_addres.Size = new Size(200, 23);
            textBox_addres.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 452);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "Год постройки";
            // 
            // textBox_year_of_construction
            // 
            textBox_year_of_construction.Location = new Point(151, 451);
            textBox_year_of_construction.Name = "textBox_year_of_construction";
            textBox_year_of_construction.Size = new Size(200, 23);
            textBox_year_of_construction.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 481);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 10;
            label5.Text = "Состояние";
            // 
            // textBox_condition
            // 
            textBox_condition.Location = new Point(151, 480);
            textBox_condition.Name = "textBox_condition";
            textBox_condition.Size = new Size(200, 23);
            textBox_condition.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 510);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 12;
            label6.Text = "Количество этажей";
            label6.Click += label6_Click;
            // 
            // textBox_number_of_floors
            // 
            textBox_number_of_floors.Location = new Point(151, 509);
            textBox_number_of_floors.Name = "textBox_number_of_floors";
            textBox_number_of_floors.Size = new Size(200, 23);
            textBox_number_of_floors.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 539);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 14;
            label7.Text = "Количество квартир";
            // 
            // textBox_number_of_kv
            // 
            textBox_number_of_kv.Location = new Point(151, 538);
            textBox_number_of_kv.Name = "textBox_number_of_kv";
            textBox_number_of_kv.Size = new Size(200, 23);
            textBox_number_of_kv.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 568);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 16;
            label8.Text = "Основной материал";
            // 
            // textBox_general_building_material
            // 
            textBox_general_building_material.Location = new Point(151, 567);
            textBox_general_building_material.Name = "textBox_general_building_material";
            textBox_general_building_material.Size = new Size(200, 23);
            textBox_general_building_material.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 597);
            label9.Name = "label9";
            label9.Size = new Size(118, 15);
            label9.TabIndex = 18;
            label9.Text = "Кадастровый номер";
            // 
            // textBox_cadastral_number
            // 
            textBox_cadastral_number.Location = new Point(151, 596);
            textBox_cadastral_number.Name = "textBox_cadastral_number";
            textBox_cadastral_number.Size = new Size(200, 23);
            textBox_cadastral_number.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 626);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 20;
            label10.Text = "Площадь";
            // 
            // textBox_area
            // 
            textBox_area.Location = new Point(151, 625);
            textBox_area.Name = "textBox_area";
            textBox_area.Size = new Size(200, 23);
            textBox_area.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 655);
            label11.Name = "label11";
            label11.Size = new Size(122, 15);
            label11.TabIndex = 22;
            label11.Text = "Количество жителей";
            // 
            // textBox_count_of_persons
            // 
            textBox_count_of_persons.Location = new Point(151, 654);
            textBox_count_of_persons.Name = "textBox_count_of_persons";
            textBox_count_of_persons.Size = new Size(200, 23);
            textBox_count_of_persons.TabIndex = 21;
            // 
            // ref_btn
            // 
            ref_btn.Location = new Point(813, 452);
            ref_btn.Name = "ref_btn";
            ref_btn.Size = new Size(144, 94);
            ref_btn.TabIndex = 23;
            ref_btn.Text = "Обновить";
            ref_btn.UseVisualStyleBackColor = true;
            ref_btn.Click += ref_btn_Click;
            // 
            // new_btn
            // 
            new_btn.Location = new Point(378, 367);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(125, 224);
            new_btn.TabIndex = 24;
            new_btn.Text = "Новая запись";
            new_btn.UseVisualStyleBackColor = true;
            new_btn.Click += new_btn_Click;
            // 
            // textBox_search
            // 
            textBox_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_search.Location = new Point(12, 311);
            textBox_search.Multiline = true;
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(1132, 33);
            textBox_search.TabIndex = 25;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(640, 367);
            button1.Name = "button1";
            button1.Size = new Size(125, 224);
            button1.TabIndex = 26;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(378, 599);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(387, 78);
            save_btn.TabIndex = 27;
            save_btn.Text = "Сохранить";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // change_btn
            // 
            change_btn.Location = new Point(509, 367);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(125, 224);
            change_btn.TabIndex = 28;
            change_btn.Text = "Редактировать";
            change_btn.UseVisualStyleBackColor = true;
            change_btn.Click += change_btn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { управлениеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1192, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // управлениеToolStripMenuItem
            // 
            управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            управлениеToolStripMenuItem.Size = new Size(85, 20);
            управлениеToolStripMenuItem.Text = "Управление";
            управлениеToolStripMenuItem.Click += управлениеToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tlsUserStatus });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1192, 25);
            toolStrip1.TabIndex = 30;
            toolStrip1.Text = "toolStrip1";
            // 
            // tlsUserStatus
            // 
            tlsUserStatus.Name = "tlsUserStatus";
            tlsUserStatus.ReadOnly = true;
            tlsUserStatus.Size = new Size(100, 25);
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 687);
            Controls.Add(toolStrip1);
            Controls.Add(change_btn);
            Controls.Add(save_btn);
            Controls.Add(button1);
            Controls.Add(textBox_search);
            Controls.Add(new_btn);
            Controls.Add(ref_btn);
            Controls.Add(label11);
            Controls.Add(textBox_count_of_persons);
            Controls.Add(label10);
            Controls.Add(textBox_area);
            Controls.Add(label9);
            Controls.Add(textBox_cadastral_number);
            Controls.Add(label8);
            Controls.Add(textBox_general_building_material);
            Controls.Add(label7);
            Controls.Add(textBox_number_of_kv);
            Controls.Add(label6);
            Controls.Add(textBox_number_of_floors);
            Controls.Add(label5);
            Controls.Add(textBox_condition);
            Controls.Add(label4);
            Controls.Add(textBox_year_of_construction);
            Controls.Add(label3);
            Controls.Add(textBox_addres);
            Controls.Add(label2);
            Controls.Add(textBox_building_name);
            Controls.Add(label1);
            Controls.Add(textBox_id);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Main_Form";
            Text = "Main_Form";
            Load += Main_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox_id;
        private Label label1;
        private Label label2;
        private TextBox textBox_building_name;
        private Label label3;
        private TextBox textBox_addres;
        private Label label4;
        private TextBox textBox_year_of_construction;
        private Label label5;
        private TextBox textBox_condition;
        private Label label6;
        private TextBox textBox_number_of_floors;
        private Label label7;
        private TextBox textBox_number_of_kv;
        private Label label8;
        private TextBox textBox_general_building_material;
        private Label label9;
        private TextBox textBox_cadastral_number;
        private Label label10;
        private TextBox textBox_area;
        private Label label11;
        private TextBox textBox_count_of_persons;
        private Button ref_btn;
        private Button new_btn;
        private TextBox textBox_search;
        private Button button1;
        private Button save_btn;
        private Button change_btn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem управлениеToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripTextBox tlsUserStatus;
    }
}