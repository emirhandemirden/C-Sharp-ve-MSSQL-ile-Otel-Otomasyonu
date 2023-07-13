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
    public partial class Form_CariIslemGecmisleriListesiRaporu : Form
    {
        public Form_CariIslemGecmisleriListesiRaporu()
        {
            InitializeComponent();
        }

        private void Form_CariIslemGecmisleriListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cariGecmisleriDataSet.CariGecmisleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cariGecmisleriTableAdapter.Fill(this.cariGecmisleriDataSet.CariGecmisleri);

            this.reportViewer1.RefreshReport();
        }
    }
}
