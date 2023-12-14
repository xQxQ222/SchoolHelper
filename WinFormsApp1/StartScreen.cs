namespace WinFormsApp1
{
    public partial class StartScreen : Form
    {

        public StartScreen()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();
            regForm.Show();
            Hide();
        }

        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var logForm = new LoginForm();
            logForm.Show();
            Hide();
        }

        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void StartScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void StartScreen_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}