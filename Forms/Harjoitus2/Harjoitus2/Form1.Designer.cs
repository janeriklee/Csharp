namespace Harjoitus2
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
            OtiskkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtiskkoLB
            // 
            OtiskkoLB.AutoSize = true;
            OtiskkoLB.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OtiskkoLB.Location = new Point(46, 45);
            OtiskkoLB.Name = "OtiskkoLB";
            OtiskkoLB.Size = new Size(288, 33);
            OtiskkoLB.TabIndex = 0;
            OtiskkoLB.Text = "Anna tulostettava teksti:";
            OtiskkoLB.Click += label1_Click;
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TulostusLB.Location = new Point(46, 91);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(72, 33);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            TulostusLB.Click += label1_Click_1;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ViestiTB.Location = new Point(340, 45);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(282, 34);
            ViestiTB.TabIndex = 2;
            ViestiTB.TextChanged += textBox1_TextChanged;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Location = new Point(469, 85);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(153, 30);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtiskkoLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtiskkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}