using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Muhasebe {
    public partial class Form_GunlukMuhasebeRaporu : Form {
        public Form_GunlukMuhasebeRaporu() {
            InitializeComponent();
            gunlukMuhasebeTableAdapter.Fill(gunlukMuhasebeDataSet.GunlukMuhasebe);
            reportViewer1.RefreshReport();
        }

        private void Button_Filtrele_Click(object sender, EventArgs e) {
            gunlukMuhasebeBindingSource.Filter = "muhasebe_tarih='" + textBox_Filtre.Text + "'";
            reportViewer1.RefreshReport();
        }
    }
}