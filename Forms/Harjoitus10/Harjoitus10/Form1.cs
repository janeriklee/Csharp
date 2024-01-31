namespace Harjoitus10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            if (bmi < 18.5)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Blue;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Blue;
                KuvausLB.Visible = true;
            }
            else if (bmi < 25)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
            }
            else if (bmi < 40)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Gold;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                KuvausLB.Visible = true;
            }
            else
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                KuvausLB.Visible = true;
            }
        }
    }
}