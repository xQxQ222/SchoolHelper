using MySqlConnector;
using System.Data;

namespace WinFormsApp1
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)//Метод, который при нажатии на кнопку "Назад" перекидывает пользователя на окно "Menu"
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)//Метод закрытия приложения
        {
            Application.Exit();
        }

        private void Chat_Load(object sender, EventArgs e)//Метод, вызываемый при загрузке формы. Добавляет в ComboBox имена доступных получателей
        {
            comboBox1.DataSource = ReadFromDB.GetRecipients().Item1;//вставляем имена получателей в комбо бокс
        }

        private void SendMessageButton_Click(object sender, EventArgs e)//Метод, позволяющий пользователю отправить письмо во внутреннем чате программы другому пользователю
        {
            var recip = ReadFromDB.GetRecipients();//доступные получатели

            WriteToDB.AddNewMessage(recip, comboBox1.Text, richTextBox1.Text);

            MessageBox.Show("Сообщение успешно отправлено");
            richTextBox1.Clear();
        }

    }
}
