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

namespace Hakaton
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Main_Form : Form
    {
        private readonly CheckUser _user;

        DataBase database = new DataBase();

        int selectedRow;

        public Main_Form(CheckUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void isAdmin()
        {
            управлениеToolStripMenuItem.Enabled = _user.IsAdmin;
            new_btn.Enabled = _user.IsAdmin;
            button1.Enabled = _user.IsAdmin;
            change_btn.Enabled = _user.IsAdmin;
            save_btn.Enabled = _user.IsAdmin;

        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("building_name", "Название здания");
            dataGridView1.Columns.Add("addres", "Адрес");
            dataGridView1.Columns.Add("year_of_construction", "Год постройки");
            dataGridView1.Columns.Add("condition", "Состояние");
            dataGridView1.Columns.Add("number_of_floors", "Количество этажей");
            dataGridView1.Columns.Add("number_of_kv", "Количество квартир");
            dataGridView1.Columns.Add("general_building_material", "Основной материал");
            dataGridView1.Columns.Add("cadastral_number", "Кадастровый номер");
            dataGridView1.Columns.Add("area", "Площадь");
            dataGridView1.Columns.Add("count_of_persons", "Количество жильцов");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetInt32(5), record.GetInt32(6), record.GetString(7), record.GetString(8), record.GetDecimal(9), record.GetInt32(10), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from buildings";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

            database.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            tlsUserStatus.Text = $"{_user.Login}: {_user.Status}";
            isAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_building_name.Text = row.Cells[1].Value.ToString();
                textBox_addres.Text = row.Cells[2].Value.ToString();
                textBox_year_of_construction.Text = row.Cells[3].Value.ToString();
                textBox_condition.Text = row.Cells[4].Value.ToString();
                textBox_number_of_floors.Text = row.Cells[5].Value.ToString();
                textBox_number_of_kv.Text = row.Cells[6].Value.ToString();
                textBox_general_building_material.Text = row.Cells[7].Value.ToString();
                textBox_cadastral_number.Text = row.Cells[8].Value.ToString();
                textBox_area.Text = row.Cells[9].Value.ToString();
                textBox_count_of_persons.Text = row.Cells[10].Value.ToString();
            }
        }

        private void ref_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            add_form frm_add = new add_form();
            frm_add.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from buildings where concat (id, building_name, addres, year_of_construction, condition, number_of_floors, number_of_kv, general_building_material, cadastral_number, area, count_of_persons) like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
        }


        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Updates()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[11].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var building_name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var addres = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var year_of_construction = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var condition = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var number_of_floors = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var number_of_kv = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var general_building_material = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var cadastral_number = dataGridView1.Rows[index].Cells[8].Value.ToString();
                    var area = dataGridView1.Rows[index].Cells[9].Value.ToString();
                    var count_of_persons = dataGridView1.Rows[index].Cells[10].Value.ToString();

                    var changeQuery = $"UPDATE buildings SET building_name = '{building_name}', addres = '{addres}', year_of_construction = '{year_of_construction}', condition = '{condition}', number_of_floors = '{number_of_floors}', number_of_kv = '{number_of_kv}', general_building_material = '{general_building_material}', cadastral_number = '{cadastral_number}', area = '{area}', count_of_persons = '{count_of_persons}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from buildings where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var building_name = textBox_building_name.Text;
            var addres = textBox_addres.Text;
            int year_of_construction;
            var condition = textBox_condition.Text;
            int number_of_floors;
            int number_of_kv;
            var general_building_material = textBox_general_building_material.Text;
            var cadastral_number = textBox_cadastral_number.Text;
            var area = textBox_area.Text;
            int count_of_persons;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_year_of_construction.Text, out year_of_construction) &&
                int.TryParse(textBox_number_of_floors.Text, out number_of_floors) &&
                int.TryParse(textBox_number_of_kv.Text, out number_of_kv) &&
                int.TryParse(textBox_count_of_persons.Text, out count_of_persons))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, building_name, addres, year_of_construction, condition, number_of_floors, number_of_kv, general_building_material, cadastral_number, area, count_of_persons);
                    dataGridView1.Rows[selectedRowIndex].Cells[11].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Должен быть числовой формат");
                }

            }
        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            Updates();
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_panel frm_adm = new admin_panel();
            frm_adm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
