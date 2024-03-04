namespace Hotellipaneeli
{
    partial class HuoneetFM
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
            HallitseHuoneitaDGW = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Puhelin2TB = new TextBox();
            HuoneenNroTB = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            HuonetyyppiCB = new ComboBox();
            panel2 = new Panel();
            VapaanaEiRB = new RadioButton();
            VapaanaKyllaRB = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)HallitseHuoneitaDGW).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // HallitseHuoneitaDGW
            // 
            HallitseHuoneitaDGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HallitseHuoneitaDGW.Location = new Point(433, 102);
            HallitseHuoneitaDGW.Name = "HallitseHuoneitaDGW";
            HallitseHuoneitaDGW.RowTemplate.Height = 25;
            HallitseHuoneitaDGW.Size = new Size(343, 300);
            HallitseHuoneitaDGW.TabIndex = 31;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(55, 367);
            button4.Name = "button4";
            button4.Size = new Size(346, 35);
            button4.TabIndex = 30;
            button4.Text = "Tyhjennä Sarakkeet";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(55, 326);
            button3.Name = "button3";
            button3.Size = new Size(158, 35);
            button3.TabIndex = 29;
            button3.Text = "Lisää Uusi Huone";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(219, 326);
            button2.Name = "button2";
            button2.Size = new Size(98, 35);
            button2.TabIndex = 28;
            button2.Text = "Muokkaa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(323, 326);
            button1.Name = "button1";
            button1.Size = new Size(78, 35);
            button1.TabIndex = 27;
            button1.Text = "Poista";
            button1.UseVisualStyleBackColor = true;
            // 
            // Puhelin2TB
            // 
            Puhelin2TB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Puhelin2TB.Location = new Point(202, 185);
            Puhelin2TB.Name = "Puhelin2TB";
            Puhelin2TB.Size = new Size(193, 29);
            Puhelin2TB.TabIndex = 25;
            Puhelin2TB.TextChanged += Puhelin2TB_TextChanged;
            // 
            // HuoneenNroTB
            // 
            HuoneenNroTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HuoneenNroTB.Location = new Point(202, 106);
            HuoneenNroTB.Name = "HuoneenNroTB";
            HuoneenNroTB.Size = new Size(133, 29);
            HuoneenNroTB.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(104, 216);
            label6.Name = "label6";
            label6.Size = new Size(98, 30);
            label6.TabIndex = 21;
            label6.Text = "Vapaana:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(114, 181);
            label5.Name = "label5";
            label5.Size = new Size(87, 30);
            label5.TabIndex = 20;
            label5.Text = "Puhelin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(60, 141);
            label3.Name = "label3";
            label3.Size = new Size(142, 30);
            label3.TabIndex = 18;
            label3.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 102);
            label2.Name = "label2";
            label2.Size = new Size(147, 30);
            label2.TabIndex = 17;
            label2.Text = "Huoneen Nro:";
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
            label1.Location = new Point(203, 5);
            label1.Name = "label1";
            label1.Size = new Size(405, 65);
            label1.TabIndex = 0;
            label1.Text = "Hallitse Huoneita";
            // 
            // HuonetyyppiCB
            // 
            HuonetyyppiCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HuonetyyppiCB.FormattingEnabled = true;
            HuonetyyppiCB.Items.AddRange(new object[] { "Single", "Double", "Family", "Suite" });
            HuonetyyppiCB.Location = new Point(202, 145);
            HuonetyyppiCB.Name = "HuonetyyppiCB";
            HuonetyyppiCB.Size = new Size(193, 29);
            HuonetyyppiCB.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(VapaanaEiRB);
            panel2.Controls.Add(VapaanaKyllaRB);
            panel2.Location = new Point(201, 225);
            panel2.Name = "panel2";
            panel2.Size = new Size(134, 37);
            panel2.TabIndex = 33;
            // 
            // VapaanaEiRB
            // 
            VapaanaEiRB.AutoSize = true;
            VapaanaEiRB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            VapaanaEiRB.ForeColor = Color.Red;
            VapaanaEiRB.Location = new Point(84, 2);
            VapaanaEiRB.Name = "VapaanaEiRB";
            VapaanaEiRB.Size = new Size(47, 34);
            VapaanaEiRB.TabIndex = 1;
            VapaanaEiRB.TabStop = true;
            VapaanaEiRB.Text = "Ei";
            VapaanaEiRB.UseVisualStyleBackColor = true;
            // 
            // VapaanaKyllaRB
            // 
            VapaanaKyllaRB.AutoSize = true;
            VapaanaKyllaRB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            VapaanaKyllaRB.ForeColor = Color.Green;
            VapaanaKyllaRB.Location = new Point(3, 2);
            VapaanaKyllaRB.Name = "VapaanaKyllaRB";
            VapaanaKyllaRB.Size = new Size(73, 34);
            VapaanaKyllaRB.TabIndex = 0;
            VapaanaKyllaRB.TabStop = true;
            VapaanaKyllaRB.Text = "Kyllä";
            VapaanaKyllaRB.UseVisualStyleBackColor = true;
            // 
            // HuoneetFM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 412);
            Controls.Add(panel2);
            Controls.Add(HuonetyyppiCB);
            Controls.Add(HallitseHuoneitaDGW);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Puhelin2TB);
            Controls.Add(HuoneenNroTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "HuoneetFM";
            Text = "Hallitse Huoneita";
            Load += HuoneetFM_Load;
            ((System.ComponentModel.ISupportInitialize)HallitseHuoneitaDGW).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HallitseHuoneitaDGW;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox Puhelin2TB;
        private TextBox HuoneenNroTB;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private ComboBox HuonetyyppiCB;
        private Panel panel2;
        private RadioButton VapaanaEiRB;
        private RadioButton VapaanaKyllaRB;
    }
}