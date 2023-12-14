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

        private void RegistrationForm_Load(object sender, EventArgs e)
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

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
                PasswordField.UseSystemPasswordChar = false;
            else if (ShowPassword.Checked == false)
                PasswordField.UseSystemPasswordChar = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var form = new StartScreen();
            form.Show();
            this.Close();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        Point lastPoint;
        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (ReadFromDB.CheckIfNameOfUserInBD(LoginField.Text) || ReadFromDB.CheckIfEmailInBD(emailField.Text))
            {
                MessageBox.Show("Пользователь с таким логином или E-mail уже существует");
                return;
            }
            

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

            var userSuccessfullyRegistered = WriteToDB.RegisterANewUser(newUser);

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
        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stat = status.SelectedItem.ToString();
        }

        private void ConfirmEmailButton_Click(object sender, EventArgs e)
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
        private void ConfirmCodeButton_Click(object sender, EventArgs e)
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
        public bool isCorrectEmailCode(int code)
        {
            if (codeField.Text == code.ToString() && codeField.Text != "0")
            {
                return true;
            }
            return false;
        }
        public int SendMessage(string adressTo)
        {
            emailField.Enabled = false;
            try
            {
                string from = @"schoolhelper634@gmail.com";
                string pass = "ewlr vryt jiey qyqa"; 
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); 
                mess.From = new MailAddress(from);
                mess.Subject = "Одноразовый код для подтверждения почты"; 
                var r = new Random();
                var code = r.Next(100000, 999999);
                mess.Body = code.ToString(); 
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com"; 
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mess); 
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
