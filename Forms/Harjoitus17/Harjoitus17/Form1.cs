using System.Windows.Forms;

namespace Harjoitus17
{
    public partial class NotepadForm : Form
    {
        string tiedostoPolku = "";
        public NotepadForm()
        {
            InitializeComponent();
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {

        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RikasTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                RikasTB.Text = "";
            }
            else
            {
                RikasTB.Text = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "TextDocument|*.txt|Rikastekstiformaatti|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    string fileContent;
                    using (StreamReader reader = new StreamReader(atk.FileName))
                    {
                        Task<string> teksti = reader.ReadToEndAsync();
                        fileContent = teksti.Result;
                    }

                    if (Path.GetExtension(atk.FileName).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                    {
                        RikasTB.Rtf = fileContent;
                    }
                    else if (Path.GetExtension(atk.FileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        RikasTB.Text = fileContent;
                    }
                }
            }
        }


        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                { Filter = "TextDocument|*.txt|Rikastekstiformaatti|*.rtf", ValidateNames = true })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.RikasTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostoPolku))
                {
                    vk.WriteLineAsync(RikasTB.Rtf);
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt|Rikastekstiformaatti|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(RikasTB.Text);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            RikasTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RikasTB.Text, RikasTB.Font, Brushes.Black, 12, 10);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Copy();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Paste();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Cut();
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.SelectAll();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.SelectedText = "";
        }

        private void RikasTB_TextChanged(object sender, EventArgs e)
        {
            if (RikasTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

        private void tekstinRivittysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tekstinRivittysToolStripMenuItem.Checked == true)
            {
                tekstinRivittysToolStripMenuItem.Checked = false;
                RikasTB.WordWrap = false;
            }
            else
            {
                tekstinRivittysToolStripMenuItem.Checked = true;
                RikasTB.WordWrap = true;
            }
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.SelectionBackColor = Color.Yellow;
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }
    }
}