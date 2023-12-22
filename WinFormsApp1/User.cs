using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public class User
    {
        public int? _id;
        public string _login;
        public string _password;
        public string _name;
        public string _surename;
        public string _patronymic;
        public DateTime _Date;
        public string _email;
        public string _status;
        public string _additionalParameter="";
        public static User Current { get; set; }
        public User(int id,string login,string pass,string name,string surename,string patronymic,DateTime date,string status,string additionalParameter,string email)
        {
            this._id = id;
            this._login = login;
            this._password = pass;
            this._name = name;
            this._surename = surename;
            this._patronymic = patronymic;
            this._Date = date;
            this._status = status;
            this._additionalParameter = additionalParameter;
            this._email = email;
        }
        public User( string login, string pass, string name, string surename, string patronymic, DateTime date, string status,string additionalParameter, string email)
        {
            this._login = login;
            this._password = pass;
            this._name = name;
            this._surename = surename;
            this._patronymic = patronymic;
            this._Date = date;
            this._status = status;
            this._additionalParameter = additionalParameter;
            this._email = email;
        }
        public User() { }
    }
}
