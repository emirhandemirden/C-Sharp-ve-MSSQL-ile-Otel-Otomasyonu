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
    public partial class Form_OdalaraGoreKayitListesiRaporu : Form {
        public Form_OdalaraGoreKayitListesiRaporu() {
            InitializeComponent();
            odaKayitlariTableAdapter.Fill(odaKayitlariDataSet.OdaKayitlari);
            reportViewer1.RefreshReport();
        }

        private void Button_Filtrele_Click(object sender, EventArgs e) {
            odaKayitlariBindingSource.Filter = "oda_ad='" + textBox_Filtre.Text + "'";
            reportViewer1.RefreshReport();
        }
    }
}