namespace Nay_Aung_Latt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGameName_Enter(object sender, EventArgs e)
        {
            txtGameName.BackColor = Color.AliceBlue;
        }

        private void txtGameName_Leave(object sender, EventArgs e)
        {
            txtGameName.BackColor = SystemColors.Window;
        }

        private void txtGamePrice_Enter(object sender, EventArgs e)
        {
            txtGamePrice.BackColor = Color.AliceBlue;
        }

        private void txtGamePrice_Leave(object sender, EventArgs e)
        {
            txtGamePrice.BackColor = SystemColors.Window;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGameName.Clear();
            txtGamePrice.Clear();
            lstOutput.Items.Clear();
            txtGameName.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables.
            string gameName;
            double gamePrice, taxRate, taxAmount, totalPrice;

            //Assigning variables.
            gameName = txtGameName.Text;
            gamePrice = double.Parse(txtGamePrice.Text);
            taxRate = 0.0875;
            taxAmount = gamePrice * taxRate;
            totalPrice = gamePrice + taxAmount;

            //Output.
            lstOutput.Items.Add("Game: " + gameName);
            lstOutput.Items.Add("Price: " + gamePrice.ToString("C"));
            lstOutput.Items.Add("Tax Amount: " + taxAmount.ToString("C") + " (Tax Rate: " + taxRate.ToString("P") + ")");
            lstOutput.Items.Add("Total Price: " + totalPrice.ToString("C"));

            //Focus.
            btnReset.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}