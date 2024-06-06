namespace NP._9._6
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
        private double price = 15.5;
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
            else if (e.KeyChar == ',' && textBox2.Text.Count(x => x == ',') < 1)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void cheak()
        {
            if (radioButton1.Checked && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) || radioButton2.Checked && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {

                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Math.Round(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text) * price),2).ToString(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cheak();
            if(radioButton1.Checked)
            {
                price = 15.5;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cheak();
            if(radioButton2.Checked)
            {
                price = 30.15;
            }
            
        }
    }
}
