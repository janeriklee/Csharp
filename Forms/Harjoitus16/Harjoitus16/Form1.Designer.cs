namespace Harjoitus16
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
            components = new System.ComponentModel.Container();
            MinuutitCB = new ComboBox();
            SekunnitCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AikaLB = new Label();
            StartBT = new Button();
            StopBT = new Button();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MinuutitCB
            // 
            MinuutitCB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MinuutitCB.FormattingEnabled = true;
            MinuutitCB.Location = new Point(12, 37);
            MinuutitCB.Name = "MinuutitCB";
            MinuutitCB.Size = new Size(84, 38);
            MinuutitCB.TabIndex = 0;
            MinuutitCB.SelectedIndexChanged += MinuutitCB_SelectedIndexChanged;
            // 
            // SekunnitCB
            // 
            SekunnitCB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SekunnitCB.FormattingEnabled = true;
            SekunnitCB.Location = new Point(118, 37);
            SekunnitCB.Name = "SekunnitCB";
            SekunnitCB.Size = new Size(84, 38);
            SekunnitCB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 2;
            label1.Text = "Minuutit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 13);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 3;
            label2.Text = "Sekunnit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(118, 13);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 3;
            label3.Text = "Sekunnit:";
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            AikaLB.Location = new Point(12, 78);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(191, 86);
            AikaLB.TabIndex = 4;
            AikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            StartBT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartBT.Location = new Point(12, 176);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(93, 44);
            StartBT.TabIndex = 5;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // StopBT
            // 
            StopBT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StopBT.Location = new Point(109, 176);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(93, 44);
            StopBT.TabIndex = 6;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // AjastinTM
            // 
            AjastinTM.Interval = 1000;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 235);
            Controls.Add(StopBT);
            Controls.Add(StartBT);
            Controls.Add(AikaLB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SekunnitCB);
            Controls.Add(MinuutitCB);
            Name = "Form1";
            Text = "Ajastin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox MinuutitCB;
        private ComboBox SekunnitCB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label AikaLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}