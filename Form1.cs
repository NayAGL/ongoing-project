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
            bool priceValid;

            //Assigning variables.
            gameName = txtGameName.Text;
            //gamePrice = double.Parse(txtGamePrice.Text);
            priceValid = double.TryParse(txtGamePrice.Text, out gamePrice); //Returns whether TryParse worked or not.
            taxRate = 0.0875;

            if (priceValid)
            {
                taxAmount = gamePrice * taxRate;
                totalPrice = gamePrice + taxAmount;

                //Output.
                lstOutput.Items.Add("Game: " + gameName);
                lstOutput.Items.Add("Price: " + gamePrice.ToString("C"));
                lstOutput.Items.Add("Tax Amount: " + taxAmount.ToString("C") + " (Tax Rate: " + taxRate.ToString("P") + ")");
                lstOutput.Items.Add("Total Price: " + totalPrice.ToString("C"));
            }
            else { lstOutput.Items.Add("Invalid price value."); }

            //Focus.
            btnReset.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected;
            buttonSelected = MessageBox.Show("Program is being closed! Are you sure?",
                                             "Exiting...", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (buttonSelected == DialogResult.Yes) { this.Close(); }
        }
    }
}