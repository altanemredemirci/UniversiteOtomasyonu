namespace UniversiteOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_loginStdnt_Click(object sender, EventArgs e)
        {
            Login login = new Login(0);
            login.Show();
            this.Hide();
        }

        private void btn_loginTeachr_Click(object sender, EventArgs e)
        {
            Login login = new Login(1);
            login.Show();
            this.Hide();
        }

        private void btn_loginEmployee_Click(object sender, EventArgs e)
        {
            Login login = new Login(2);
            login.Show();
            this.Hide();
        }
    }
}
