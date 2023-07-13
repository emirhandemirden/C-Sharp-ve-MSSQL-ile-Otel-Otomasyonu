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

namespace OtelOtomasyonu.Kafeterya {
    public partial class Form_OdaSatis : Form {
        public Form_OdaSatis() {
            InitializeComponent();
            UrunleriGetir();
        }

        double netgelir = 0, gelir = 0, seciliurunlerinfiyati = 0;
        string id = "";

        private void UrunleriGetir() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM Urunler", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                while (verioku.Read()) {
                    string[] satir = { verioku["urun_ad"].ToString(), verioku["urun_ucret"].ToString(), verioku["urun_kategori"].ToString() };
                    listView_urunler.Items.Add(new ListViewItem(satir));
                }
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
                    gelir = double.Parse(verioku["muhasebe_gelir"].ToString());
                }
                verioku.Close();
                for (int i = 0; i < listView_urunler.CheckedItems.Count; i++) { seciliurunlerinfiyati += double.Parse(listView_urunler.CheckedItems[i].SubItems[1].Text); }
                netgelir += seciliurunlerinfiyati;
                gelir += seciliurunlerinfiyati;
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_ekle_Click(object sender, EventArgs e) {
            MuhasebeVerileriniGuncelle();
            if (Veritabani_islemleri.Guncelle("GunlukMuhasebe","muhasebe_id",id, "muhasebe_netgelir='" + netgelir + "', muhasebe_gelir='" + gelir + "'", "Hayır") && Veritabani_islemleri.Ekle("MuhasebeIslemleri", "islem_ad,islem_tur,islem_ucret,islem_saat,islem_tarih", "'Kafeterya Ürün Satışı','Gelir','" + seciliurunlerinfiyati + "','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır")) {
                for (int i = 0; i < listView_urunler.CheckedItems.Count; i++) {
                    if (Veritabani_islemleri.Ekle("Siparisler", "oda_id,siparis_urun,urun_tutar,urun_kategori", "'" + Form_Otel.oda_id + "','" + listView_urunler.CheckedItems[i].SubItems[0].Text + "','" + listView_urunler.CheckedItems[i].SubItems[1].Text + "','" + listView_urunler.CheckedItems[i].SubItems[2].Text + "'", listView_urunler.CheckedItems[i].SubItems[0].Text + " siparişi verildi.") && Veritabani_islemleri.Ekle("OdaIslemGecmisleri", "oda_ad,gecmis_baslik,gecmis_aciklama,gecmis_saat,gecmis_tarih", "'" + Form_Otel.oda_ad + "','Odaya Ürün Ekleme İşlemi','" + listView_urunler.CheckedItems[i].SubItems[0].Text + " adlı ürün " + Form_Otel.oda_ad + " adlı odaya eklenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır")) Close();
                    else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_iptal_Click(object sender, EventArgs e) { Close(); }
    }
}