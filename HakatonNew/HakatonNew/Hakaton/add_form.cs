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
    public partial class add_form : Form
    {

        DataBase database = new DataBase();

        public add_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var building_name = textBox_building_name2.Text;
            var addres = textBox_addres2.Text;
            int year_of_construction;
            var condition = textBox_condition2.Text;
            int number_of_floors;
            int number_of_kv;
            var general_building_material = textBox_general_building_material2.Text;
            var cadastral_number = textBox_cadastral_number2.Text;
            var area = textBox_area2.Text;
            int count_of_persons;

            if (int.TryParse(textBox_year_of_construction2.Text, out year_of_construction) &&
                int.TryParse(textBox_number_of_floors2.Text, out number_of_floors) &&
                int.TryParse(textBox_number_of_kv2.Text, out number_of_kv) &&
                int.TryParse(textBox_count_of_persons2.Text, out count_of_persons))
            {
                var addQuery = $"insert into buildings(building_name, addres, year_of_construction, condition, number_of_floors, number_of_kv, general_building_material, cadastral_number, area, count_of_persons) VALUES('{building_name}', '{addres}', '{year_of_construction}', '{condition}', '{number_of_floors}', '{number_of_kv}', '{general_building_material}', '{cadastral_number}', {area}, '{count_of_persons}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Успешная запись", "Удачно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не корректная запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();

        }
    }
}
