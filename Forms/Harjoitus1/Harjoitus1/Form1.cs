namespace Harjoitus1
{
    public partial class H1FM : Form
    {
        public H1FM()
        {
            InitializeComponent();
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            if (OtsikkoLB.Text == "Otsikko")
            {
                OtsikkoLB.Text = "Heippa maailma";
            }
            else
            {
                OtsikkoLB.Text = "Otsikko";
            }
        }
    }
}