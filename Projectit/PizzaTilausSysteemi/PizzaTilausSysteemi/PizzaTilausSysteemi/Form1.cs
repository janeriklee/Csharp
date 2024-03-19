namespace PizzaTilausSysteemi
{
    public partial class TilausPaneeliFM : Form
    {
        public TilausPaneeliFM()
        {
            InitializeComponent();

            VahvistaTilausLB.Click += VahvistaTilausLB_Click;
            TilaaLB.Click += TilaaLB_Click;
        }

        private void TilausPaneeliFM_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void JuustoRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VahvistaTilausPL_Paint(object sender, PaintEventArgs e)
        {

        }
        private void VahvistaTilausLB_Click(object sender, EventArgs e)
        {
            MaksaTilausPL.Visible = false;
            VahvistaTilausPL.Visible = true;
            TilaaPL.Visible = false;

            VahvistaTilausLB.Font = new Font(VahvistaTilausLB.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
            MaksaTilausLB.Font = new Font(VahvistaTilausLB.Font, FontStyle.Bold | FontStyle.Underline);
            TilaaLB.Font = new Font(TilaaLB.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void TilaaLB_Click(object sender, EventArgs e)
        {
            MaksaTilausPL.Visible = false;
            VahvistaTilausPL.Visible = false;
            TilaaPL.Visible = true;

            VahvistaTilausLB.Font = new Font(VahvistaTilausLB.Font, FontStyle.Bold | FontStyle.Underline);
            MaksaTilausLB.Font = new Font(VahvistaTilausLB.Font, FontStyle.Bold | FontStyle.Underline);
            TilaaLB.Font = new Font(TilaaLB.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaksaTilausLB_Click(object sender, EventArgs e)
        {
            VahvistaTilausPL.Visible = false;
            TilaaPL.Visible = false;
            MaksaTilausPL.Visible = true;

            VahvistaTilausLB.Font = new Font(VahvistaTilausLB.Font, FontStyle.Bold | FontStyle.Underline);
            TilaaLB.Font = new Font(VahvistaTilausLB.Font, FontStyle.Bold | FontStyle.Underline);
            MaksaTilausLB.Font = new Font(TilaaLB.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
        }
    }
}