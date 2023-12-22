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

        private void BackButton_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            var recip = ReadFromDB.GetRecipients();
            comboBox1.DataSource = recip.Item1;
            UpdateChat();
        }
        public void UpdateChat()
        {
            RecievedMessages.Items.Clear();
            SendMessages.Items.Clear();
            var dict = ReadFromDB.GetMessages();
            var dict2 = ReadFromDB.GetMessagesSends();
            var i = 0;
            var k = 0;
            foreach (var messages in dict)
            {
                i++;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(messages.Value.Item1);
                item.SubItems.Add(messages.Value.Item2);
                RecievedMessages.Items.Add(item);
            }
            foreach (var messages in dict2)
            {
                k++;
                ListViewItem item = new ListViewItem(k.ToString());
                item.SubItems.Add(messages.Value.Item1);
                item.SubItems.Add(messages.Value.Item2);
                SendMessages.Items.Add(item);
            }
        }
        private void Send_Click(object sender, EventArgs e)
        {
            var recip = ReadFromDB.GetRecipients();

            WriteToDB.AddNewMessage(recip, comboBox1.Text, richTextBox1.Text);

            MessageBox.Show("Сообщение успешно отправлено");
            richTextBox1.Clear();
            UpdateChat();
        }
    }
}
