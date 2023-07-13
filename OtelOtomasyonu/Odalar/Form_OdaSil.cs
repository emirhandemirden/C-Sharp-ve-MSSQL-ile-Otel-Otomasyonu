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

namespace OtelOtomasyonu.Odalar {
    public partial class Form_OdaSil : Form {
        public Form_OdaSil() {
            InitializeComponent();
            OdaBilgileriniGetir();
        }

        private void OdaBilgileriniGetir() {
            label_odaid.Text = Form_Odalar.satir["oda_id"].ToString();
            maskedTextBox_odano.Text = Form_Odalar.satir["oda_no"].ToString();
            maskedTextBox_katno.Text = Form_Odalar.satir["oda_kat"].ToString();
            comboBox_tur.Text = Form_Odalar.satir["oda_tur"].ToString();
        }

        private void button_sil_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Eğer devam ederseniz bu işlemi geri alamazsınız.\nDevam ederek bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                if (Veritabani_islemleri.Sil("Oda başarıyla silindi.", "oda_id", label_odaid.Text, "Odalar")) Close();
                else MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("Silme işlemi kullanıcı tarafından iptal edilmiştir.", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Information); }
        }
    }
}