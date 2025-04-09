namespace Nay_Aung_Latt
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 f1)
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

            sw = File.CreateText(form1.configFile);
            sw.Close();
        }
    }
}
