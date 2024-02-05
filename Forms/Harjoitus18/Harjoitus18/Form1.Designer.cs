namespace Harjoitus18
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
            label2 = new Label();
            label3 = new Label();
            OppilaitoksetCB = new ComboBox();
            VastuuhenkilotCB = new ComboBox();
            KatuosoiteLB = new Label();
            PostinumeroLB = new Label();
            PostitoimipaikkaLB = new Label();
            PuhelinLB = new Label();
            TitteliLB = new Label();
            SijaintiLB = new Label();
            EmailLB = new Label();
            PhoneLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(409, 45);
            label1.TabIndex = 0;
            label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 1;
            label2.Text = "Valitse oppilaitos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(262, 73);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 2;
            label3.Text = "Valitse vastuuhenkilö:";
            // 
            // OppilaitoksetCB
            // 
            OppilaitoksetCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OppilaitoksetCB.FormattingEnabled = true;
            OppilaitoksetCB.Location = new Point(12, 106);
            OppilaitoksetCB.Name = "OppilaitoksetCB";
            OppilaitoksetCB.Size = new Size(127, 29);
            OppilaitoksetCB.TabIndex = 3;
            OppilaitoksetCB.SelectedIndexChanged += OppilaitoksetCB_SelectedIndexChanged;
            // 
            // VastuuhenkilotCB
            // 
            VastuuhenkilotCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            VastuuhenkilotCB.FormattingEnabled = true;
            VastuuhenkilotCB.Location = new Point(262, 106);
            VastuuhenkilotCB.Name = "VastuuhenkilotCB";
            VastuuhenkilotCB.Size = new Size(159, 29);
            VastuuhenkilotCB.TabIndex = 4;
            VastuuhenkilotCB.SelectedIndexChanged += VastuuhenkilotCB_SelectedIndexChanged;
            // 
            // KatuosoiteLB
            // 
            KatuosoiteLB.AutoSize = true;
            KatuosoiteLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KatuosoiteLB.Location = new Point(12, 147);
            KatuosoiteLB.Name = "KatuosoiteLB";
            KatuosoiteLB.Size = new Size(55, 21);
            KatuosoiteLB.TabIndex = 5;
            KatuosoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            PostinumeroLB.AutoSize = true;
            PostinumeroLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PostinumeroLB.Location = new Point(12, 177);
            PostinumeroLB.Name = "PostinumeroLB";
            PostinumeroLB.Size = new Size(82, 21);
            PostinumeroLB.TabIndex = 6;
            PostinumeroLB.Text = "Postikoodi";
            // 
            // PostitoimipaikkaLB
            // 
            PostitoimipaikkaLB.AutoSize = true;
            PostitoimipaikkaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PostitoimipaikkaLB.Location = new Point(12, 207);
            PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            PostitoimipaikkaLB.Size = new Size(75, 21);
            PostitoimipaikkaLB.TabIndex = 7;
            PostitoimipaikkaLB.Text = "Kaupunki";
            // 
            // PuhelinLB
            // 
            PuhelinLB.AutoSize = true;
            PuhelinLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PuhelinLB.Location = new Point(12, 237);
            PuhelinLB.Name = "PuhelinLB";
            PuhelinLB.Size = new Size(117, 21);
            PuhelinLB.TabIndex = 8;
            PuhelinLB.Text = "Puhelinnumero";
            // 
            // TitteliLB
            // 
            TitteliLB.AutoSize = true;
            TitteliLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitteliLB.Location = new Point(262, 147);
            TitteliLB.Name = "TitteliLB";
            TitteliLB.Size = new Size(48, 21);
            TitteliLB.TabIndex = 9;
            TitteliLB.Text = "Titteli";
            // 
            // SijaintiLB
            // 
            SijaintiLB.AutoSize = true;
            SijaintiLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SijaintiLB.Location = new Point(262, 177);
            SijaintiLB.Name = "SijaintiLB";
            SijaintiLB.Size = new Size(57, 21);
            SijaintiLB.TabIndex = 10;
            SijaintiLB.Text = "Sijainti";
            // 
            // EmailLB
            // 
            EmailLB.AutoSize = true;
            EmailLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLB.Location = new Point(262, 207);
            EmailLB.Name = "EmailLB";
            EmailLB.Size = new Size(87, 21);
            EmailLB.TabIndex = 11;
            EmailLB.Text = "Sähköposti";
            // 
            // PhoneLB
            // 
            PhoneLB.AutoSize = true;
            PhoneLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLB.Location = new Point(262, 237);
            PhoneLB.Name = "PhoneLB";
            PhoneLB.Size = new Size(117, 21);
            PhoneLB.TabIndex = 12;
            PhoneLB.Text = "Puhelinnumero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 270);
            Controls.Add(PhoneLB);
            Controls.Add(EmailLB);
            Controls.Add(SijaintiLB);
            Controls.Add(TitteliLB);
            Controls.Add(PuhelinLB);
            Controls.Add(PostitoimipaikkaLB);
            Controls.Add(PostinumeroLB);
            Controls.Add(KatuosoiteLB);
            Controls.Add(VastuuhenkilotCB);
            Controls.Add(OppilaitoksetCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Oppilaitosten avainhenkilöt";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox OppilaitoksetCB;
        private ComboBox VastuuhenkilotCB;
        private Label KatuosoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label TitteliLB;
        private Label SijaintiLB;
        private Label EmailLB;
        private Label PhoneLB;
    }
}