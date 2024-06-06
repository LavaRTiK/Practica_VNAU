namespace NP._9._3F
{
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();
        public Form1()
        {
            InitializeComponent();
            labels.Add(price1);
            labels.Add(price2);
            labels.Add(price3);
            labels.Add(price4);
        }
        double price = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            total.Text = (price * Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ClearPrice();
            price1.Text = "25,00";
            price = 25.00;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ClearPrice();
            price2.Text = "40,00";
            price = 40.00;
        }
        private void ClearPrice()
        {
            foreach (Label label in labels)
            {
                label.Text = "0,00";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ClearPrice();
            price3.Text = "60,00";
            price = 60.00;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ClearPrice();
            price4.Text = "90,00";
            price = 90.00;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
