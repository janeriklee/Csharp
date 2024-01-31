namespace Harjoitus15
{
    partial class Ajastin
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
            components = new System.ComponentModel.Container();
            AjastinTM = new System.Windows.Forms.Timer(components);
            KelloLB = new Label();
            button1 = new Button();
            StartBT = new Button();
            button3 = new Button();
            ResetBT = new Button();
            StopBT = new Button();
            SuspendLayout();
            // 
            // AjastinTM
            // 
            AjastinTM.Enabled = true;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // KelloLB
            // 
            KelloLB.AutoSize = true;
            KelloLB.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            KelloLB.Location = new Point(12, 9);
            KelloLB.Name = "KelloLB";
            KelloLB.Size = new Size(394, 86);
            KelloLB.TabIndex = 0;
            KelloLB.Text = "00:00:00.000";
            KelloLB.Click += KelloLB_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 109);
            button1.Name = "button1";
            button1.Size = new Size(69, 36);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // StartBT
            // 
            StartBT.Location = new Point(27, 109);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(69, 36);
            StartBT.TabIndex = 1;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // button3
            // 
            button3.Location = new Point(170, 108);
            button3.Name = "button3";
            button3.Size = new Size(69, 36);
            button3.TabIndex = 2;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = true;
            // 
            // ResetBT
            // 
            ResetBT.Location = new Point(315, 108);
            ResetBT.Name = "ResetBT";
            ResetBT.Size = new Size(69, 36);
            ResetBT.TabIndex = 3;
            ResetBT.Text = "Reset";
            ResetBT.UseVisualStyleBackColor = true;
            ResetBT.Click += ResetBT_Click;
            // 
            // StopBT
            // 
            StopBT.Location = new Point(170, 109);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(69, 36);
            StopBT.TabIndex = 2;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // Ajastin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 169);
            Controls.Add(ResetBT);
            Controls.Add(StopBT);
            Controls.Add(button3);
            Controls.Add(StartBT);
            Controls.Add(button1);
            Controls.Add(KelloLB);
            Name = "Ajastin";
            Text = "Sekunttikello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer AjastinTM;
        private Label KelloLB;
        private Button button1;
        private Button StartBT;
        private Button button3;
        private Button ResetBT;
        private Button StopBT;
    }
}