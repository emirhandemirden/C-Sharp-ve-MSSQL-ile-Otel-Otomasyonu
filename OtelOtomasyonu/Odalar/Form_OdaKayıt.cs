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
    public partial class Form_OdaKayıt : Form {
        public Form_OdaKayıt() {
            InitializeComponent();
            carilerTableAdapter.FillBy(musterilerDataSet.Cariler);
            odalarTableAdapter.Fill(odalarDataSet.Odalar);
            dateTimePicker_giris.MinDate = DateTime.Today;
            dateTimePicker_cikis.MinDate = DateTime.Today.AddDays(1);
            textBox_ucret.TextChanged += new EventHandler(UcretHesapla);
            if (Form_Otel.anasayfadanmi == "Evet") OdaBilgileriniGetir();
            else OdalariGetir();
            dateTimePicker_giris.ValueChanged += new EventHandler(UcretHesapla);
            dateTimePicker_cikis.ValueChanged += new EventHandler(UcretHesapla);
        }

        double netgelir = 0, gelir = 0, ucret = 0;
        string id = "", oda_id = "";
        int gunsayisi = 0;

        private void OdalariGetir() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM Odalar WHERE oda_dolumu='Hayır'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                while (verioku.Read()) comboBox_oda.Items.Add(verioku["oda_id"].ToString() + ": Oda " + verioku["oda_kat"].ToString() + "." + verioku["oda_no"].ToString());
                verioku.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
                comboBox_oda.SelectedIndex = 0;
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void OdaBilgileriniGetir() {
            oda_id = Form_Otel.oda_id;
            groupBox_odaBilgileri.Text = Form_Otel.oda_ad + " Bilgileri";
            label_odaAciklama.Text = Form_Otel.oda_aciklama;
            ucret = double.Parse(Form_Otel.oda_ucret);
            textBox_ucret.Text = ucret.ToString();
            comboBox_oda.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_oda.Text = Form_Otel.oda_ad;
            comboBox_oda.Enabled = false;
        }

        private void MuhasebeVerileriniGuncelle() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM GunlukMuhasebe WHERE muhasebe_tarih='" + DateTime.Now.ToShortDateString() + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                if (verioku.Read()) {
                    id = verioku["muhasebe_id"].ToString();
                    netgelir = double.Parse(verioku["muhasebe_netgelir"].ToString());
                }
                verioku.Close();
                netgelir += double.Parse(textBox_ucret2.Text);
                gelir += double.Parse(textBox_ucret2.Text);
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_kaydet_Click(object sender, EventArgs e) {
            if (comboBox_musteri.Text != "" && textBox_ucret.Text != "" && textBox_ucret2.Text != "") {
                MuhasebeVerileriniGuncelle();
                if (Veritabani_islemleri.Guncelle("GunlukMuhasebe", "muhasebe_id", id, "muhasebe_netgelir='" + netgelir + "', muhasebe_gelir='" + gelir + "'", "Günlük muhasebe verileri güncellendi.") && Veritabani_islemleri.Ekle("MuhasebeIslemleri","islem_ad,islem_tur,islem_ucret,islem_saat,islem_tarih", "'Oda kayıt işlemi.','Gelir','" + textBox_ucret2.Text + "','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'","Hayır") && Veritabani_islemleri.Ekle("OdaKayitlari", "kayit_musteri,kayit_giris,kayit_cikis,oda_id,oda_ad,kayit_sure,kayıt_ucret", "'" + comboBox_musteri.Text + "','" + dateTimePicker_giris.Value.ToShortDateString() + "','" + dateTimePicker_cikis.Value.ToShortDateString() + "','" + oda_id + "','" + Form_Otel.oda_ad + "','" + gunsayisi + "','" + ucret + "'", comboBox_musteri.Text + " adlı müşteri odaya eklendi eklendi.") && Veritabani_islemleri.Ekle("OdaIslemGecmisleri", "oda_ad,gecmis_baslik,gecmis_aciklama,gecmis_saat,gecmis_tarih", "'" + Form_Otel.oda_ad + "','Oda Kayıt İşlemi','" + comboBox_musteri.Text + " adlı müşteri tarafından " + dateTimePicker_giris.Value.ToShortDateString() + "-" + dateTimePicker_cikis.Value.ToShortDateString() + " tarihleri arası zaman için oda kaydı gerçekleştirilmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'","Hayır") && Veritabani_islemleri.Guncelle("Odalar","oda_id",Form_Otel.oda_id,"oda_dolumu='Evet'","Hayır")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (textBox_ucret2.Text == "") {
                    textBox_ucret2.BackColor = Color.Red;
                    textBox_ucret2.ForeColor = Color.White;
                    textBox_ucret2.Focus();
                }
                if (textBox_ucret.Text == "") {
                    textBox_ucret.BackColor = Color.Red;
                    textBox_ucret.ForeColor = Color.White;
                    textBox_ucret.Focus();
                }
                if (comboBox_musteri.Text == "") {
                    comboBox_musteri.BackColor = Color.Red;
                    comboBox_musteri.ForeColor = Color.White;
                    comboBox_musteri.Focus();
                }
                MessageBox.Show("Kırmızı ile işaretlenmiş yerleri lütfen doldurunuz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox_oda_SelectedIndexChanged(object sender, EventArgs e) {
            string[] yazi = comboBox_oda.Text.Split(':');
            oda_id = yazi[0];
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM Odalar WHERE oda_id='" + oda_id + "'", Form_Otel.baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                if (verioku.Read()) { 
                    textBox_ucret.Text = verioku["oda_ucret"].ToString();
                    label_odaAciklama.Text = verioku["oda_aciklama"].ToString();
                }
                verioku.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void UcretHesapla(object sender, EventArgs e) {
            if (dateTimePicker_giris.Value < dateTimePicker_cikis.Value) {
                ucret = double.Parse(textBox_ucret.Text);
                TimeSpan fark = dateTimePicker_cikis.Value - dateTimePicker_giris.Value;
                gunsayisi = (int)Math.Ceiling(fark.TotalHours / 24);
                label5.Text = gunsayisi + " Günlük Ücret:";
                ucret *= gunsayisi;
                textBox_ucret2.Text = ucret.ToString();
            }
            else { MessageBox.Show("Giriş tarihi çıkış tarihinden sonra olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}