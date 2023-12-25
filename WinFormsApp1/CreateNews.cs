//using MySql.Data.MySqlClient;
using MySqlConnector;
using SchoolHelperApp;
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
    public partial class CreateNews : Form
    {
        public CreateNews()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkWithImages.SelectImage(pictureBox1);
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }

        private void CreateNews_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ReadFromDB.GetAdministrators();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void createNewsButton_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = WorkWithImages.ImageToByteArray(pictureBox1.Image);
            var news = new News(comboBox1.Text, richTextBox1.Text, imageBytes);
            ChangeDBData.CreateNews(news);
            MessageBox.Show("Новость успешна создана");
            var menu= new Menu();
            menu.Show();
            this.Close();
        }
    }
}
