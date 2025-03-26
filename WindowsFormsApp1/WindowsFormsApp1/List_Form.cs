using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
   
    public partial class List_Form : Form
    {
        DataBase db = new DataBase();

        int selectedRow;
        public List_Form()
        {
            InitializeComponent();
        }

        private void CreateColumns()//создаём колонки-таблицу
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Модель");
            dataGridView1.Columns.Add("type", "Тип товара");
            dataGridView1.Columns.Add("price", "Цена");
            //dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRows(DataGridView dgw,IDataRecord record ) //чтение таблицы
        { 
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3));//, RowState.ModifiredNew

        }

        private void RefreshDataGrid(DataGridView dgw)//Вывод данных в таблицу
        {
            DataBase db = new DataBase();

            dgw.Rows.Clear();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `products`", db.getConnection());

            db.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MySqlDataReader reader = command.ExecuteReader(); //чтение потока строк

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        

        private void Back_button_List_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm MainForm = new mainForm();
            MainForm.Show();
        }
    }
}
