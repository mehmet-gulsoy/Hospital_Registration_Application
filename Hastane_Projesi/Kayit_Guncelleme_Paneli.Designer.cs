namespace Hastane_Pro
{
    partial class Kayit_Guncelleme_Paneli
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
            this.checkBox_saglik_sigortasi = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_hasta_yatis_tarihi = new System.Windows.Forms.DateTimePicker();
            this.textBox_hastalik_tanisi = new System.Windows.Forms.TextBox();
            this.textBox_yas = new System.Windows.Forms.TextBox();
            this.comboBox_kan_grubu = new System.Windows.Forms.ComboBox();
            this.comboBox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_TC = new System.Windows.Forms.TextBox();
            this.label_hasta_yatis_tarihi = new System.Windows.Forms.Label();
            this.label_hastalik_tanisi = new System.Windows.Forms.Label();
            this.label_yas = new System.Windows.Forms.Label();
            this.label_kan_grubu = new System.Windows.Forms.Label();
            this.label_cinsiyet = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_TC = new System.Windows.Forms.Label();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.dateTimePicker_hasta_taburcu_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label_hasta_taburcu_tarihi = new System.Windows.Forms.Label();
            this.checkBox_taburcu = new System.Windows.Forms.CheckBox();
            this.button_kayit_paneli = new System.Windows.Forms.Button();
            this.button_kaydi_sil = new System.Windows.Forms.Button();
            this.dataGridView_hasta_listesi = new System.Windows.Forms.DataGridView();
            this.groupBox_guncelleme_formu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hasta_listesi)).BeginInit();
            this.groupBox_guncelleme_formu.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_saglik_sigortasi
            // 
            this.checkBox_saglik_sigortasi.AutoSize = true;
            this.checkBox_saglik_sigortasi.Location = new System.Drawing.Point(47, 573);
            this.checkBox_saglik_sigortasi.Name = "checkBox_saglik_sigortasi";
            this.checkBox_saglik_sigortasi.Size = new System.Drawing.Size(123, 20);
            this.checkBox_saglik_sigortasi.TabIndex = 35;
            this.checkBox_saglik_sigortasi.Text = "Sağlık Sigortası";
            this.checkBox_saglik_sigortasi.UseVisualStyleBackColor = true;
            this.checkBox_saglik_sigortasi.CheckedChanged += new System.EventHandler(this.checkBox_saglik_sigortasi_CheckedChanged);
            // 
            // dateTimePicker_hasta_yatis_tarihi
            // 
            this.dateTimePicker_hasta_yatis_tarihi.Location = new System.Drawing.Point(182, 402);
            this.dateTimePicker_hasta_yatis_tarihi.Name = "dateTimePicker_hasta_yatis_tarihi";
            this.dateTimePicker_hasta_yatis_tarihi.Size = new System.Drawing.Size(163, 22);
            this.dateTimePicker_hasta_yatis_tarihi.TabIndex = 34;
            this.dateTimePicker_hasta_yatis_tarihi.ValueChanged += new System.EventHandler(this.dateTimePicker_hasta_yatis_tarihi_ValueChanged);
            // 
            // textBox_hastalik_tanisi
            // 
            this.textBox_hastalik_tanisi.Location = new System.Drawing.Point(195, 344);
            this.textBox_hastalik_tanisi.Name = "textBox_hastalik_tanisi";
            this.textBox_hastalik_tanisi.Size = new System.Drawing.Size(121, 22);
            this.textBox_hastalik_tanisi.TabIndex = 33;
            this.textBox_hastalik_tanisi.TextChanged += new System.EventHandler(this.textBox_hastalik_tanisi_TextChanged);
            // 
            // textBox_yas
            // 
            this.textBox_yas.Location = new System.Drawing.Point(195, 288);
            this.textBox_yas.Name = "textBox_yas";
            this.textBox_yas.Size = new System.Drawing.Size(121, 22);
            this.textBox_yas.TabIndex = 32;
            this.textBox_yas.TextChanged += new System.EventHandler(this.textBox_yas_TextChanged);
            // 
            // comboBox_kan_grubu
            // 
            this.comboBox_kan_grubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kan_grubu.FormattingEnabled = true;
            this.comboBox_kan_grubu.Location = new System.Drawing.Point(195, 234);
            this.comboBox_kan_grubu.Name = "comboBox_kan_grubu";
            this.comboBox_kan_grubu.Size = new System.Drawing.Size(121, 24);
            this.comboBox_kan_grubu.TabIndex = 31;
            this.comboBox_kan_grubu.SelectedIndexChanged += new System.EventHandler(this.comboBox_kan_grubu_SelectedIndexChanged);
            // 
            // comboBox_cinsiyet
            // 
            this.comboBox_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cinsiyet.FormattingEnabled = true;
            this.comboBox_cinsiyet.Location = new System.Drawing.Point(195, 179);
            this.comboBox_cinsiyet.Name = "comboBox_cinsiyet";
            this.comboBox_cinsiyet.Size = new System.Drawing.Size(121, 24);
            this.comboBox_cinsiyet.TabIndex = 30;
            this.comboBox_cinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBox_cinsiyet_SelectedIndexChanged);
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(195, 131);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(121, 22);
            this.textBox_soyad.TabIndex = 29;
            this.textBox_soyad.TextChanged += new System.EventHandler(this.textBox_soyad_TextChanged);
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(195, 87);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(121, 22);
            this.textBox_ad.TabIndex = 28;
            this.textBox_ad.TextChanged += new System.EventHandler(this.textBox_ad_TextChanged);
            // 
            // textBox_TC
            // 
            this.textBox_TC.Location = new System.Drawing.Point(195, 38);
            this.textBox_TC.Name = "textBox_TC";
            this.textBox_TC.Size = new System.Drawing.Size(121, 22);
            this.textBox_TC.TabIndex = 27;
            this.textBox_TC.TextChanged += new System.EventHandler(this.textBox_TC_TextChanged);
            // 
            // label_hasta_yatis_tarihi
            // 
            this.label_hasta_yatis_tarihi.AutoSize = true;
            this.label_hasta_yatis_tarihi.Location = new System.Drawing.Point(39, 408);
            this.label_hasta_yatis_tarihi.Name = "label_hasta_yatis_tarihi";
            this.label_hasta_yatis_tarihi.Size = new System.Drawing.Size(113, 16);
            this.label_hasta_yatis_tarihi.TabIndex = 26;
            this.label_hasta_yatis_tarihi.Text = "Hasta Yatış Tarihi";
            this.label_hasta_yatis_tarihi.Click += new System.EventHandler(this.label_hasta_yatis_tarihi_Click);
            // 
            // label_hastalik_tanisi
            // 
            this.label_hastalik_tanisi.AutoSize = true;
            this.label_hastalik_tanisi.Location = new System.Drawing.Point(39, 347);
            this.label_hastalik_tanisi.Name = "label_hastalik_tanisi";
            this.label_hastalik_tanisi.Size = new System.Drawing.Size(96, 16);
            this.label_hastalik_tanisi.TabIndex = 25;
            this.label_hastalik_tanisi.Text = "Hastalık Tanısı";
            this.label_hastalik_tanisi.Click += new System.EventHandler(this.label_hastalik_tanisi_Click);
            // 
            // label_yas
            // 
            this.label_yas.AutoSize = true;
            this.label_yas.Location = new System.Drawing.Point(39, 291);
            this.label_yas.Name = "label_yas";
            this.label_yas.Size = new System.Drawing.Size(31, 16);
            this.label_yas.TabIndex = 24;
            this.label_yas.Text = "Yaş";
            this.label_yas.Click += new System.EventHandler(this.label_yas_Click);
            // 
            // label_kan_grubu
            // 
            this.label_kan_grubu.AutoSize = true;
            this.label_kan_grubu.Location = new System.Drawing.Point(39, 237);
            this.label_kan_grubu.Name = "label_kan_grubu";
            this.label_kan_grubu.Size = new System.Drawing.Size(69, 16);
            this.label_kan_grubu.TabIndex = 23;
            this.label_kan_grubu.Text = "Kan Grubu";
            this.label_kan_grubu.Click += new System.EventHandler(this.label_kan_grubu_Click);
            // 
            // label_cinsiyet
            // 
            this.label_cinsiyet.AutoSize = true;
            this.label_cinsiyet.Location = new System.Drawing.Point(39, 182);
            this.label_cinsiyet.Name = "label_cinsiyet";
            this.label_cinsiyet.Size = new System.Drawing.Size(54, 16);
            this.label_cinsiyet.TabIndex = 22;
            this.label_cinsiyet.Text = "Cinsiyet";
            this.label_cinsiyet.Click += new System.EventHandler(this.label_cinsiyet_Click);
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(39, 134);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(47, 16);
            this.label_soyad.TabIndex = 21;
            this.label_soyad.Text = "Soyad";
            this.label_soyad.Click += new System.EventHandler(this.label_soyad_Click);
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Location = new System.Drawing.Point(46, 90);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(24, 16);
            this.label_ad.TabIndex = 20;
            this.label_ad.Text = "Ad";
            this.label_ad.Click += new System.EventHandler(this.label_ad_Click);
            // 
            // label_TC
            // 
            this.label_TC.AutoSize = true;
            this.label_TC.Location = new System.Drawing.Point(39, 41);
            this.label_TC.Name = "label_TC";
            this.label_TC.Size = new System.Drawing.Size(37, 16);
            this.label_TC.TabIndex = 19;
            this.label_TC.Text = "T.C. :";
            this.label_TC.Click += new System.EventHandler(this.label_TC_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Location = new System.Drawing.Point(151, 647);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(100, 36);
            this.button_temizle.TabIndex = 37;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(269, 648);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(105, 36);
            this.button_guncelle.TabIndex = 36;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // dateTimePicker_hasta_taburcu_tarihi
            // 
            this.dateTimePicker_hasta_taburcu_tarihi.Location = new System.Drawing.Point(195, 519);
            this.dateTimePicker_hasta_taburcu_tarihi.Name = "dateTimePicker_hasta_taburcu_tarihi";
            this.dateTimePicker_hasta_taburcu_tarihi.Size = new System.Drawing.Size(163, 22);
            this.dateTimePicker_hasta_taburcu_tarihi.TabIndex = 39;
            this.dateTimePicker_hasta_taburcu_tarihi.ValueChanged += new System.EventHandler(this.dateTimePicker_hasta_taburcu_tarihi_ValueChanged);
            // 
            // label_hasta_taburcu_tarihi
            // 
            this.label_hasta_taburcu_tarihi.AutoSize = true;
            this.label_hasta_taburcu_tarihi.Location = new System.Drawing.Point(39, 524);
            this.label_hasta_taburcu_tarihi.Name = "label_hasta_taburcu_tarihi";
            this.label_hasta_taburcu_tarihi.Size = new System.Drawing.Size(133, 16);
            this.label_hasta_taburcu_tarihi.TabIndex = 38;
            this.label_hasta_taburcu_tarihi.Text = "Hasta Taburcu Tarihi";
            this.label_hasta_taburcu_tarihi.Click += new System.EventHandler(this.label_hasta_taburcu_tarihi_Click);
            // 
            // checkBox_taburcu
            // 
            this.checkBox_taburcu.AutoSize = true;
            this.checkBox_taburcu.Location = new System.Drawing.Point(42, 462);
            this.checkBox_taburcu.Name = "checkBox_taburcu";
            this.checkBox_taburcu.Size = new System.Drawing.Size(116, 20);
            this.checkBox_taburcu.TabIndex = 40;
            this.checkBox_taburcu.Text = "Taburcu Edildi";
            this.checkBox_taburcu.UseVisualStyleBackColor = true;
            this.checkBox_taburcu.CheckedChanged += new System.EventHandler(this.checkBox_taburcu_CheckedChanged);
            // 
            // button_kayit_paneli
            // 
            this.button_kayit_paneli.Location = new System.Drawing.Point(34, 773);
            this.button_kayit_paneli.Name = "button_kayit_paneli";
            this.button_kayit_paneli.Size = new System.Drawing.Size(143, 65);
            this.button_kayit_paneli.TabIndex = 41;
            this.button_kayit_paneli.Text = "<--  Kayıt Paneli";
            this.button_kayit_paneli.UseVisualStyleBackColor = true;
            this.button_kayit_paneli.Click += new System.EventHandler(this.button_kayit_paneli_Click);
            // 
            // button_kaydi_sil
            // 
            this.button_kaydi_sil.Location = new System.Drawing.Point(30, 647);
            this.button_kaydi_sil.Name = "button_kaydi_sil";
            this.button_kaydi_sil.Size = new System.Drawing.Size(98, 37);
            this.button_kaydi_sil.TabIndex = 42;
            this.button_kaydi_sil.Text = "Kaydı Sil";
            this.button_kaydi_sil.UseVisualStyleBackColor = true;
            this.button_kaydi_sil.Click += new System.EventHandler(this.button_kaydi_sil_Click);
            // 
            // dataGridView_hasta_listesi
            // 
            this.dataGridView_hasta_listesi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_hasta_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hasta_listesi.Location = new System.Drawing.Point(484, 90);
            this.dataGridView_hasta_listesi.Name = "dataGridView_hasta_listesi";
            this.dataGridView_hasta_listesi.RowHeadersWidth = 51;
            this.dataGridView_hasta_listesi.RowTemplate.Height = 24;
            this.dataGridView_hasta_listesi.Size = new System.Drawing.Size(856, 604);
            this.dataGridView_hasta_listesi.TabIndex = 43;
            this.dataGridView_hasta_listesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hasta_listesi_CellContentClick);
            // 
            // groupBox_guncelleme_formu
            // 
            this.groupBox_guncelleme_formu.Controls.Add(this.button_kaydi_sil);
            this.groupBox_guncelleme_formu.Controls.Add(this.checkBox_taburcu);
            this.groupBox_guncelleme_formu.Controls.Add(this.dateTimePicker_hasta_taburcu_tarihi);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_hasta_taburcu_tarihi);
            this.groupBox_guncelleme_formu.Controls.Add(this.button_temizle);
            this.groupBox_guncelleme_formu.Controls.Add(this.button_guncelle);
            this.groupBox_guncelleme_formu.Controls.Add(this.checkBox_saglik_sigortasi);
            this.groupBox_guncelleme_formu.Controls.Add(this.dateTimePicker_hasta_yatis_tarihi);
            this.groupBox_guncelleme_formu.Controls.Add(this.textBox_hastalik_tanisi);
            this.groupBox_guncelleme_formu.Controls.Add(this.textBox_yas);
            this.groupBox_guncelleme_formu.Controls.Add(this.comboBox_kan_grubu);
            this.groupBox_guncelleme_formu.Controls.Add(this.comboBox_cinsiyet);
            this.groupBox_guncelleme_formu.Controls.Add(this.textBox_soyad);
            this.groupBox_guncelleme_formu.Controls.Add(this.textBox_ad);
            this.groupBox_guncelleme_formu.Controls.Add(this.textBox_TC);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_hasta_yatis_tarihi);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_hastalik_tanisi);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_yas);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_kan_grubu);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_cinsiyet);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_soyad);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_ad);
            this.groupBox_guncelleme_formu.Controls.Add(this.label_TC);
            this.groupBox_guncelleme_formu.Location = new System.Drawing.Point(38, 29);
            this.groupBox_guncelleme_formu.Name = "groupBox_guncelleme_formu";
            this.groupBox_guncelleme_formu.Size = new System.Drawing.Size(415, 710);
            this.groupBox_guncelleme_formu.TabIndex = 44;
            this.groupBox_guncelleme_formu.TabStop = false;
            this.groupBox_guncelleme_formu.Text = "Güncelleme Formu";
            this.groupBox_guncelleme_formu.Enter += new System.EventHandler(this.groupBox_guncelleme_formu_Enter);
            // 
            // Kayit_Guncelleme_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 850);
            this.Controls.Add(this.groupBox_guncelleme_formu);
            this.Controls.Add(this.dataGridView_hasta_listesi);
            this.Controls.Add(this.button_kayit_paneli);
            this.Name = "Kayit_Guncelleme_Paneli";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Kayit_Guncelleme_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hasta_listesi)).EndInit();
            this.groupBox_guncelleme_formu.ResumeLayout(false);
            this.groupBox_guncelleme_formu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_saglik_sigortasi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hasta_yatis_tarihi;
        private System.Windows.Forms.TextBox textBox_hastalik_tanisi;
        private System.Windows.Forms.TextBox textBox_yas;
        private System.Windows.Forms.ComboBox comboBox_kan_grubu;
        private System.Windows.Forms.ComboBox comboBox_cinsiyet;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_TC;
        private System.Windows.Forms.Label label_hasta_yatis_tarihi;
        private System.Windows.Forms.Label label_hastalik_tanisi;
        private System.Windows.Forms.Label label_yas;
        private System.Windows.Forms.Label label_kan_grubu;
        private System.Windows.Forms.Label label_cinsiyet;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_TC;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hasta_taburcu_tarihi;
        private System.Windows.Forms.Label label_hasta_taburcu_tarihi;
        private System.Windows.Forms.CheckBox checkBox_taburcu;
        private System.Windows.Forms.Button button_kayit_paneli;
        private System.Windows.Forms.Button button_kaydi_sil;
        private System.Windows.Forms.DataGridView dataGridView_hasta_listesi;
        private System.Windows.Forms.GroupBox groupBox_guncelleme_formu;
    }
}