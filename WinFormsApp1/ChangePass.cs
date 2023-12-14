//using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace WinFormsApp1
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)//метод, отправляющий сообщение на введенную пользователем электронную почту
        {
            if (ReadFromDB.CheckIfEmailInBD(emailBox.Text))
            {
                code = SendMessage(emailBox.Text);
                MessageBox.Show("Код отправлен на почту");
            }
            else
                MessageBox.Show("Почта не найдена");
        }
        public int code;

        public int SendMessage(string adressTo)//Метод отправки сообщения с кодом подтверждения
        {
            emailBox.Enabled = false;
            try
            {
                string from = @"schoolhelper634@gmail.com"; // адреса отправителя
                string pass = "ewlr vryt jiey qyqa"; // пароль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = "Одноразовый код для смены пароля"; // тема
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

                return code;
            }
            catch
            {
                MessageBox.Show("Ошибка отправки");
                return 0;
            }

        }

        private void ButtonNext_Click(object sender, EventArgs e)//Метод, который в случае совпадения кода, введенного пользователем, и кода, высланного на почту, меняет у данного user ячейку с паролем
        {
            if (int.Parse(CodeBox.Text) == code && code != 0)
            {
                WriteToDB.ChangePass(emailBox.Text, newPass.Text);
                Thread.Sleep(500);
                var form = new LoginForm();
                form.Show();
                this.Close();
            }
            else
                MessageBox.Show("Неверный код подтверждения");
        }

        private void BackButton_Click(object sender, EventArgs e)//Метод, который при нажатии на кнопку "Назад" перекидывает пользователя на окно "LoginForm"
        {
            var form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)//Метод, который в зависимости от выбора пользователя показывать или не показывать пароль применяет метод UseSystemPasswordChar к PasswordField
        {
            if (!ShowPassword.Checked)
                newPass.UseSystemPasswordChar = true;
            if (ShowPassword.Checked)
                newPass.UseSystemPasswordChar = false;
        }
    }
}
