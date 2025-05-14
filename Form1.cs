namespace Nay_Aung_Latt
{
    internal partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
        }

        //Class level variables.
        const string PC = "PC";
        const string PLAYSTATION = "PlayStation";
        const string XBOX = "Xbox";
        const int DISPLAY_LISTBOX = 1;
        const int DISPLAY_LOGFILE = 2;
        const int DISPLAY_BOTH = 3;
        private string platformType;
        internal string configFile = "platformCFG!.txt"; //Intentionally wrote the wrong file name.
        private string logFile = "logTran.txt";
        private double markupRatePC;
        private double markupRatePlayStation;
        private double markupRateXbox;

        Form2 sf;

        internal double MarkupRatePC
        {
            get { return markupRatePC; }
            set
            {
                //Property that doesn't allow the setting to be negative or greater than 50%.
                if (value >= 0 || value <= 0.5) { markupRatePC = value; }
            }
        }

        internal double MarkupRatePlayStation
        {
            get { return markupRatePlayStation; }
            set
            {
                if (value >= 0 || value <= 0.5) { markupRatePlayStation = value; }
            }
        }

        internal double MarkupRateXbox
        {
            get { return markupRateXbox; }
            set
            {
                if (value >= 0 || value <= 0.5) { markupRateXbox = value; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader srCfg;
            sf = new Form2(this);

            bool fileWasNotFound = true;

            rdoPC.Checked = true;

            do
            {
                try
                {
                    srCfg = File.OpenText(configFile);
                    fileWasNotFound = false;

                    MarkupRatePC = double.Parse(srCfg.ReadLine());
                    MarkupRatePlayStation = double.Parse(srCfg.ReadLine());
                    MarkupRateXbox = double.Parse(srCfg.ReadLine());

                    srCfg.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message + " Enter a new file name.", "File Not Found!");

                    OFD.Title = "Open Configuration File";
                    OFD.Filter = "Text Files |*.txt | All Files | *.*";
                    OFD.ShowDialog();
                    configFile = OFD.FileName;
                }
                catch (FormatException ex) //If something is bad in the file and you can't depend on anything in the file.
                {
                    lstOutput.Items.Add("File data corrupted! Values were set to defaults.");
                    lstOutput.Items.Add(ex.Message);

                    //Setting default values for markup rates.
                    markupRatePC = 0.12;
                    markupRatePlayStation = 0.15;
                    markupRateXbox = 0.30;
                }

            } while (fileWasNotFound);
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            sf.txtPC.Text = MarkupRatePC.ToString();
            sf.txtPlayStation.Text = MarkupRatePlayStation.ToString();
            sf.txtXbox.Text = MarkupRateXbox.ToString();

            sf.ShowDialog();
        }

        private void showLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int MAX_LOGLINES = 2000;
            string[] logLines = new string[MAX_LOGLINES];
            StreamReader sr = File.OpenText(logFile);
            int numLines = 0;

            while (!sr.EndOfStream)
            {
                logLines[numLines] = sr.ReadLine(); numLines++;
            }

            int logStart = -2;
            int logEnd = 6;

            for (int i = 0; i < numLines; i++)
            {
                if (logLines[i] == "Platform: " + platformType)
                {
                    for (int j = i + logStart; j <= i + logEnd; j++)
                    {
                        lstOutput.Items.Add(logLines[j]);
                    }
                }
            }

            sr.Close();
        }

        private void rdoPC_CheckedChanged(object sender, EventArgs e)
        {
            //This will run in cases where check = true and false our code should only when true.
            if (rdoPC.Checked) { platformType = PC; }
        }

        private void rdoPlayStation_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPlayStation.Checked) { platformType = PLAYSTATION; }
        }

        private void rdoXbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoXbox.Checked) { platformType = XBOX; }
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
            rdoPC.Checked = true;
        }

        private void OutputDisplay(int outputType, string outputMessage)
        {
            StreamWriter log;

            if (outputType == DISPLAY_LISTBOX || outputType == DISPLAY_BOTH)
            {
                lstOutput.Items.Add(outputMessage);
            }

            if (outputType == DISPLAY_LOGFILE || outputType == DISPLAY_BOTH)
            {
                log = File.AppendText(logFile); log.WriteLine(outputMessage); log.Close();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables.
            string gameName;
            double gamePrice, taxRate, taxAmount, totalPrice, markupRate, markupAmount, finalPrice;
            bool priceValid;

            //Assigning variables.
            gameName = txtGameName.Text;
            //gamePrice = double.Parse(txtGamePrice.Text);
            priceValid = double.TryParse(txtGamePrice.Text, out gamePrice); //Returns whether TryParse worked or not.
            taxRate = 0.0875;
            markupRate = 0.0;

            if (priceValid)
            {
                switch (platformType)
                {
                    case PC:
                        markupRate = markupRatePC;
                        break;
                    case PLAYSTATION:
                        markupRate = markupRatePlayStation;
                        break;
                    case XBOX:
                        markupRate = markupRateXbox;
                        break;
                    default:
                        lstOutput.Items.Add("This should never happen.");
                        break;
                }

                //Calculations.
                taxAmount = gamePrice * taxRate;
                totalPrice = gamePrice + taxAmount;
                markupAmount = totalPrice * markupRate;
                finalPrice = totalPrice + markupAmount;

                //Output.
                OutputDisplay(DISPLAY_LOGFILE, "--------- Beginning of Transaction ---------");
                OutputDisplay(DISPLAY_BOTH, "Game: " + gameName);
                OutputDisplay(DISPLAY_BOTH, "Platform: " + platformType);
                OutputDisplay(DISPLAY_BOTH, "Price: " + gamePrice.ToString("C"));
                OutputDisplay(DISPLAY_BOTH, "Tax Amount: " + taxAmount.ToString("C") + " (Tax Rate: " + taxRate.ToString("P") + ")");
                OutputDisplay(DISPLAY_BOTH, "Total Price: " + totalPrice.ToString("C"));
                OutputDisplay(DISPLAY_BOTH, "Markup Amount: " + markupAmount.ToString("C") + " (Markup Rate: " + markupRate.ToString("P") + ")");
                OutputDisplay(DISPLAY_BOTH, "Final Price: " + finalPrice.ToString("C"));
                OutputDisplay(DISPLAY_LOGFILE, "---------  [" + DateTime.Now.ToString("G") + "]  ---------");
            }
            else { lstOutput.Items.Add("Invalid price value."); }

            //Setting the Focus.
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