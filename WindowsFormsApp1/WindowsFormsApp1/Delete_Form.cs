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
    public partial class Delete_Form : Form
    {
        public Delete_Form()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Delete_Form add_delete_form = new Add_Delete_Form();
            add_delete_form.Show();
        }

        private void delete_button1_Click(object sender, EventArgs e)
        {


            if (Id_Seller_textBox1.Text == "") // проверка на введённые данные 
            {
                MessageBox.Show("Введите id продавца ");
                return;
            }

            if (Id_pr_textBox2.Text == "")
            {
                MessageBox.Show("Введите id товара ");
                return;
            }

            if (checkid_seller())//проверка id продавца на существование
            {
                return;
            }

            



            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM products WHERE id = @id ", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Id_pr_textBox2.Text;
            

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Товар удалён");
            }
            else
            {
                MessageBox.Show("Товара с таким id не существует");
            }
            

            db.closeConnection();
        }

       

        public Boolean checkid_seller() //проверка id продавца на существование
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE  id = @id ", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Id_Seller_textBox1.Text;


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
