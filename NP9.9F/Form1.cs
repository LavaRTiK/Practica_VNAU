namespace NP9._9F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox1.Text.Length > 0 && comboBox1.SelectedIndex != -1)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double width = double.Parse(textBox2.Text);
            double height = double.Parse(textBox1.Text);
            int materialIndex = comboBox1.SelectedIndex;
            double price = 0;
            switch (materialIndex)
            {
                case 0:
                    price = width * height * 100;
                    break;
                case 1:
                    price = width * height * 150;
                    break;
                case 2:
                    price = width * height * 200;
                    break;
            }

            // Відображення суми розрахунку
            textBox3.Text = $"Сума: {price:F2} грн";
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
