namespace Harjoitus10
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
            label2 = new Label();
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            LaskeBT = new Button();
            BmiLB = new Label();
            KuvausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "Anna paino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 1;
            label2.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            PainoTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PainoTB.Location = new Point(114, 21);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(80, 29);
            PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            PituusTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PituusTB.Location = new Point(114, 59);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(80, 29);
            PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LaskeBT.Location = new Point(12, 103);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(182, 29);
            LaskeBT.TabIndex = 4;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // BmiLB
            // 
            BmiLB.AutoSize = true;
            BmiLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BmiLB.Location = new Point(12, 144);
            BmiLB.Name = "BmiLB";
            BmiLB.Size = new Size(98, 21);
            BmiLB.TabIndex = 5;
            BmiLB.Text = "painoindeksi";
            // 
            // KuvausLB
            // 
            KuvausLB.AutoSize = true;
            KuvausLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KuvausLB.Location = new Point(12, 168);
            KuvausLB.Name = "KuvausLB";
            KuvausLB.Size = new Size(59, 21);
            KuvausLB.TabIndex = 6;
            KuvausLB.Text = "kuvaus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 198);
            Controls.Add(KuvausLB);
            Controls.Add(BmiLB);
            Controls.Add(LaskeBT);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BMI Laskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button LaskeBT;
        private Label BmiLB;
        private Label KuvausLB;
    }
}