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

namespace OtelOtomasyonu.Muhasebe {
    public partial class Form_MuhasebeEkle : Form {
        public Form_MuhasebeEkle() { InitializeComponent(); }

        double netgelir = 0, gelir = 0, gider = 0;
        string id = "";

        private void MuhasebeTurleriniGetir() {
            comboBox_baslik.Items.Clear();
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM MuhasebeTurleri WHERE tur_tur='" + comboBox_tur.Text + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                while (verioku.Read()) { comboBox_baslik.Items.Add(verioku["tur_ad"].ToString()); }
                verioku.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
                comboBox_baslik.SelectedIndex = 0;
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MuhasebeVerileriniGuncelle() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM GunlukMuhasebe WHERE muhasebe_tarih='" + DateTime.Now.ToShortDateString() + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                if (verioku.Read()) {
                    id = verioku["muhasebe_id"].ToString();
                    netgelir = double.Parse(verioku["muhasebe_netgelir"].ToString());
                    gelir = double.Parse(verioku["muhasebe_gelir"].ToString());
                    gider = double.Parse(verioku["muhasebe_gider"].ToString());
                }
                verioku.Close();
                if(comboBox_tur.Text == "Gelir") {
                    netgelir += double.Parse(maskedTextBox_tutar.Text);
                    gelir += double.Parse(maskedTextBox_tutar.Text);
                }
                else {
                    netgelir -= double.Parse(maskedTextBox_tutar.Text);
                    gider += double.Parse(maskedTextBox_tutar.Text);
                }
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_kaydet_Click(object sender, EventArgs e) {
            MuhasebeVerileriniGuncelle();
            if (comboBox_baslik.Text != "" && comboBox_tur.Text != "" && maskedTextBox_tutar.Text != "") {
                if (Veritabani_islemleri.Guncelle("GunlukMuhasebe","muhasebe_id",id, "muhasebe_netgelir='" + netgelir + "', muhasebe_gelir='" + gelir + "', muhasebe_gider='" + gider + "'", "Günlük muhasebe verileri güncellendi.") && Veritabani_islemleri.Ekle("MuhasebeIslemleri", "islem_ad,islem_tur,islem_ucret,islem_saat,islem_tarih", "'" + comboBox_baslik.Text + "','" + comboBox_tur.Text + "','" + maskedTextBox_tutar.Text + "','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", comboBox_tur.Text + " başarıyla eklendi.")) {
                    comboBox_tur.Text = "Gelir";
                    maskedTextBox_tutar.Text = "";
                    comboBox_baslik.SelectedIndex = 0;
                }
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (maskedTextBox_tutar.Text == "") {
                    maskedTextBox_tutar.BackColor = Color.Red;
                    maskedTextBox_tutar.ForeColor = Color.White;
                    maskedTextBox_tutar.Focus();
                }
                if (comboBox_baslik.Text == "") {
                    comboBox_baslik.BackColor = Color.Red;
                    comboBox_baslik.ForeColor = Color.White;
                    comboBox_baslik.Focus();
                }
                if (comboBox_tur.Text == "") {
                    comboBox_tur.BackColor = Color.Red;
                    comboBox_tur.ForeColor = Color.White;
                    comboBox_tur.Focus();
                }
                MessageBox.Show("Kırmızı ile işaretlenmiş yerleri lütfen doldurunuz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox_tur_SelectedIndexChanged(object sender, EventArgs e) { MuhasebeTurleriniGetir(); }
    }
} 