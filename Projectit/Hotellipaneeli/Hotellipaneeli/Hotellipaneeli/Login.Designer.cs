namespace Hotellipaneeli
{
    partial class LoginFM
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            KayttajanimiTB = new TextBox();
            SalasanaTB = new TextBox();
            KirjauduBT = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_icon;
            pictureBox1.Location = new Point(109, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.WaitOnLoad = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 68);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, -3);
            label1.Name = "label1";
            label1.Size = new Size(203, 65);
            label1.TabIndex = 0;
            label1.Text = "Kirjaudu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 276);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 2;
            label2.Text = "Käyttäjänimi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 315);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 3;
            label3.Text = "Salasana:";
            // 
            // KayttajanimiTB
            // 
            KayttajanimiTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            KayttajanimiTB.Location = new Point(150, 277);
            KayttajanimiTB.Name = "KayttajanimiTB";
            KayttajanimiTB.Size = new Size(221, 33);
            KayttajanimiTB.TabIndex = 4;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SalasanaTB.Location = new Point(150, 316);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(221, 33);
            SalasanaTB.TabIndex = 5;
            SalasanaTB.UseSystemPasswordChar = true;
            // 
            // KirjauduBT
            // 
            KirjauduBT.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            KirjauduBT.Location = new Point(12, 364);
            KirjauduBT.Name = "KirjauduBT";
            KirjauduBT.Size = new Size(359, 46);
            KirjauduBT.TabIndex = 6;
            KirjauduBT.Text = "Kirjaudu";
            KirjauduBT.UseVisualStyleBackColor = true;
            KirjauduBT.Click += button1_Click;
            // 
            // LoginFM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(383, 421);
            Controls.Add(KirjauduBT);
            Controls.Add(SalasanaTB);
            Controls.Add(KayttajanimiTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginFM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kirjaudu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox KayttajanimiTB;
        private TextBox SalasanaTB;
        private Button KirjauduBT;
    }
}