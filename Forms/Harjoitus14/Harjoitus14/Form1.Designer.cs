namespace Harjoitus14
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
            TallennaBT = new Button();
            TekstiRTB = new RichTextBox();
            SuspendLayout();
            // 
            // TallennaBT
            // 
            TallennaBT.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TallennaBT.Location = new Point(12, 366);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(776, 72);
            TallennaBT.TabIndex = 0;
            TallennaBT.Text = "Tallenna päiväkirjaan";
            TallennaBT.UseVisualStyleBackColor = true;
            TallennaBT.Click += TallennaBT_Click;
            // 
            // TekstiRTB
            // 
            TekstiRTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TekstiRTB.Location = new Point(12, 12);
            TekstiRTB.Name = "TekstiRTB";
            TekstiRTB.Size = new Size(776, 348);
            TekstiRTB.TabIndex = 1;
            TekstiRTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TekstiRTB);
            Controls.Add(TallennaBT);
            Name = "Form1";
            Text = "Päiväkirja";
            ResumeLayout(false);
        }

        #endregion

        private Button TallennaBT;
        private RichTextBox TekstiRTB;
    }
}