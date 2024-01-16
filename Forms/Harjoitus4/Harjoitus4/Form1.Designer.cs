namespace Harjoitus4
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
            SyntymaAikaDT = new DateTimePicker();
            button1 = new Button();
            VuosinaLB = new Label();
            KuukausinaLB = new Label();
            PaivinaLB = new Label();
            TunteinaLB = new Label();
            MinuutteinaLB = new Label();
            SekuntteinaLB = new Label();
            SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            SyntymaAikaDT.Location = new Point(12, 12);
            SyntymaAikaDT.Name = "SyntymaAikaDT";
            SyntymaAikaDT.Size = new Size(200, 23);
            SyntymaAikaDT.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(230, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Laske";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VuosinaLB
            // 
            VuosinaLB.AutoSize = true;
            VuosinaLB.Location = new Point(12, 48);
            VuosinaLB.Name = "VuosinaLB";
            VuosinaLB.Size = new Size(49, 15);
            VuosinaLB.TabIndex = 2;
            VuosinaLB.Text = "Vuosina";
            VuosinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            KuukausinaLB.AutoSize = true;
            KuukausinaLB.Location = new Point(12, 79);
            KuukausinaLB.Name = "KuukausinaLB";
            KuukausinaLB.Size = new Size(68, 15);
            KuukausinaLB.TabIndex = 3;
            KuukausinaLB.Text = "Kuukausina";
            KuukausinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            PaivinaLB.AutoSize = true;
            PaivinaLB.Location = new Point(12, 112);
            PaivinaLB.Name = "PaivinaLB";
            PaivinaLB.Size = new Size(45, 15);
            PaivinaLB.TabIndex = 4;
            PaivinaLB.Text = "Päivinä";
            PaivinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            TunteinaLB.AutoSize = true;
            TunteinaLB.Location = new Point(174, 48);
            TunteinaLB.Name = "TunteinaLB";
            TunteinaLB.Size = new Size(53, 15);
            TunteinaLB.TabIndex = 5;
            TunteinaLB.Text = "Tunteina";
            TunteinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            MinuutteinaLB.AutoSize = true;
            MinuutteinaLB.Location = new Point(174, 79);
            MinuutteinaLB.Name = "MinuutteinaLB";
            MinuutteinaLB.Size = new Size(72, 15);
            MinuutteinaLB.TabIndex = 6;
            MinuutteinaLB.Text = "Minuutteina";
            MinuutteinaLB.Visible = false;
            // 
            // SekuntteinaLB
            // 
            SekuntteinaLB.AutoSize = true;
            SekuntteinaLB.Location = new Point(174, 112);
            SekuntteinaLB.Name = "SekuntteinaLB";
            SekuntteinaLB.Size = new Size(69, 15);
            SekuntteinaLB.TabIndex = 7;
            SekuntteinaLB.Text = "Sekuntteina";
            SekuntteinaLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 139);
            Controls.Add(SekuntteinaLB);
            Controls.Add(MinuutteinaLB);
            Controls.Add(TunteinaLB);
            Controls.Add(PaivinaLB);
            Controls.Add(KuukausinaLB);
            Controls.Add(VuosinaLB);
            Controls.Add(button1);
            Controls.Add(SyntymaAikaDT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button button1;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label PaivinaLB;
        private Label TunteinaLB;
        private Label MinuutteinaLB;
        private Label SekuntteinaLB;
    }
}