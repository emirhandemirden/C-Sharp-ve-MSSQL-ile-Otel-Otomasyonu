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
    public partial class Form_PersonelIslemGecmisleriListesiRaporu : Form
    {
        public Form_PersonelIslemGecmisleriListesiRaporu()
        {
            InitializeComponent();
        }

        private void Form_PersonelIslemGecmisleriListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelIslemGecmisleriDataSet.PersonelIslemGecmisleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelIslemGecmisleriTableAdapter.Fill(this.personelIslemGecmisleriDataSet.PersonelIslemGecmisleri);

            this.reportViewer1.RefreshReport();
        }
    }
}
