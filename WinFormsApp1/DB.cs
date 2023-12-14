using MySqlConnector;

namespace WinFormsApp1
{
    class DB//класс для работы с БД
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=schoolhelper");//Подключение к базе данных MySql

        public void openConnection()//Метод для открытия соединения с БД
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void closeConnection()//метод для закрытия соединения с БД
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public MySqlConnection getConnection()//Метод, возвращающий переменную для соединения с БД
        {
            return connect;
        }
    }

}
