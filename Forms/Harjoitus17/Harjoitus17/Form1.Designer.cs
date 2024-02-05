namespace Harjoitus17
{
    partial class NotepadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
            RikasTB = new RichTextBox();
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            uusiToolStripMenuItem = new ToolStripMenuItem();
            avaaToolStripMenuItem = new ToolStripMenuItem();
            tallennaToolStripMenuItem = new ToolStripMenuItem();
            tallennaNimelläToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tulostuksenEsikatseluToolStripMenuItem = new ToolStripMenuItem();
            tulostaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            muokkaaToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            kopioiToolStripMenuItem = new ToolStripMenuItem();
            leikkaaToolStripMenuItem = new ToolStripMenuItem();
            liitäToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            valitseKaikkiToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            poistaToolStripMenuItem = new ToolStripMenuItem();
            muotoileToolStripMenuItem = new ToolStripMenuItem();
            kirjasinToolStripMenuItem = new ToolStripMenuItem();
            tekstinKorostusToolStripMenuItem = new ToolStripMenuItem();
            tekstinRivittysToolStripMenuItem = new ToolStripMenuItem();
            apuaToolStripMenuItem = new ToolStripMenuItem();
            tietoaToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            saveFileDialog1 = new SaveFileDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            pageSetupDialog1 = new PageSetupDialog();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            colorDialog1 = new ColorDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RikasTB
            // 
            RikasTB.Dock = DockStyle.Fill;
            RikasTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RikasTB.Location = new Point(0, 24);
            RikasTB.Name = "RikasTB";
            RikasTB.Size = new Size(800, 426);
            RikasTB.TabIndex = 0;
            RikasTB.Text = "";
            RikasTB.WordWrap = false;
            RikasTB.TextChanged += RikasTB_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, muokkaaToolStripMenuItem, muotoileToolStripMenuItem, apuaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uusiToolStripMenuItem, avaaToolStripMenuItem, tallennaToolStripMenuItem, tallennaNimelläToolStripMenuItem, toolStripSeparator1, tulostuksenEsikatseluToolStripMenuItem, tulostaToolStripMenuItem, toolStripSeparator2, poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(64, 20);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            uusiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            uusiToolStripMenuItem.Size = new Size(191, 22);
            uusiToolStripMenuItem.Text = "Uusi";
            uusiToolStripMenuItem.Click += uusiToolStripMenuItem_Click;
            // 
            // avaaToolStripMenuItem
            // 
            avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            avaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            avaaToolStripMenuItem.Size = new Size(191, 22);
            avaaToolStripMenuItem.Text = "Avaa";
            avaaToolStripMenuItem.Click += avaaToolStripMenuItem_Click;
            // 
            // tallennaToolStripMenuItem
            // 
            tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            tallennaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            tallennaToolStripMenuItem.Size = new Size(191, 22);
            tallennaToolStripMenuItem.Text = "Tallenna";
            tallennaToolStripMenuItem.Click += tallennaToolStripMenuItem_Click;
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            tallennaNimelläToolStripMenuItem.Size = new Size(191, 22);
            tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä...";
            tallennaNimelläToolStripMenuItem.Click += tallennaNimelläToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(188, 6);
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            tulostuksenEsikatseluToolStripMenuItem.Size = new Size(191, 22);
            tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            tulostuksenEsikatseluToolStripMenuItem.Click += tulostuksenEsikatseluToolStripMenuItem_Click;
            // 
            // tulostaToolStripMenuItem
            // 
            tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            tulostaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            tulostaToolStripMenuItem.Size = new Size(191, 22);
            tulostaToolStripMenuItem.Text = "Tulosta";
            tulostaToolStripMenuItem.Click += tulostaToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(188, 6);
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            poistuToolStripMenuItem.Size = new Size(191, 22);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // muokkaaToolStripMenuItem
            // 
            muokkaaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, kopioiToolStripMenuItem, leikkaaToolStripMenuItem, liitäToolStripMenuItem, toolStripSeparator4, valitseKaikkiToolStripMenuItem, toolStripSeparator6, poistaToolStripMenuItem });
            muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            muokkaaToolStripMenuItem.Size = new Size(68, 20);
            muokkaaToolStripMenuItem.Text = "Muokkaa";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(182, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(182, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(179, 6);
            // 
            // kopioiToolStripMenuItem
            // 
            kopioiToolStripMenuItem.Enabled = false;
            kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            kopioiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopioiToolStripMenuItem.Size = new Size(182, 22);
            kopioiToolStripMenuItem.Text = "Kopioi";
            kopioiToolStripMenuItem.Click += kopioiToolStripMenuItem_Click;
            // 
            // leikkaaToolStripMenuItem
            // 
            leikkaaToolStripMenuItem.Enabled = false;
            leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            leikkaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            leikkaaToolStripMenuItem.Size = new Size(182, 22);
            leikkaaToolStripMenuItem.Text = "Leikkaa";
            leikkaaToolStripMenuItem.Click += leikkaaToolStripMenuItem_Click;
            // 
            // liitäToolStripMenuItem
            // 
            liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            liitäToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            liitäToolStripMenuItem.Size = new Size(182, 22);
            liitäToolStripMenuItem.Text = "Liitä";
            liitäToolStripMenuItem.Click += liitäToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(179, 6);
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            valitseKaikkiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            valitseKaikkiToolStripMenuItem.Size = new Size(182, 22);
            valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            valitseKaikkiToolStripMenuItem.Click += valitseKaikkiToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(179, 6);
            // 
            // poistaToolStripMenuItem
            // 
            poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            poistaToolStripMenuItem.Size = new Size(182, 22);
            poistaToolStripMenuItem.Text = "Poista";
            poistaToolStripMenuItem.Click += poistaToolStripMenuItem_Click;
            // 
            // muotoileToolStripMenuItem
            // 
            muotoileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kirjasinToolStripMenuItem, tekstinKorostusToolStripMenuItem, tekstinRivittysToolStripMenuItem });
            muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            muotoileToolStripMenuItem.Size = new Size(67, 20);
            muotoileToolStripMenuItem.Text = "Muotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            kirjasinToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            kirjasinToolStripMenuItem.Size = new Size(184, 22);
            kirjasinToolStripMenuItem.Text = "Kirjasin";
            kirjasinToolStripMenuItem.Click += kirjasinToolStripMenuItem_Click;
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            tekstinKorostusToolStripMenuItem.Size = new Size(184, 22);
            tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            tekstinKorostusToolStripMenuItem.Click += tekstinKorostusToolStripMenuItem_Click;
            // 
            // tekstinRivittysToolStripMenuItem
            // 
            tekstinRivittysToolStripMenuItem.Name = "tekstinRivittysToolStripMenuItem";
            tekstinRivittysToolStripMenuItem.Size = new Size(184, 22);
            tekstinRivittysToolStripMenuItem.Text = "Tekstin rivittys";
            tekstinRivittysToolStripMenuItem.Click += tekstinRivittysToolStripMenuItem_Click;
            // 
            // apuaToolStripMenuItem
            // 
            apuaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tietoaToolStripMenuItem });
            apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            apuaToolStripMenuItem.Size = new Size(47, 20);
            apuaToolStripMenuItem.Text = "Apua";
            // 
            // tietoaToolStripMenuItem
            // 
            tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            tietoaToolStripMenuItem.Size = new Size(106, 22);
            tietoaToolStripMenuItem.Text = "Tietoa";
            tietoaToolStripMenuItem.Click += tietoaToolStripMenuItem_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // NotepadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RikasTB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "NotepadForm";
            Text = "Muistio";
            Load += NotepadForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RikasTB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private ToolStripMenuItem tallennaToolStripMenuItem;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem kirjasinToolStripMenuItem;
        private FontDialog fontDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private PageSetupDialog pageSetupDialog1;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ColorDialog colorDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripMenuItem muokkaaToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem kopioiToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem leikkaaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem poistaToolStripMenuItem;
        private ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivittysToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripMenuItem tietoaToolStripMenuItem;
    }
}