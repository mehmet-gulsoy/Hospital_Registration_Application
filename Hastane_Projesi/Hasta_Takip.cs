using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Pro
{
    public partial class Hasta_Takip : Form
    {
        private readonly SqlConnection baglanti =
            new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HastaneDB2;Integrated Security=True;Encrypt=False;");

        public Hasta_Takip()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_cinsiyet.Items.Clear();
            comboBox_cinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });

            comboBox_kan_grubu.Items.Clear();
            comboBox_kan_grubu.Items.AddRange(new object[]
            {
                "A Rh+","A Rh-","B Rh+","B Rh-","AB Rh+","AB Rh-","0 Rh+","0 Rh-"
            });

            dateTimePicker_hasta_yatis_tarihi.Format = DateTimePickerFormat.Short;

            Listele();
            IstatistikleriYukle();
        }

        private void Listele()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hastalar ORDER BY Id DESC", baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView_hastalistesi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void IstatistikleriYukle()
        {
            try
            {
                baglanti.Open();

                using (SqlCommand cmdToplam = new SqlCommand("SELECT COUNT(*) FROM Hastalar", baglanti))
                {
                    int toplam = Convert.ToInt32(cmdToplam.ExecuteScalar());
                    label_toplam_hastalik_sayisi_deger.Text = toplam.ToString();
                }

                using (SqlCommand cmdOrt = new SqlCommand("SELECT AVG(CAST(Yas AS FLOAT)) FROM Hastalar", baglanti))
                {
                    object ortSonuc = cmdOrt.ExecuteScalar();
                    double ortalama = (ortSonuc == DBNull.Value) ? 0 : Convert.ToDouble(ortSonuc);
                    label_hastalirin_ortalama_yasi_deger.Text = Math.Round(ortalama, 1).ToString();
                }

                int maxSayi = 0;
                using (SqlCommand cmdMax = new SqlCommand(@"
SELECT MAX(Sayi) FROM (
    SELECT COUNT(*) AS Sayi
    FROM Hastalar
    GROUP BY HastalikTanisi
) T", baglanti))
                {
                    object maxSonuc = cmdMax.ExecuteScalar();
                    if (maxSonuc == DBNull.Value || maxSonuc == null)
                    {
                        label_en_sik_gorulen_hastalik_deger.Text = "-";
                        baglanti.Close();
                        return;
                    }
                    maxSayi = Convert.ToInt32(maxSonuc);
                }

                int kacTane = 0;
                using (SqlCommand cmdKacTane = new SqlCommand(@"
SELECT COUNT(*) FROM (
    SELECT HastalikTanisi
    FROM Hastalar
    GROUP BY HastalikTanisi
    HAVING COUNT(*) = @max
) T", baglanti))
                {
                    cmdKacTane.Parameters.AddWithValue("@max", maxSayi);
                    kacTane = Convert.ToInt32(cmdKacTane.ExecuteScalar());
                }

                if (kacTane == 1)
                {
                    using (SqlCommand cmdHastalik = new SqlCommand(@"
SELECT TOP 1 HastalikTanisi
FROM Hastalar
GROUP BY HastalikTanisi
ORDER BY COUNT(*) DESC", baglanti))
                    {
                        object enCok = cmdHastalik.ExecuteScalar();
                        label_en_sik_gorulen_hastalik_deger.Text =
                            (enCok == null || enCok == DBNull.Value) ? "-" : enCok.ToString();
                    }
                }
                else
                {
                    label_en_sik_gorulen_hastalik_deger.Text = "-";
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("İstatistik hatası: " + ex.Message);
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"
INSERT INTO Hastalar
(TC, Ad, Soyad, Cinsiyet, KanGrubu, Yas, HastalikTanisi, YatisTarihi, SaglikSigortasi, TaburcuEdildi, TaburcuTarihi)
VALUES
(@tc, @ad, @soyad, @cinsiyet, @kangrubu, @yas, @tani, @yatis, @sigorta, 0, NULL)";

                using (SqlCommand cmd = new SqlCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@tc", textBox_TC.Text.Trim());
                    cmd.Parameters.AddWithValue("@ad", textBox_ad.Text.Trim());
                    cmd.Parameters.AddWithValue("@soyad", textBox_soyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@cinsiyet", comboBox_cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@kangrubu", comboBox_kan_grubu.Text);
                    cmd.Parameters.AddWithValue("@yas", int.Parse(textBox_yas.Text));
                    cmd.Parameters.AddWithValue("@tani", textBox_hastalik_tanisi.Text.Trim());
                    cmd.Parameters.AddWithValue("@yatis", dateTimePicker_hasta_yatis_tarihi.Value.Date);
                    cmd.Parameters.AddWithValue("@sigorta", checkBox_saglik_sigortasi.Checked);

                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                }

                MessageBox.Show("Hasta kaydı eklendi ✅");

                Temizle();
                Listele();
                IstatistikleriYukle();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Kayıt hatası ❌ Lütfen tekrar deneyin.: " + ex.Message);
            }
        }

        private void Temizle()
        {
            textBox_TC.Clear();
            textBox_ad.Clear();
            textBox_soyad.Clear();
            textBox_yas.Clear();
            textBox_hastalik_tanisi.Clear();

            comboBox_cinsiyet.SelectedIndex = -1;
            comboBox_kan_grubu.SelectedIndex = -1;

            checkBox_saglik_sigortasi.Checked = false;
            dateTimePicker_hasta_yatis_tarihi.Value = DateTime.Now;
        }

        private void button_temizlik_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button_guncelleme_paneli_Click(object sender, EventArgs e)
        {
            Kayit_Guncelleme_Paneli f2 = new Kayit_Guncelleme_Paneli();
            f2.Show();
            this.Hide();
        }

        private void dataGridView_hastalistesi_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox_hasta_kayit_Enter(object sender, EventArgs e) { }
        private void label_TC_Click(object sender, EventArgs e) { }
        private void label_ad_Click(object sender, EventArgs e) { }
        private void label_soyad_Click(object sender, EventArgs e) { }
        private void label_cinsiyet_Click(object sender, EventArgs e) { }
        private void label_kan_grubu_Click(object sender, EventArgs e) { }
        private void label_yas_Click(object sender, EventArgs e) { }
        private void label_hastalik_tanisi_Click(object sender, EventArgs e) { }
        private void label_tastalik_yatis_tarihi_Click(object sender, EventArgs e) { }
        private void checkBox_saglik_sigortasi_CheckedChanged(object sender, EventArgs e) { }
        private void label_toplam_hastalik_sayisi_Click(object sender, EventArgs e) { }
        private void label_toplam_hastalik_sayisi_deger_Click(object sender, EventArgs e) { }
        private void dateTimePicker_hasta_yatis_tarihi_ValueChanged(object sender, EventArgs e) { }
        private void textBox_hastalik_tanisi_TextChanged(object sender, EventArgs e) { }
        private void comboBox_kan_grubu_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox_yas_TextChanged(object sender, EventArgs e) { }
        private void comboBox_cinsiyet_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox_soyad_TextChanged(object sender, EventArgs e) { }
        private void textBox_ad_TextChanged(object sender, EventArgs e) { }
        private void textBox_TC_TextChanged(object sender, EventArgs e) { }
        private void label_en_cok_gorulen_hastalik_deger_Click(object sender, EventArgs e) { }
        private void label_en_cok_gorulen_hastalik_Click(object sender, EventArgs e) { }
        private void label_en_sik_gorulen_hastalik_Click(object sender, EventArgs e) { }
        private void label_en_sik_gorulen_hastalik_deger_Click(object sender, EventArgs e) { }
        private void label_hastalirin_ortalama_yasi_deger_Click(object sender, EventArgs e) { }
    }
}
