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

namespace OtelOtomasyonu.Odalar {
    public partial class Form_OdaKayitSil : Form {
        public Form_OdaKayitSil() {
            InitializeComponent();
            OdaKayıtBilgileriniGetir();
        }

        double netgelir = 0, gider = 0;
        string id = "";

        private void OdaKayıtBilgileriniGetir() {
            label_id.Text = Form_OdaKayitlari.satir["kayit_id"].ToString();
            comboBox_oda.Text = Form_OdaKayitlari.satir["oda_ad"].ToString();
            comboBox_musteri.Text = Form_OdaKayitlari.satir["kayit_musteri"].ToString();
            dateTimePicker_giris.Text = Form_OdaKayitlari.satir["kayit_giris"].ToString();
            dateTimePicker_cikis.Text = Form_OdaKayitlari.satir["kayit_cikis"].ToString();
            label5.Text = Form_OdaKayitlari.satir["kayit_sure"].ToString() + "Günlük Ücret:";
            textBox_ucret2.Text = Form_OdaKayitlari.satir["kayıt_ucret"].ToString();
        }

        private void MuhasebeVerileriniGuncelle() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM GunlukMuhasebe WHERE muhasebe_tarih='" + DateTime.Now.ToShortDateString() + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                if (verioku.Read()) {
                    id = verioku["muhasebe_id"].ToString();
                    netgelir = double.Parse(verioku["muhasebe_netgelir"].ToString());
                    gider = double.Parse(verioku["muhasebe_gider"].ToString());
                }
                verioku.Close();
                netgelir -= double.Parse(textBox_ucret2.Text);
                gider += double.Parse(textBox_ucret2.Text);
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_sil_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Eğer devam ederseniz bu işlemi geri alamazsınız.\nDevam ederek bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                MuhasebeVerileriniGuncelle();
                if (Veritabani_islemleri.Guncelle("GunlukMuhasebe", "muhasebe_id", id, "muhasebe_netgelir='" + netgelir + "', muhasebe_gider='" + gider + "'", "Günlük muhasebe verileri güncellendi.") && Veritabani_islemleri.Guncelle("Odalar", "oda_id", Form_OdaKayitlari.satir["oda_id"].ToString(), "oda_dolumu='Hayır'", "Hayır") && Veritabani_islemleri.Sil("Oda kaydı silinmiştir.", "kayit_id", label_id.Text, "OdaKayitlari") && Veritabani_islemleri.Ekle("OdaIslemGecmisleri", "oda_ad,gecmis_baslik,gecmis_aciklama,gecmis_saat,gecmis_tarih", "'" + comboBox_oda.Text + "','Oda Kayıt İptal İşlemi','Kullanıcı tarafından oda kaydı iptal edilmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır")) { Close(); }
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("Silme işlemi kullanıcı tarafından iptal edilmiştir.", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Information); }
        }
    }
}