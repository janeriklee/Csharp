using System.Diagnostics;

namespace Harjoitus15
{
    public partial class Ajastin : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public Ajastin()
        {
            InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void KelloLB_Click(object sender, EventArgs e)
        {

        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            KelloLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}