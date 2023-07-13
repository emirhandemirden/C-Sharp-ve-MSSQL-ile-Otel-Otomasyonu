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

namespace OtelOtomasyonu.Kafeterya {
    public partial class Form_UrunGuncelle : Form {
        public Form_UrunGuncelle() {
            InitializeComponent();
            urunKategorileriTableAdapter.Fill(urunKategorileriDataSet.UrunKategorileri);
            UrunBilgileriniGetir();
        }

        private void UrunBilgileriniGetir() {
            label_id.Text = Form_Kafeterya.satir["urun_id"].ToString();
            textBox_ad.Text = Form_Kafeterya.satir["urun_ad"].ToString();
            maskedTextBox_ucret.Text = Form_Kafeterya.satir["urun_ucret"].ToString();
            maskedTextBox_stok.Text = Form_Kafeterya.satir["urun_stok"].ToString();
            comboBox_kategori.Text = Form_Kafeterya.satir["urun_kategori"].ToString();
        }

        private void button_guncelle_Click(object sender, EventArgs e) {
            if (textBox_ad.Text != "" && maskedTextBox_ucret.Text != "" && maskedTextBox_ekstok.Text != "" && comboBox_kategori.Text != "") {
                if (Veritabani_islemleri.Guncelle("Urunler", "urun_id", label_id.Text, "urun_ad='" + textBox_ad.Text + "',urun_ucret='" + maskedTextBox_ucret.Text + "',urun_stok='" + (int.Parse(maskedTextBox_stok.Text) + int.Parse(maskedTextBox_ekstok.Text)) + "',urun_kategori='" + comboBox_kategori.Text + "'", "Ürün başarıyla güncellendi.")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (comboBox_kategori.Text == "") {
                    comboBox_kategori.BackColor = Color.Red;
                    comboBox_kategori.ForeColor = Color.White;
                    comboBox_kategori.Focus();
                }
                if (maskedTextBox_ekstok.Text == "") {
                    maskedTextBox_ekstok.BackColor = Color.Red;
                    maskedTextBox_ekstok.ForeColor = Color.White;
                    maskedTextBox_ekstok.Focus();
                }
                if (maskedTextBox_ucret.Text == "") {
                    maskedTextBox_ucret.BackColor = Color.Red;
                    maskedTextBox_ucret.ForeColor = Color.White;
                    maskedTextBox_ucret.Focus();
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
            UrunBilgileriniGetir();
            textBox_ad.BackColor = Color.White;
            textBox_ad.ForeColor = Color.Black;
            maskedTextBox_ucret.BackColor = Color.White;
            maskedTextBox_ucret.ForeColor = Color.Black;
            maskedTextBox_ekstok.BackColor = Color.White;
            maskedTextBox_ekstok.ForeColor = Color.Black;
            comboBox_kategori.BackColor = Color.White;
            comboBox_kategori.ForeColor = Color.Black;
            textBox_ad.Focus();
        }
    }
}