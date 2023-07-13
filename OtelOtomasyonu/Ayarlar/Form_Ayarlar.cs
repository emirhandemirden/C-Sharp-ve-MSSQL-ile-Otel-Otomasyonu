using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Ayarlar {
    public partial class Form_Ayarlar : Form {
        public Form_Ayarlar() {
            InitializeComponent();
        }

        private void ToolStripButtons_Click(object sender, EventArgs e) {
            switch ((sender as ToolStripButton).Text) {
                case "Uygulama Ayarları": tableLayoutPanel_uygulamaayarlari.Visible = true; break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }
    }
}