namespace Hotellipaneeli
{
    partial class AsiakasFM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SukunimiAsiakasTB = new TextBox();
            LahiosoiteAsiakasTB = new TextBox();
            PostinumeroAsiakasTB = new TextBox();
            KaupunkiAsiakasTB = new TextBox();
            PoistaBT = new Button();
            MuokkaaBT = new Button();
            LisaaUusiAsiakasBT = new Button();
            TyhjennaSarakkeetAsiakasBT = new Button();
            AsiakkaatDGW = new DataGridView();
            label2 = new Label();
            EtunimiAsiakasTB = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AsiakkaatDGW).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(195, 10);
            label1.Name = "label1";
            label1.Size = new Size(425, 65);
            label1.TabIndex = 0;
            label1.Text = "Hallitse Asiakkaita";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 144);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 2;
            label3.Text = "Sukunimi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 183);
            label4.Name = "label4";
            label4.Size = new Size(115, 30);
            label4.TabIndex = 3;
            label4.Text = "Lähiosoite:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 223);
            label5.Name = "label5";
            label5.Size = new Size(139, 30);
            label5.TabIndex = 4;
            label5.Text = "Postinumero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(53, 263);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 5;
            label6.Text = "Kaupunki:";
            // 
            // SukunimiAsiakasTB
            // 
            SukunimiAsiakasTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SukunimiAsiakasTB.Location = new Point(166, 145);
            SukunimiAsiakasTB.Name = "SukunimiAsiakasTB";
            SukunimiAsiakasTB.Size = new Size(235, 29);
            SukunimiAsiakasTB.TabIndex = 7;
            // 
            // LahiosoiteAsiakasTB
            // 
            LahiosoiteAsiakasTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LahiosoiteAsiakasTB.Location = new Point(166, 184);
            LahiosoiteAsiakasTB.Name = "LahiosoiteAsiakasTB";
            LahiosoiteAsiakasTB.Size = new Size(235, 29);
            LahiosoiteAsiakasTB.TabIndex = 8;
            // 
            // PostinumeroAsiakasTB
            // 
            PostinumeroAsiakasTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PostinumeroAsiakasTB.Location = new Point(166, 224);
            PostinumeroAsiakasTB.Name = "PostinumeroAsiakasTB";
            PostinumeroAsiakasTB.Size = new Size(235, 29);
            PostinumeroAsiakasTB.TabIndex = 9;
            // 
            // KaupunkiAsiakasTB
            // 
            KaupunkiAsiakasTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KaupunkiAsiakasTB.Location = new Point(166, 263);
            KaupunkiAsiakasTB.Name = "KaupunkiAsiakasTB";
            KaupunkiAsiakasTB.Size = new Size(235, 29);
            KaupunkiAsiakasTB.TabIndex = 10;
            // 
            // PoistaBT
            // 
            PoistaBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PoistaBT.Location = new Point(323, 326);
            PoistaBT.Name = "PoistaBT";
            PoistaBT.Size = new Size(78, 35);
            PoistaBT.TabIndex = 11;
            PoistaBT.Text = "Poista";
            PoistaBT.UseVisualStyleBackColor = true;
            PoistaBT.Click += PoistaBT_Click;
            // 
            // MuokkaaBT
            // 
            MuokkaaBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MuokkaaBT.Location = new Point(219, 326);
            MuokkaaBT.Name = "MuokkaaBT";
            MuokkaaBT.Size = new Size(98, 35);
            MuokkaaBT.TabIndex = 12;
            MuokkaaBT.Text = "Muokkaa";
            MuokkaaBT.UseVisualStyleBackColor = true;
            MuokkaaBT.Click += MuokkaaBT_Click;
            // 
            // LisaaUusiAsiakasBT
            // 
            LisaaUusiAsiakasBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LisaaUusiAsiakasBT.Location = new Point(55, 326);
            LisaaUusiAsiakasBT.Name = "LisaaUusiAsiakasBT";
            LisaaUusiAsiakasBT.Size = new Size(158, 35);
            LisaaUusiAsiakasBT.TabIndex = 13;
            LisaaUusiAsiakasBT.Text = "Lisää Uusi Asiakas";
            LisaaUusiAsiakasBT.UseVisualStyleBackColor = true;
            LisaaUusiAsiakasBT.Click += LisaaUusiAsiakasBT_Click;
            // 
            // TyhjennaSarakkeetAsiakasBT
            // 
            TyhjennaSarakkeetAsiakasBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TyhjennaSarakkeetAsiakasBT.Location = new Point(55, 367);
            TyhjennaSarakkeetAsiakasBT.Name = "TyhjennaSarakkeetAsiakasBT";
            TyhjennaSarakkeetAsiakasBT.Size = new Size(346, 35);
            TyhjennaSarakkeetAsiakasBT.TabIndex = 14;
            TyhjennaSarakkeetAsiakasBT.Text = "Tyhjennä Sarakkeet";
            TyhjennaSarakkeetAsiakasBT.UseVisualStyleBackColor = true;
            TyhjennaSarakkeetAsiakasBT.Click += TyhjennaSarakkeetAsiakasBT_Click;
            // 
            // AsiakkaatDGW
            // 
            AsiakkaatDGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AsiakkaatDGW.Location = new Point(433, 102);
            AsiakkaatDGW.Name = "AsiakkaatDGW";
            AsiakkaatDGW.RowTemplate.Height = 25;
            AsiakkaatDGW.Size = new Size(343, 300);
            AsiakkaatDGW.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 105);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 1;
            label2.Text = "Etunimi:";
            // 
            // EtunimiAsiakasTB
            // 
            EtunimiAsiakasTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EtunimiAsiakasTB.Location = new Point(166, 106);
            EtunimiAsiakasTB.Name = "EtunimiAsiakasTB";
            EtunimiAsiakasTB.Size = new Size(235, 29);
            EtunimiAsiakasTB.TabIndex = 6;
            // 
            // AsiakasFM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 412);
            Controls.Add(AsiakkaatDGW);
            Controls.Add(TyhjennaSarakkeetAsiakasBT);
            Controls.Add(LisaaUusiAsiakasBT);
            Controls.Add(MuokkaaBT);
            Controls.Add(PoistaBT);
            Controls.Add(KaupunkiAsiakasTB);
            Controls.Add(PostinumeroAsiakasTB);
            Controls.Add(LahiosoiteAsiakasTB);
            Controls.Add(SukunimiAsiakasTB);
            Controls.Add(EtunimiAsiakasTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AsiakasFM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asiakas hallinta";
            Load += AsiakasFM_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AsiakkaatDGW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox SukunimiAsiakasTB;
        private TextBox LahiosoiteAsiakasTB;
        private TextBox PostinumeroAsiakasTB;
        private TextBox KaupunkiAsiakasTB;
        private Button PoistaBT;
        private Button MuokkaaBT;
        private Button LisaaUusiAsiakasBT;
        private Button TyhjennaSarakkeetAsiakasBT;
        private DataGridView AsiakkaatDGW;
        private Label label2;
        private TextBox EtunimiAsiakasTB;
    }
}