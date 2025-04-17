using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class List_Form : Form
    {
        private DataBase db = new DataBase();
        public List_Form()
        {
            InitializeComponent();
            LoadData();
        }

        private void Back_button_List_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm MainForm = new mainForm();
            MainForm.Show();
        }



        private void LoadData()
        {
            try
            {
                db.openConnection(); // Пытаемся открыть соединение
                string query = "SELECT * FROM products"; 
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Данные не найдены.");
                    dataGridView1.DataSource = null; // очищаем грид, если данные отсутствуют
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection(); // Закрываем соединение в любом случае
            }
        }

       
        public Boolean Search()
        {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM products WHERE  name = @name ", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = text_boxsearch.Text;


                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.openConnection();  // соединение сбазой
                if (table.Rows.Count > 0)
                {
                    
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = table;


                return true;
                }
                else
                {
                    MessageBox.Show("Такой модели нет в наличие ");
                    return false;
                }

            
        }

        private void button1_search_Click(object sender, EventArgs e)
        {
            if (Search())
            {
                return;
            }
        }
    }
}
