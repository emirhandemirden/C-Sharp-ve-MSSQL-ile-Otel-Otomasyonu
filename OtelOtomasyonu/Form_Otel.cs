using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyonu.Ayarlar;
using OtelOtomasyonu.Cariler;
using OtelOtomasyonu.Gecmiler;
using OtelOtomasyonu.Giriş_Ekranı;
using OtelOtomasyonu.Kafeterya;
using OtelOtomasyonu.Muhasebe;
using OtelOtomasyonu.Odalar;
using OtelOtomasyonu.Sınıflar;
using OtelOtomasyonu.Tanimlamalar;

namespace OtelOtomasyonu {
    public partial class Form_Otel : Form {
        public Form_Otel() {
            InitializeComponent();
            OdalariGetir("SELECT * FROM Odalar");
            TurBilgileriniGetir();
            odaTurleriTableAdapter.Fill(odaTurleriDataSet.OdaTurleri);
            carilerTableAdapter.Fill(gorevlilerDataSet.Cariler);
            toolStripLabel_kullaniciAdi.Text = Form_GirisYap.kullaniciAdi;
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Otel; Integrated Security = True; MultipleActiveResultSets=True");
        int say = 0, x = 0, y = 0;
        string aciklama = "";
        public static string durum = "", oda_id = "", oda_aciklama = "", oda_ad = "", oda_ucret = "", anasayfadanmi="";
        Label label_OdaAciklamasi;
        Button button_oda;
        string[] turBilgileri = new string[7] { "False", "False", "False", "False", "False", "False", "False"};
        bool ilkEklendiMi = false;

        #region Anaekran işlemleri
        private void TurBilgileriniGetir() {
            try {
                if (baglanti.State != ConnectionState.Open) { baglanti.Open(); }
                SqlCommand vericek = new SqlCommand("SELECT * FROM CariTurleri WHERE tur_ad='" + Form_GirisYap.kullaniciTur + "'", baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                if (verioku.Read()) {
                    if (verioku["tur_odalar"].ToString() == "True") turBilgileri[0] = "True";
                    if (verioku["tur_muhasebe"].ToString() == "True") turBilgileri[1] = "True";
                    if (verioku["tur_cariler"].ToString() == "True") turBilgileri[2] = "True";
                    if (verioku["tur_kafeterya"].ToString() == "True") turBilgileri[3] = "True";
                    if (verioku["tur_gecmisler"].ToString() == "True") turBilgileri[4] = "True";
                    if (verioku["tur_tanimlamalar"].ToString() == "True") turBilgileri[5] = "True";
                    if (verioku["tur_ayarlar"].ToString() == "True") turBilgileri[6] = "True";
                }
                verioku.Close();
                if (baglanti.State != ConnectionState.Closed) { baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void OdalariGetir(string sorguSatiri) {
            try {
                panel_odalar.Controls.Clear();
                anasayfadanmi = "";
                int dikey = 12, yatay = 12;
                if (baglanti.State != ConnectionState.Open) { baglanti.Open(); }
                SqlCommand vericek = new SqlCommand(sorguSatiri,baglanti);
                SqlDataReader verioku = vericek.ExecuteReader();
                int size = panel_odalar.Width / 112;
                for (int i = 1; verioku.Read(); i++) {
                    if(i == size) { i = 1; dikey += 92; yatay = 12; }
                    else if (i != 1) { yatay += 112; }
                    if(verioku["oda_dolumu"].ToString() == "Evet") {
                        button_oda = new Button {
                            BackColor = Color.Red,
                            ForeColor = Color.White,
                            Text = "Oda " + verioku["oda_kat"].ToString() + "." +  verioku["oda_no"].ToString(),
                            TextAlign = ContentAlignment.BottomCenter,
                            ImageAlign = ContentAlignment.TopCenter,
                            Image = Image.FromFile("C:\\Users\\emirh\\source\\repos\\OtelOtomasyonu\\OtelOtomasyonu\\Resimler\\OdaGorsel.png"),
                            Location = new Point(yatay, dikey),
                            Size = new Size(100, 80),
                            AccessibleDescription = verioku["oda_aciklama"].ToString(),
                            AccessibleName = verioku["oda_ucret"].ToString(),
                            Tag = verioku["oda_id"].ToString()
                        };
                    }
                    else {
                        button_oda = new Button {
                            BackColor = Color.White,
                            ForeColor = Color.Black,
                            Text = "Oda " + verioku["oda_kat"].ToString() + "." +  verioku["oda_no"].ToString(),
                            TextAlign = ContentAlignment.BottomCenter,
                            ImageAlign = ContentAlignment.TopCenter,
                            Image = Image.FromFile("C:\\Users\\emirh\\source\\repos\\OtelOtomasyonu\\OtelOtomasyonu\\Resimler\\OdaGorsel.png"),
                            Location = new Point(yatay, dikey),
                            Size = new Size(100, 80),
                            AccessibleDescription = verioku["oda_aciklama"].ToString(),
                            AccessibleName = verioku["oda_ucret"].ToString(),
                            Tag = verioku["oda_id"].ToString()
                        };
                    }
                    panel_odalar.Controls.Add(button_oda);
                    button_oda.Click += new EventHandler(button_oda_click);
                    button_oda.MouseHover += new EventHandler(button_oda_Hover);
                    button_oda.MouseLeave += new EventHandler(button_oda_Leave);
                }
                verioku.Close();
                label_OdaAciklamasi = new Label {
                    Location = new Point(0, 0),
                    Visible = false,
                    BackColor = Color.DodgerBlue,
                    ForeColor = Color.White,
                    AutoSize = true
                };
                panel_odalar.Controls.Add(label_OdaAciklamasi);
                if (baglanti.State != ConnectionState.Closed) { baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void button_oda_click(object sender, EventArgs e) {
            if (turBilgileri[0] == "True") { 
                oda_ad = (sender as Button).Text;
                oda_aciklama = (sender as Button).AccessibleDescription;
                oda_id = (sender as Button).Tag.ToString();
                oda_ucret = (sender as Button).AccessibleName.ToString();
                anasayfadanmi = "Evet";
                if ((sender as Button).BackColor != Color.Red) Form_islemleri.Form_Ac(new Form_OdaKayıt());
                else Form_islemleri.Form_Ac(new Form_OdaEkrani());
                OdalariGetir("SELECT * FROM Odalar");
            }
            else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_oda_Hover(object sender, EventArgs e) {
            aciklama = (sender as Button).AccessibleDescription;
            timer_aciklamagoster.Start();
        }

        private void button_oda_Leave(object sender, EventArgs e) {
            timer_aciklamagoster.Stop();
            label_OdaAciklamasi.Visible = false;
        }

        private void timer_aciklamagoster_Tick(object sender, EventArgs e) {
            if (say == 3) {
                timer_aciklamagoster.Stop();
                label_OdaAciklamasi.BringToFront();
                label_OdaAciklamasi.Visible = true;
                label_OdaAciklamasi.Text = aciklama;
                Point screenPoint = Control.MousePosition;
                Point formPoint = PointToClient(screenPoint);
                x = formPoint.X;
                y = formPoint.Y;
                label_OdaAciklamasi.Location = new Point(x, y);
                say = 0;
            }
            else { say++; }
        }

        private void timer_tarihsaat_Tick(object sender, EventArgs e) {
            toolStripLabel_saat.Text = "Saat: " + DateTime.Now.ToShortTimeString();
            toolStripLabel_tarih.Text = "Tarih: " + DateTime.Now.ToShortDateString();
        }

        private void Form_Otel_FormClosing(object sender, FormClosingEventArgs e) { if (durum == "Çıkış Yap") {  } else durum = "Programı Kapat"; }

        private void Form_Odalar_Resize(object sender, EventArgs e) { OdalariGetir("SELECT * FROM Odalar"); }
        #endregion

        #region Menü Butonları
        private void ToolStripMenuItems_Click(object sender, EventArgs e) {
            switch ((sender as ToolStripMenuItem).Text) {
                case "Oda Müşteri Kayıtları":
                    if (turBilgileri[0] == "True") {
                        Form_islemleri.Form_Ac(new Form_OdaKayitlari());
                        OdalariGetir("SELECT * FROM Odalar");
                    }
                    else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                case "Odalar":
                    if (turBilgileri[0] == "True") {
                        Form_islemleri.Form_Ac(new Form_Odalar());
                        OdalariGetir("SELECT * FROM Odalar");
                    }
                    else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                case "Muhasebe":
                    if (turBilgileri[1] == "True") Form_islemleri.Form_Ac(new Form_Muhasebe());
                    else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                case "Cariler":
                    if (turBilgileri[2] == "True") Form_islemleri.Form_Ac(new Form_Cariler());
                    else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                case "Kafeterya":
                    if (turBilgileri[3] == "True") Form_islemleri.Form_Ac(new Form_Kafeterya());
                    else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                case "Geçmişler":
                    if (turBilgileri[4] == "True") Form_islemleri.Form_Ac(new Form_Gecmisler());
                    else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                case "Tanımlamalar":
                    if (turBilgileri[5] == "True") Form_islemleri.Form_Ac(new Form_Tanimlamalar());
                    else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                case "Ayarlar":
                    if (turBilgileri[6] == "True") Form_islemleri.Form_Ac(new Form_Ayarlar());
                    else { MessageBox.Show("Bu sayfayı görüntülemek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                default: MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        private void toolStripButton_CikisYap_Click(object sender, EventArgs e) {
            Veritabani_islemleri.Ekle("PersonelIslemGecmisleri", "gecmis_baslik,gecmis_detay,gecmis_saat,gecmis_tarih", "'Kullanıcı Çıkış İşlemi','" + toolStripLabel_kullaniciAdi.Text + " adlı kullanıcı uygulamadan çıkış yaptı.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "'", "Hayır");
            durum = "Çıkış Yap";
            Close();
        }
        #endregion

        #region Arama

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e) {
            if (checkBox4.Checked) {
                maskedTextBox_odanobirebir.Enabled = true;
                maskedTextBox_odanobirebir.Focus();
            }
            else {
                maskedTextBox_odanobirebir.Text = "";
                maskedTextBox_odanobirebir.Enabled = false;
            }
            if (checkBox1.Checked) {
                maskedTextBox_katnobirebir.Enabled = true;
                maskedTextBox_katnobirebir.Focus();
            }
            else {
                maskedTextBox_katnobirebir.Text = "";
                maskedTextBox_katnobirebir.Enabled = false;
            }
            if (checkBox2.Checked) {
                comboBox_turbirebir.Enabled = true;
                comboBox_turbirebir.Focus();
            }
            else {
                comboBox_turbirebir.Text = "";
                comboBox_turbirebir.Enabled = false;
            }
            if (checkBox3.Checked) {
                maskedTextBox_yataksayisibirebir.Enabled = true;
                maskedTextBox_yataksayisibirebir.Focus();
            }
            else {
                maskedTextBox_yataksayisibirebir.Text = "";
                maskedTextBox_yataksayisibirebir.Enabled = false;
            }
            if (checkBox5.Checked) {
                comboBox_gorevlibirebir.Enabled = true;
                comboBox_gorevlibirebir.Focus();
            }
            else {
                comboBox_gorevlibirebir.Text = "";
                comboBox_gorevlibirebir.Enabled = false;
            }
            if (checkBox6.Checked) {
                comboBox_dolumubirebir.Enabled = true;
                comboBox_dolumubirebir.Focus();
            }
            else {
                comboBox_dolumubirebir.Text = "";
                comboBox_dolumubirebir.Enabled = false;
            }
        }

        private void button_birebirara_Click(object sender, EventArgs e) { BirebirAra(); }

        private void BirebirAra() {
            try {
                ilkEklendiMi = false;
                if (baglanti.State != ConnectionState.Open) { baglanti.Open(); }
                string sorguSatiri = "SELECT * FROM Odalar";
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked) {
                    sorguSatiri += " WHERE ";
                    if (checkBox4.Checked) {
                        sorguSatiri += "oda_no = '" + maskedTextBox_odanobirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox1.Checked) {
                        if (ilkEklendiMi) sorguSatiri += "AND oda_kat = '" + maskedTextBox_katnobirebir.Text + "'";
                        else sorguSatiri += "oda_kat = '" + maskedTextBox_katnobirebir.Text + "'";
                        ilkEklendiMi = true;
                    }
                    if (checkBox2.Checked) {
                        if (ilkEklendiMi) sorguSatiri += " AND oda_tur = '" + comboBox_turbirebir.Text + "'";
                        else sorguSatiri += "oda_tur = '" + comboBox_turbirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                    if (checkBox3.Checked) {
                        if (ilkEklendiMi) sorguSatiri += " AND oda_yataksayisi = '" + maskedTextBox_yataksayisibirebir.Text + "'";
                        else sorguSatiri += "oda_yataksayisi = '" + maskedTextBox_yataksayisibirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                    if (checkBox5.Checked) {
                        if (ilkEklendiMi) sorguSatiri += " AND oda_gorevlisi = '" + comboBox_gorevlibirebir.Text + "'";
                        else sorguSatiri += "oda_gorevlisi = '" + comboBox_gorevlibirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                    if (checkBox6.Checked) {
                        if (ilkEklendiMi) sorguSatiri += " AND oda_dolumu = '" + comboBox_dolumubirebir.Text + "'";
                        else sorguSatiri += "oda_dolumu = '" + comboBox_dolumubirebir.Text + "' ";
                        ilkEklendiMi = true;
                    }
                }
                OdalariGetir(sorguSatiri);
                if (baglanti.State != ConnectionState.Closed) { baglanti.Close(); }
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu. Hata mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion
    }
}