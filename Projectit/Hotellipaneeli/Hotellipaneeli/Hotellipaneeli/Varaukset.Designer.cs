namespace Hotellipaneeli
{
    partial class VarauksetFM
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
            VarauksetDGW = new DataGridView();
            TyhjennaSarakkeetBT = new Button();
            LisaaVarausBT = new Button();
            MuokkaaBT = new Button();
            PoistaBT = new Button();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            HuonenumeroCB = new ComboBox();
            SisaanDP = new DateTimePicker();
            UlosDP = new DateTimePicker();
            AsiakasIdCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)VarauksetDGW).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // VarauksetDGW
            // 
            VarauksetDGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VarauksetDGW.Location = new Point(433, 102);
            VarauksetDGW.Name = "VarauksetDGW";
            VarauksetDGW.RowTemplate.Height = 25;
            VarauksetDGW.Size = new Size(343, 300);
            VarauksetDGW.TabIndex = 31;
            // 
            // TyhjennaSarakkeetBT
            // 
            TyhjennaSarakkeetBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TyhjennaSarakkeetBT.Location = new Point(55, 367);
            TyhjennaSarakkeetBT.Name = "TyhjennaSarakkeetBT";
            TyhjennaSarakkeetBT.Size = new Size(346, 35);
            TyhjennaSarakkeetBT.TabIndex = 30;
            TyhjennaSarakkeetBT.Text = "Tyhjennä Sarakkeet";
            TyhjennaSarakkeetBT.UseVisualStyleBackColor = true;
            TyhjennaSarakkeetBT.Click += TyhjennaSarakkeetBT_Click;
            // 
            // LisaaVarausBT
            // 
            LisaaVarausBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LisaaVarausBT.Location = new Point(55, 326);
            LisaaVarausBT.Name = "LisaaVarausBT";
            LisaaVarausBT.Size = new Size(158, 35);
            LisaaVarausBT.TabIndex = 29;
            LisaaVarausBT.Text = "Lisää uusi varaus";
            LisaaVarausBT.UseVisualStyleBackColor = true;
            LisaaVarausBT.Click += LisaaVarausBT_Click;
            // 
            // MuokkaaBT
            // 
            MuokkaaBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MuokkaaBT.Location = new Point(219, 326);
            MuokkaaBT.Name = "MuokkaaBT";
            MuokkaaBT.Size = new Size(98, 35);
            MuokkaaBT.TabIndex = 28;
            MuokkaaBT.Text = "Muokkaa";
            MuokkaaBT.UseVisualStyleBackColor = true;
            MuokkaaBT.Click += MuokkaaBT_Click;
            // 
            // PoistaBT
            // 
            PoistaBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PoistaBT.Location = new Point(323, 326);
            PoistaBT.Name = "PoistaBT";
            PoistaBT.Size = new Size(78, 35);
            PoistaBT.TabIndex = 27;
            PoistaBT.Text = "Poista";
            PoistaBT.UseVisualStyleBackColor = true;
            PoistaBT.Click += PoistaBT_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(83, 180);
            label6.Name = "label6";
            label6.Size = new Size(77, 30);
            label6.TabIndex = 21;
            label6.Text = "Sisään:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(-2, 138);
            label5.Name = "label5";
            label5.Size = new Size(162, 30);
            label5.TabIndex = 20;
            label5.Text = "Huone numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 101);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 17;
            label2.Text = "Asiakas ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 76);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(197, 6);
            label1.Name = "label1";
            label1.Size = new Size(411, 65);
            label1.TabIndex = 0;
            label1.Text = "Hallitse Varauksia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(100, 219);
            label7.Name = "label7";
            label7.Size = new Size(60, 30);
            label7.TabIndex = 32;
            label7.Text = "Ulos:";
            // 
            // HuonenumeroCB
            // 
            HuonenumeroCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HuonenumeroCB.FormattingEnabled = true;
            HuonenumeroCB.Location = new Point(166, 142);
            HuonenumeroCB.Name = "HuonenumeroCB";
            HuonenumeroCB.Size = new Size(235, 29);
            HuonenumeroCB.TabIndex = 35;
            // 
            // SisaanDP
            // 
            SisaanDP.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SisaanDP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SisaanDP.Location = new Point(166, 184);
            SisaanDP.Name = "SisaanDP";
            SisaanDP.Size = new Size(235, 25);
            SisaanDP.TabIndex = 36;
            // 
            // UlosDP
            // 
            UlosDP.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UlosDP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UlosDP.Location = new Point(166, 223);
            UlosDP.Name = "UlosDP";
            UlosDP.Size = new Size(235, 25);
            UlosDP.TabIndex = 37;
            // 
            // AsiakasIdCB
            // 
            AsiakasIdCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AsiakasIdCB.FormattingEnabled = true;
            AsiakasIdCB.Location = new Point(166, 102);
            AsiakasIdCB.Name = "AsiakasIdCB";
            AsiakasIdCB.Size = new Size(235, 29);
            AsiakasIdCB.TabIndex = 38;
            // 
            // VarauksetFM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 412);
            Controls.Add(AsiakasIdCB);
            Controls.Add(UlosDP);
            Controls.Add(SisaanDP);
            Controls.Add(HuonenumeroCB);
            Controls.Add(label7);
            Controls.Add(VarauksetDGW);
            Controls.Add(TyhjennaSarakkeetBT);
            Controls.Add(LisaaVarausBT);
            Controls.Add(MuokkaaBT);
            Controls.Add(PoistaBT);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VarauksetFM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Varausten Hallinta";
            ((System.ComponentModel.ISupportInitialize)VarauksetDGW).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView VarauksetDGW;
        private Button TyhjennaSarakkeetBT;
        private Button LisaaVarausBT;
        private Button MuokkaaBT;
        private Button PoistaBT;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private ComboBox HuonenumeroCB;
        private DateTimePicker SisaanDP;
        private DateTimePicker UlosDP;
        private ComboBox AsiakasIdCB;
    }
}