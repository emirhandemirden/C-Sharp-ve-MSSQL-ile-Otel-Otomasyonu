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
    public partial class Form_KategoriyeGoreUrunlerListesi : Form {
        public Form_KategoriyeGoreUrunlerListesi() {
            InitializeComponent();
            urunlerTableAdapter.Fill(urunlerDataSet.Urunler);
            reportViewer1.RefreshReport();
        }

        private void Button_Filtrele_Click(object sender, EventArgs e) {
            urunlerBindingSource.Filter = "urun_kategori='" + textBox_Filtre.Text + "'";
            reportViewer1.RefreshReport();
        }
    }
}