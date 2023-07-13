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

namespace OtelOtomasyonu.Muhasebe {
    public partial class Form_Muhasebe : Form {
        public Form_Muhasebe() {
            InitializeComponent();
            TabloVerileriniGetir();
        }

        int secilisatir = 0;
        public static DataRow satir;
        bool ilkEklendiMi = false;

        private void TabloVerileriniGetir() {
            gunlukMuhasebeTableAdapter.Fill(gunlukMuhasebeDataSet.GunlukMuhasebe);
            gridView_gunluk.BestFitColumns();
            muhasebeIslemleriTableAdapter.Fill(muhasebeIslemleriDataSet.MuhasebeIslemleri);
            gridView_islem.BestFitColumns();
            muhasebeTurleriTableAdapter.Fill(muhasebeTurleriDataSet.MuhasebeTurleri);
        }

        private void ToolStripButtons_Click(object sender, EventArgs e) {
            secilisatir = gridView_islem.FocusedRowHandle;
            satir = gridView_islem.GetDataRow(secilisatir);
            switch ((sender as ToolStripButton).Text) {
                case "Ekle": Form_islemleri.Form_Ac(new Form_MuhasebeEkle()); break;
                case "Sil": Form_islemleri.Form_Ac(new Form_MuhasebeSil()); break;
                case "Güncelle": Form_islemleri.Form_Ac(new Form_MuhasebeGuncelle()); break;
                case "Genel Muhasebe Raporu": Form_islemleri.Form_Ac(new Form_GenelMuhasebeRaporu()); break;
                case "Günlük Muhasebe Raporu": Form_islemleri.Form_Ac(new Form_GunlukMuhasebeRaporu()); break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
            TabloVerileriniGetir();
        }

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
                comboBox_turbirebir.Enabled = true;
                comboBox_turbirebir.Focus();
            }
            else {
                comboBox_turbirebir.Text = "";
                comboBox_turbirebir.Enabled = false;
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

        private void button_birebirara_Click(object sender, EventArgs e) { BirebirAra(); }

        private void BirebirAra() {
            try {
                ilkEklendiMi = false;
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM MuhasebeIslemleri";
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) {
                    sorguSatiri += " WHERE ";
                    if (checkBox1.Checked) {
                        sorguSatiri += "islem_ad = '" + textBox_baslikbirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox2.Checked) {
                        if (ilkEklendiMi) sorguSatiri += "AND islem_baslik = '" + comboBox_turbirebir.Text + "'";
                        else sorguSatiri += "islem_baslik = '" + comboBox_turbirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox3.Checked) {
                        if (ilkEklendiMi) sorguSatiri += " AND islem_tarih = '" + maskedTextBox_tarihbirebir.Text + "'";
                        else sorguSatiri += "islem_tarih = '" + maskedTextBox_tarihbirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri, Form_Otel.baglanti);
                da.Fill(ds, "MuhasebeIslemleri");
                gridControl_islem.DataSource = ds.Tables["MuhasebeIslemleri"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_aciklama.Checked) {
                label3.Text = "Başlık:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
            else {
                label3.Text = "Ücret:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
        }

        private void textBox_aranan_TextChanged(object sender, EventArgs e) { HizliAra(); }

        private void HizliAra() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM MuhasebeIslemleri WHERE ";
                if (radioButton_aciklama.Checked) sorguSatiri += "islem_ad ";
                else sorguSatiri += "islem_ucret ";
                switch (comboBox_filtre.Text) {
                    case "İle Başlayan": sorguSatiri += "Like'" + textBox_aranan.Text + "%'"; break;
                    case "İle Biten": sorguSatiri += "Like'%" + textBox_aranan.Text + "'"; break;
                    case "İçeren": sorguSatiri += "Like'%" + textBox_aranan.Text + "%'"; break;
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri, Form_Otel.baglanti);
                da.Fill(ds, "MuhasebeIslemleri");
                gridControl_islem.DataSource = ds.Tables["MuhasebeIslemleri"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}