using Newtonsoft.Json;
using System.Net;
using WinFormsApp1.OpenWeather;
using SchoolHelperApp.Properties;
using SchoolHelperApp;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            PrepareToLoad();
            ShowWeater();
            ShowNews();
        }
        private void ShowNews()
        {
            var news = ReadFromDB.GetNewsFromDB();
            var firstNews = new News("","",null);
            var secondNews= new News("", "", null);
            var thirdNews= new News("", "", null);
            var fourthNews= new News("", "", null);
            if (news.Length >= 1)
            {
                firstNews = news[news.Length - 1];
                newsIcon1.Image = WorkWithImages.ByteArrayToImage(firstNews.image);
                newsText1.Text=firstNews.text;
                newsAuthor1.Text=firstNews.author;
            }
            if(news.Length >= 2)
            {
                secondNews = news[news.Length - 2];
                newsIcon2.Image = WorkWithImages.ByteArrayToImage(secondNews.image);
                newsText2.Text = secondNews.text;
                newsAuthor2.Text = secondNews.author;
            }
            if(news.Length >= 3)
            {
                thirdNews = news[news.Length - 3];
                newsIcon3.Image = WorkWithImages.ByteArrayToImage(thirdNews.image);
                newsText3.Text = thirdNews.text;
                newsAuthor3.Text = thirdNews.author;
            }
            if(news.Length >= 4)
            {
                fourthNews = news[news.Length - 4];
                newsIcon4.Image = WorkWithImages.ByteArrayToImage(fourthNews.image);
                newsText4.Text = fourthNews.text;
                newsAuthor4.Text = fourthNews.author;
            }
        }
        
        private void PrepareToLoad()
        {
            flowLayoutPanel1.Visible = false;
            if (User.Current._status == "Администратор")
            {
                button1.Location = new System.Drawing.Point(74, 146);
                button2.Location = new System.Drawing.Point(74, 398);
                button3.Location = new System.Drawing.Point(74, 635);
                button4.Location = new System.Drawing.Point(74, 837);
                pictureBox5.Location = new System.Drawing.Point(335, 165);
                pictureBox4.Location = new System.Drawing.Point(335, 417);
                pictureBox2.Location = new System.Drawing.Point(335, 654);
                pictureBox11.Location = new System.Drawing.Point(335, 856);
                newsText1.ReadOnly = false; newsText2.ReadOnly = false;
                newsText3.ReadOnly = false; newsText4.ReadOnly = false;
            }
            else
            {
                button4.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                button1.Location = new System.Drawing.Point(64, 192);
                button2.Location = new System.Drawing.Point(64, 486);
                button3.Location = new System.Drawing.Point(64, 763);
                pictureBox5.Location = new System.Drawing.Point(325, 211);
                pictureBox4.Location = new System.Drawing.Point(325, 505);
                pictureBox2.Location = new System.Drawing.Point(325, 782);
                newsText1.ReadOnly = true;
                newsText2.ReadOnly = true;
                newsText3.ReadOnly = true;
                newsText4.ReadOnly = true;
            }
        }
        private async void ShowWeater()
        {
            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=Izhevsk&APPID=94048917cc9847b12ba053b704683a9e");
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(s))
                {
                    answer = await sr.ReadToEndAsync();
                }
            }

            response.Close();

            OpenWeather.OpenWeather oW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);

            WeatherIcon.Image = oW.weather[0].Icon;

            string plus;
            if (oW.main.temp > 0)
                plus = "+";
            else
                plus = "";
            label4.Text = oW.weather[0].description;

            string[] sides = new string[] { "С", "СВ", "В", "ЮВ", "Ю", "ЮЗ", "З", "СЗ" };
            label6.Text = plus + oW.main.temp.ToString("0.#") + "°С";
            label9.Text = oW.wind.speed.ToString() + "м/с, ";
            var degr = (int)Math.Ceiling(oW.wind.deg / 45) - 1;
            label10.Text = sides[degr];
            label7.Text = oW.main.humidity.ToString() + "%";
            label8.Text = ((int)oW.main.pressure).ToString() + "мм.рт.с.";
            isPEOutside(oW.main.temp, oW.wind.speed);
        }

        private void isPEOutside(double temp, double windSpeed)
        {

            PrimarySchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Decline;
            MiddleSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Decline;
            HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Decline;
            var winter = new int[] { 12, 1, 2 };
            if (winter.Contains(DateTime.Now.Month))
            {
                if (windSpeed == 0)
                {
                    if (temp > -10)
                    {
                        PrimarySchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        MiddleSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                    }
                    else if (temp > -14)
                    {
                        MiddleSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                    }
                    else if (temp > -16)
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                }
                else if (windSpeed <= 5 && windSpeed > 0)
                {
                    if (temp > -6)
                    {
                        PrimarySchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        MiddleSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                    }
                    else if (temp > -10)
                    {
                        MiddleSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                    }
                    else if (temp > -15)
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                }
                else if (windSpeed <= 10 && windSpeed > 5)
                {
                    if (temp > -3)
                    {
                        PrimarySchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        MiddleSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                    }
                    else if (temp > -6)
                    {
                        MiddleSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                    }
                    else if (temp > -10)
                        HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                }
            }
            else
            {
                if (temp > 14)
                {
                    PrimarySchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                    MiddleSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                    HighSchoolPEIcon.Image = SchoolHelperApp.Properties.Resources.Confirm;
                }
            }

        }
        Point lastPoint;
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            var form = new Table();
            form.Show();
            this.Close();
        }

        private void JournalButton_Click(object sender, EventArgs e)
        {
            var form = new Journal();
            form.Show();
            this.Close();
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            var form = new Chat();
            form.Show();
            this.Close();
        }

        private void VerifyUsersButton_Click(object sender, EventArgs e)
        {
            var form = new VerifyUsers();
            form.Show();
            this.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            var form = new Profile();
            form.Show();
            this.Close();
        }
        private bool isShow = false;
        private void ShowAdditionalButtons_Click(object sender, EventArgs e)
        {
            if (isShow)
                isShow = false;
            else isShow = true;
            flowLayoutPanel1.Visible = isShow;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var form = new StartScreen();
            form.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            var form = new CreateNews();
            form.Show();
            this.Close();
        }
    }
}
