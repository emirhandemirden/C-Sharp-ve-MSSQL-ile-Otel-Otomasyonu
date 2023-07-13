using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Kafeterya
{
    public partial class Form_UrunlerListesiRaporu : Form
    {
        public Form_UrunlerListesiRaporu()
        {
            InitializeComponent();
        }

        private void Form_UrunlerListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunlerDataSet.Urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTableAdapter.Fill(this.urunlerDataSet.Urunler);

            this.reportViewer1.RefreshReport();
        }
    }
}
