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

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>
            {
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

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new StartScreen();
            form.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User newUser = new User(LoginField.Text, PasswordField.Text, name.Text, surname.Text, Otchestvo.Text, birthDate.Value, status.Text,additionalParameter.Text, emailBox.Text);

            var userSuccessfullyRegistered = ChangeDBData.RegisterANewUser(newUser);

            if (userSuccessfullyRegistered)
                MessageBox.Show("Пользователь успешно занесен в систему. Ожидайте подтверждения аккаунта от администратора");
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

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status.SelectedIndex == 0)
            {
                label9.Visible = false;
                additionalParameter.Visible = false;
            }
            else if (status.SelectedIndex == 1)
            {
                label9.Visible = true;
                additionalParameter.Visible = true;
                label9.Text = "Класс";

            }
            else if (status.SelectedIndex == 2)
            {
                label9.Visible = true;
                label9.Text = "Предмет";
                additionalParameter.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emailBox.Enabled = false;
            codeField.Enabled = true;
            codeField.Visible = true;
            label7.Visible = true;
            pictureBox5.Visible = true;
            ConfirmCodeButton.Visible = true;
            ConfirmCodeButton.Enabled = true;
            button2.Visible = false;
            button2.Enabled = false;
            int code = SendMessage(emailBox.Text);
            _code = code;
        }
        int _code;
        bool isCorrectCode = false;
        private void button3_Click(object sender, EventArgs e)
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
                MessageBox.Show($"Почта {emailBox.Text} успешно подтверждена");
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
            emailBox.Enabled = false;
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
