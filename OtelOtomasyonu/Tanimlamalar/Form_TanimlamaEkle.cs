using OtelOtomasyonu.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Tanimlamalar {
    public partial class Form_TanimlamaEkle : Form {
        public Form_TanimlamaEkle() { InitializeComponent(); }

        private void comboBox_secim_SelectedIndexChanged(object sender, EventArgs e) {
            Sifirla();
            switch (comboBox_secim.Text) {
                case "Oda Türleri": break;
                case "Oda Eşyaları": label_icerik.Text = "Eşya:"; break;
                case "Cari Türleri":
                    groupBox_yetkiler.Visible = true;
                    Size = new Size(326, 490);
                    break;
                case "Muhasebe İşlem Türleri":
                    Size = new Size(326, 232);
                    label3.Visible = true;
                    label_icerik.Text = "Başlık:";
                    comboBox_muhasebeTur.Visible = true;
                    break;
                case "Ürün Kategorileri": label_icerik.Text = "Kategori:"; break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        private void Sifirla() {
            label3.Visible = false;
            comboBox_muhasebeTur.Visible = false;
            groupBox_yetkiler.Visible = false;
            label_icerik.Text = "Tür:";
            Size = new Size(326, 195);
            textBox_icerik.Text = "";
            comboBox_muhasebeTur.SelectedIndex = 0;
            foreach (CheckBox item in groupBox_yetkiler.Controls) { if (item is CheckBox) item.Checked = false; }
            textBox_icerik.BackColor = Color.White;
            textBox_icerik.ForeColor = Color.Black;
            textBox_icerik.Focus();
        }

        private void button_kaydet_Click(object sender, EventArgs e) {
            if(textBox_icerik.Text != "") {
                switch (comboBox_secim.Text) {
                    case "Oda Türleri":
                        if (Veritabani_islemleri.Ekle("OdaTurleri", "tur_ad", "'" + textBox_icerik.Text + "'", "Oda türü başarıyla eklendi.")) Sifirla();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Oda Eşyaları":
                        if (Veritabani_islemleri.Ekle("OdaEsyalari", "esya_ad", "'" + textBox_icerik.Text + "'", "Oda eşyası başarıyla eklendi.")) Sifirla();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Cari Türleri":
                        if (Veritabani_islemleri.Ekle("CariTurleri", "tur_ad,tur_uygulama,tur_odalar,tur_muhasebe,tur_cariler,tur_gecmisler,tur_tanimlamalar,tur_ayarlar,tur_kafeterya", "'" + textBox_icerik.Text + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "','" + checkBox3.Checked + "','" + checkBox4.Checked + "','" + checkBox5.Checked + "','" + checkBox6.Checked + "','" + checkBox7.Checked + "','" + checkBox8.Checked + "'", "Cari türü başarıyla eklendi.")) Sifirla();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Muhasebe İşlem Türleri":
                        if (Veritabani_islemleri.Ekle("MuhasebeTurleri", "tur_ad,tur_tur", "'" + textBox_icerik.Text + "','" + comboBox_muhasebeTur.Text + "'", "Muhasebe türü başarıyla eklendi.")) Sifirla();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Ürün Kategorileri":
                        if (Veritabani_islemleri.Ekle("UrunKategorileri", "kategori_ad", "'" + textBox_icerik.Text + "'", "Kategori başarıyla eklendi.")) Sifirla();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                }
                comboBox_secim.SelectedIndex = 0;
            }
            else {
                textBox_icerik.BackColor = Color.Red;
                textBox_icerik.ForeColor = Color.White;
                textBox_icerik.Focus();
            }
        }
    }
}