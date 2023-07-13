using DevExpress.XtraExport.Xls;
using OtelOtomasyonu.Gecmisler;
using OtelOtomasyonu.Odalar;
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

namespace OtelOtomasyonu.Gecmiler {
    public partial class Form_Gecmisler : Form {
        public Form_Gecmisler() {
            InitializeComponent();
            odaIslemGecmisleriTableAdapter.Fill(odaIslemGecmisleriDataSet.OdaIslemGecmisleri);
            gridView1.BestFitColumns();
            muhasebeIslemleriTableAdapter.Fill(muhasebeGecmisleriDataSet.MuhasebeIslemleri);
            gridView2.BestFitColumns();
            cariGecmisleriTableAdapter.Fill(cariGecmisleriDataSet.CariGecmisleri);
            gridView3.BestFitColumns();
            personelIslemGecmisleriTableAdapter.Fill(personelIslemGecmisleriDataSet.PersonelIslemGecmisleri);
            gridView4.BestFitColumns();
        }

        bool ilkEklendiMi = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                textBox_baslikbirebir.Enabled = true;
                textBox_baslikbirebir.Focus();
            }
            else {
                textBox_baslikbirebir.Text = "";
                textBox_baslikbirebir.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked) {
                maskedTextBox_saatbirebir.Enabled = true;
                maskedTextBox_saatbirebir.Focus();
            }
            else {
                maskedTextBox_saatbirebir.Text = "";
                maskedTextBox_saatbirebir.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked) {
                maskedTextBox_tarihbirebir.Enabled = true;
                maskedTextBox_tarihbirebir.Focus();
            }
            else {
                maskedTextBox_tarihbirebir.Text = "";
                maskedTextBox_tarihbirebir.Enabled = false;
            }
        }

        private void button_birebirara_Click(object sender, EventArgs e) {
            string col1 = "gecmis_baslik", col2 = "gecmis_saat", col3 = "gecmis_tarih", tableName = "MuhasebeIslemleri";
            if(comboBox_tablobirebir.Text == "Muhasebe İşlem Geçmişleri") { col1 = "islem_ad"; col2 = "islem_saat"; col3 = "islem_tarih"; }
            if(comboBox_tablobirebir.Text == "Oda Kayıt Geçmişleri") { tableName = "OdaIslemGecmisleri"; }
            if(comboBox_tablobirebir.Text == "Cari İşlem Geçmişleri") { tableName = "CariGecmisleri"; }
            if(comboBox_tablobirebir.Text == "Personel İşlem Geçmişleri") { tableName = "PersonelIslemGecmisleri"; }
            BirebirAra(col1,col2,col3,tableName); 
        }

        private void BirebirAra(string col1, string col2, string col3, string tableName) {
            try {
                ilkEklendiMi = false;
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM " + tableName;
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) {
                    sorguSatiri += " WHERE ";
                    if (checkBox1.Checked) {
                        sorguSatiri += col1 + " = '" + textBox_baslikbirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox2.Checked) {
                        if (ilkEklendiMi) sorguSatiri += "AND " + col2 + " = '" + maskedTextBox_saatbirebir.Text + "'";
                        else sorguSatiri += col2 + " = '" + maskedTextBox_saatbirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox3.Checked) {
                        if (ilkEklendiMi) sorguSatiri += " AND " + col3 + " = '" + maskedTextBox_tarihbirebir.Text + "'";
                        else sorguSatiri += col3 + " = '" + maskedTextBox_tarihbirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri, Form_Otel.baglanti);
                da.Fill(ds, tableName);
                switch (comboBox_tablobirebir.Text) {
                    case "Oda Kayıt Geçmişleri": gridControl1.DataSource = ds.Tables[tableName]; break;
                    case "Muhasebe İşlem Geçmişleri": gridControl2.DataSource = ds.Tables[tableName]; break;
                    case "Cari İşlem Geçmişleri": gridControl3.DataSource = ds.Tables[tableName]; break;
                    case "Personel İşlem Geçmişleri": gridControl4.DataSource = ds.Tables[tableName]; break;
                }
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_aciklama.Checked) {
                label6.Text = "Başlık:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
            else {
                if (comboBox_tabloHizli.Text == "Muhasebe İşlem Geçmişleri") label6.Text = "Tür:";
                else label6.Text = "Detay:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
        }

        private void textBox_aranan_TextChanged(object sender, EventArgs e) {
            string col1 = "gecmis_baslik", col2 = "gecmis_detay", tableName = "MuhasebeIslemleri";
            if (comboBox_tabloHizli.Text == "Muhasebe İşlem Geçmişleri") { col1 = "islem_ad"; col2 = "islem_tur"; }
            if (comboBox_tabloHizli.Text == "Oda Kayıt Geçmişleri") { tableName = "OdaIslemGecmisleri"; col2 = "gecmis_aciklama"; }
            if (comboBox_tabloHizli.Text == "Cari İşlem Geçmişleri") { tableName = "CariGecmisleri"; }
            if (comboBox_tabloHizli.Text == "Personel İşlem Geçmişleri") { tableName = "PersonelIslemGecmisleri"; }
            HizliAra(col1, col2, tableName); 
        }

        private void HizliAra(string col1, string col2, string tableName) {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM " + tableName + " WHERE ";
                if(radioButton_aciklama.Checked) { sorguSatiri += col1; }
                else { sorguSatiri += col2; }
                switch (comboBox_filtre.Text) {
                    case "İle Başlayan": sorguSatiri += " Like'" + textBox_aranan.Text + "%'"; break;
                    case "İle Biten": sorguSatiri += " Like'%" + textBox_aranan.Text + "'"; break;
                    case "İçeren": sorguSatiri += " Like'%" + textBox_aranan.Text + "%'"; break;
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri,Form_Otel.baglanti);
                da.Fill(ds, tableName);
                switch (comboBox_tabloHizli.Text) {
                    case "Oda Kayıt Geçmişleri": gridControl1.DataSource = ds.Tables[tableName]; break;
                    case "Muhasebe İşlem Geçmişleri": gridControl2.DataSource = ds.Tables[tableName]; break;
                    case "Cari İşlem Geçmişleri": gridControl3.DataSource = ds.Tables[tableName]; break;
                    case "Personel İşlem Geçmişleri": gridControl4.DataSource = ds.Tables[tableName]; break;
                }
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ToolStripButtons_Click(object sender, EventArgs e) {
            switch ((sender as ToolStripButton).Text) {
                case "Oda Kayıt Geçmişleri Listesi Raporu": Form_islemleri.Form_Ac(new Form_OdaKayitGecmisleriListesiRaporu()); break;
                case "Muhasebe İşlemleri Listesi Raporu": Form_islemleri.Form_Ac(new Form_MuhasebeIslemleriListesiRaporu()); break;
                case "Cari İşlem Geçmişleri Listesi Raporu": Form_islemleri.Form_Ac(new Form_CariIslemGecmisleriListesiRaporu()); break;
                case "Personel İşlem Geçmişleri Listesi Raporu": Form_islemleri.Form_Ac(new Form_PersonelIslemGecmisleriListesiRaporu()); break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }
    }
}