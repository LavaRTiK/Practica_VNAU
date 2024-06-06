namespace NP._9._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ������������ ������ "������", ���� TextBox �� ������
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ������������ ������ "��������", ���� ������� ������� ComboBox
            if (comboBox1.SelectedIndex != -1)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // ������ ����� � TextBox �� ComboBox
            comboBox1.Items.Add(textBox1.Text);

            // �������� TextBox
            textBox1.Text = "";

            // ��������� ������ "������"
            button1.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // �������� �������� ������� ComboBox
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            button2.Enabled = false;
            comboBox1.Text = "";
        }
    }
}
