namespace Harjoitus9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            NumeroTB = new TextBox();
            VastausLB = new Label();
            MuutaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Viner Hand ITC", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(522, 78);
            label1.TabIndex = 0;
            label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(609, 31);
            label2.TabIndex = 1;
            label2.Text = "Anna numero 1-3999 väliltä, niin muutan sen roomalaiseksi:";
            // 
            // NumeroTB
            // 
            NumeroTB.BorderStyle = BorderStyle.FixedSingle;
            NumeroTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NumeroTB.Location = new Point(615, 83);
            NumeroTB.Name = "NumeroTB";
            NumeroTB.Size = new Size(100, 35);
            NumeroTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.BackColor = Color.Transparent;
            VastausLB.Font = new Font("Viner Hand ITC", 36F, FontStyle.Bold, GraphicsUnit.Point);
            VastausLB.ForeColor = Color.White;
            VastausLB.Location = new Point(12, 139);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(219, 78);
            VastausLB.TabIndex = 3;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            MuutaBT.FlatStyle = FlatStyle.Flat;
            MuutaBT.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MuutaBT.ForeColor = Color.Black;
            MuutaBT.Location = new Point(615, 154);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(100, 41);
            MuutaBT.TabIndex = 4;
            MuutaBT.Text = "Muuta";
            MuutaBT.UseVisualStyleBackColor = true;
            MuutaBT.Click += MuutaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(729, 250);
            Controls.Add(MuutaBT);
            Controls.Add(VastausLB);
            Controls.Add(NumeroTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Roomalaiset numerot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NumeroTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}