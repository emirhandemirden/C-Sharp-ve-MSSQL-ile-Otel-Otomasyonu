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
    public partial class Form_Kafeterya : Form {
        public Form_Kafeterya() {
            InitializeComponent();
            urunlerTableAdapter.Fill(urunlerDataSet.Urunler);
            urunKategorileriTableAdapter.Fill(urunKategorileriDataSet.UrunKategorileri);
            gridView_list.BestFitColumns();
        }

        int secilisatir = 0;
        public static DataRow satir;
        bool ilkEklendiMi = false;

        private void ToolStripButtons_Click(object sender, EventArgs e) {
            secilisatir = gridView_list.FocusedRowHandle;
            satir = gridView_list.GetDataRow(secilisatir);
            switch ((sender as ToolStripButton).Text) {
                case "Ürün Ekle": Form_islemleri.Form_Ac(new Form_UrunEkle()); break;
                case "Ürün Sil": Form_islemleri.Form_Ac(new Form_UrunSil()); break;
                case "Ürün Güncelle": Form_islemleri.Form_Ac(new Form_UrunGuncelle()); break;
                case "Ürünler Listesi Raporu": Form_islemleri.Form_Ac(new Form_UrunlerListesiRaporu()); break;
                case "Kategoriye Göre Ürünler Listesi Raporu": Form_islemleri.Form_Ac(new Form_KategoriyeGoreUrunlerListesi()); break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
            urunlerTableAdapter.Fill(urunlerDataSet.Urunler);
        }

        private void BirebirAra() {
            try {
                ilkEklendiMi = false;
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM Urunler";
                if (checkBox1.Checked || checkBox2.Checked) {
                    sorguSatiri += " WHERE ";
                    if (checkBox1.Checked) {
                        sorguSatiri += "urun_ad = '" + textBox_urunadbirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox2.Checked) {
                        if (ilkEklendiMi) sorguSatiri += "AND urun_kategori = '" + comboBox_kategoribirebir.Text + "'";
                        else sorguSatiri += "urun_kategori = '" + comboBox_kategoribirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri, Form_Otel.baglanti);
                da.Fill(ds, "Urunler");
                gridControl_list.DataSource = ds.Tables["Urunler"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void HizliAra() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM Urunler WHERE ";
                if (radioButton_ad.Checked) sorguSatiri += "urun_ad "; 
                else sorguSatiri += "urun_stok ";
                switch (comboBox_filtre.Text) {
                    case "İle Başlayan": sorguSatiri += "Like'" + textBox_aranan.Text + "%'"; break;
                    case "İle Biten": sorguSatiri += "Like'%" + textBox_aranan.Text + "'"; break;
                    case "İçeren": sorguSatiri += "Like'%" + textBox_aranan.Text + "%'"; break;
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri,Form_Otel.baglanti);
                da.Fill(ds, "Urunler");
                gridControl_list.DataSource = ds.Tables["Urunler"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_ad.Checked) {
                label2.Text = "Ürün Ad:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
            else {
                label2.Text = "Ürün Stok:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
        }

        private void textBox_aranan_TextChanged(object sender, EventArgs e) { HizliAra(); }

        private void button_birebirara_Click(object sender, EventArgs e) { BirebirAra(); }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                textBox_urunadbirebir.Enabled = true;
                textBox_urunadbirebir.Focus();
            }
            else {
                textBox_urunadbirebir.Text = "";
                textBox_urunadbirebir.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked) {
                comboBox_kategoribirebir.Enabled = true;
                comboBox_kategoribirebir.Focus();
            }
            else {
                comboBox_kategoribirebir.SelectedIndex = 0;
                comboBox_kategoribirebir.Enabled = false;
            }
        }
    }
}