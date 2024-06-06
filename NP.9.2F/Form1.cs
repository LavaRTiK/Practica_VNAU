namespace NP._9._2F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static decimal usdb = 40.1M;
        static decimal usds = 41.2M;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                return;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                return;
            }
            else if (e.KeyChar == ',' && textBox1.Text.Count(x => x == ',') < 1)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox2.Text = Math.Round((usdb * Convert.ToDecimal(textBox1.Text)), 2).ToString();
            }
            else
            {
                textBox2.Text = Math.Round((Convert.ToDecimal(textBox1.Text) / usds), 2).ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "Кількість (UA)";
            }
            else
            {
                label1.Text = "Кількість (USD)";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
