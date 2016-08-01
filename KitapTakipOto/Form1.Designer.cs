namespace KitapTakipOto
{
    partial class Form1
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
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriEPosta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.lstKitap = new System.Windows.Forms.ListBox();
            this.cmbMusteriKitap = new System.Windows.Forms.ComboBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chkVarMi = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(507, 175);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(83, 30);
            this.btnKisiEkle.TabIndex = 0;
            this.btnKisiEkle.Text = "Kişi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(462, 28);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(128, 20);
            this.txtMusteriAdi.TabIndex = 2;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(462, 65);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(128, 20);
            this.txtMusteriSoyad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad";
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(462, 138);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(128, 20);
            this.txtMusteriTelefon.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefon";
            // 
            // txtMusteriEPosta
            // 
            this.txtMusteriEPosta.Location = new System.Drawing.Point(462, 101);
            this.txtMusteriEPosta.Name = "txtMusteriEPosta";
            this.txtMusteriEPosta.Size = new System.Drawing.Size(128, 20);
            this.txtMusteriEPosta.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-Posta";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(446, 211);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 76);
            this.textBox5.TabIndex = 13;
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.Location = new System.Drawing.Point(507, 293);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(83, 30);
            this.btnMesajGonder.TabIndex = 14;
            this.btnMesajGonder.Text = "Mesaj Gönder";
            this.btnMesajGonder.UseVisualStyleBackColor = true;
            // 
            // lstKitap
            // 
            this.lstKitap.FormattingEnabled = true;
            this.lstKitap.Location = new System.Drawing.Point(12, 65);
            this.lstKitap.Name = "lstKitap";
            this.lstKitap.Size = new System.Drawing.Size(166, 251);
            this.lstKitap.TabIndex = 15;
            this.lstKitap.SelectedIndexChanged += new System.EventHandler(this.lstKitap_SelectedIndexChanged);
            // 
            // cmbMusteriKitap
            // 
            this.cmbMusteriKitap.FormattingEnabled = true;
            this.cmbMusteriKitap.Location = new System.Drawing.Point(11, 24);
            this.cmbMusteriKitap.Name = "cmbMusteriKitap";
            this.cmbMusteriKitap.Size = new System.Drawing.Size(167, 21);
            this.cmbMusteriKitap.TabIndex = 16;
            this.cmbMusteriKitap.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriKitap_SelectedIndexChanged);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(255, 65);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(128, 20);
            this.txtKitapAdi.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kitap Adı";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(255, 138);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(128, 20);
            this.txtKategori.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Kategori";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(255, 101);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(128, 20);
            this.txtYazar.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Yazar";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(255, 175);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(128, 20);
            this.nudFiyat.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fiyat";
            // 
            // chkVarMi
            // 
            this.chkVarMi.AutoSize = true;
            this.chkVarMi.Location = new System.Drawing.Point(265, 213);
            this.chkVarMi.Name = "chkVarMi";
            this.chkVarMi.Size = new System.Drawing.Size(80, 17);
            this.chkVarMi.TabIndex = 26;
            this.chkVarMi.Text = "checkBox1";
            this.chkVarMi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Var Mı?";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(332, 257);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 39);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(195, 257);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(64, 39);
            this.btnEkle.TabIndex = 29;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(265, 257);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(64, 39);
            this.btnDuzenle.TabIndex = 30;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 338);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkVarMi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMusteriKitap);
            this.Controls.Add(this.lstKitap);
            this.Controls.Add(this.btnMesajGonder);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtMusteriEPosta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKisiEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriEPosta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.ListBox lstKitap;
        private System.Windows.Forms.ComboBox cmbMusteriKitap;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkVarMi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
    }
}

