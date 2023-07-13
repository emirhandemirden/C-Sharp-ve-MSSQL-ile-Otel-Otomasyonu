namespace OtelOtomasyonu
{
    partial class Form_Otel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Otel));
            this.menuStrip_islemler = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaMüşteriKayıtlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kafeteryaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_deneme = new System.Windows.Forms.Button();
            this.timer_aciklamagoster = new System.Windows.Forms.Timer(this.components);
            this.toolStrip_ = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_CikisYap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_tarih = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_saat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_kullaniciAdi = new System.Windows.Forms.ToolStripLabel();
            this.panel_odalar = new System.Windows.Forms.Panel();
            this.timer_tarihsaat = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.comboBox_dolumubirebir = new System.Windows.Forms.ComboBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.comboBox_gorevlibirebir = new System.Windows.Forms.ComboBox();
            this.carilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevlilerDataSet = new OtelOtomasyonu.GorevlilerDataSet();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox_odanobirebir = new System.Windows.Forms.MaskedTextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_birebirara = new System.Windows.Forms.Button();
            this.maskedTextBox_yataksayisibirebir = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_turbirebir = new System.Windows.Forms.ComboBox();
            this.odaTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaTurleriDataSet = new OtelOtomasyonu.OdaTurleriDataSet();
            this.maskedTextBox_katnobirebir = new System.Windows.Forms.MaskedTextBox();
            this.carilerTableAdapter = new OtelOtomasyonu.GorevlilerDataSetTableAdapters.CarilerTableAdapter();
            this.odaTurleriTableAdapter = new OtelOtomasyonu.OdaTurleriDataSetTableAdapters.OdaTurleriTableAdapter();
            this.menuStrip_islemler.SuspendLayout();
            this.toolStrip_.SuspendLayout();
            this.panel_odalar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_islemler
            // 
            this.menuStrip_islemler.BackColor = System.Drawing.Color.Silver;
            this.menuStrip_islemler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip_islemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.odalarToolStripMenuItem,
            this.muhasebeToolStripMenuItem,
            this.carilerToolStripMenuItem,
            this.kafeteryaToolStripMenuItem,
            this.geçmişlerToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip_islemler.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_islemler.Name = "menuStrip_islemler";
            this.menuStrip_islemler.Size = new System.Drawing.Size(1234, 29);
            this.menuStrip_islemler.TabIndex = 0;
            this.menuStrip_islemler.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaMüşteriKayıtlarıToolStripMenuItem});
            this.anasayfaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.anasayfaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anasayfaToolStripMenuItem.Image")));
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // odaMüşteriKayıtlarıToolStripMenuItem
            // 
            this.odaMüşteriKayıtlarıToolStripMenuItem.Name = "odaMüşteriKayıtlarıToolStripMenuItem";
            this.odaMüşteriKayıtlarıToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.odaMüşteriKayıtlarıToolStripMenuItem.Text = "Oda Müşteri Kayıtları";
            this.odaMüşteriKayıtlarıToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.odalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("odalarToolStripMenuItem.Image")));
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.odalarToolStripMenuItem.Text = "Odalar";
            this.odalarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // muhasebeToolStripMenuItem
            // 
            this.muhasebeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.muhasebeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("muhasebeToolStripMenuItem.Image")));
            this.muhasebeToolStripMenuItem.Name = "muhasebeToolStripMenuItem";
            this.muhasebeToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.muhasebeToolStripMenuItem.Text = "Muhasebe";
            this.muhasebeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // carilerToolStripMenuItem
            // 
            this.carilerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.carilerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carilerToolStripMenuItem.Image")));
            this.carilerToolStripMenuItem.Name = "carilerToolStripMenuItem";
            this.carilerToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.carilerToolStripMenuItem.Text = "Cariler";
            this.carilerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // kafeteryaToolStripMenuItem
            // 
            this.kafeteryaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kafeteryaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kafeteryaToolStripMenuItem.Image")));
            this.kafeteryaToolStripMenuItem.Name = "kafeteryaToolStripMenuItem";
            this.kafeteryaToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.kafeteryaToolStripMenuItem.Text = "Kafeterya";
            this.kafeteryaToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // geçmişlerToolStripMenuItem
            // 
            this.geçmişlerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.geçmişlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geçmişlerToolStripMenuItem.Image")));
            this.geçmişlerToolStripMenuItem.Name = "geçmişlerToolStripMenuItem";
            this.geçmişlerToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.geçmişlerToolStripMenuItem.Text = "Geçmişler";
            this.geçmişlerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.tanımlamalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tanımlamalarToolStripMenuItem.Image")));
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(131, 25);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            this.tanımlamalarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ayarlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarToolStripMenuItem.Image")));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // button_deneme
            // 
            this.button_deneme.Image = ((System.Drawing.Image)(resources.GetObject("button_deneme.Image")));
            this.button_deneme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_deneme.Location = new System.Drawing.Point(12, 12);
            this.button_deneme.Name = "button_deneme";
            this.button_deneme.Size = new System.Drawing.Size(100, 80);
            this.button_deneme.TabIndex = 0;
            this.button_deneme.Text = "Oda 1.1";
            this.button_deneme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_deneme.UseVisualStyleBackColor = true;
            this.button_deneme.Visible = false;
            // 
            // timer_aciklamagoster
            // 
            this.timer_aciklamagoster.Interval = 500;
            this.timer_aciklamagoster.Tick += new System.EventHandler(this.timer_aciklamagoster_Tick);
            // 
            // toolStrip_
            // 
            this.toolStrip_.BackColor = System.Drawing.Color.Silver;
            this.toolStrip_.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_CikisYap,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripLabel4,
            this.toolStripLabel_tarih,
            this.toolStripLabel_saat,
            this.toolStripSeparator2,
            this.toolStripLabel_kullaniciAdi});
            this.toolStrip_.Location = new System.Drawing.Point(0, 533);
            this.toolStrip_.Name = "toolStrip_";
            this.toolStrip_.Size = new System.Drawing.Size(1234, 28);
            this.toolStrip_.TabIndex = 2;
            this.toolStrip_.Text = "toolStrip1";
            // 
            // toolStripButton_CikisYap
            // 
            this.toolStripButton_CikisYap.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton_CikisYap.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CikisYap.Image")));
            this.toolStripButton_CikisYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CikisYap.Name = "toolStripButton_CikisYap";
            this.toolStripButton_CikisYap.Size = new System.Drawing.Size(92, 25);
            this.toolStripButton_CikisYap.Text = "Çıkış Yap";
            this.toolStripButton_CikisYap.Click += new System.EventHandler(this.toolStripButton_CikisYap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 25);
            this.toolStripLabel1.Text = "Boş";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(92, 25);
            this.toolStripLabel4.Text = "Dolu Oda";
            // 
            // toolStripLabel_tarih
            // 
            this.toolStripLabel_tarih.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_tarih.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel_tarih.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel_tarih.Image")));
            this.toolStripLabel_tarih.Name = "toolStripLabel_tarih";
            this.toolStripLabel_tarih.Size = new System.Drawing.Size(144, 25);
            this.toolStripLabel_tarih.Text = "Tarih: 00.00.0000";
            // 
            // toolStripLabel_saat
            // 
            this.toolStripLabel_saat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_saat.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel_saat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel_saat.Image")));
            this.toolStripLabel_saat.Name = "toolStripLabel_saat";
            this.toolStripLabel_saat.Size = new System.Drawing.Size(102, 25);
            this.toolStripLabel_saat.Text = "Saat: 00.00";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel_kullaniciAdi
            // 
            this.toolStripLabel_kullaniciAdi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_kullaniciAdi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel_kullaniciAdi.Image")));
            this.toolStripLabel_kullaniciAdi.Name = "toolStripLabel_kullaniciAdi";
            this.toolStripLabel_kullaniciAdi.Size = new System.Drawing.Size(84, 25);
            this.toolStripLabel_kullaniciAdi.Text = "Emirhan";
            // 
            // panel_odalar
            // 
            this.panel_odalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_odalar.Controls.Add(this.button_deneme);
            this.panel_odalar.Location = new System.Drawing.Point(0, 29);
            this.panel_odalar.Name = "panel_odalar";
            this.panel_odalar.Size = new System.Drawing.Size(1000, 504);
            this.panel_odalar.TabIndex = 3;
            // 
            // timer_tarihsaat
            // 
            this.timer_tarihsaat.Enabled = true;
            this.timer_tarihsaat.Interval = 500;
            this.timer_tarihsaat.Tick += new System.EventHandler(this.timer_tarihsaat_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.comboBox_dolumubirebir);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.comboBox_gorevlibirebir);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.maskedTextBox_odanobirebir);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button_birebirara);
            this.groupBox1.Controls.Add(this.maskedTextBox_yataksayisibirebir);
            this.groupBox1.Controls.Add(this.comboBox_turbirebir);
            this.groupBox1.Controls.Add(this.maskedTextBox_katnobirebir);
            this.groupBox1.Location = new System.Drawing.Point(1009, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 504);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox6.Location = new System.Drawing.Point(6, 383);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(123, 22);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "Oda Dolu mu?";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // comboBox_dolumubirebir
            // 
            this.comboBox_dolumubirebir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_dolumubirebir.DisplayMember = "tur_ad";
            this.comboBox_dolumubirebir.Enabled = false;
            this.comboBox_dolumubirebir.FormattingEnabled = true;
            this.comboBox_dolumubirebir.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.comboBox_dolumubirebir.Location = new System.Drawing.Point(6, 411);
            this.comboBox_dolumubirebir.Name = "comboBox_dolumubirebir";
            this.comboBox_dolumubirebir.Size = new System.Drawing.Size(198, 32);
            this.comboBox_dolumubirebir.TabIndex = 15;
            this.comboBox_dolumubirebir.ValueMember = "tur_id";
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox5.Location = new System.Drawing.Point(6, 311);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(117, 22);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Oda Görevlisi";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // comboBox_gorevlibirebir
            // 
            this.comboBox_gorevlibirebir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_gorevlibirebir.DataSource = this.carilerBindingSource;
            this.comboBox_gorevlibirebir.DisplayMember = "cari_ad";
            this.comboBox_gorevlibirebir.Enabled = false;
            this.comboBox_gorevlibirebir.FormattingEnabled = true;
            this.comboBox_gorevlibirebir.Location = new System.Drawing.Point(6, 339);
            this.comboBox_gorevlibirebir.Name = "comboBox_gorevlibirebir";
            this.comboBox_gorevlibirebir.Size = new System.Drawing.Size(198, 32);
            this.comboBox_gorevlibirebir.TabIndex = 13;
            this.comboBox_gorevlibirebir.ValueMember = "cari_id";
            // 
            // carilerBindingSource
            // 
            this.carilerBindingSource.DataMember = "Cariler";
            this.carilerBindingSource.DataSource = this.gorevlilerDataSet;
            // 
            // gorevlilerDataSet
            // 
            this.gorevlilerDataSet.DataSetName = "GorevlilerDataSet";
            this.gorevlilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox4.Location = new System.Drawing.Point(6, 32);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 22);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Oda No";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // maskedTextBox_odanobirebir
            // 
            this.maskedTextBox_odanobirebir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_odanobirebir.Enabled = false;
            this.maskedTextBox_odanobirebir.Location = new System.Drawing.Point(3, 60);
            this.maskedTextBox_odanobirebir.Mask = "00000";
            this.maskedTextBox_odanobirebir.Name = "maskedTextBox_odanobirebir";
            this.maskedTextBox_odanobirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_odanobirebir.TabIndex = 11;
            this.maskedTextBox_odanobirebir.ValidatingType = typeof(int);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox3.Location = new System.Drawing.Point(6, 242);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(139, 22);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Oda Yatak Sayısı";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox2.Location = new System.Drawing.Point(6, 170);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 22);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Oda Tür";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(6, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Oda Kat No";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // button_birebirara
            // 
            this.button_birebirara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_birebirara.Location = new System.Drawing.Point(6, 463);
            this.button_birebirara.Name = "button_birebirara";
            this.button_birebirara.Size = new System.Drawing.Size(201, 35);
            this.button_birebirara.TabIndex = 7;
            this.button_birebirara.Text = "Ara";
            this.button_birebirara.UseVisualStyleBackColor = true;
            this.button_birebirara.Click += new System.EventHandler(this.button_birebirara_Click);
            // 
            // maskedTextBox_yataksayisibirebir
            // 
            this.maskedTextBox_yataksayisibirebir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_yataksayisibirebir.Enabled = false;
            this.maskedTextBox_yataksayisibirebir.Location = new System.Drawing.Point(3, 270);
            this.maskedTextBox_yataksayisibirebir.Mask = "00000";
            this.maskedTextBox_yataksayisibirebir.Name = "maskedTextBox_yataksayisibirebir";
            this.maskedTextBox_yataksayisibirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_yataksayisibirebir.TabIndex = 6;
            this.maskedTextBox_yataksayisibirebir.ValidatingType = typeof(int);
            // 
            // comboBox_turbirebir
            // 
            this.comboBox_turbirebir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_turbirebir.DataSource = this.odaTurleriBindingSource;
            this.comboBox_turbirebir.DisplayMember = "tur_ad";
            this.comboBox_turbirebir.Enabled = false;
            this.comboBox_turbirebir.FormattingEnabled = true;
            this.comboBox_turbirebir.Location = new System.Drawing.Point(6, 198);
            this.comboBox_turbirebir.Name = "comboBox_turbirebir";
            this.comboBox_turbirebir.Size = new System.Drawing.Size(198, 32);
            this.comboBox_turbirebir.TabIndex = 4;
            this.comboBox_turbirebir.ValueMember = "tur_id";
            // 
            // odaTurleriBindingSource
            // 
            this.odaTurleriBindingSource.DataMember = "OdaTurleri";
            this.odaTurleriBindingSource.DataSource = this.odaTurleriDataSet;
            // 
            // odaTurleriDataSet
            // 
            this.odaTurleriDataSet.DataSetName = "OdaTurleriDataSet";
            this.odaTurleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox_katnobirebir
            // 
            this.maskedTextBox_katnobirebir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_katnobirebir.Enabled = false;
            this.maskedTextBox_katnobirebir.Location = new System.Drawing.Point(3, 129);
            this.maskedTextBox_katnobirebir.Mask = "00000";
            this.maskedTextBox_katnobirebir.Name = "maskedTextBox_katnobirebir";
            this.maskedTextBox_katnobirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_katnobirebir.TabIndex = 2;
            this.maskedTextBox_katnobirebir.ValidatingType = typeof(int);
            // 
            // carilerTableAdapter
            // 
            this.carilerTableAdapter.ClearBeforeFill = true;
            // 
            // odaTurleriTableAdapter
            // 
            this.odaTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Otel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_odalar);
            this.Controls.Add(this.toolStrip_);
            this.Controls.Add(this.menuStrip_islemler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_islemler;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Otel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Otel_FormClosing);
            this.Resize += new System.EventHandler(this.Form_Odalar_Resize);
            this.menuStrip_islemler.ResumeLayout(false);
            this.menuStrip_islemler.PerformLayout();
            this.toolStrip_.ResumeLayout(false);
            this.toolStrip_.PerformLayout();
            this.panel_odalar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_islemler;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçmişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.Button button_deneme;
        private System.Windows.Forms.Timer timer_aciklamagoster;
        private System.Windows.Forms.ToolStrip toolStrip_;
        private System.Windows.Forms.Panel panel_odalar;
        private System.Windows.Forms.Timer timer_tarihsaat;
        private System.Windows.Forms.ToolStripButton toolStripButton_CikisYap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem kafeteryaToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_tarih;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_saat;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaMüşteriKayıtlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_kullaniciAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_odanobirebir;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_birebirara;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_yataksayisibirebir;
        private System.Windows.Forms.ComboBox comboBox_turbirebir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_katnobirebir;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ComboBox comboBox_dolumubirebir;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ComboBox comboBox_gorevlibirebir;
        private GorevlilerDataSet gorevlilerDataSet;
        private System.Windows.Forms.BindingSource carilerBindingSource;
        private GorevlilerDataSetTableAdapters.CarilerTableAdapter carilerTableAdapter;
        private OdaTurleriDataSet odaTurleriDataSet;
        private System.Windows.Forms.BindingSource odaTurleriBindingSource;
        private OdaTurleriDataSetTableAdapters.OdaTurleriTableAdapter odaTurleriTableAdapter;
    }
}

