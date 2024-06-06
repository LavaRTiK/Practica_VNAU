namespace NP9._7F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double basePricePerSquareFoot = 15.00;
        private const double deliveryCost = 18.00;
        private const double installationCost = 11.00;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double width = double.Parse(textBox1.Text);
            double height = double.Parse(textBox2.Text);
            double baseCost = width * height * basePricePerSquareFoot;
            double extrasCost = 0;
            if (checkBox1.Checked)
            {
                extrasCost += deliveryCost;
            }
            if (checkBox2.Checked)
            {
                extrasCost += installationCost;
            }
            double totalCost = baseCost + extrasCost;
            textBox3.Text = "Total Cost: $" + totalCost.ToString("F2");
            listBox1.Items.Add(new Order(width, height, extrasCost, totalCost));
        }
    }

    public class Order
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double ExtrasCost { get; set; }
        public double TotalCost { get; set; }

        public Order(double width, double height, double extrasCost, double totalCost)
        {
            Width = width;
            Height = height;
            ExtrasCost = extrasCost;
            TotalCost = totalCost;
        }

        public override string ToString()
        {
            return $"Width: {Width} cm\nHeight: {Height} cm\nExtras Cost: ${ExtrasCost:F2}\nTotal Cost: ${TotalCost:F2}";
        }
    }
}
