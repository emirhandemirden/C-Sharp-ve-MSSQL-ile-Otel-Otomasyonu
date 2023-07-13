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

namespace OtelOtomasyonu.Cariler {
    public partial class Form_Cariler : Form {
        public Form_Cariler() {
            InitializeComponent();
            carilerTableAdapter.Fill(carilerDataSet.Cariler);
            cariTurleriTableAdapter.Fill(cariTurleriDataSet.CariTurleri);
            gridView_list.BestFitColumns();
        }

        int secilisatir = 0;
        public static DataRow satir;
        bool ilkEklendiMi = false;

        private void toolStripButtons_Click(object sender, EventArgs e) {
            secilisatir = gridView_list.FocusedRowHandle;
            satir = gridView_list.GetDataRow(secilisatir);
            switch ((sender as ToolStripButton).Text) {
                case "Cari Ekle": Form_islemleri.Form_Ac(new Form_CariEkle()); break;
                case "Cari Sil": Form_islemleri.Form_Ac(new Form_CariSil()); break;
                case "Cari Güncelle": Form_islemleri.Form_Ac(new Form_CariGuncelle()); break;
                case "Cariler Listesi Raporu": Form_islemleri.Form_Ac(new Form_CarilerListesiRaporu()); break;
                case "Türüne Göre Cariler Listesi Raporu": Form_islemleri.Form_Ac(new Form_TuruneGoreCarilerListesi()); break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
            carilerTableAdapter.Fill(carilerDataSet.Cariler);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                textBox_adBirebir.Enabled = true;
                textBox_adBirebir.Focus();
            }
            else {
                textBox_adBirebir.Text = "";
                textBox_adBirebir.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked) {
                maskedTextBox_dogumbirebir.Enabled = true;
                maskedTextBox_dogumbirebir.Focus();
            }
            else {
                maskedTextBox_dogumbirebir.Text = "";
                maskedTextBox_dogumbirebir.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked) {
                comboBox_turbirebir.Enabled = true;
                comboBox_turbirebir.Focus();
            }
            else {
                comboBox_turbirebir.SelectedIndex = 0;
                comboBox_turbirebir.Enabled = false;
            }
        }

        private void button_birebirara_Click(object sender, EventArgs e) { BirebirAra(); }

        private void BirebirAra() {
            try {
                ilkEklendiMi = false;
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM Cariler";
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                {
                    sorguSatiri += " WHERE ";
                    if (checkBox1.Checked)
                    {
                        sorguSatiri += "cari_ad = '" + textBox_adBirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox2.Checked)
                    {
                        if (ilkEklendiMi) sorguSatiri += "AND cari_dogum = '" + maskedTextBox_dogumbirebir.Text + "'";
                        else sorguSatiri += "cari_dogum = '" + maskedTextBox_dogumbirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox3.Checked)
                    {
                        if (ilkEklendiMi) sorguSatiri += " AND cari_tur = '" + comboBox_turbirebir.Text + "'";
                        else sorguSatiri += "cari_tur = '" + comboBox_turbirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri, Form_Otel.baglanti);
                da.Fill(ds, "Cariler");
                gridControl_list.DataSource = ds.Tables["Cariler"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RadioButtonsCheckedChanged(object sender, EventArgs e) {
            if (radioButton_ad.Checked) {
                label2.Text = "Ad:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
            else {
                label2.Text = "Telefon Numarası:";
                textBox_aranan.Focus();
                textBox_aranan.Text = "";
            }
        }

        private void textBox_aranan_TextChanged(object sender, EventArgs e) { HizliAra(); }

        private void HizliAra() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM Cariler WHERE ";
                if (radioButton_ad.Checked) sorguSatiri += "cari_ad "; 
                else sorguSatiri += "cari_tel ";
                switch (comboBox_filtre.Text) {
                    case "İle Başlayan": sorguSatiri += "Like'" + textBox_aranan.Text + "%'"; break;
                    case "İle Biten": sorguSatiri += "Like'%" + textBox_aranan.Text + "'"; break;
                    case "İçeren": sorguSatiri += "Like'%" + textBox_aranan.Text + "%'"; break;
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sorguSatiri,Form_Otel.baglanti);
                da.Fill(ds, "Cariler");
                gridControl_list.DataSource = ds.Tables["Cariler"];
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}