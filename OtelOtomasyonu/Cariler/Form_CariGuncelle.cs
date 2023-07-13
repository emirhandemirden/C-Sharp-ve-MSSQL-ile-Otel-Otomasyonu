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

namespace OtelOtomasyonu.Cariler {
    public partial class Form_CariGuncelle : Form {
        public Form_CariGuncelle() {
            InitializeComponent();
            cariTurleriTableAdapter.Fill(cariTurleriDataSet.CariTurleri);
            CariBilgileriniGetir();
        }

        private void CariBilgileriniGetir() {
            label_id.Text = Form_Cariler.satir["cari_id"].ToString();
            textBox_ad.Text = Form_Cariler.satir["cari_ad"].ToString();
            maskedTextBox_tel.Text = Form_Cariler.satir["cari_tel"].ToString();
            maskedTextBox_dogum.Text = Form_Cariler.satir["cari_dogum"].ToString();
            comboBox_tur.Text = Form_Cariler.satir["cari_tur"].ToString();
            textBox_sifre.Text = Form_Cariler.satir["cari_sifre"].ToString();
        }

        private void button_guncelle_Click(object sender, EventArgs e) {
            if (textBox_ad.Text != "" && comboBox_tur.Text != "" && maskedTextBox_tel.Text != "" && maskedTextBox_dogum.Text != "") {
                if (Veritabani_islemleri.Guncelle("Cariler", "cari_id", label_id.Text, "cari_ad='" + textBox_ad.Text + "',cari_tur='" + comboBox_tur.Text + "',cari_tel='" + maskedTextBox_tel.Text + "',cari_dogum='" + maskedTextBox_dogum.Text + "',cari_sifre='" + textBox_sifre.Text + "'", "Cari başarıyla güncellendi.") && Veritabani_islemleri.Ekle("CariGecmisleri", "gecmis_baslik,gecmis_detay,gecmis_saat,gecmis_tarih", "'Cari Güncelleme İşlemi','" + textBox_ad.Text + " adlı cari güncellendi.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (comboBox_tur.Text == "") {
                    comboBox_tur.BackColor = Color.Red;
                    comboBox_tur.ForeColor = Color.White;
                    comboBox_tur.Focus();
                }
                if (maskedTextBox_dogum.Text == "") {
                    maskedTextBox_dogum.BackColor = Color.Red;
                    maskedTextBox_dogum.ForeColor = Color.White;
                    maskedTextBox_dogum.Focus();
                }
                if (maskedTextBox_tel.Text == "") {
                    maskedTextBox_tel.BackColor = Color.Red;
                    maskedTextBox_tel.ForeColor = Color.White;
                    maskedTextBox_tel.Focus();
                }
                if (textBox_ad.Text == "") {
                    textBox_ad.BackColor = Color.Red;
                    textBox_ad.ForeColor = Color.White;
                    textBox_ad.Focus();
                }
                MessageBox.Show("Kırmızı ile işaretlenmiş yerleri lütfen doldurunuz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_temizle_Click(object sender, EventArgs e) {
            CariBilgileriniGetir();
            textBox_ad.BackColor = Color.White;
            textBox_ad.ForeColor = Color.Black;
            comboBox_tur.BackColor = Color.White;
            comboBox_tur.ForeColor = Color.Black;
            maskedTextBox_tel.BackColor = Color.White;
            maskedTextBox_tel.ForeColor = Color.Black;
            maskedTextBox_dogum.BackColor = Color.White;
            maskedTextBox_dogum.ForeColor = Color.Black;
            textBox_ad.Focus();
        }

        private void Sifirla() {
            label6.Visible = false;
            textBox_sifre.Visible = false;
            Size = new Size(439, 303);
        }

        private void comboBox_tur_SelectedIndexChanged(object sender, EventArgs e) { TurKontrol(); }

        private void TurKontrol() {
            try {
                Sifirla();
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM CariTurleri WHERE tur_ad='" + comboBox_tur.Text + "'", Form_Otel.baglanti);
                SqlDataReader veriler = vericek.ExecuteReader();
                while (veriler.Read()) {
                    if (veriler["tur_uygulama"].ToString() == "True") {
                        label6.Visible = true;
                        textBox_sifre.Visible = true;
                        Size = new Size(439, 342);
                    }
                }
                veriler.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Form_CariGuncelle_Load(object sender, EventArgs e) { TurKontrol(); }
    }
}