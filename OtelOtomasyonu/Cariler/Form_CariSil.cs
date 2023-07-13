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

namespace OtelOtomasyonu.Cariler {
    public partial class Form_CariSil : Form {
        public Form_CariSil() {
            InitializeComponent();
            CariBilgileriniGetir();
        }

        private void CariBilgileriniGetir() {
            label_id.Text = Form_Cariler.satir["cari_id"].ToString();
            textBox_ad.Text = Form_Cariler.satir["cari_ad"].ToString();
            maskedTextBox_tel.Text = Form_Cariler.satir["cari_tel"].ToString();
            maskedTextBox_dogum.Text = Form_Cariler.satir["cari_dogum"].ToString();
            comboBox_tur.Text = Form_Cariler.satir["cari_tur"].ToString();
        }

        private void button_sil_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Eğer devam ederseniz bu işlemi geri alamazsınız.\nDevam ederek bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                if (Veritabani_islemleri.Sil("Cari başarıyla silindi.", "cari_id", label_id.Text, "Cariler") && Veritabani_islemleri.Ekle("CariGecmisleri", "gecmis_baslik,gecmis_detay,gecmis_saat,gecmis_tarih", "'Cari Silme İşlemi','" + textBox_ad.Text + " adlı cari silindi.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("Silme işlemi kullanıcı tarafından iptal edilmiştir.", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Information); }
        }
    }
}