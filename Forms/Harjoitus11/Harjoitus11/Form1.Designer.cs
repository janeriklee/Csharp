namespace Harjoitus11
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
            Noppa01PB = new PictureBox();
            Noppa02PB = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 51);
            label1.TabIndex = 0;
            label1.Text = "Nopan heitto";
            // 
            // Noppa01PB
            // 
            Noppa01PB.Image = Properties.Resources.dice01;
            Noppa01PB.Location = new Point(11, 72);
            Noppa01PB.Name = "Noppa01PB";
            Noppa01PB.Size = new Size(112, 106);
            Noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            Noppa01PB.TabIndex = 1;
            Noppa01PB.TabStop = false;
            Noppa01PB.Click += pictureBox1_Click;
            // 
            // Noppa02PB
            // 
            Noppa02PB.Image = Properties.Resources.dice01;
            Noppa02PB.Location = new Point(144, 72);
            Noppa02PB.Name = "Noppa02PB";
            Noppa02PB.Size = new Size(112, 106);
            Noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            Noppa02PB.TabIndex = 2;
            Noppa02PB.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(11, 195);
            button1.Name = "button1";
            button1.Size = new Size(245, 52);
            button1.TabIndex = 3;
            button1.Text = "Heitä";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 259);
            Controls.Add(button1);
            Controls.Add(Noppa02PB);
            Controls.Add(Noppa01PB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Nopanheitto";
            ((System.ComponentModel.ISupportInitialize)Noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)Noppa02PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox Noppa01PB;
        private PictureBox Noppa02PB;
        private Button button1;
    }
}