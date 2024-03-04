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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(150, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 33);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(150, 316);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 33);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 364);
            button1.Name = "button1";
            button1.Size = new Size(359, 46);
            button1.TabIndex = 6;
            button1.Text = "Kirjaudu";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoginFM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(383, 421);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LoginFM";
            Text = "Kirjaudu";
            Load += LoginFM_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}