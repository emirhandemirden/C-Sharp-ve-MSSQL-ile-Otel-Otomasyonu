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
    public partial class Form_UrunSil : Form {
        public Form_UrunSil() {
            InitializeComponent();
            UrunBilgileriniGetir();
        }

        private void UrunBilgileriniGetir() {
            label_id.Text = Form_Kafeterya.satir["urun_id"].ToString();
            textBox_ad.Text = Form_Kafeterya.satir["urun_ad"].ToString();
        }

        private void button_sil_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Eğer devam ederseniz bu işlemi geri alamazsınız.\nDevam ederek bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                if (Veritabani_islemleri.Sil("Ürün başarıyla silindi.", "urun_id", label_id.Text, "Urunler")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("Silme işlemi kullanıcı tarafından iptal edilmiştir.", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Information); }
        }
    }
}