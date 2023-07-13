using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Odalar
{
    public partial class Form_OdalarRapor : Form
    {
        public Form_OdalarRapor()
        {
            InitializeComponent();
        }

        private void Form_OdalarRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelDataSet.Odalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odalarTableAdapter.Fill(this.otelDataSet.Odalar);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
