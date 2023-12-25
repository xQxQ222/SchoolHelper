using MySqlConnector;
using System.Data;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ReadFromDB.ReadCurrentUser(LoginField.Text, PasswordField.Text))
            {
                MessageBox.Show("Пользователь успешно авторизован");
                Thread.Sleep(500);

                var form = new Menu();
                form.Show();
                this.Close();
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var startScreen = new StartScreen();
            startScreen.Show();
            Close();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordChecker.Checked == true)
                PasswordField.UseSystemPasswordChar = false;
            else if (ShowPasswordChecker.Checked == false)
                PasswordField.UseSystemPasswordChar = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ChangePasswordLink_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ChangePass();
            form.Show();
            this.Close();
        }
    }
}
