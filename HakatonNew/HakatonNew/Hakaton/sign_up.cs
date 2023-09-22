using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hakaton
{
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            textBox_login2.MaxLength = 50;
            textBox_password2.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkuser())
            {
                return;
            }

            var login = textBox_login2.Text;
            var password = textBox_password2.Text;
            string querystring = $"insert into register(login_user, password_user, is_admin) values('{login}', '{password}', 0)";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();



            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Удачно");
                Form1 frm_log = new Form1();
                this.Hide();
                frm_log.ShowDialog();
            }
            else
                MessageBox.Show("Аккаунт не создан");

            dataBase.closeConnection();

        }

        private bool checkuser()
        {
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;


            if (string.IsNullOrWhiteSpace(textBox_login2.Text) || string.IsNullOrWhiteSpace(textBox_password2.Text))
            {
                MessageBox.Show("Введите данные");
                return true;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            textBox_login2.Text = "";
            textBox_password2.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}
