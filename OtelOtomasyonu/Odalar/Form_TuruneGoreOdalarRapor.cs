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
    public partial class Form_TuruneGoreOdalarRapor : Form {
        public Form_TuruneGoreOdalarRapor() {
            InitializeComponent();
            odalarTableAdapter.Fill(otelDataSet.Odalar);
            reportViewer1.RefreshReport();
        }

        private void Button_Filtrele_Click(object sender, EventArgs e) {
            odalarBindingSource.Filter = "oda_tur='" + textBox_Filtre.Text + "'";
            reportViewer1.RefreshReport();
        }
    }
}