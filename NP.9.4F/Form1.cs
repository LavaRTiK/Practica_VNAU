using System.Reflection;

namespace NP._9._4F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double price = 4.25;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                cheack();
                return;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                cheack();
                return;
            }
            else if (e.KeyChar == ',' && textBox1.Text.Count(x => x == ',') < 1)
            {
                return;
            }
            else
            {
                cheack();
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                cheack();
                return;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                cheack();
                return;
            }
            else if (e.KeyChar == ',' && textBox2.Text.Count(x => x == ',') < 1)
            {
                return;
            }
            else
            {
                cheack();
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {

                return;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                return;
            }
            else if (e.KeyChar == ',' && textBox5.Text.Count(x => x == ',') < 1)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                button1.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void cheack()
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToDouble(textBox2.Text) * price).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
                price = 4.25;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            price = Convert.ToDouble(textBox5.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
