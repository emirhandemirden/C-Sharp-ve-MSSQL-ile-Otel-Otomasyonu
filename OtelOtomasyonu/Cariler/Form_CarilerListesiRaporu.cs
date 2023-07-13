using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Cariler
{
    public partial class Form_CarilerListesiRaporu : Form
    {
        public Form_CarilerListesiRaporu()
        {
            InitializeComponent();
        }

        private void Form_CarilerListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet.Cariler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.carilerTableAdapter.Fill(this.carilerDataSet.Cariler);

            this.reportViewer1.RefreshReport();
        }
    }
}
