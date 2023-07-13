using OtelOtomasyonu.Kafeterya;
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
    public partial class Form_OdaEkrani : Form {
        public Form_OdaEkrani() {
            InitializeComponent();
            MusteriBilgileriniGetir();
            SiparisleriGetir();
        }

        double netgelir = 0, gider = 0, seciliurunlerinfiyati = 0;
        string id = "";

        private void SiparisleriGetir() {
            listView_urunler.Items.Clear();
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM Siparisler WHERE oda_id='" + Form_Otel.oda_id + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                while (verioku.Read()) {
                    string[] satir = { verioku["siparis_id"].ToString(), verioku["siparis_urun"].ToString(), verioku["urun_tutar"].ToString(), verioku["urun_kategori"].ToString() };
                    listView_urunler.Items.Add(new ListViewItem(satir));
                }
                verioku.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MusteriBilgileriniGetir() {
            groupBox_musteriBilgileri.Text = Form_Otel.oda_ad + " Müşteri Bilgileri";
             try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM OdaKayitlari WHERE oda_id='" + Form_Otel.oda_id + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                if (verioku.Read()) { label_musteriBilgileri.Text = "Müşteri Adı: " + verioku["kayit_musteri"].ToString() + "\nGiriş Tarihi: " + verioku["kayit_giris"].ToString() + "Çıkış Tarihi: " + verioku["kayit_cikis"].ToString(); }
                verioku.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
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
                    gider = double.Parse(verioku["muhasebe_gider"].ToString());
                }
                verioku.Close();
                for (int i = 0; i < listView_urunler.CheckedItems.Count; i++) { seciliurunlerinfiyati += double.Parse(listView_urunler.CheckedItems[i].SubItems[2].Text); }
                netgelir -= seciliurunlerinfiyati;
                gider += seciliurunlerinfiyati;
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ToolStripButtons_Click(object sender, EventArgs e) {
            switch ((sender as ToolStripButton).Tag) {
                case "2":
                    Form_islemleri.Form_Ac(new Form_OdaSatis());
                    SiparisleriGetir();
                    break;
                case "3":
                    MuhasebeVerileriniGuncelle();
                    if (Veritabani_islemleri.Guncelle("GunlukMuhasebe", "muhasebe_id", id, "muhasebe_netgelir='" + netgelir + "', muhasebe_gider='" + gider + "'", "Hayır") && Veritabani_islemleri.Ekle("MuhasebeIslemleri", "islem_ad,islem_tur,islem_ucret,islem_saat,islem_tarih", "'Kafeterya Ürün Satışı İptali','Gider','" + seciliurunlerinfiyati + "','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır")) {
                        for (int i = 0; i < listView_urunler.CheckedItems.Count; i++) {
                            if (Veritabani_islemleri.Sil(listView_urunler.CheckedItems[i].SubItems[1].Text + " başarıyla silindi.", "siparis_id", listView_urunler.CheckedItems[i].SubItems[0].Text, "Siparisler") && Veritabani_islemleri.Ekle("OdaIslemGecmisleri", "oda_ad,gecmis_baslik,gecmis_aciklama,gecmis_saat,gecmis_tarih", "'" + Form_Otel.oda_ad + "','Odadan Ürün Silme İşlemi','" + listView_urunler.CheckedItems[i].SubItems[1].Text + " adlı ürün " + Form_Otel.oda_ad + " adlı odadan silinmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır")) { SiparisleriGetir(); }
                            else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }
    }
}