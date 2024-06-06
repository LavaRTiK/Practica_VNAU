namespace NP._9._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCos_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Cos(number);
            textBox2.Text = result.ToString();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Sin(number);
            textBox2.Text = result.ToString();
        }

        private void buttonTg_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Tan(number);
            textBox2.Text = result.ToString();
        }

        private void buttonCtg_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = 1 / Math.Tan(number);
            textBox2.Text = result.ToString();
        }
    }
}
