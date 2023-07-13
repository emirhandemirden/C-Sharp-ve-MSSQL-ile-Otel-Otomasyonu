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
    public partial class Form_MuhasebeSil : Form {
        public Form_MuhasebeSil() {
            InitializeComponent();
            MuhasebeVerileriniGetir();
        }

        double netgelir = 0, gelir = 0, gider = 0;
        string id = "";

        private void MuhasebeVerileriniGetir() {
            label_id.Text = Form_Muhasebe.satir["islem_id"].ToString();
            comboBox_tur.Text = Form_Muhasebe.satir["islem_tur"].ToString();
            comboBox_baslik.Text = Form_Muhasebe.satir["islem_ad"].ToString();
            maskedTextBox_tutar.Text = Form_Muhasebe.satir["islem_ucret"].ToString();
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
                    netgelir -= double.Parse(maskedTextBox_tutar.Text);
                    gelir -= double.Parse(maskedTextBox_tutar.Text);
                }
                else {
                    netgelir += double.Parse(maskedTextBox_tutar.Text);
                    gider -= double.Parse(maskedTextBox_tutar.Text);
                }
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_sil_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Eğer devam ederseniz bu işlemi geri alamazsınız.\nDevam ederek bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                MuhasebeVerileriniGuncelle();
                if (Veritabani_islemleri.Guncelle("GunlukMuhasebe", "muhasebe_id", id, "muhasebe_netgelir='" + netgelir + "', muhasebe_gelir='" + gelir + "', muhasebe_gider='" + gider + "'", "Günlük muhasebe verileri güncellendi.") && Veritabani_islemleri.Sil(comboBox_tur.Text + " başarıyla silindi.", "islem_id", "'" + label_id.Text + "'", "MuhasebeIslemleri")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("Silme işlemi kullanıcı tarafından iptal edilmiştir.", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Information); }
        }
    }
}