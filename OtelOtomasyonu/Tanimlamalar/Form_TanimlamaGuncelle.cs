using OtelOtomasyonu.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Tanimlamalar {
    public partial class Form_TanimlamaGuncelle : Form {
        public Form_TanimlamaGuncelle() {
            InitializeComponent();
            VerileriGetir();
        }

        private void VerileriGetir() {
            switch (Form_Tanimlamalar.gridAd) {
                case "gridView_odaEsyalari":
                    textBox_icerik.Text = Form_Tanimlamalar.satir["esya_ad"].ToString();
                    label_id.Text = Form_Tanimlamalar.satir["esya_id"].ToString();
                    label_icerik.Text = "Eşya:";
                    break;
                case "gridView_cariTur":
                    textBox_icerik.Text = Form_Tanimlamalar.satir["tur_ad"].ToString();
                    label_id.Text = Form_Tanimlamalar.satir["tur_id"].ToString();
                    Size = new Size(326, 483);
                    groupBox_yetkiler.Visible = true;
                    YetkileriGetir();
                    break;
                case "gridView_muhasebeTurleri":
                    Size = new Size(326, 222);
                    label3.Visible = true;
                    label_icerik.Text = "Başlık:";
                    comboBox_muhasebeTur.Visible = true;
                    label_id.Text = Form_Tanimlamalar.satir["tur_id"].ToString();
                    textBox_icerik.Text = Form_Tanimlamalar.satir["tur_ad"].ToString();
                    comboBox_muhasebeTur.Text = Form_Tanimlamalar.satir["tur_tur"].ToString();
                    break;
                case "gridView_urunKategorileri":
                    textBox_icerik.Text = Form_Tanimlamalar.satir["kategori_ad"].ToString();
                    label_id.Text = Form_Tanimlamalar.satir["kategori_id"].ToString();
                    label_icerik.Text = "Kategori:";
                    break;
                default:
                    textBox_icerik.Text = Form_Tanimlamalar.satir["tur_ad"].ToString();
                    label_id.Text = Form_Tanimlamalar.satir["tur_id"].ToString();
                    break;
            }
        }

        private void YetkileriGetir() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM CariTurleri WHERE tur_id=" + label_id.Text + "", Form_Otel.baglanti);
                SqlDataReader veriler = vericek.ExecuteReader();
                while (veriler.Read()) {
                    if(veriler["tur_uygulama"].ToString() == "True") { checkBox1.Checked = true; }
                    if(veriler["tur_odalar"].ToString() == "True") { checkBox2.Checked = true; }
                    if(veriler["tur_muhasebe"].ToString() == "True") { checkBox3.Checked = true; }
                    if(veriler["tur_cariler"].ToString() == "True") { checkBox4.Checked = true; }
                    if(veriler["tur_kafeterya"].ToString() == "True") { checkBox8.Checked = true; }
                    if(veriler["tur_gecmisler"].ToString() == "True") { checkBox5.Checked = true; }
                    if(veriler["tur_tanimlamalar"].ToString() == "True") { checkBox6.Checked = true; }
                    if(veriler["tur_ayarlar"].ToString() == "True") { checkBox7.Checked = true; }
                }
                veriler.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_guncelle_Click(object sender, EventArgs e) {
            if (textBox_icerik.Text != "") { 
                switch (Form_Tanimlamalar.gridAd) {
                case "gridView_odaTur":
                    if (Veritabani_islemleri.Guncelle("OdaTurleri", "tur_id", label_id.Text, "tur_ad='" + textBox_icerik.Text + "'", "Oda türü başarıyla güncellendi.")) Close();
                    else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "gridView_odaEsyalari":
                    if (Veritabani_islemleri.Guncelle("OdaEsyalari", "esya_id", label_id.Text, "esya_ad='" + textBox_icerik.Text + "'", "Oda eşyası başarıyla güncellendi.")) Close();
                    else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "gridView_cariTur":
                    if (Veritabani_islemleri.Guncelle("CariTurleri", "tur_id", label_id.Text, "tur_ad='" + textBox_icerik.Text + "',tur_uygulama='" + checkBox1.Checked + "',tur_odalar='" + checkBox2.Checked + "',tur_muhasebe='" + checkBox3.Checked + "',tur_cariler='" + checkBox4.Checked + "',tur_gecmisler='" + checkBox5.Checked + "',tur_tanimlamalar='" + checkBox6.Checked + "',tur_ayarlar='" + checkBox7.Checked + "', tur_kafeterya='" + checkBox8.Checked + "'", "Cari türü başarıyla güncellendi.")) Close();
                    else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "gridView_muhasebeTurleri":
                    if (Veritabani_islemleri.Guncelle("MuhasebeTurleri", "tur_id", label_id.Text, "tur_ad='" + textBox_icerik.Text + "',tur_tur='" + comboBox_muhasebeTur.Text + "'", "Muhasebe türü başarıyla güncellendi.")) Close();
                    else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "gridView_urunKategorileri":
                    if (Veritabani_islemleri.Guncelle("UrunKategorileri", "kategori_id", label_id.Text, "kategori_ad='" + textBox_icerik.Text + "'", "Kategori başarıyla güncellendi.")) Close();
                    else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                }
            }
            else {
                textBox_icerik.BackColor = Color.Red;
                textBox_icerik.ForeColor = Color.White;
                textBox_icerik.Focus();
            }
        }
    }
}