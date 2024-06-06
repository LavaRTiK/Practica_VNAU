using System.Windows.Forms;

namespace NP._9._12F
{
    public partial class Form1 : Form
    {
        List<string> applicantData = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // �������� ������ ��� ��������� ����� ������
            // ������ ��� � TextBox �� ������
            applicantData.Add($"ϲ�: {textBox1.Text}");
            applicantData.Add($"���� ����������: {textBox2.Text}");
            applicantData.Add($"�������: {textBox3.Text}");
            applicantData.Add($"���� ���: {textBox4.Text}");

            // �������� TextBox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            // ³��������� ��� ������ � ListBox
            listBox1.Items.Clear();
            foreach (string item in applicantData)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
