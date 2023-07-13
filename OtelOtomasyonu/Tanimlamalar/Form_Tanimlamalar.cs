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
    public partial class Form_Tanimlamalar : Form {
        public Form_Tanimlamalar() {
            InitializeComponent();
            TabloVerileriniGetir();
        }

        int secilisatir = 0;
        public static DataRow satir;
        public static string gridAd = "";

        private void TabloVerileriniGetir() {
            muhasebeTurleriTableAdapter.Fill(muhasebeTurleriDataSet.MuhasebeTurleri);
            cariTurleriTableAdapter.Fill(cariTurleriDataSet.CariTurleri);
            odaEsyalariTableAdapter.Fill(odaEsyalariDataSet.OdaEsyalari);
            odaTurleriTableAdapter.Fill(odaTurleriDataSet.OdaTurleri);
            urunKategorileriTableAdapter.Fill(urunKategorileriDataSet.UrunKategorileri);
            gridView_odaTur.BestFitColumns();
            gridView_odaEsyalari.BestFitColumns();
            gridView_cariTur.BestFitColumns();
            gridView_muhasebeTurleri.BestFitColumns();
            gridView_urunKategorileri.BestFitColumns();
        }

        private void ToolStripButton_Click(object sender, EventArgs e) {
            switch ((sender as ToolStripButton).Text) {
                case "Ekle": Form_islemleri.Form_Ac(new Form_TanimlamaEkle()); break;
                case "Sil": Form_islemleri.Form_Ac(new Form_TanimlamaSil()); break;
                case "Güncelle": Form_islemleri.Form_Ac(new Form_TanimlamaGuncelle()); break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
            TabloVerileriniGetir();
        }

        private void gridViews_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) { SeciliSatiriAl((sender as DevExpress.XtraGrid.Views.Grid.GridView).Name); }

        private void gridViews_Click(object sender, EventArgs e) { SeciliSatiriAl((sender as DevExpress.XtraGrid.Views.Grid.GridView).Name); }

        private void SeciliSatiriAl(string name) {
            switch (name) {
                case "gridView_muhasebeTurleri":
                    secilisatir = gridView_muhasebeTurleri.FocusedRowHandle;
                    satir = gridView_muhasebeTurleri.GetDataRow(secilisatir);
                    gridAd = "gridView_muhasebeTurleri";
                    break;
                case "gridView_cariTur":
                    secilisatir = gridView_cariTur.FocusedRowHandle;
                    satir = gridView_cariTur.GetDataRow(secilisatir);
                    gridAd = "gridView_cariTur";
                    break;
                case "gridView_odaEsyalari":
                    secilisatir = gridView_odaEsyalari.FocusedRowHandle;
                    satir = gridView_odaEsyalari.GetDataRow(secilisatir);
                    gridAd = "gridView_odaEsyalari";
                    break;
                case "gridView_odaTur":
                    secilisatir = gridView_odaTur.FocusedRowHandle;
                    satir = gridView_odaTur.GetDataRow(secilisatir);
                    gridAd = "gridView_odaTur";
                    break;
                case "gridView_urunKategorileri":
                    secilisatir = gridView_urunKategorileri.FocusedRowHandle;
                    satir = gridView_urunKategorileri.GetDataRow(secilisatir);
                    gridAd = "gridView_urunKategorileri";
                    break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }
    }
}