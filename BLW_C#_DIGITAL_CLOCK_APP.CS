namespace BLW_DIGITAL_CLOCK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm");
            label3.Text = DateTime.Now.ToString("ss");
            label4.Text = DateTime.Now.ToString("MMM dd yyyy");
            label5.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            MaximizeBox = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
