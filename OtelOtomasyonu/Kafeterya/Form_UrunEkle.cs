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
    public partial class Form_UrunEkle : Form {
        public Form_UrunEkle() {
            InitializeComponent();
            urunKategorileriTableAdapter.Fill(urunKategorileriDataSet.UrunKategorileri);
        }

        private void button_kaydet_Click(object sender, EventArgs e) {
            if (textBox_ad.Text != "" && maskedTextBox_ucret.Text != "" && maskedTextBox_stok.Text != "" && comboBox_kategori.Text != "") {
                if (Veritabani_islemleri.Ekle("Urunler", "urun_ad,urun_ucret,urun_stok,urun_kategori", "'" + textBox_ad.Text + "','" + maskedTextBox_ucret.Text + "','" + maskedTextBox_stok.Text + "','" + comboBox_kategori.Text + "'", "Ürün başarıyla eklendi.")) button_temizle.PerformClick();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (comboBox_kategori.Text == "") {
                    comboBox_kategori.BackColor = Color.Red;
                    comboBox_kategori.ForeColor = Color.White;
                    comboBox_kategori.Focus();
                }
                if (maskedTextBox_stok.Text == "") {
                    maskedTextBox_stok.BackColor = Color.Red;
                    maskedTextBox_stok.ForeColor = Color.White;
                    maskedTextBox_stok.Focus();
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
            textBox_ad.Text = "";
            maskedTextBox_stok.Text = "";
            maskedTextBox_ucret.Text = "";
            comboBox_kategori.Text = "";
            comboBox_kategori.BackColor = Color.White;
            comboBox_kategori.ForeColor = Color.Black;
            maskedTextBox_ucret.BackColor = Color.White;
            maskedTextBox_ucret.ForeColor = Color.Black;
            maskedTextBox_stok.BackColor = Color.White;
            maskedTextBox_stok.ForeColor = Color.Black;
            textBox_ad.BackColor = Color.White;
            textBox_ad.ForeColor = Color.Black;
            textBox_ad.Focus();
        }
    }
}