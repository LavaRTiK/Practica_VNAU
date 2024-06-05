using System.Text.RegularExpressions;

namespace NP._9._1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        record Person(string name, int old, bool sex)
        {
            public override string ToString()
            {
                return $"²ì'ÿ:{name},Â³ê:{old},Ñòàòü:{(sex == true ? "÷îë." : "æ³í")}";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                Person obj = new Person(textBox1.Text, Convert.ToInt32(textBox2.Text), radioButton1.Checked == true ? true : false);
                listBox1.Items.Add(obj);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                return;
            }
            else if (Char.IsControl(e.KeyChar) == true)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.Match(e.KeyChar.ToString(),@"[A-Za-z À-ßà-ÿ]").Success == true)
            {
                return;
            }
            else if (Char.IsControl(e.KeyChar) == true)
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
