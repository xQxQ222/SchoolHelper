using Newtonsoft.Json;
using System.Net;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        static bool isOnProfileButton;
        static bool isOnExitButton;
        public Menu()
        {
            InitializeComponent();
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            if (User.Current._status == "Администратор")
            {
                tableButton.Location = new System.Drawing.Point(74, 146);
                JournalButton.Location = new System.Drawing.Point(74, 398);
                mailButton.Location = new System.Drawing.Point(74, 635);
                confirmAccountsButton.Location = new System.Drawing.Point(74, 837);
                pictureBox5.Location = new System.Drawing.Point(335, 165);
                pictureBox4.Location = new System.Drawing.Point(335, 417);
                pictureBox2.Location = new System.Drawing.Point(335, 654);
                pictureBox11.Location = new System.Drawing.Point(335, 856);
                news1Text.ReadOnly = false; news2Text.ReadOnly = false;
                news3Text.ReadOnly = false; news4Text.ReadOnly = false;
            }
            else
            {
                confirmAccountsButton.Visible = false;
                pictureBox11.Visible = false;
                createNewsButton.Visible = false;
                tableButton.Location = new System.Drawing.Point(64, 192);
                JournalButton.Location = new System.Drawing.Point(64, 486);
                mailButton.Location = new System.Drawing.Point(64, 763);
                pictureBox5.Location = new System.Drawing.Point(325, 211);
                pictureBox4.Location = new System.Drawing.Point(325, 505);
                pictureBox2.Location = new System.Drawing.Point(325, 782);
                news1Text.ReadOnly = true;
                news2Text.ReadOnly = true;
                news3Text.ReadOnly = true;
                news4Text.ReadOnly = true;
            }
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

            //WeatherIcon.Image = oW.weather[0].Icon;

            string plus;
            if (oW.main.temp > 0)
                plus = "+";
            else
                plus = "";
            label4.Text = oW.weather[0].description;

            string[] sides = new string[] { "С", "СВ", "В", "ЮВ", "Ю", "ЮЗ", "З", "СЗ" };
            WeatherInfo.Text = plus + oW.main.temp.ToString("0.#") + "°С";
            WindInfo.Text = oW.wind.speed.ToString() + "м/с, ";
            var degr = (int)Math.Ceiling(oW.wind.deg / 45) - 1;
            WindAngleInfo.Text = sides[degr];
            HumidityInfo.Text = oW.main.humidity.ToString() + "%";
            PressureInfo.Text = ((int)oW.main.pressure).ToString() + "мм.рт.с.";
            PEData(oW.main.temp, oW.wind.speed);

        }

        private void PEData(double temp, double windSpeed)
        {
            PrimarySchoolIcon.Image = Resources.Yes;
            MediumSchoolIcon.Image = Resources.Yes;
            HighSchoolIcon.Image = Resources.Yes;
            if (DateTime.Now.Month == 12 || DateTime.Now.Month == 1 || DateTime.Now.Month == 2)
            {

                if (windSpeed == 0)
                {

                    if (temp <= -11)
                        PrimarySchoolIcon.Image = Resources.No;
                    if (temp <= -14)
                        MediumSchoolIcon.Image = Resources.No;
                    if (temp <= -16)
                        HighSchoolIcon.Image = Resources.No;
                }
                if (windSpeed <= 5 && windSpeed > 0)
                {
                    if (temp <= -7)
                        PrimarySchoolIcon.Image = (Resources.No);
                    if (temp <= -10)
                        MediumSchoolIcon.Image = (Resources.No);
                    if (temp <= -15)
                        HighSchoolIcon.Image = Resources.No;
                }
                if (windSpeed > 5)
                {
                    if (temp <= -4)
                        PrimarySchoolIcon.Image = Resources.No;
                    if (temp <= -6)
                        MediumSchoolIcon.Image = Resources.No;
                    if (temp < -10)
                        HighSchoolIcon.Image = Resources.No;
                }
            }
            else
            {
                if (temp <= 12)
                {
                    PrimarySchoolIcon.Image = Resources.No;
                    MediumSchoolIcon.Image = Resources.No;
                    HighSchoolIcon.Image = Resources.No;
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

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Table();
            form.Show();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Journal();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Chat();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isShow)
                isShow = false;
            else isShow = true;
            flowLayoutPanel1.Visible = isShow;
        }


        private void exitButton_Click(object sender, EventArgs e)
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
