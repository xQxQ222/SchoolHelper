using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void EscapeButton_Click(object sender, EventArgs e)//метод кнопки, завершающей выполнение программы
        {
            Application.Exit();
        }

        private void Profile_Load(object sender, EventArgs e)//Метод, вызываемый при загрузке формы. Отображает на экране все основные данные пользователя
        {
            name.Text = User.Current._name;
            surename.Text = User.Current._surename;
            patronymic.Text = User.Current._patronymic;
            status.Text = User.Current._status;
            birthDate.Text = User.Current._Date.ToShortDateString();
            email.Text = User.Current._email;
        }

        private void SetPhotoButton_Click(object sender, EventArgs e)//Метод, позволяющий пользователю загрузить свою фотографию
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)//метод, перекидывающий назад на форму "Меню"
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }
    }
}
