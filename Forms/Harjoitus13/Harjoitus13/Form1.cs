using System.Web;

namespace Harjoitus13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Users/Jan Erik/source/repos/Csharp/Forms/Harjoitus13/Harjoitus13/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/Jan Erik/source/repos/Csharp/Forms/Harjoitus13/Harjoitus13/tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string poika in pojat)
            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi on vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            if (VastausLB.Visible == false) 
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimen joukosta! :(";
                VastausLB.Visible = true;
            }
        }
    }
}