namespace NP._9._5F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //record Tovar(string name,double price,int cout);
        //List<Tovar> tovars = new List<Tovar>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = (checkBox1.Checked ? Convert.ToDouble(label4.Text) * Convert.ToInt32(textBox1.Text) : 0) + (checkBox2.Checked ? Convert.ToDouble(label5.Text) * Convert.ToInt32(textBox2.Text) : 0) + (checkBox3.Checked ? Convert.ToDouble(label6.Text) * Convert.ToInt32(textBox3.Text) : 0) + (checkBox4.Checked ? Convert.ToDouble(label7.Text) * Convert.ToInt32(textBox4.Text) : 0);
            textBox5.Text = total.ToString();
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }
        private void cheak()
        {
            if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox1.Text) || checkBox2.Checked && !string.IsNullOrWhiteSpace(textBox2.Text) || checkBox3.Checked && !string.IsNullOrWhiteSpace(textBox3.Text) || checkBox4.Checked && !string.IsNullOrWhiteSpace(textBox4.Text))
            {

                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

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
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {

                return;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {

                return;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {

                return;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            cheak();
            //tovars.Add(new Tovar(label1.Text,Convert.ToDouble(label4.Text),Convert.ToInt32(textBox1.Text)));
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cheak();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cheak();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
