namespace Harjoitus13
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
            VastausLB = new Label();
            NimiTB = new TextBox();
            TarkastaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(538, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkistan, onko se 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.Location = new Point(12, 48);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(76, 25);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // NimiTB
            // 
            NimiTB.BorderStyle = BorderStyle.FixedSingle;
            NimiTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NimiTB.Location = new Point(556, 9);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(168, 29);
            NimiTB.TabIndex = 2;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TarkastaBT.Location = new Point(624, 44);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(100, 42);
            TarkastaBT.TabIndex = 3;
            TarkastaBT.Text = "Tarkasta";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 102);
            Controls.Add(TarkastaBT);
            Controls.Add(NimiTB);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private TextBox NimiTB;
        private Button TarkastaBT;
    }
}