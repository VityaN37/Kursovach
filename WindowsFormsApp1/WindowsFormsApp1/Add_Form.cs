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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Add_Form : Form
    {
        public Add_Form()
        {
            InitializeComponent(); //метод в C#, который создаёт и инициализирует все элементы управления формы, а также задает их размеры и расположение в окне
        }

        private void Back_button_Click(object sender, EventArgs e) //закрывает эту форму открывает другую
        {
            this.Hide();
            Add_Delete_Form add_delete_form = new Add_Delete_Form();
            add_delete_form.Show();
        }

       

        private void Add_button2_Click(object sender, EventArgs e)// добавление данных в базу при нажатие
        {
            if (id_seller_textBox4.Text == "") // проверка на введённые данные 
            {
                MessageBox.Show("Введите ID продавца");
                return;
            }

            if (Type_comboBox1.Text == "")
            {
                MessageBox.Show("Введите тип");
                return;
            } 

            if (id_textBox2.Text == "")
            {
                MessageBox.Show("Введите id устройства ");
                return;
            }

            if (name_textBox3.Text == "")
            {
                MessageBox.Show("Введите модель");
                return;
            }

            

            if (price_textBox4.Text == "")
            {
                MessageBox.Show("Введите цену");
                return;
            }

            if (checkid_seller())//проверка id продавца на существование
            {
                return;
            }

            if (checkid())//проверка id
            {
                return;
            }
            

            DataBase db = new DataBase(); //подключение к класссу содинения с базой
            MySqlCommand command = new MySqlCommand(" INSERT INTO `products` (id ,name ,type ,price) VALUES (@id ,@nm ,@tp ,@prc)", db.getConnection());//команда из mysql , соединение с базой

            
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id_textBox2.Text;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name_textBox3.Text;
            command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = Type_comboBox1.Text;//значения которые будут отправлены в базу данных
            command.Parameters.Add("@prc", MySqlDbType.VarChar).Value = price_textBox4.Text;
            
            db.openConnection();  // соединение сбазой

            if (command.ExecuteNonQuery() == 1)// проверяем выполнение команды
            {
                MessageBox.Show("Товар добавлен");
            }
            else
            {
                MessageBox.Show("Товар не добавлен");
            }


            
            db.closeConnection();//закрываем соединение
        }

        public Boolean checkid() //проверка id на существование
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM products WHERE  id = @id ", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id_textBox2.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Уже существующий id");
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean checkid_seller() //проверка id на существование
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE  id = @id ", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id_seller_textBox4.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                
                return false;
            }
            else
            {
                MessageBox.Show("Доступ запрещён");
                return true;
            }

        }
    }
}
