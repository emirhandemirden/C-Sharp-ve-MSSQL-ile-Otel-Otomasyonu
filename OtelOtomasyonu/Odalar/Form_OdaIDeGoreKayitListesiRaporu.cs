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
    public partial class Form_OdaIDeGoreKayitListesiRaporu : Form {
        public Form_OdaIDeGoreKayitListesiRaporu() {
            InitializeComponent();
            odaKayitlariTableAdapter.Fill(odaKayitlariDataSet.OdaKayitlari);
            reportViewer1.RefreshReport();
        }

        private void Button_Filtrele_Click(object sender, EventArgs e) {
            odaKayitlariBindingSource.Filter = "oda_id='" + textBox_Filtre.Text + "'";
            reportViewer1.RefreshReport();
        }
    }
}