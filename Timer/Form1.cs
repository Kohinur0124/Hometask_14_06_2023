namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        int t;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = 0;
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t++;
            label4.Text = (t / 3600).ToString() + ":" + (t % 3600 / 60).ToString() + ":" + (t % 60).ToString();
        }
    }
}