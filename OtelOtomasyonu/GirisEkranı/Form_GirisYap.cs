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

namespace OtelOtomasyonu.Giriş_Ekranı {
    public partial class Form_GirisYap : Form {
        public Form_GirisYap() {
            InitializeComponent();
            GunlukMuhasebeKontrol();
            OdalariTemizle();
        }

        public static string muhasebe_id = "", kullaniciTur = "";
        public static string kullaniciAdi = "";

        private void OdalariTemizle() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM OdaKayitlari", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                while (verioku.Read()) {
                    if ((DateTime.Parse(verioku["kayit_cikis"].ToString()).Day <= DateTime.Now.Day && DateTime.Parse(verioku["kayit_cikis"].ToString()).Month == DateTime.Now.Month) || DateTime.Parse(verioku["kayit_cikis"].ToString()).Month < DateTime.Now.Month || DateTime.Parse(verioku["kayit_cikis"].ToString()).Year < DateTime.Now.Year) {
                        string oda_ad = verioku["oda_ad"].ToString();
                        if (Veritabani_islemleri.Sil("Hayır", "kayit_id", verioku["kayit_id"].ToString(), "OdaKayitlari") && Veritabani_islemleri.Ekle("OdaIslemGecmisleri", "oda_ad,gecmis_baslik,gecmis_aciklama,gecmis_saat,gecmis_tarih", "'" + oda_ad + "','Oda Kayıt Süresi Dolumu','Çıkış tarihi gelmiş olan kayıt silinmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır") && Veritabani_islemleri.Guncelle("Odalar", "oda_id", verioku["oda_id"].ToString(),"oda_dolumu='Hayır'","Hayır")) { }
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                verioku.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void GunlukMuhasebeKontrol() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM GunlukMuhasebe WHERE muhasebe_tarih='" + DateTime.Now.ToShortDateString() + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                if (!verioku.Read()) { Veritabani_islemleri.Ekle("GunlukMuhasebe", "muhasebe_netgelir,muhasebe_gelir,muhasebe_gider,muhasebe_tarih", "'0','0','0','" + DateTime.Now.ToShortDateString() + "'","Hayır"); if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); } }
                verioku.Close();
                verioku = vericek.ExecuteReader();
                if(verioku.Read()) muhasebe_id = verioku["muhasebe_id"].ToString();
                verioku.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SocialMediaButtons_Clicked(object sender, EventArgs e) { System.Diagnostics.Process.Start((sender as Button).AccessibleDescription); }

        private void button_girisYap_Click(object sender, EventArgs e) { GirisYap(); }

        private void button_cikis_Click(object sender, EventArgs e) { if (MessageBox.Show("Devam ederseniz program kapanacak. Onaylıyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit(); }

        private void Form_GirisYap_FormClosing(object sender, FormClosingEventArgs e) { if (Form_Otel.durum == "Programı Kapat" && MessageBox.Show("Devam ederseniz program kapanacak. Onaylıyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) { e.Cancel = true; GirisYap(); } }

        private void GirisYap() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM Cariler WHERE cari_ad='" + textBox_kullaniciAdi.Text + "' AND cari_sifre='" + textBox_Sifre.Text + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                if (verioku.Read()) {
                    Hide();
                    kullaniciTur = verioku["cari_tur"].ToString();
                    kullaniciAdi = verioku["cari_ad"].ToString();
                    Veritabani_islemleri.Ekle("PersonelIslemGecmisleri", "gecmis_baslik,gecmis_detay,gecmis_saat,gecmis_tarih", "'Kullanıcı Giriş İşlemi','" + kullaniciAdi + " adlı kullanıcı uygulamaya giriş yaptı.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'","Hayır");
                    Form_islemleri.Form_Ac(new Form_Otel());
                    if (Form_Otel.durum == "Programı Kapat") { Application.Exit(); }
                    else {
                        textBox_Sifre.Text = "";
                        textBox_kullaniciAdi.Text = "";
                        kullaniciTur = "";
                        kullaniciAdi = "";
                        textBox_kullaniciAdi.Focus();
                        Show();
                    }
                }
                else { MessageBox.Show("Kullanıcı adı veya şifre hatalı!\nTekrar deneyiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox_kullaniciAdi.Focus(); }
                verioku.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}