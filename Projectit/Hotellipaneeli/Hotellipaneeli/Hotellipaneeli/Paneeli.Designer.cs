namespace Hotellipaneeli
{
    partial class PaneeliFM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ValikkoMS = new MenuStrip();
            hallitseAsiakTSMI = new ToolStripMenuItem();
            hallitseVarauksiaTSMI = new ToolStripMenuItem();
            hallitseHuoneitaTSMI = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ValikkoMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ValikkoMS
            // 
            ValikkoMS.BackColor = Color.Gold;
            ValikkoMS.Items.AddRange(new ToolStripItem[] { hallitseAsiakTSMI, hallitseVarauksiaTSMI, hallitseHuoneitaTSMI });
            ValikkoMS.Location = new Point(0, 0);
            ValikkoMS.Name = "ValikkoMS";
            ValikkoMS.Size = new Size(800, 24);
            ValikkoMS.TabIndex = 0;
            ValikkoMS.Text = "menuStrip1";
            // 
            // hallitseAsiakTSMI
            // 
            hallitseAsiakTSMI.Name = "hallitseAsiakTSMI";
            hallitseAsiakTSMI.Size = new Size(114, 20);
            hallitseAsiakTSMI.Text = "Hallitse Asiakkaita";
            hallitseAsiakTSMI.Click += hallitseAsiakTSMI_Click;
            // 
            // hallitseVarauksiaTSMI
            // 
            hallitseVarauksiaTSMI.Name = "hallitseVarauksiaTSMI";
            hallitseVarauksiaTSMI.Size = new Size(110, 20);
            hallitseVarauksiaTSMI.Text = "Hallitse Varauksia";
            hallitseVarauksiaTSMI.Click += hallitseVarauksiaTSMI_Click;
            // 
            // hallitseHuoneitaTSMI
            // 
            hallitseHuoneitaTSMI.Name = "hallitseHuoneitaTSMI";
            hallitseHuoneitaTSMI.Size = new Size(110, 20);
            hallitseHuoneitaTSMI.Text = "Hallitse Huoneita";
            hallitseHuoneitaTSMI.Click += hallitseHuoneitaTSMI_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.point3d_commercial_imaging_ltd_i1kzMmWYQT4_unsplash;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(325, 96);
            label1.TabIndex = 2;
            label1.Text = "Tervetuloa Hotelli Paneeliin.\r\nValitse valikosta, mitä haluat\r\ntehdä.";
            // 
            // PaneeliFM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 412);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ValikkoMS);
            ForeColor = Color.Gold;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = ValikkoMS;
            Name = "PaneeliFM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paneeli";
            Load += PaneeliFM_Load;
            ValikkoMS.ResumeLayout(false);
            ValikkoMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ValikkoMS;
        private ToolStripMenuItem hallitseAsiakTSMI;
        private ToolStripMenuItem hallitseVarauksiaTSMI;
        private ToolStripMenuItem hallitseHuoneitaTSMI;
        private PictureBox pictureBox1;
        private Label label1;
    }
}