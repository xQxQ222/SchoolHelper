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

        private void ExitButton_Click(object sender, EventArgs e)//Метод закрытия приложения при нажатии на крестик
        {
            Application.Exit();
        }

        private void Chat_Load(object sender, EventArgs e)//Метод, вызываемый при загрузке формы. Добавляет в ComboBox имена доступных получателей
        {
            var recip = ReadFromDB.GetRecipients();//метод описан в классе ReadFromDB
            comboBox1.DataSource = recip.Item1;
        }

        private void SendMessageButton_Click(object sender, EventArgs e)//Метод, позволяющий пользователю отправить письмо во внутреннем чате программы другому пользователю
        {
            var recip = ReadFromDB.GetRecipients();

            WriteToDB.AddNewMessage(recip, comboBox1.Text, richTextBox1.Text);

            MessageBox.Show("Сообщение успешно отправлено");
            richTextBox1.Clear();
        }

    }
}
