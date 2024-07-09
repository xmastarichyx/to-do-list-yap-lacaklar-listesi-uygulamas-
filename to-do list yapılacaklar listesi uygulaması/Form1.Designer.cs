namespace to_do_list_yapılacaklar_listesi_uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yapılacak_is = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gün_liste = new System.Windows.Forms.ComboBox();
            this.önemi = new System.Windows.Forms.ComboBox();
            this.sırala = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yapılacak iş";
            // 
            // yapılacak_is
            // 
            this.yapılacak_is.Location = new System.Drawing.Point(25, 47);
            this.yapılacak_is.Name = "yapılacak_is";
            this.yapılacak_is.Size = new System.Drawing.Size(141, 22);
            this.yapılacak_is.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Önceliği";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Günü";
            // 
            // gün_liste
            // 
            this.gün_liste.FormattingEnabled = true;
            this.gün_liste.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.gün_liste.Location = new System.Drawing.Point(358, 45);
            this.gün_liste.Name = "gün_liste";
            this.gün_liste.Size = new System.Drawing.Size(107, 24);
            this.gün_liste.TabIndex = 6;
            this.gün_liste.Leave += new System.EventHandler(this.gün_liste_Leave);
            // 
            // önemi
            // 
            this.önemi.BackColor = System.Drawing.SystemColors.Window;
            this.önemi.FormattingEnabled = true;
            this.önemi.Items.AddRange(new object[] {
            "Yüksek Öncelikli",
            "Öncelikli",
            "Orta",
            "Düşük Öncelikli",
            "Gereksiz"});
            this.önemi.Location = new System.Drawing.Point(187, 45);
            this.önemi.Name = "önemi";
            this.önemi.Size = new System.Drawing.Size(145, 24);
            this.önemi.TabIndex = 7;
            this.önemi.Text = "Orta";
            this.önemi.Leave += new System.EventHandler(this.önemi_Leave);
            // 
            // sırala
            // 
            this.sırala.Location = new System.Drawing.Point(585, 422);
            this.sırala.Name = "sırala";
            this.sırala.Size = new System.Drawing.Size(243, 23);
            this.sırala.TabIndex = 8;
            this.sırala.Text = "Yenile";
            this.sırala.UseVisualStyleBackColor = true;
            this.sırala.Click += new System.EventHandler(this.sırala_Click);
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.ItemHeight = 16;
            this.liste.Location = new System.Drawing.Point(484, 28);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(462, 388);
            this.liste.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(481, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "BAŞLIK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(562, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "TARİH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(639, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ÖNCELİK SIRASI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(539, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = " / ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(616, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = " / ";
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(849, 422);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 16;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.sırala);
            this.Controls.Add(this.önemi);
            this.Controls.Add(this.gün_liste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yapılacak_is);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yapılacak_is;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gün_liste;
        private System.Windows.Forms.ComboBox önemi;
        private System.Windows.Forms.Button sırala;
        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sil;
    }
}

