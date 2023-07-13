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
    public partial class Form_MuhasebeGuncelle : Form {
        public Form_MuhasebeGuncelle() {
            InitializeComponent();
            MuhasebeVerileriniGetir();
            MuhasebeTurleriniGetir();
        }

        double netgelir = 0, gelir = 0, gider = 0, tutar = 0;
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

        private void comboBox_tur_SelectedIndexChanged(object sender, EventArgs e) { MuhasebeTurleriniGetir(); }

        private void MuhasebeVerileriniGetir() {
            label_id.Text = Form_Muhasebe.satir["islem_id"].ToString();
            comboBox_tur.SelectedIndex = comboBox_tur.FindString(Form_Muhasebe.satir["islem_tur"].ToString());
            comboBox_baslik.Text = Form_Muhasebe.satir["islem_ad"].ToString();
            maskedTextBox_tutar.Text = Form_Muhasebe.satir["islem_ucret"].ToString();
            tutar = double.Parse(Form_Muhasebe.satir["islem_ucret"].ToString());
        }

        private void MuhasebeVerileriniGuncelle() {
            try {
                tutar = double.Parse(maskedTextBox_tutar.Text) - tutar;
                if (tutar != 0) {
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
                        netgelir += tutar;
                        gelir += tutar;
                    }
                    else {
                        netgelir -= tutar;
                        gider += tutar;
                    }
                    if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
                }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_guncelle_Click(object sender, EventArgs e) {
            if (comboBox_baslik.Text != "" && comboBox_tur.Text != "" && maskedTextBox_tutar.Text != "") {
                MuhasebeVerileriniGuncelle();
                if (Veritabani_islemleri.Guncelle("GunlukMuhasebe", "muhasebe_id", id, "muhasebe_netgelir='" + netgelir + "', muhasebe_gelir='" + gelir + "', muhasebe_gider='" + gider + "'", "Günlük muhasebe verileri güncellendi.") && Veritabani_islemleri.Guncelle("MuhasebeIslemleri", "islem_id", label_id.Text, "islem_ad='" + comboBox_baslik.Text + "',islem_tur='" + comboBox_tur.Text + "',islem_ucret='" + maskedTextBox_tutar.Text + "'", comboBox_tur.Text + " başarıyla güncellendi.")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (comboBox_tur.Text == "") {
                    comboBox_tur.BackColor = Color.Red;
                    comboBox_tur.ForeColor = Color.White;
                    comboBox_tur.Focus();
                }
                if (comboBox_baslik.Text == "") {
                    comboBox_baslik.BackColor = Color.Red;
                    comboBox_baslik.ForeColor = Color.White;
                    comboBox_baslik.Focus();
                }
                if (maskedTextBox_tutar.Text == "") {
                    maskedTextBox_tutar.BackColor = Color.Red;
                    maskedTextBox_tutar.ForeColor = Color.White;
                    maskedTextBox_tutar.Focus();
                }
                MessageBox.Show("Kırmızı ile işaretlenmiş yerleri lütfen doldurunuz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}