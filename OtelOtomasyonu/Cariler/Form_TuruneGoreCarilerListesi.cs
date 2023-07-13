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
    public partial class Form_TuruneGoreCarilerListesi : Form {
        public Form_TuruneGoreCarilerListesi() {
            InitializeComponent();
            carilerTableAdapter.Fill(carilerDataSet.Cariler);
            reportViewer1.RefreshReport();
        }

        private void Button_Filtrele_Click(object sender, EventArgs e) {
            carilerBindingSource.Filter = "cari_tur='" + textBox_Filtre.Text + "'";
            reportViewer1.RefreshReport();
        }
    }
}