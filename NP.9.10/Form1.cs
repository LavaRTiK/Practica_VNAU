namespace NP._9._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Contact> contacts = new List<Contact>();

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            Contact newContact = new Contact
            {
                Name = textBox1.Text,
                LastName = textBox2.Text,
                Phone = textBox3.Text,
                City = textBox4.Text,
                Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text
            };

            contacts.Add(newContact);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            UpdateContactsList();
        }

        private void UpdateContactsList()
        {
            listBox1.Items.Clear();

            foreach (Contact contact in contacts)
            {
                listBox1.Items.Add(contact);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                contacts.RemoveAt(listBox1.SelectedIndex);
                UpdateContactsList();
            }
        }
    }

    class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"Імя:{Name} Прізвище:{LastName} Телефон:{Phone} Город:{City} Пол:{Gender}";
        }
    }
}
