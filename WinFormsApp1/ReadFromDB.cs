using MySqlConnector;
using System.Data;
using System.Text;

namespace WinFormsApp1
{
    public class ReadFromDB
    {
        public static bool ReadCurrentUser(string login, string password)
        {
            DB db = new DB();
            bool userIsLoggedInSuccessfully;
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            if (dt.Rows.Count > 0)
            {
                userIsLoggedInSuccessfully = true;
                var read = command.ExecuteReader();
                read.Read();
                User.Current = new User(read.GetInt32(0), read.GetString(1),
                    read.GetString(2), read.GetString(3), read.GetString(4), read.GetString(5), read.GetDateTime(6), read.GetString(7),read.GetString(8), read.GetString(9));
            }
            else
                userIsLoggedInSuccessfully = false;
            db.closeConnection();
            return userIsLoggedInSuccessfully;
        }

        public static List<string> GetAdministrators()
        {
            DB db = new DB();
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `status` LIKE 'Администратор'", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.openConnection();
            list.Add("");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var read = command.ExecuteReader();
                    read.Read();
                    var name = read.GetString(3);
                    var surname = read.GetString(4);
                    var patronymic = read.GetString(5);
                    var fullName = $"{surname} {name.Substring(0, 1)}. {patronymic.Substring(0, 1)}.";
                    string teacher = fullName;
                    list.Add(teacher);
                }
            }
            db.closeConnection();
            return list;
        }

        public static bool CheckIfEmailInBD(string email,string table)
        {
            DB db = new DB();
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `{table}` WHERE `email`=@uE", db.getConnection());
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public static bool CheckIfLoginOfUserInBD(string nameOfUser,string table)
        {
            DB db = new DB();
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `{table}` WHERE `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = nameOfUser;
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public static Tuple<List<string>, Dictionary<string, string>> GetRecipients()
        {
            var list = new List<string>();
            var dic = new Dictionary<string, string>();
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = null;
            if (User.Current._status == "Ученик")
                command = new MySqlCommand("SELECT * FROM `users` WHERE `status` LIKE 'Учитель'", db.getConnection());
            else if (User.Current._status == "Учитель")
                command = new MySqlCommand("SELECT * FROM `users` WHERE 'status' LIKE 'Учитель' OR 'Ученик'", db.getConnection());
            else if (User.Current._status == "Администратор")
            {
                command = new MySqlCommand("SELECT * FROM `users` WHERE `id` != @id", db.getConnection());
                command.Parameters.Add("@id",MySqlDbType.Int64).Value=User.Current._id;
            }
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            list.Add("");
            if (dt.Rows.Count > 0)
            {
                var read = command.ExecuteReader();
                foreach (DataRow row in dt.Rows)
                {
                    
                    read.Read();
                    var login = read.GetString(1);
                    var name = read.GetString(3);
                    var surname = read.GetString(4);
                    var patronymic = read.GetString(5);
                    var fullName = $"{surname} {name.Substring(0, 1)}. {patronymic.Substring(0, 1)}.";
                    string teacher = fullName;
                    dic[fullName] = login;
                    list.Add(teacher);
                }
            }
            db.closeConnection();
            var tuple = new Tuple<List<string>, Dictionary<string, string>>(list, dic);
            return tuple;
        }
        public static Dictionary<int,Tuple<string,string>> GetMessages()
        {
            var dict=new Dictionary<int,Tuple<string,string>>();
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `messages` WHERE `recipient` LIKE @recipient", db.getConnection());
            command.Parameters.Add("@recipient", MySqlDbType.VarChar).Value = User.Current._login;
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            if(dt.Rows.Count > 0)
            {
                var read = command.ExecuteReader();
                foreach (DataRow row in dt.Rows)
                {
                    read.Read();
                    var id=read.GetInt32(0);
                    var sender=read.GetString(1);
                    var text=read.GetString(3);
                    var tuple=new Tuple<string,string>(sender, text);
                    dict.Add(id, tuple);
                }
            }
            return dict;
        }
        public static Dictionary<int, Tuple<string, string>> GetMessagesSends()
        {
            var dict = new Dictionary<int, Tuple<string, string>>();
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `messages` WHERE `sender` LIKE @sender", db.getConnection());
            command.Parameters.Add("@sender", MySqlDbType.VarChar).Value = User.Current._login;
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            if (dt.Rows.Count > 0)
            {
                var read = command.ExecuteReader();
                foreach (DataRow row in dt.Rows)
                {
                    read.Read();
                    var id = read.GetInt32(0);
                    var sender = read.GetString(1);
                    var text = read.GetString(3);
                    var tuple = new Tuple<string, string>(sender, text);
                    dict.Add(id, tuple);
                }
            }
            return dict;
        }
        public static User[] getAwaitingUsers()
        {
            var users=new List<User>();
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter=new MySqlDataAdapter();
            var command =new MySqlCommand("SELECT * FROM `awaitingconfirmation`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            var reader=command.ExecuteReader();
            if(dt.Rows.Count > 0)
            {
                
                foreach (DataRow row in dt.Rows)
                {
                    reader.Read();
                    var user=new User(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7),reader.GetString(8), reader.GetString(9));
                    users.Add(user);
                }
            }
            db.closeConnection();
            return users.ToArray();
        }

        public static News[] GetNewsFromDB()
        {
            var db = new DB();
            var newsArray = new List<News>();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `news`", db.getConnection());
            adapter.SelectCommand= command;
            adapter.Fill(dt);
            db.openConnection();
            var reader=command.ExecuteReader();
            if(dt.Rows.Count > 0 )
            {
                foreach(DataRow row in dt.Rows)
                {
                    reader.Read();
                    var news=new News(reader.GetInt32(0), "Автор: " + reader.GetString(1), reader.GetString(2), (byte[])reader[3]);
                    newsArray.Add(news);
                }
            }
            return newsArray.ToArray();
        }
    }
}
