namespace Hastane_Pro
{
    partial class Hasta_Takip
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
            this.groupBox_hasta_kayit = new System.Windows.Forms.GroupBox();
            this.checkBox_saglik_sigortasi = new System.Windows.Forms.CheckBox();
            this.button_temizlik = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.dateTimePicker_hasta_yatis_tarihi = new System.Windows.Forms.DateTimePicker();
            this.textBox_hastalik_tanisi = new System.Windows.Forms.TextBox();
            this.textBox_yas = new System.Windows.Forms.TextBox();
            this.comboBox_kan_grubu = new System.Windows.Forms.ComboBox();
            this.comboBox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_TC = new System.Windows.Forms.TextBox();
            this.label_tastalik_yatis_tarihi = new System.Windows.Forms.Label();
            this.label_hastalik_tanisi = new System.Windows.Forms.Label();
            this.label_yas = new System.Windows.Forms.Label();
            this.label_kan_grubu = new System.Windows.Forms.Label();
            this.label_cinsiyet = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_TC = new System.Windows.Forms.Label();
            this.label_toplam_hastalik_sayisi = new System.Windows.Forms.Label();
            this.dataGridView_hastalistesi = new System.Windows.Forms.DataGridView();
            this.label_toplam_hastalik_sayisi_deger = new System.Windows.Forms.Label();
            this.label_en_sik_gorulen_hastalik = new System.Windows.Forms.Label();
            this.label_en_sik_gorulen_hastalik_deger = new System.Windows.Forms.Label();
            this.label_hastalirin_ortalama_yasi = new System.Windows.Forms.Label();
            this.label_hastalirin_ortalama_yasi_deger = new System.Windows.Forms.Label();
            this.button_guncelleme_paneli = new System.Windows.Forms.Button();
            this.groupBox_hasta_kayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_hasta_kayit
            // 
            this.groupBox_hasta_kayit.Controls.Add(this.checkBox_saglik_sigortasi);
            this.groupBox_hasta_kayit.Controls.Add(this.button_temizlik);
            this.groupBox_hasta_kayit.Controls.Add(this.button_kaydet);
            this.groupBox_hasta_kayit.Controls.Add(this.dateTimePicker_hasta_yatis_tarihi);
            this.groupBox_hasta_kayit.Controls.Add(this.textBox_hastalik_tanisi);
            this.groupBox_hasta_kayit.Controls.Add(this.textBox_yas);
            this.groupBox_hasta_kayit.Controls.Add(this.comboBox_kan_grubu);
            this.groupBox_hasta_kayit.Controls.Add(this.comboBox_cinsiyet);
            this.groupBox_hasta_kayit.Controls.Add(this.textBox_soyad);
            this.groupBox_hasta_kayit.Controls.Add(this.textBox_ad);
            this.groupBox_hasta_kayit.Controls.Add(this.textBox_TC);
            this.groupBox_hasta_kayit.Controls.Add(this.label_tastalik_yatis_tarihi);
            this.groupBox_hasta_kayit.Controls.Add(this.label_hastalik_tanisi);
            this.groupBox_hasta_kayit.Controls.Add(this.label_yas);
            this.groupBox_hasta_kayit.Controls.Add(this.label_kan_grubu);
            this.groupBox_hasta_kayit.Controls.Add(this.label_cinsiyet);
            this.groupBox_hasta_kayit.Controls.Add(this.label_soyad);
            this.groupBox_hasta_kayit.Controls.Add(this.label_ad);
            this.groupBox_hasta_kayit.Controls.Add(this.label_TC);
            this.groupBox_hasta_kayit.Location = new System.Drawing.Point(62, 70);
            this.groupBox_hasta_kayit.Name = "groupBox_hasta_kayit";
            this.groupBox_hasta_kayit.Size = new System.Drawing.Size(359, 629);
            this.groupBox_hasta_kayit.TabIndex = 0;
            this.groupBox_hasta_kayit.TabStop = false;
            this.groupBox_hasta_kayit.Text = "Hasta Kayıt";
            this.groupBox_hasta_kayit.Enter += new System.EventHandler(this.groupBox_hasta_kayit_Enter);
            // 
            // checkBox_saglik_sigortasi
            // 
            this.checkBox_saglik_sigortasi.AutoSize = true;
            this.checkBox_saglik_sigortasi.Location = new System.Drawing.Point(47, 512);
            this.checkBox_saglik_sigortasi.Name = "checkBox_saglik_sigortasi";
            this.checkBox_saglik_sigortasi.Size = new System.Drawing.Size(123, 20);
            this.checkBox_saglik_sigortasi.TabIndex = 18;
            this.checkBox_saglik_sigortasi.Text = "Sağlık Sigortası";
            this.checkBox_saglik_sigortasi.UseVisualStyleBackColor = true;
            this.checkBox_saglik_sigortasi.CheckedChanged += new System.EventHandler(this.checkBox_saglik_sigortasi_CheckedChanged);
            // 
            // button_temizlik
            // 
            this.button_temizlik.Location = new System.Drawing.Point(29, 572);
            this.button_temizlik.Name = "button_temizlik";
            this.button_temizlik.Size = new System.Drawing.Size(100, 36);
            this.button_temizlik.TabIndex = 17;
            this.button_temizlik.Text = "Temizle";
            this.button_temizlik.UseVisualStyleBackColor = true;
            this.button_temizlik.Click += new System.EventHandler(this.button_temizlik_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(210, 572);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(93, 36);
            this.button_kaydet.TabIndex = 16;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // dateTimePicker_hasta_yatis_tarihi
            // 
            this.dateTimePicker_hasta_yatis_tarihi.Location = new System.Drawing.Point(169, 447);
            this.dateTimePicker_hasta_yatis_tarihi.Name = "dateTimePicker_hasta_yatis_tarihi";
            this.dateTimePicker_hasta_yatis_tarihi.Size = new System.Drawing.Size(163, 22);
            this.dateTimePicker_hasta_yatis_tarihi.TabIndex = 15;
            this.dateTimePicker_hasta_yatis_tarihi.ValueChanged += new System.EventHandler(this.dateTimePicker_hasta_yatis_tarihi_ValueChanged);
            // 
            // textBox_hastalik_tanisi
            // 
            this.textBox_hastalik_tanisi.Location = new System.Drawing.Point(182, 389);
            this.textBox_hastalik_tanisi.Name = "textBox_hastalik_tanisi";
            this.textBox_hastalik_tanisi.Size = new System.Drawing.Size(121, 22);
            this.textBox_hastalik_tanisi.TabIndex = 14;
            this.textBox_hastalik_tanisi.TextChanged += new System.EventHandler(this.textBox_hastalik_tanisi_TextChanged);
            // 
            // textBox_yas
            // 
            this.textBox_yas.Location = new System.Drawing.Point(182, 333);
            this.textBox_yas.Name = "textBox_yas";
            this.textBox_yas.Size = new System.Drawing.Size(121, 22);
            this.textBox_yas.TabIndex = 13;
            this.textBox_yas.TextChanged += new System.EventHandler(this.textBox_yas_TextChanged);
            // 
            // comboBox_kan_grubu
            // 
            this.comboBox_kan_grubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kan_grubu.FormattingEnabled = true;
            this.comboBox_kan_grubu.Location = new System.Drawing.Point(182, 279);
            this.comboBox_kan_grubu.Name = "comboBox_kan_grubu";
            this.comboBox_kan_grubu.Size = new System.Drawing.Size(121, 24);
            this.comboBox_kan_grubu.TabIndex = 12;
            this.comboBox_kan_grubu.SelectedIndexChanged += new System.EventHandler(this.comboBox_kan_grubu_SelectedIndexChanged);
            // 
            // comboBox_cinsiyet
            // 
            this.comboBox_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cinsiyet.FormattingEnabled = true;
            this.comboBox_cinsiyet.Location = new System.Drawing.Point(182, 224);
            this.comboBox_cinsiyet.Name = "comboBox_cinsiyet";
            this.comboBox_cinsiyet.Size = new System.Drawing.Size(121, 24);
            this.comboBox_cinsiyet.TabIndex = 11;
            this.comboBox_cinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBox_cinsiyet_SelectedIndexChanged);
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(182, 176);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(121, 22);
            this.textBox_soyad.TabIndex = 10;
            this.textBox_soyad.TextChanged += new System.EventHandler(this.textBox_soyad_TextChanged);
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(182, 132);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(121, 22);
            this.textBox_ad.TabIndex = 9;
            this.textBox_ad.TextChanged += new System.EventHandler(this.textBox_ad_TextChanged);
            // 
            // textBox_TC
            // 
            this.textBox_TC.Location = new System.Drawing.Point(182, 83);
            this.textBox_TC.Name = "textBox_TC";
            this.textBox_TC.Size = new System.Drawing.Size(121, 22);
            this.textBox_TC.TabIndex = 8;
            this.textBox_TC.TextChanged += new System.EventHandler(this.textBox_TC_TextChanged);
            // 
            // label_tastalik_yatis_tarihi
            // 
            this.label_tastalik_yatis_tarihi.AutoSize = true;
            this.label_tastalik_yatis_tarihi.Location = new System.Drawing.Point(26, 453);
            this.label_tastalik_yatis_tarihi.Name = "label_tastalik_yatis_tarihi";
            this.label_tastalik_yatis_tarihi.Size = new System.Drawing.Size(113, 16);
            this.label_tastalik_yatis_tarihi.TabIndex = 7;
            this.label_tastalik_yatis_tarihi.Text = "Hasta Yatış Tarihi";
            this.label_tastalik_yatis_tarihi.Click += new System.EventHandler(this.label_tastalik_yatis_tarihi_Click);
            // 
            // label_hastalik_tanisi
            // 
            this.label_hastalik_tanisi.AutoSize = true;
            this.label_hastalik_tanisi.Location = new System.Drawing.Point(26, 392);
            this.label_hastalik_tanisi.Name = "label_hastalik_tanisi";
            this.label_hastalik_tanisi.Size = new System.Drawing.Size(96, 16);
            this.label_hastalik_tanisi.TabIndex = 6;
            this.label_hastalik_tanisi.Text = "Hastalık Tanısı";
            this.label_hastalik_tanisi.Click += new System.EventHandler(this.label_hastalik_tanisi_Click);
            // 
            // label_yas
            // 
            this.label_yas.AutoSize = true;
            this.label_yas.Location = new System.Drawing.Point(26, 336);
            this.label_yas.Name = "label_yas";
            this.label_yas.Size = new System.Drawing.Size(31, 16);
            this.label_yas.TabIndex = 5;
            this.label_yas.Text = "Yaş";
            this.label_yas.Click += new System.EventHandler(this.label_yas_Click);
            // 
            // label_kan_grubu
            // 
            this.label_kan_grubu.AutoSize = true;
            this.label_kan_grubu.Location = new System.Drawing.Point(26, 282);
            this.label_kan_grubu.Name = "label_kan_grubu";
            this.label_kan_grubu.Size = new System.Drawing.Size(69, 16);
            this.label_kan_grubu.TabIndex = 4;
            this.label_kan_grubu.Text = "Kan Grubu";
            this.label_kan_grubu.Click += new System.EventHandler(this.label_kan_grubu_Click);
            // 
            // label_cinsiyet
            // 
            this.label_cinsiyet.AutoSize = true;
            this.label_cinsiyet.Location = new System.Drawing.Point(26, 227);
            this.label_cinsiyet.Name = "label_cinsiyet";
            this.label_cinsiyet.Size = new System.Drawing.Size(54, 16);
            this.label_cinsiyet.TabIndex = 3;
            this.label_cinsiyet.Text = "Cinsiyet";
            this.label_cinsiyet.Click += new System.EventHandler(this.label_cinsiyet_Click);
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(26, 179);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(47, 16);
            this.label_soyad.TabIndex = 2;
            this.label_soyad.Text = "Soyad";
            this.label_soyad.Click += new System.EventHandler(this.label_soyad_Click);
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Location = new System.Drawing.Point(26, 135);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(24, 16);
            this.label_ad.TabIndex = 1;
            this.label_ad.Text = "Ad";
            this.label_ad.Click += new System.EventHandler(this.label_ad_Click);
            // 
            // label_TC
            // 
            this.label_TC.AutoSize = true;
            this.label_TC.Location = new System.Drawing.Point(26, 86);
            this.label_TC.Name = "label_TC";
            this.label_TC.Size = new System.Drawing.Size(31, 16);
            this.label_TC.TabIndex = 0;
            this.label_TC.Text = "T.C.";
            this.label_TC.Click += new System.EventHandler(this.label_TC_Click);
            // 
            // label_toplam_hastalik_sayisi
            // 
            this.label_toplam_hastalik_sayisi.AutoSize = true;
            this.label_toplam_hastalik_sayisi.Location = new System.Drawing.Point(74, 775);
            this.label_toplam_hastalik_sayisi.Name = "label_toplam_hastalik_sayisi";
            this.label_toplam_hastalik_sayisi.Size = new System.Drawing.Size(139, 16);
            this.label_toplam_hastalik_sayisi.TabIndex = 1;
            this.label_toplam_hastalik_sayisi.Text = "Toplam Hasta Sayısı :";
            this.label_toplam_hastalik_sayisi.Click += new System.EventHandler(this.label_toplam_hastalik_sayisi_Click);
            // 
            // dataGridView_hastalistesi
            // 
            this.dataGridView_hastalistesi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_hastalistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hastalistesi.Location = new System.Drawing.Point(479, 79);
            this.dataGridView_hastalistesi.Name = "dataGridView_hastalistesi";
            this.dataGridView_hastalistesi.ReadOnly = true;
            this.dataGridView_hastalistesi.RowHeadersWidth = 51;
            this.dataGridView_hastalistesi.RowTemplate.Height = 24;
            this.dataGridView_hastalistesi.Size = new System.Drawing.Size(941, 620);
            this.dataGridView_hastalistesi.TabIndex = 2;
            this.dataGridView_hastalistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hastalistesi_CellContentClick);
            // 
            // label_toplam_hastalik_sayisi_deger
            // 
            this.label_toplam_hastalik_sayisi_deger.AutoSize = true;
            this.label_toplam_hastalik_sayisi_deger.Location = new System.Drawing.Point(219, 775);
            this.label_toplam_hastalik_sayisi_deger.Name = "label_toplam_hastalik_sayisi_deger";
            this.label_toplam_hastalik_sayisi_deger.Size = new System.Drawing.Size(51, 16);
            this.label_toplam_hastalik_sayisi_deger.TabIndex = 3;
            this.label_toplam_hastalik_sayisi_deger.Text = "label10";
            this.label_toplam_hastalik_sayisi_deger.Click += new System.EventHandler(this.label_toplam_hastalik_sayisi_deger_Click);
            // 
            // label_en_sik_gorulen_hastalik
            // 
            this.label_en_sik_gorulen_hastalik.AutoSize = true;
            this.label_en_sik_gorulen_hastalik.Location = new System.Drawing.Point(479, 775);
            this.label_en_sik_gorulen_hastalik.Name = "label_en_sik_gorulen_hastalik";
            this.label_en_sik_gorulen_hastalik.Size = new System.Drawing.Size(153, 16);
            this.label_en_sik_gorulen_hastalik.TabIndex = 6;
            this.label_en_sik_gorulen_hastalik.Text = "En Sık Görülen Hastalık :";
            this.label_en_sik_gorulen_hastalik.Click += new System.EventHandler(this.label_en_sik_gorulen_hastalik_Click);
            // 
            // label_en_sik_gorulen_hastalik_deger
            // 
            this.label_en_sik_gorulen_hastalik_deger.AutoSize = true;
            this.label_en_sik_gorulen_hastalik_deger.Location = new System.Drawing.Point(639, 775);
            this.label_en_sik_gorulen_hastalik_deger.Name = "label_en_sik_gorulen_hastalik_deger";
            this.label_en_sik_gorulen_hastalik_deger.Size = new System.Drawing.Size(51, 16);
            this.label_en_sik_gorulen_hastalik_deger.TabIndex = 7;
            this.label_en_sik_gorulen_hastalik_deger.Text = "label14";
            this.label_en_sik_gorulen_hastalik_deger.Click += new System.EventHandler(this.label_en_sik_gorulen_hastalik_deger_Click);
            // 
            // label_hastalirin_ortalama_yasi
            // 
            this.label_hastalirin_ortalama_yasi.AutoSize = true;
            this.label_hastalirin_ortalama_yasi.Location = new System.Drawing.Point(1011, 775);
            this.label_hastalirin_ortalama_yasi.Name = "label_hastalirin_ortalama_yasi";
            this.label_hastalirin_ortalama_yasi.Size = new System.Drawing.Size(162, 16);
            this.label_hastalirin_ortalama_yasi.TabIndex = 8;
            this.label_hastalirin_ortalama_yasi.Text = "Hastaların Ortalama Yaşı :";
            // 
            // label_hastalirin_ortalama_yasi_deger
            // 
            this.label_hastalirin_ortalama_yasi_deger.AutoSize = true;
            this.label_hastalirin_ortalama_yasi_deger.Location = new System.Drawing.Point(1192, 775);
            this.label_hastalirin_ortalama_yasi_deger.Name = "label_hastalirin_ortalama_yasi_deger";
            this.label_hastalirin_ortalama_yasi_deger.Size = new System.Drawing.Size(51, 16);
            this.label_hastalirin_ortalama_yasi_deger.TabIndex = 9;
            this.label_hastalirin_ortalama_yasi_deger.Text = "label16";
            this.label_hastalirin_ortalama_yasi_deger.Click += new System.EventHandler(this.label_hastalirin_ortalama_yasi_deger_Click);
            // 
            // button_guncelleme_paneli
            // 
            this.button_guncelleme_paneli.Location = new System.Drawing.Point(1280, 736);
            this.button_guncelleme_paneli.Name = "button_guncelleme_paneli";
            this.button_guncelleme_paneli.Size = new System.Drawing.Size(160, 64);
            this.button_guncelleme_paneli.TabIndex = 10;
            this.button_guncelleme_paneli.Text = "Güncelleme Paneli  -->";
            this.button_guncelleme_paneli.UseVisualStyleBackColor = true;
            this.button_guncelleme_paneli.Click += new System.EventHandler(this.button_guncelleme_paneli_Click);
            // 
            // Hasta_Takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 826);
            this.Controls.Add(this.button_guncelleme_paneli);
            this.Controls.Add(this.label_hastalirin_ortalama_yasi_deger);
            this.Controls.Add(this.label_hastalirin_ortalama_yasi);
            this.Controls.Add(this.label_en_sik_gorulen_hastalik_deger);
            this.Controls.Add(this.label_en_sik_gorulen_hastalik);
            this.Controls.Add(this.label_toplam_hastalik_sayisi_deger);
            this.Controls.Add(this.dataGridView_hastalistesi);
            this.Controls.Add(this.label_toplam_hastalik_sayisi);
            this.Controls.Add(this.groupBox_hasta_kayit);
            this.Name = "Hasta_Takip";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_hasta_kayit.ResumeLayout(false);
            this.groupBox_hasta_kayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hastalistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_hasta_kayit;
        private System.Windows.Forms.Label label_tastalik_yatis_tarihi;
        private System.Windows.Forms.Label label_hastalik_tanisi;
        private System.Windows.Forms.Label label_yas;
        private System.Windows.Forms.Label label_kan_grubu;
        private System.Windows.Forms.Label label_cinsiyet;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_TC;
        private System.Windows.Forms.TextBox textBox_TC;
        private System.Windows.Forms.Button button_temizlik;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hasta_yatis_tarihi;
        private System.Windows.Forms.TextBox textBox_hastalik_tanisi;
        private System.Windows.Forms.TextBox textBox_yas;
        private System.Windows.Forms.ComboBox comboBox_kan_grubu;
        private System.Windows.Forms.ComboBox comboBox_cinsiyet;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.CheckBox checkBox_saglik_sigortasi;
        private System.Windows.Forms.Label label_toplam_hastalik_sayisi;
        private System.Windows.Forms.DataGridView dataGridView_hastalistesi;
        private System.Windows.Forms.Label label_toplam_hastalik_sayisi_deger;
        private System.Windows.Forms.Label label_en_sik_gorulen_hastalik;
        private System.Windows.Forms.Label label_en_sik_gorulen_hastalik_deger;
        private System.Windows.Forms.Label label_hastalirin_ortalama_yasi;
        private System.Windows.Forms.Label label_hastalirin_ortalama_yasi_deger;
        private System.Windows.Forms.Button button_guncelleme_paneli;
    }
}

