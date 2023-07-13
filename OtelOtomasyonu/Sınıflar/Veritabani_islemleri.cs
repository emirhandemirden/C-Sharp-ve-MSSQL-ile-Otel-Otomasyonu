using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Sınıflar {
    public class Veritabani_islemleri {

        public static bool Ekle(string veritabani,string veriSutunSatiri, string verilerSatiri, string mesajSatiri) {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand ekle = new SqlCommand("INSERT INTO " + veritabani + " (" + veriSutunSatiri + ")VALUES(" + verilerSatiri + ")", Form_Otel.baglanti);
                ekle.ExecuteNonQuery();
                //if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
                if(mesajSatiri != "Hayır") MessageBox.Show(mesajSatiri,"Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            catch (Exception) { return false; }
        }

        public static void VeriCek(string veritabani, string veriSutunAd, string id) {
            //
        }

        public static bool Sil(string mesajSatiri, string veriSutunAd, string id, string veritabani) {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand sil = new SqlCommand("DELETE FROM " + veritabani + " WHERE " + veriSutunAd + "=" + id + "", Form_Otel.baglanti);
                sil.ExecuteNonQuery();
                //if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
                if (mesajSatiri != "Hayır") MessageBox.Show(mesajSatiri, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception) { return false; }
        }

        public static bool Guncelle(string veritabani, string veriSutunAd, string id, string verilerSatiri, string mesajSatiri) {
            try {
                if (Form_Otel.baglanti.State != ConnectionState.Open) { Form_Otel.baglanti.Open(); }
                SqlCommand guncelle = new SqlCommand("UPDATE " + veritabani + " SET " + verilerSatiri + " WHERE " + veriSutunAd + "='" + id + "'", Form_Otel.baglanti);
                guncelle.ExecuteNonQuery();
                //if (Form_Otel.baglanti.State != ConnectionState.Closed) { Form_Otel.baglanti.Close(); }
                if (mesajSatiri != "Hayır") MessageBox.Show(mesajSatiri, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception) { return false; }
        }
    }
}