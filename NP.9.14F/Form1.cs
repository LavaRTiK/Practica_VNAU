namespace NP._9._14F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                // ��������� ������� �� �� ������ ������
                textBox4.Text = "г������ �� �� ������ ������";
            }
            else
            {
                // ����������� ����� ����������� �������
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                // ������� ����� ����������� �������
                textBox4.Text = "x1 = " + x1.ToString("F2") + "\n x2 = " + x2.ToString("F2");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
