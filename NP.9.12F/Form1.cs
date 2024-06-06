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
            // Створити список для зберігання даних анкети
            // Додати дані з TextBox до списку
            applicantData.Add($"ПІБ: {textBox1.Text}");
            applicantData.Add($"Дата народження: {textBox2.Text}");
            applicantData.Add($"Атестат: {textBox3.Text}");
            applicantData.Add($"Бали ЗНО: {textBox4.Text}");

            // Очистити TextBox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            // Відобразити дані анкети в ListBox
            listBox1.Items.Clear();
            foreach (string item in applicantData)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
