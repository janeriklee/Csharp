namespace Harjoitus1
{
    partial class H1FM
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
            OtsikkoLB = new Label();
            VaihdaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(335, 50);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(94, 32);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Otsikko";
            // 
            // VaihdaBT
            // 
            VaihdaBT.BackColor = SystemColors.Highlight;
            VaihdaBT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VaihdaBT.ForeColor = SystemColors.Control;
            VaihdaBT.Location = new Point(309, 85);
            VaihdaBT.Name = "VaihdaBT";
            VaihdaBT.Size = new Size(142, 46);
            VaihdaBT.TabIndex = 1;
            VaihdaBT.Text = "Muuta teksti";
            VaihdaBT.UseVisualStyleBackColor = false;
            VaihdaBT.Click += VaihdaBT_Click;
            // 
            // H1FM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VaihdaBT);
            Controls.Add(OtsikkoLB);
            Name = "H1FM";
            Text = "Harjoitus 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Button VaihdaBT;
    }
}