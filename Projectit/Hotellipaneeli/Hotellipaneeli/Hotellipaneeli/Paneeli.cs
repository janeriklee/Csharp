using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellipaneeli
{
    public partial class PaneeliFM : Form
    {
        public PaneeliFM()
        {
            InitializeComponent();
        }

        private void PaneeliFM_Load(object sender, EventArgs e)
        {

        }

        private void hallitseAsiakTSMI_Click(object sender, EventArgs e)
        {
            AsiakasFM asiakasForm = new AsiakasFM();
            asiakasForm.Show();
        }

        private void hallitseVarauksiaTSMI_Click(object sender, EventArgs e)
        {
            VarauksetFM varauksetForm = new VarauksetFM();
            varauksetForm.Show();
        }

        private void hallitseHuoneitaTSMI_Click(object sender, EventArgs e)
        {
            HuoneetFM huoneetForm = new HuoneetFM();
            huoneetForm.Show();
        }
    }
}
