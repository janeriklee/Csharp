namespace Harjoitus14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:/Users/Jan Erik/source/repos/Csharp/Forms/Harjoitus14/p�iv�kirja.txt");
            TekstiRTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += TekstiRTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/Users/Jan Erik/source/repos/Csharp/Forms/Harjoitus14/p�iv�kirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}