using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Gecmisler
{
    public partial class Form_OdaKayitGecmisleriListesiRaporu : Form
    {
        public Form_OdaKayitGecmisleriListesiRaporu()
        {
            InitializeComponent();
        }

        private void Form_OdaKayıtGecmisleriListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odaIslemGecmisleriDataSet.OdaIslemGecmisleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odaIslemGecmisleriTableAdapter.Fill(this.odaIslemGecmisleriDataSet.OdaIslemGecmisleri);

            this.reportViewer1.RefreshReport();
        }
    }
}
