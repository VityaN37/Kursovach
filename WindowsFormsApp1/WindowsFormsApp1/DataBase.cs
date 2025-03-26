using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DataBase //класс подключения программы к mysql
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=electrostore"); //подключение к базе данных

        public void openConnection() // подключение к базе данных 
        {
            if(connection.State==System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection() // отключение от базы данных 
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection() //возвращает соединение с базой данных 
        {
            return connection;
        }
    }
}
