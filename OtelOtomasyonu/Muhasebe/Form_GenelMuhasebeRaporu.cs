using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Muhasebe
{
    public partial class Form_GenelMuhasebeRaporu : Form
    {
        public Form_GenelMuhasebeRaporu()
        {
            InitializeComponent();
        }

        private void Form_GeneMuhasebeRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'muhasebeIslemleriDataSet.MuhasebeIslemleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.muhasebeIslemleriTableAdapter.Fill(this.muhasebeIslemleriDataSet.MuhasebeIslemleri);

            this.reportViewer1.RefreshReport();
        }
    }
}
