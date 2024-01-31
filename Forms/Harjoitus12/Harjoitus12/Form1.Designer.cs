namespace Harjoitus12
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
            KysymysLB = new Label();
            ARB = new RadioButton();
            BRB = new RadioButton();
            CRB = new RadioButton();
            DRB = new RadioButton();
            VastausLB = new Label();
            VastausARB = new RadioButton();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            KysymysLB.Location = new Point(12, 9);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(236, 30);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaus 1. kysymykseen:";
            KysymysLB.Click += KysymysLB_Click;
            // 
            // ARB
            // 
            ARB.AutoSize = true;
            ARB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ARB.Location = new Point(294, 49);
            ARB.Name = "ARB";
            ARB.Size = new Size(37, 24);
            ARB.TabIndex = 1;
            ARB.TabStop = true;
            ARB.Text = "A";
            ARB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            BRB.AutoSize = true;
            BRB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BRB.Location = new Point(294, 74);
            BRB.Name = "BRB";
            BRB.Size = new Size(36, 24);
            BRB.TabIndex = 2;
            BRB.TabStop = true;
            BRB.Text = "B";
            BRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            CRB.AutoSize = true;
            CRB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CRB.Location = new Point(294, 99);
            CRB.Name = "CRB";
            CRB.Size = new Size(36, 24);
            CRB.TabIndex = 3;
            CRB.TabStop = true;
            CRB.Text = "C";
            CRB.UseVisualStyleBackColor = true;
            // 
            // DRB
            // 
            DRB.AutoSize = true;
            DRB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DRB.Location = new Point(293, 124);
            DRB.Name = "DRB";
            DRB.Size = new Size(38, 24);
            DRB.TabIndex = 4;
            DRB.TabStop = true;
            DRB.Text = "D";
            DRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.Location = new Point(12, 163);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(83, 30);
            VastausLB.TabIndex = 5;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // VastausARB
            // 
            VastausARB.AutoCheck = false;
            VastausARB.AutoSize = true;
            VastausARB.Location = new Point(248, 171);
            VastausARB.Name = "VastausARB";
            VastausARB.Size = new Size(86, 19);
            VastausARB.TabIndex = 6;
            VastausARB.TabStop = true;
            VastausARB.Text = "VastausARB";
            VastausARB.UseVisualStyleBackColor = true;
            VastausARB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 202);
            Controls.Add(VastausARB);
            Controls.Add(VastausLB);
            Controls.Add(DRB);
            Controls.Add(CRB);
            Controls.Add(BRB);
            Controls.Add(ARB);
            Controls.Add(KysymysLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private RadioButton ARB;
        private RadioButton BRB;
        private RadioButton CRB;
        private RadioButton DRB;
        private Label VastausLB;
        private RadioButton VastausARB;
    }
}