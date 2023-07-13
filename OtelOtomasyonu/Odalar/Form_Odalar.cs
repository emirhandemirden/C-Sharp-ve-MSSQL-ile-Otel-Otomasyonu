using OtelOtomasyonu.Sınıflar;
using OtelOtomasyonu.Odalar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelOtomasyonu.Odalar {
    public partial class Form_Odalar : Form {
        public Form_Odalar() {
            InitializeComponent();
            odalarTableAdapter.Fill(odalarDataSet.Odalar);
            odaTurleriTableAdapter.Fill(odaTurleriDataSet.OdaTurleri);
            gridView_list.BestFitColumns();
        }

        int secilisatir = 0;
        public static DataRow satir;
        bool ilkEklendiMi = false;

        private void ToolStripButtons_Click(object sender, EventArgs e) {
            secilisatir = gridView_list.FocusedRowHandle;
            satir = gridView_list.GetDataRow(secilisatir);
            switch ((sender as ToolStripButton).Text) {
                case "Oda Ekle": Form_islemleri.Form_Ac(new Form_OdaEkle()); break;
                case "Oda Sil": Form_islemleri.Form_Ac(new Form_OdaSil()); break;
                case "Oda Güncelle": Form_islemleri.Form_Ac(new Form_OdaGuncelle()); break;
                case "Oda Listesi Raporu": Form_islemleri.Form_Ac(new Form_OdalarRapor()); break;
                case "Türüne Göre Odalar Listesi Raporu": Form_islemleri.Form_Ac(new Form_TuruneGoreOdalarRapor()); break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
            odalarTableAdapter.Fill(odalarDataSet.Odalar);
        }

        private void button_birebirara_Click(object sender, EventArgs e) { BirebirAra(); }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                maskedTextBox_katnobirebir.Enabled = true;
                maskedTextBox_katnobirebir.Focus();
            }
            else {
                maskedTextBox_katnobirebir.Text = "";
                maskedTextBox_katnobirebir.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked) {
                comboBox_turbirebir.Enabled = true;
                comboBox_turbirebir.Focus();
            }
            else {
                comboBox_turbirebir.SelectedIndex = 0;
                comboBox_turbirebir.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked) {
                maskedTextBox_yataksayisibirebir.Enabled = true;
                maskedTextBox_yataksayisibirebir.Focus();
            }
            else {
                maskedTextBox_yataksayisibirebir.Text = "";
                maskedTextBox_yataksayisibirebir.Enabled = false;
            }
        }

        private void BirebirAra() {
            try {
                ilkEklendiMi = false;
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM Odalar";
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) {
                    sorguSatiri += " WHERE ";
                    if (checkBox1.Checked) {
                        sorguSatiri += "oda_kat = '" + maskedTextBox_katnobirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox2.Checked) {
                        if (ilkEklendiMi) sorguSatiri += "AND oda_tur = '" + comboBox_turbirebir.Text + "'";
                        else sorguSatiri += "oda_tur = '" + comboBox_turbirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox3.Checked) {
                        if (ilkEklendiMi) sorguSatiri += " AND oda_yataksayisi = '" + maskedTextBox_yataksayisibirebir.Text + "'";
                        else sorguSatiri += "oda_yataksayisi = '" + maskedTextBox_yataksayisibirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri, Form_Otel.baglanti);
                da.Fill(ds, "Odalar");
                gridControl_list.DataSource = ds.Tables["Odalar"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void HizliAra() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM Odalar WHERE ";
                if (radioButton_aciklama.Checked) sorguSatiri += "oda_aciklama "; 
                else sorguSatiri += "oda_esyalar ";
                switch (comboBox_filtre.Text) {
                    case "İle Başlayan": sorguSatiri += "Like'" + textBox_aranan.Text + "%'"; break;
                    case "İle Biten": sorguSatiri += "Like'%" + textBox_aranan.Text + "'"; break;
                    case "İçeren": sorguSatiri += "Like'%" + textBox_aranan.Text + "%'"; break;
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri,Form_Otel.baglanti);
                da.Fill(ds, "Odalar");
                gridControl_list.DataSource = ds.Tables["Odalar"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_aciklama.Checked) {
                label2.Text = "Açıklama:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
            else {
                label2.Text = "Eşyalar:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
        }

        private void textBox_aranan_TextChanged(object sender, EventArgs e) { HizliAra(); }
    }
}