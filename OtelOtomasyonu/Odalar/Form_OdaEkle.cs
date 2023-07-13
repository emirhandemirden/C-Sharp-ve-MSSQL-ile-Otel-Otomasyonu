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
using OtelOtomasyonu.Sınıflar;

namespace OtelOtomasyonu.Odalar {
    public partial class Form_OdaEkle : Form {
        public Form_OdaEkle() {
            InitializeComponent();
            EsyalariGetir();
            carilerTableAdapter1.FillBy(gorevlilerDataSet.Cariler);
            odaTurleriTableAdapter.Fill(odaTurleriDataSet.OdaTurleri);
        }
        string odaesyalari = "";

        private void button_kaydet_Click(object sender, EventArgs e) {
            for (int i = 0; i < checkedListBox_esyalar.CheckedItems.Count; i++) { odaesyalari += checkedListBox_esyalar.CheckedItems[i] + ","; }
            if(maskedTextBox_odano.Text != "" && maskedTextBox_katno.Text != "" && richTextBox_aciklama.Text != "" && maskedTextBox_yataksayisi.Text != "" && comboBox_tur.Text != "" && comboBox_gorevlisi.Text != "" && odaesyalari != "") {
                if(Veritabani_islemleri.Ekle("Odalar","oda_aciklama,oda_tur,oda_yataksayisi,oda_gorevlisi,oda_kat,oda_no,oda_esyalar,oda_ucret,oda_dolumu", "'" + richTextBox_aciklama.Text + "','" + comboBox_tur.Text + "','" + maskedTextBox_yataksayisi.Text + "','" + comboBox_gorevlisi.Text + "','" + maskedTextBox_katno.Text + "','" + maskedTextBox_odano.Text + "','" + odaesyalari + "','" + maskedTextBox_ucret.Text + "','Hayır'", "Oda başarıyla eklendi.")) button_temizle.PerformClick();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if(comboBox_gorevlisi.Text == "") {
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

        private void button_temizle_Click(object sender, EventArgs e) {
            odaesyalari = "";
            maskedTextBox_odano.Text = "";
            maskedTextBox_katno.Text = "";
            richTextBox_aciklama.Text = "";
            maskedTextBox_yataksayisi.Text = "";
            comboBox_tur.Text = "";
            comboBox_gorevlisi.Text = "";
            for (int i = 0; i < checkedListBox_esyalar.Items.Count; i++) { checkedListBox_esyalar.SetItemChecked(i, false); }
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