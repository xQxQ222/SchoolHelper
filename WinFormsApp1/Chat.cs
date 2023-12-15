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

<<<<<<< HEAD
        private void ExitButton_Click(object sender, EventArgs e)//Метод кнопки закрытия приложения
=======
        private void ExitButton_Click(object sender, EventArgs e)//Метод закрытия приложения
>>>>>>> feature-1
        {
            Application.Exit();
        }

        private void Chat_Load(object sender, EventArgs e)//Метод, вызываемый при загрузке формы. Добавляет в ComboBox имена доступных получателей
        {
<<<<<<< HEAD
            comboBox1.DataSource = ReadFromDB.GetRecipients().Item1;
=======
            comboBox1.DataSource = ReadFromDB.GetRecipients().Item1;//вставляем имена получателей в комбо бокс
>>>>>>> feature-1
        }

        private void SendMessageButton_Click(object sender, EventArgs e)//Метод, позволяющий пользователю отправить письмо во внутреннем чате программы другому пользователю
        {
<<<<<<< HEAD
            var recip = ReadFromDB.GetRecipients();//Доступные получатели письма
=======
            var recip = ReadFromDB.GetRecipients();//доступные получатели
>>>>>>> feature-1

            WriteToDB.AddNewMessage(recip, comboBox1.Text, richTextBox1.Text);//метод описан в классе WriteToDB

            MessageBox.Show("Сообщение успешно отправлено");
            richTextBox1.Clear();
        }

    }
}
