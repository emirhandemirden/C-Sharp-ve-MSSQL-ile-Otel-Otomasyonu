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

namespace OtelOtomasyonu.Tanimlamalar {
    public partial class Form_TanimlamaSil : Form {
        public Form_TanimlamaSil() {
            InitializeComponent();
            VerileriGetir();
        }

        private void VerileriGetir() {
            switch (Form_Tanimlamalar.gridAd) {
                case "gridView_odaEsyalari":
                    textBox_icerik.Text = Form_Tanimlamalar.satir["esya_ad"].ToString();
                    label_id.Text = Form_Tanimlamalar.satir["esya_id"].ToString();
                    label_icerik.Text = "Eşya:";
                    break;
                case "gridView_cariTur":
                    textBox_icerik.Text = Form_Tanimlamalar.satir["tur_ad"].ToString();
                    label_id.Text = Form_Tanimlamalar.satir["tur_id"].ToString();
                    break;
                case "gridView_muhasebeTurleri":
                    label_icerik.Text = "Başlık:";
                    label_id.Text = Form_Tanimlamalar.satir["tur_id"].ToString();
                    textBox_icerik.Text = Form_Tanimlamalar.satir["tur_ad"].ToString();
                    break;
                case "gridView_urunKategorileri":
                    label_icerik.Text = "Kategori:";
                    label_id.Text = Form_Tanimlamalar.satir["kategori_id"].ToString();
                    textBox_icerik.Text = Form_Tanimlamalar.satir["kategori_ad"].ToString();
                    break;
                default:
                    textBox_icerik.Text = Form_Tanimlamalar.satir["tur_ad"].ToString();
                    label_id.Text = Form_Tanimlamalar.satir["tur_id"].ToString();
                    break;
            }
        }

        private void button_sil_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Eğer devam ederseniz bu işlemi geri alamazsınız.\nDevam ederek bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                switch (Form_Tanimlamalar.gridAd) {
                    case "gridView_odaTur":
                        if (Veritabani_islemleri.Sil("Oda türü başarıyla silindi.", "tur_id", "'" + label_id.Text + "'", "OdaTurleri")) Close();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "gridView_odaEsyalari":
                        if (Veritabani_islemleri.Sil("Oda eşyası başarıyla silindi.", "esya_id", "'" + label_id.Text + "'", "OdaEsyalari")) Close();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "gridView_cariTur":
                        if (Veritabani_islemleri.Sil("Cari türü başarıyla silindi.", "tur_id", "'" + label_id.Text + "'", "CariTurleri")) Close();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "gridView_muhasebeTurleri":
                        if (Veritabani_islemleri.Sil("Muhasebe türü başarıyla silindi.", "tur_id", "'" + label_id.Text + "'", "MuhasebeTurleri")) Close();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "gridView_urunKategorileri":
                        if (Veritabani_islemleri.Sil("Ürün kategorisi başarıyla silindi.", "kategori_id", "'" + label_id.Text + "'", "UrunKategorileri")) Close();
                        else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                }
            }
            else { MessageBox.Show("Silme işlemi kullanıcı tarafından iptal edilmiştir.", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Information); }
            
        }
    }
}