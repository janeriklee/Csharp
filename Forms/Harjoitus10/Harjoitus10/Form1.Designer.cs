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
            AsteetTB = new TextBox();
            CelsiusRB = new RadioButton();
            FahrenheitRB = new RadioButton();
            label2 = new Label();
            MuunnaBT = new Button();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            AsteetTB.BorderStyle = BorderStyle.FixedSingle;
            AsteetTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AsteetTB.Location = new Point(118, 55);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(54, 29);
            AsteetTB.TabIndex = 1;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CelsiusRB.Location = new Point(191, 55);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(70, 20);
            CelsiusRB.TabIndex = 2;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            CelsiusRB.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FahrenheitRB.ForeColor = SystemColors.ControlText;
            FahrenheitRB.Location = new Point(191, 80);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(94, 20);
            FahrenheitRB.TabIndex = 3;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            FahrenheitRB.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 31);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 4;
            label2.Text = "Mihin muunnat?";
            label2.Click += label2_Click;
            // 
            // MuunnaBT
            // 
            MuunnaBT.FlatStyle = FlatStyle.Flat;
            MuunnaBT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MuunnaBT.Location = new Point(356, 58);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(75, 29);
            MuunnaBT.TabIndex = 5;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = true;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VastausLB.Location = new Point(12, 140);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(64, 21);
            VastausLB.TabIndex = 6;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 170);
            Controls.Add(VastausLB);
            Controls.Add(MuunnaBT);
            Controls.Add(label2);
            Controls.Add(FahrenheitRB);
            Controls.Add(CelsiusRB);
            Controls.Add(AsteetTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Celsius/Fahreinheit muuntaja";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AsteetTB;
        private RadioButton CelsiusRB;
        private RadioButton FahrenheitRB;
        private Label label2;
        private Button MuunnaBT;
        private Label VastausLB;
    }
}