namespace SocietyBook
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

        private void button1_Click(object sender, EventArgs e)
        {
            nameInput.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            nameInput.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int amount = ((int)amountInput.Value);

            Partner partner = new(name, amount);
            this.partners.Add(partner);

            int total = 0;
            foreach (var item in this.partners)
            {
                total += item.GetCapital();
            }
            partnersList.Items.Clear();
            foreach (var item in this.partners)
            {
                partnersList.Items.Add(item.ToString(total));
            }
            nameInput.Text = "";
            amountInput.Value = 0;
            amountInput.Enabled = false;
            saveButton.Enabled = false;
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            amountInput.Enabled = nameInput.Text.Length > 2;
        }

        private void amountInput_ValueChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = amountInput.Value > 0;
        }

    }
}
