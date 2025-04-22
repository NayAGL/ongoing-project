namespace Nay_Aung_Latt
{
    internal partial class Form2 : Form
    {
        Form1 form1;
        internal Form2(Form1 f1)
        {
            InitializeComponent();
            form1 = f1;
        }

        private void btnReturnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw;

            //Settings form1 Properties.
            form1.MarkupRatePC = double.Parse(txtPC.Text);
            form1.MarkupRatePlayStation = double.Parse(txtPlayStation.Text);
            form1.MarkupRateXbox = double.Parse(txtXbox.Text);

            //Opens the 'configFile.txt' file to add values.
            sw = File.CreateText(form1.configFile);
            //Saves the Properties in the file.
            sw.WriteLine(form1.MarkupRatePC.ToString());
            sw.WriteLine(form1.MarkupRatePlayStation.ToString());
            sw.WriteLine(form1.MarkupRateXbox.ToString());
            //Closes the 'configFile.txt' file.
            sw.Close();
            //Hides the dialog after clicking the 'Return & Save' button.
            this.Hide();
        }
    }
}
