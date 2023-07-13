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
    public partial class Form_OdaGuncelle : Form {
        public Form_OdaGuncelle() {
            InitializeComponent();
            carilerTableAdapter.FillBy(gorevlilerDataSet.Cariler);
            odaTurleriTableAdapter.Fill(odaTurleriDataSet.OdaTurleri);
            EsyalariGetir();
            OdaBilgileriniGetir();
        }
        string odaesyalari = "";

        private void button_temizle_Click(object sender, EventArgs e) {
            OdaBilgileriniGetir();
            comboBox_gorevlisi.BackColor = Color.White;
            comboBox_gorevlisi.ForeColor = Color.Black;
            comboBox_tur.BackColor = Color.White;
            comboBox_tur.ForeColor = Color.Black;
            maskedTextBox_yataksayisi.BackColor = Color.White;
            maskedTextBox_yataksayisi.ForeColor = Color.Black;
            richTextBox_aciklama.BackColor = Color.White;
            richTextBox_aciklama.ForeColor = Color.Black;
            maskedTextBox_katno.BackColor = Color.White;
            maskedTextBox_katno.ForeColor = Color.Black;
            maskedTextBox_odano.BackColor = Color.White;
            maskedTextBox_odano.ForeColor = Color.Black;
            maskedTextBox_odano.Focus();
        }

        private void OdaBilgileriniGetir() {
            label_odaid.Text = Form_Odalar.satir["oda_id"].ToString();
            maskedTextBox_odano.Text = Form_Odalar.satir["oda_no"].ToString();
            maskedTextBox_katno.Text = Form_Odalar.satir["oda_kat"].ToString();
            comboBox_tur.SelectedIndex = comboBox_tur.FindString(Form_Odalar.satir["oda_tur"].ToString());
            richTextBox_aciklama.Text = Form_Odalar.satir["oda_aciklama"].ToString();
            maskedTextBox_yataksayisi.Text = Form_Odalar.satir["oda_yataksayisi"].ToString();
            comboBox_gorevlisi.Text = Form_Odalar.satir["oda_gorevlisi"].ToString();
            string[] esyalar = Form_Odalar.satir["oda_esyalar"].ToString().Split(',');
            for (int i = 0; i < checkedListBox_esyalar.Items.Count; i++)
                for (int j = 0; j < esyalar.Length; j++)
                    if (checkedListBox_esyalar.Items[i].ToString() == esyalar[j])
                        checkedListBox_esyalar.SetItemChecked(i, true);
        }

        private void button_guncelle_Click(object sender, EventArgs e) {
            for (int i = 0; i < checkedListBox_esyalar.CheckedItems.Count; i++) { odaesyalari += checkedListBox_esyalar.CheckedItems[i] + ","; }
            if (maskedTextBox_odano.Text != "" && maskedTextBox_katno.Text != "" && richTextBox_aciklama.Text != "" && maskedTextBox_yataksayisi.Text != "" && comboBox_tur.Text != "" && comboBox_gorevlisi.Text != "" && odaesyalari != "") {
                if (Veritabani_islemleri.Guncelle("Odalar", "oda_id", label_odaid.Text, "oda_aciklama='" + richTextBox_aciklama.Text + "',oda_tur='" + comboBox_tur.Text + "',oda_yataksayisi='" + maskedTextBox_yataksayisi.Text + "',oda_gorevlisi='" + comboBox_gorevlisi.Text + "',oda_kat='" + maskedTextBox_katno.Text + "',oda_no='" + maskedTextBox_odano.Text + "',oda_esyalar='" + odaesyalari + "', oda_ucret='" + maskedTextBox_ucret.Text + "'", "Oda başarıyla güncellendi.")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (comboBox_gorevlisi.Text == "") {
                    comboBox_gorevlisi.BackColor = Color.Red;
                    comboBox_gorevlisi.ForeColor = Color.White;
                    comboBox_gorevlisi.Focus();
                }
                if (maskedTextBox_yataksayisi.Text == "") {
                    maskedTextBox_yataksayisi.BackColor = Color.Red;
                    maskedTextBox_yataksayisi.ForeColor = Color.White;
                    maskedTextBox_yataksayisi.Focus();
                }
                if (comboBox_tur.Text == "") {
                    comboBox_tur.BackColor = Color.Red;
                    comboBox_tur.ForeColor = Color.White;
                    comboBox_tur.Focus();
                }
                if (richTextBox_aciklama.Text == "") {
                    richTextBox_aciklama.BackColor = Color.Red;
                    richTextBox_aciklama.ForeColor = Color.White;
                    richTextBox_aciklama.Focus();
                }
                if (maskedTextBox_katno.Text == "") {
                    maskedTextBox_katno.BackColor = Color.Red;
                    maskedTextBox_katno.ForeColor = Color.White;
                    maskedTextBox_katno.Focus();
                }
                if (maskedTextBox_odano.Text == "") {
                    maskedTextBox_odano.BackColor = Color.Red;
                    maskedTextBox_odano.ForeColor = Color.White;
                    maskedTextBox_odano.Focus();
                }
                MessageBox.Show("Kırmızı ile işaretlenmiş yerleri lütfen doldurunuz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EsyalariGetir() {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand kaydet = new SqlCommand("SELECT * FROM OdaEsyalari", Form_Otel.baglanti);
                SqlDataReader cek = kaydet.ExecuteReader();
                while (cek.Read()) { checkedListBox_esyalar.Items.Add(cek["esya_ad"].ToString()); }
                cek.Close();
                if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}