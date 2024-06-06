namespace NP._9._8F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double numberA = double.Parse(textBox1.Text);
            double numberB = double.Parse(textBox2.Text);

            double result = numberA + numberB;

            textBox3.Text = result.ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            double numberA = double.Parse(textBox1.Text);
            double numberB = double.Parse(textBox2.Text);

            double result = numberA - numberB;

            textBox3.Text = result.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            double numberA = double.Parse(textBox1.Text);
            double numberB = double.Parse(textBox2.Text);

            double result = numberA * numberB;

            textBox3.Text = result.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            double numberA = double.Parse(textBox1.Text);
            double numberB = double.Parse(textBox2.Text);

            if (numberB == 0)
            {
                MessageBox.Show("Не можна ділити на 0!");
                return;
            }

            double result = numberA / numberB;

            textBox3.Text = result.ToString();
        }
        private void buttonPowClick(object sender, EventArgs e)
        {
            double numberA = double.Parse(textBox1.Text);
            double numberB = double.Parse(textBox2.Text);

            double result = Math.Pow(numberA,numberB);

            textBox3.Text = result.ToString();
        }
        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            double numberA = double.Parse(textBox1.Text);
            double numberB = double.Parse(textBox2.Text);

            

            textBox3.Text = "result.ToString() - что ....";
        }
    }
}
