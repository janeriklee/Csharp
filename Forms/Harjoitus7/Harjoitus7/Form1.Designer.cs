namespace Harjoitus7
{
    partial class Form1
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            LainanlyhennysTB = new TextBox();
            NesteetTB = new TextBox();
            VakuutusTB = new TextBox();
            PolttonesteTB = new TextBox();
            MuutkulutTB = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            RenkaatTB = new TextBox();
            HuollotTB = new TextBox();
            PesutTB = new TextBox();
            VastausLB = new Label();
            KilometritTB = new TextBox();
            laskeBN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 65);
            label1.TabIndex = 0;
            label1.Text = "Autokululaskuri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(22, 72);
            label3.Name = "label3";
            label3.Size = new Size(268, 30);
            label3.TabIndex = 1;
            label3.Text = "Lainan lyhennys korkoineen:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(22, 113);
            label4.Name = "label4";
            label4.Size = new Size(224, 30);
            label4.TabIndex = 2;
            label4.Text = "Listättävät nesteet yms:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(22, 154);
            label5.Name = "label5";
            label5.Size = new Size(169, 30);
            label5.TabIndex = 3;
            label5.Text = "Vakuutusmaksut:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(22, 195);
            label6.Name = "label6";
            label6.Size = new Size(118, 30);
            label6.TabIndex = 4;
            label6.Text = "Polttoneste:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(22, 236);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 5;
            label7.Text = "Muut kulut:";
            label7.Click += label7_Click;
            // 
            // LainanlyhennysTB
            // 
            LainanlyhennysTB.BorderStyle = BorderStyle.FixedSingle;
            LainanlyhennysTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LainanlyhennysTB.Location = new Point(296, 72);
            LainanlyhennysTB.Name = "LainanlyhennysTB";
            LainanlyhennysTB.Size = new Size(104, 35);
            LainanlyhennysTB.TabIndex = 6;
            LainanlyhennysTB.TextChanged += textBox1_TextChanged;
            // 
            // NesteetTB
            // 
            NesteetTB.BorderStyle = BorderStyle.FixedSingle;
            NesteetTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NesteetTB.Location = new Point(296, 113);
            NesteetTB.Name = "NesteetTB";
            NesteetTB.Size = new Size(104, 35);
            NesteetTB.TabIndex = 7;
            NesteetTB.TextChanged += textBox2_TextChanged;
            // 
            // VakuutusTB
            // 
            VakuutusTB.BorderStyle = BorderStyle.FixedSingle;
            VakuutusTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            VakuutusTB.Location = new Point(296, 154);
            VakuutusTB.Name = "VakuutusTB";
            VakuutusTB.Size = new Size(104, 35);
            VakuutusTB.TabIndex = 8;
            VakuutusTB.TextChanged += textBox3_TextChanged;
            // 
            // PolttonesteTB
            // 
            PolttonesteTB.BorderStyle = BorderStyle.FixedSingle;
            PolttonesteTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PolttonesteTB.Location = new Point(296, 195);
            PolttonesteTB.Name = "PolttonesteTB";
            PolttonesteTB.Size = new Size(104, 35);
            PolttonesteTB.TabIndex = 9;
            PolttonesteTB.TextChanged += textBox4_TextChanged;
            // 
            // MuutkulutTB
            // 
            MuutkulutTB.BorderStyle = BorderStyle.FixedSingle;
            MuutkulutTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MuutkulutTB.Location = new Point(296, 236);
            MuutkulutTB.Name = "MuutkulutTB";
            MuutkulutTB.Size = new Size(104, 35);
            MuutkulutTB.TabIndex = 10;
            MuutkulutTB.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(441, 74);
            label8.Name = "label8";
            label8.Size = new Size(67, 30);
            label8.TabIndex = 11;
            label8.Text = "Pesut:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(441, 113);
            label9.Name = "label9";
            label9.Size = new Size(84, 30);
            label9.TabIndex = 12;
            label9.Text = "Huollot:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(441, 154);
            label10.Name = "label10";
            label10.Size = new Size(91, 30);
            label10.TabIndex = 13;
            label10.Text = "Renkaat:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(441, 195);
            label11.Name = "label11";
            label11.Size = new Size(106, 30);
            label11.TabIndex = 14;
            label11.Text = "Kilometrit:";
            label11.Click += label11_Click;
            // 
            // RenkaatTB
            // 
            RenkaatTB.BorderStyle = BorderStyle.FixedSingle;
            RenkaatTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RenkaatTB.Location = new Point(553, 154);
            RenkaatTB.Name = "RenkaatTB";
            RenkaatTB.Size = new Size(104, 35);
            RenkaatTB.TabIndex = 16;
            RenkaatTB.TextChanged += textBox7_TextChanged;
            // 
            // HuollotTB
            // 
            HuollotTB.BorderStyle = BorderStyle.FixedSingle;
            HuollotTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            HuollotTB.Location = new Point(553, 113);
            HuollotTB.Name = "HuollotTB";
            HuollotTB.Size = new Size(104, 35);
            HuollotTB.TabIndex = 17;
            HuollotTB.TextChanged += textBox8_TextChanged;
            // 
            // PesutTB
            // 
            PesutTB.BorderStyle = BorderStyle.FixedSingle;
            PesutTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PesutTB.Location = new Point(553, 72);
            PesutTB.Name = "PesutTB";
            PesutTB.Size = new Size(104, 35);
            PesutTB.TabIndex = 18;
            PesutTB.TextChanged += textBox9_TextChanged;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.BorderStyle = BorderStyle.Fixed3D;
            VastausLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            VastausLB.Location = new Point(406, 243);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(69, 23);
            VastausLB.TabIndex = 19;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            VastausLB.TextChanged += VastausLB_TextChanged;
            VastausLB.Click += VastausLB_Click;
            // 
            // KilometritTB
            // 
            KilometritTB.BorderStyle = BorderStyle.FixedSingle;
            KilometritTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            KilometritTB.Location = new Point(553, 195);
            KilometritTB.Name = "KilometritTB";
            KilometritTB.Size = new Size(104, 35);
            KilometritTB.TabIndex = 20;
            KilometritTB.TextChanged += KilometritTB_TextChanged;
            // 
            // laskeBN
            // 
            laskeBN.FlatStyle = FlatStyle.Flat;
            laskeBN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            laskeBN.Location = new Point(553, 13);
            laskeBN.Name = "laskeBN";
            laskeBN.Size = new Size(104, 52);
            laskeBN.TabIndex = 21;
            laskeBN.Text = "Laske";
            laskeBN.UseVisualStyleBackColor = true;
            laskeBN.Click += laskeBN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 282);
            Controls.Add(laskeBN);
            Controls.Add(KilometritTB);
            Controls.Add(VastausLB);
            Controls.Add(PesutTB);
            Controls.Add(HuollotTB);
            Controls.Add(RenkaatTB);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(MuutkulutTB);
            Controls.Add(PolttonesteTB);
            Controls.Add(VakuutusTB);
            Controls.Add(NesteetTB);
            Controls.Add(LainanlyhennysTB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox LainanlyhennysTB;
        private TextBox NesteetTB;
        private TextBox VakuutusTB;
        private TextBox PolttonesteTB;
        private TextBox MuutkulutTB;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox RenkaatTB;
        private TextBox HuollotTB;
        private TextBox PesutTB;
        private Label VastausLB;
        private TextBox KilometritTB;
        private Button laskeBN;
    }
}