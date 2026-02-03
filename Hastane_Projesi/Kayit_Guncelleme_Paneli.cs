using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hastane_Pro
{
    public partial class Kayit_Guncelleme_Paneli : Form
    {
        private readonly SqlConnection baglanti =
            new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HastaneDB2;Integrated Security=True;Encrypt=False;");
        public Kayit_Guncelleme_Paneli()
        {
            InitializeComponent();
        }

        private void Kayit_Guncelleme_Paneli_Load(object sender, EventArgs e)
        {
            dateTimePicker_hasta_yatis_tarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_hasta_taburcu_tarihi.Format = DateTimePickerFormat.Short;

            dateTimePicker_hasta_taburcu_tarihi.Enabled = false;

            comboBox_cinsiyet.Items.Clear();
            comboBox_cinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });

            comboBox_kan_grubu.Items.Clear();
            comboBox_kan_grubu.Items.AddRange(new object[]
            {
                "A Rh+","A Rh-","B Rh+","B Rh-","AB Rh+","AB Rh-","0 Rh+","0 Rh-"
            });

            Listele();
        }

        private void Listele()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hastalar ORDER BY Id DESC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_hasta_listesi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void checkBox_taburcu_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_hasta_taburcu_tarihi.Enabled = checkBox_taburcu.Checked;
        }

        private void dataGridView_hasta_listesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView_hasta_listesi.Rows[e.RowIndex];

            textBox_TC.Text = row.Cells["TC"].Value?.ToString();
            textBox_ad.Text = row.Cells["Ad"].Value?.ToString();
            textBox_soyad.Text = row.Cells["Soyad"].Value?.ToString();
            comboBox_cinsiyet.Text = row.Cells["Cinsiyet"].Value?.ToString();
            comboBox_kan_grubu.Text = row.Cells["KanGrubu"].Value?.ToString();
            textBox_yas.Text = row.Cells["Yas"].Value?.ToString();
            textBox_hastalik_tanisi.Text = row.Cells["HastalikTanisi"].Value?.ToString();

            if (row.Cells["YatisTarihi"].Value != DBNull.Value)
                dateTimePicker_hasta_yatis_tarihi.Value = Convert.ToDateTime(row.Cells["YatisTarihi"].Value);

            if (row.Cells["SaglikSigortasi"].Value != DBNull.Value)
                checkBox_saglik_sigortasi.Checked = Convert.ToBoolean(row.Cells["SaglikSigortasi"].Value);

            if (row.Cells["TaburcuEdildi"].Value != DBNull.Value)
                checkBox_taburcu.Checked = Convert.ToBoolean(row.Cells["TaburcuEdildi"].Value);

            if (row.Cells["TaburcuTarihi"].Value == DBNull.Value)
            {
                dateTimePicker_hasta_taburcu_tarihi.Value = DateTime.Now;
            }
            else
            {
                dateTimePicker_hasta_taburcu_tarihi.Value = Convert.ToDateTime(row.Cells["TaburcuTarihi"].Value);
            }
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
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
            checkBox_taburcu.Checked = false;

            dateTimePicker_hasta_yatis_tarihi.Value = DateTime.Now;
            dateTimePicker_hasta_taburcu_tarihi.Value = DateTime.Now;
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_taburcu.Checked &&
                    dateTimePicker_hasta_taburcu_tarihi.Value.Date < dateTimePicker_hasta_yatis_tarihi.Value.Date)
                {
                    MessageBox.Show("Taburcu tarihi, yatış tarihinden önce olamaz.");
                    return;
                }

                string sql = @"
UPDATE Hastalar SET
Ad=@ad,
Soyad=@soyad,
Cinsiyet=@cinsiyet,
KanGrubu=@kangrubu,
Yas=@yas,
HastalikTanisi=@tani,
YatisTarihi=@yatis,
SaglikSigortasi=@sigorta,
TaburcuEdildi=@taburcu,
TaburcuTarihi=@taburcuTarihi
WHERE TC=@tc";

                SqlCommand cmd = new SqlCommand(sql, baglanti);

                cmd.Parameters.AddWithValue("@ad", textBox_ad.Text.Trim());
                cmd.Parameters.AddWithValue("@soyad", textBox_soyad.Text.Trim());
                cmd.Parameters.AddWithValue("@cinsiyet", comboBox_cinsiyet.Text);
                cmd.Parameters.AddWithValue("@kangrubu", comboBox_kan_grubu.Text);
                cmd.Parameters.AddWithValue("@yas", int.Parse(textBox_yas.Text));
                cmd.Parameters.AddWithValue("@tani", textBox_hastalik_tanisi.Text.Trim());
                cmd.Parameters.AddWithValue("@yatis", dateTimePicker_hasta_yatis_tarihi.Value.Date);
                cmd.Parameters.AddWithValue("@sigorta", checkBox_saglik_sigortasi.Checked);
                cmd.Parameters.AddWithValue("@taburcu", checkBox_taburcu.Checked);

                if (checkBox_taburcu.Checked)
                    cmd.Parameters.AddWithValue("@taburcuTarihi", dateTimePicker_hasta_taburcu_tarihi.Value.Date);
                else
                    cmd.Parameters.AddWithValue("@taburcuTarihi", DBNull.Value);

                cmd.Parameters.AddWithValue("@tc", textBox_TC.Text.Trim());

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt güncellendi ✅");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası ❌: " + ex.Message);
                baglanti.Close();
            }
        }

        private void button_kaydi_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_TC.Text))
            {
                MessageBox.Show("Silmek için TC gir veya listeden seç.");
                return;
            }

            DialogResult r = MessageBox.Show("Bu kayıt silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Hastalar WHERE TC=@tc", baglanti);
                cmd.Parameters.AddWithValue("@tc", textBox_TC.Text.Trim());

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt silindi ✅");
                Temizle();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası ❌: " + ex.Message);
                baglanti.Close();
            }
        }

        private void button_kayit_paneli_Click(object sender, EventArgs e)
        {
            Hasta_Takip f1 = new Hasta_Takip();
            f1.Show();
            this.Hide();
        }

        private void label_TC_Click(object sender, EventArgs e) { }
        private void label_ad_Click(object sender, EventArgs e) { }
        private void label_soyad_Click(object sender, EventArgs e) { }
        private void label_cinsiyet_Click(object sender, EventArgs e) { }
        private void label_kan_grubu_Click(object sender, EventArgs e) { }
        private void label_yas_Click(object sender, EventArgs e) { }
        private void label_hastalik_tanisi_Click(object sender, EventArgs e) { }
        private void label_hasta_yatis_tarihi_Click(object sender, EventArgs e) { }
        private void label_hasta_taburcu_tarihi_Click(object sender, EventArgs e) { }
        private void checkBox_saglik_sigortasi_CheckedChanged(object sender, EventArgs e) { }
        private void dateTimePicker_hasta_taburcu_tarihi_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker_hasta_yatis_tarihi_ValueChanged(object sender, EventArgs e) { }
        private void textBox_hastalik_tanisi_TextChanged(object sender, EventArgs e) { }
        private void textBox_yas_TextChanged(object sender, EventArgs e) { }
        private void comboBox_kan_grubu_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox_cinsiyet_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox_soyad_TextChanged(object sender, EventArgs e) { }
        private void textBox_ad_TextChanged(object sender, EventArgs e) { }
        private void textBox_TC_TextChanged(object sender, EventArgs e) { }

        private void groupBox_guncelleme_formu_Enter(object sender, EventArgs e)
        {

        }
    }
}