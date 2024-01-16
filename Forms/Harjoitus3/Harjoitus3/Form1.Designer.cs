namespace Harjoitus3
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
            LukuYksiTB = new TextBox();
            LaskutoimitusCB = new ComboBox();
            LukuKaksiTB = new TextBox();
            label1 = new Label();
            VastausLB = new Label();
            LaskeTB = new Button();
            SuspendLayout();
            // 
            // LukuYksiTB
            // 
            LukuYksiTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LukuYksiTB.Location = new Point(28, 29);
            LukuYksiTB.Name = "LukuYksiTB";
            LukuYksiTB.Size = new Size(100, 35);
            LukuYksiTB.TabIndex = 0;
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(134, 26);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(47, 38);
            LaskutoimitusCB.TabIndex = 2;
            // 
            // LukuKaksiTB
            // 
            LukuKaksiTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LukuKaksiTB.Location = new Point(187, 29);
            LukuKaksiTB.Name = "LukuKaksiTB";
            LukuKaksiTB.Size = new Size(100, 35);
            LukuKaksiTB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(293, 32);
            label1.Name = "label1";
            label1.Size = new Size(27, 30);
            label1.TabIndex = 4;
            label1.Text = "=";
            label1.Click += label1_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.Location = new Point(317, 34);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(25, 30);
            VastausLB.TabIndex = 5;
            VastausLB.Text = "X";
            VastausLB.Click += label2_Click;
            // 
            // LaskeTB
            // 
            LaskeTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LaskeTB.Location = new Point(373, 24);
            LaskeTB.Name = "LaskeTB";
            LaskeTB.Size = new Size(80, 47);
            LaskeTB.TabIndex = 6;
            LaskeTB.Text = "Laske";
            LaskeTB.UseVisualStyleBackColor = true;
            LaskeTB.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 96);
            Controls.Add(LaskeTB);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Controls.Add(LukuKaksiTB);
            Controls.Add(LaskutoimitusCB);
            Controls.Add(LukuYksiTB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LukuYksiTB;
        private ComboBox LaskutoimitusCB;
        private TextBox LukuKaksiTB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeTB;
    }
}