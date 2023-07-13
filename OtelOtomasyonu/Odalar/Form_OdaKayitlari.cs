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
    public partial class Form_OdaKayitlari : Form {
        public Form_OdaKayitlari() {
            InitializeComponent();
            odaKayitlariTableAdapter.Fill(odaKayitlariDataSet.OdaKayitlari);
            gridView_list.BestFitColumns();
        }

        int secilisatir = 0;
        public static DataRow satir;
        bool ilkEklendiMi = false;

        private void ToolStripButtons_Click(object sender, EventArgs e) {
            secilisatir = gridView_list.FocusedRowHandle;
            satir = gridView_list.GetDataRow(secilisatir);
            switch ((sender as ToolStripButton).Tag) {
                case "Ekle": Form_islemleri.Form_Ac(new Form_OdaKayıt()); break;
                case "Sil": Form_islemleri.Form_Ac(new Form_OdaKayitSil()); break;
                case "Rapor1": Form_islemleri.Form_Ac(new Form_OdalaraGoreKayitListesiRaporu()); break;
                case "Rapor2": Form_islemleri.Form_Ac(new Form_OdaIDeGoreKayitListesiRaporu()); break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
            odaKayitlariTableAdapter.Fill(odaKayitlariDataSet.OdaKayitlari);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                comboBox_odabirebir.Enabled = true;
                comboBox_odabirebir.Focus();
            }
            else {
                comboBox_odabirebir.SelectedIndex = 0;
                comboBox_odabirebir.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked) {
                maskedTextBox_girisbirebir.Enabled = true;
                maskedTextBox_girisbirebir.Focus();
            }
            else {
                maskedTextBox_girisbirebir.Text = "";
                maskedTextBox_girisbirebir.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked) {
                maskedTextBox_cikisbirebir.Enabled = true;
                maskedTextBox_cikisbirebir.Focus();
            }
            else {
                maskedTextBox_cikisbirebir.Text = "";
                maskedTextBox_cikisbirebir.Enabled = false;
            }
        }

        private void button_birebirara_Click(object sender, EventArgs e) { BirebirAra(); }

        private void BirebirAra() {
            try {
                ilkEklendiMi = false;
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM OdaKayitlari";
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) {
                    sorguSatiri += " WHERE ";
                    if (checkBox1.Checked) {
                        sorguSatiri += "oda_ad = '" + comboBox_odabirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox2.Checked) {
                        if (ilkEklendiMi) sorguSatiri += "AND kayit_giris = '" + maskedTextBox_girisbirebir.Text + "'";
                        else sorguSatiri += "kayit_giris = '" + maskedTextBox_girisbirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox3.Checked) {
                        if (ilkEklendiMi) sorguSatiri += " AND kayit_cikis = '" + maskedTextBox_cikisbirebir.Text + "'";
                        else sorguSatiri += "kayit_cikis = '" + maskedTextBox_cikisbirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri, Form_Otel.baglanti);
                da.Fill(ds, "OdaKayitlari");
                gridControl_list.DataSource = ds.Tables["OdaKayitlari"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_ad.Checked) {
                label2.Text = "Müşteri Ad:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
            else {
                label2.Text = "Süre (Gün):";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
        }

        private void HizliAra() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM OdaKayitlari WHERE ";
                if (radioButton_ad.Checked) sorguSatiri += "kayit_musteri "; 
                else sorguSatiri += "kayit_sure ";
                switch (comboBox_filtre.Text) {
                    case "İle Başlayan": sorguSatiri += "Like'" + textBox_aranan.Text + "%'"; break;
                    case "İle Biten": sorguSatiri += "Like'%" + textBox_aranan.Text + "'"; break;
                    case "İçeren": sorguSatiri += "Like'%" + textBox_aranan.Text + "%'"; break;
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri,Form_Otel.baglanti);
                da.Fill(ds, "OdaKayitlari");
                gridControl_list.DataSource = ds.Tables["OdaKayitlari"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBox_aranan_TextChanged(object sender, EventArgs e) { HizliAra(); }
    }
}