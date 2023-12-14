using MySqlConnector;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace WinFormsApp1
{

    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)//Метод, вызываемый при загрузке формы. Заполняет выбор статуса заранее определенными константами
        {
            List<string> list = new List<string>
            {
                "",
                "Администратор",
                "Учитель",
                "Ученик"
            };
            list.Sort();
            status.DataSource = list;
            codeField.Enabled = false;
            codeField.Visible = false;
            pictureBox5.Visible = false;
            label7.Visible = false;
            ConfirmCodeButton.Visible = false;
            ConfirmCodeButton.Enabled = false;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)//Метод, который в зависимости от выбора пользователя показывать или не показывать пароль применяет метод UseSystemPasswordChar к PasswordField
        {
            if (ShowPassword.Checked == true)
                PasswordField.UseSystemPasswordChar = false;
            else if (ShowPassword.Checked == false)
                PasswordField.UseSystemPasswordChar = true;
        }

        private void BackButton_Click(object sender, EventArgs e)//Метод, который при нажатии на кнопку "Назад" перекидывает пользователя на окно "StartScreen"
        {
            var form = new StartScreen();
            form.Show();
            this.Close();
        }

        private void EscapeButton_Click(object sender, EventArgs e)//Метод кнопки закрытия приложения
        {
            Application.Exit();

        }
        Point lastPoint;//Переменная, в которой хранится последняя точка расположения окна на экране пользователя
        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)//Метод, срабатывающий после того, как пользователь перестанет удерживать левую кнопку мыши. Изменяет значение переменной lastPoint
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)//Метод, позволяющий перемещать данное окно "StartScreen" на экране пользователя, путем зажатия левой кнопки мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)//Метод, при нажатии на кнопку "Регистрация", который проверяет базу данных на наличие пользователя с таким же логином или почтой, создает новый объект класса User, записывает нового пользователя в базу данных
        {
            //if (checkUser() || checkEmail())
            if (ReadFromDB.CheckIfNameOfUserInBD(LoginField.Text) || ReadFromDB.CheckIfEmailInBD(emailField.Text))
            {
                MessageBox.Show("Пользователь с таким логином или E-mail уже существует");
                return;
            }
            //Тута лежит закоментированный предыдущий код
            #region
            //DB db = new DB();
            //MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `last name`,`otchestvo`, `birthdate`, `status`,`email`) VALUES (@log,@pass,@name,@surename,@otch,@birthDate,@status,@email);", db.getConnection());

            //command.Parameters.Add("@log", MySqlDbType.VarChar).Value = LoginField.Text;
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordField.Text;
            //command.Parameters.Add("@name", MySqlDbType.Text).Value = name.Text;
            //command.Parameters.Add("@surename", MySqlDbType.Text).Value = surname.Text;
            //command.Parameters.Add("@otch", MySqlDbType.VarChar).Value = Otchestvo.Text;
            //command.Parameters.Add("@birthDate", MySqlDbType.Date).Value = birthDate.Value;
            //command.Parameters.Add("@status", MySqlDbType.Text).Value = status.Text;
            //command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailBox.Text;

            //db.openConnection();
            //if (command.ExecuteNonQuery() == 1)
            //    MessageBox.Show("Пользователь успешно зарегистрирован");
            //else
            //{
            //    MessageBox.Show("Ошибка в регистрации. Проверьте заполнены ли все поля");
            //    return;
            //}
            //db.closeConnection();
            #endregion 

            User newUser = new User()
            {
                _login = LoginField.Text,
                _password = PasswordField.Text,
                _name = nameField.Text,
                _surename = surnameField.Text,
                _patronymic = Otchestvo.Text,
                _Date = birthDate.Value,
                _status = status.Text,
                _email = emailField.Text
            };

            var userSuccessfullyRegistered = WriteToDB.RegisterANewUser(newUser); // логически странно

            if (userSuccessfullyRegistered)
                MessageBox.Show("Пользователь успешно зарегистрирован");
            else
            {
                MessageBox.Show("Ошибка в регистрации. Проверьте заполнены ли все поля");
                return;
            }

            Thread.Sleep(1000);
            var form = new StartScreen();
            form.Show();
            this.Close();
        }
        #region
        //public bool checkUser()
        //{
        //    DB db = new DB();
        //    DataTable dt = new DataTable();

        //    MySqlDataAdapter adapter = new MySqlDataAdapter();

        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
        //    command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);

        //    if (dt.Rows.Count > 0)
        //    {
        //        MessageBox.Show("Пользователь с таким именем уже существует");
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        //public bool checkEmail() 
        //{
        //    DB db = new DB();
        //    DataTable dt = new DataTable();

        //    MySqlDataAdapter adapter = new MySqlDataAdapter();

        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email`=@uE", db.getConnection());
        //    command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = emailBox.Text;

        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);

        //    if (dt.Rows.Count > 0)
        //    {
        //        MessageBox.Show("Пользователь с такой почтой уже существует");
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        #endregion
        private void status_SelectedIndexChanged(object sender, EventArgs e)//Метод, позволяющий выбрать статус из ранее представленных
        {
            string stat = status.SelectedItem.ToString();
        }

        private void ConfirmEmailButton_Click(object sender, EventArgs e)//Метод, 
        {
            emailField.Enabled = false;
            codeField.Enabled = true;
            codeField.Visible = true;
            label7.Visible = true;
            pictureBox5.Visible = true;
            ConfirmCodeButton.Visible = true;
            ConfirmCodeButton.Enabled = true;
            button2.Visible = false;
            button2.Enabled = false;
            int code = SendMessage(emailField.Text);
            _code = code;
        }

        int _code;

        bool isCorrectCode = false;
        private void ConfirmCodeButton_Click(object sender, EventArgs e)//Метод, который проверяет условие правильности введенного с почты кода подтверждения
        {
            if (isCorrectEmailCode(_code))
            {
                codeField.Enabled = false;
                codeField.Visible = false;
                pictureBox5.Visible = false;
                ConfirmCodeButton.Visible = false;
                ConfirmCodeButton.Enabled = false;
                label7.Visible = false;
                isCorrectCode = true;
            }
            else
            {
                MessageBox.Show("Неверный код подтверждения");
            }
        }
        public bool isCorrectEmailCode(int code)//Проверяет правильность кода с почты
        {
            if (codeField.Text == code.ToString() && codeField.Text != "0")
            {
                return true;
            }
            return false;
        }
        public int SendMessage(string adressTo)//метод для отправки письма на почту пользователю с кодом подтверждения
        {
            emailField.Enabled = false;
            try
            {
                string from = @"schoolhelper634@gmail.com"; // адреса отправителя
                string pass = "ewlr vryt jiey qyqa"; // пароль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = "Одноразовый код для подтверждения почты"; // тема
                var r = new Random();
                var code = r.Next(100000, 999999);
                mess.Body = code.ToString(); // текст сообщения
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com"; //smtp-сервер отправителя
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mess); // отправка пользователю
                MessageBox.Show("Сообщение было отправлено на почту");
                return code;
            }
            catch
            {
                MessageBox.Show("Ошибка отправки. Проверьте правильность написания почты");
                return 0;
            }

        }
    }
}
