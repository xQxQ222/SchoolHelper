using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class VerifyUsers : Form
    {
        public VerifyUsers()
        {
            InitializeComponent();
        }
        private Dictionary<int,User> usersDic = new Dictionary<int, User>();
        private void VerifyUsers_Load(object sender, EventArgs e)
        {
            var users = ReadFromDB.getAwaitingUsers();
            
            for (int i = 0; i < users.Length; i++)
            {
                var fio = users[i]._surename + " " + users[i]._name.Substring(0, 1) + ". " + users[i]._patronymic.Substring(0, 1);
                UsersWaitingForConfirm.Rows.Add();
                UsersWaitingForConfirm.Rows[i].Cells[0].Value = i.ToString();
                UsersWaitingForConfirm.Rows[i].Cells[1].Value = fio;
                UsersWaitingForConfirm.Rows[i].Cells[2].Value = users[i]._status;
                UsersWaitingForConfirm.Rows[i].Cells[3].Value = users[i]._additionalParameter;
                usersDic.Add(i, users[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsersWaitingForConfirm_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var id=int.Parse(UsersWaitingForConfirm.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            WriteToDB.ConfirmUser(usersDic[id]);
            WriteToDB.DeleteConfirmedUser(usersDic[id]);
            UsersWaitingForConfirm.Rows.Remove(UsersWaitingForConfirm.CurrentRow);
        }
    }
}
