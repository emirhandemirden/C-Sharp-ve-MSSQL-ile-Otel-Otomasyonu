namespace OtelOtomasyonu.Muhasebe
{
    partial class Form_Muhasebe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Muhasebe));
            this.toolStrip_islemler = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_guncelle = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl_islem = new DevExpress.XtraGrid.GridControl();
            this.muhasebeIslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeIslemleriDataSet = new OtelOtomasyonu.MuhasebeIslemleriDataSet();
            this.gridView_islem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colislem_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colislem_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colislem_tur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colislem_ucret = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colislem_saat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colislem_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl_gunluk = new DevExpress.XtraGrid.GridControl();
            this.gunlukMuhasebeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunlukMuhasebeDataSet = new OtelOtomasyonu.GunlukMuhasebeDataSet();
            this.gridView_gunluk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmuhasebe_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuhasebe_netgelir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuhasebe_gelir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuhasebe_gider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuhasebe_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.muhasebeIslemleriTableAdapter = new OtelOtomasyonu.MuhasebeIslemleriDataSetTableAdapters.MuhasebeIslemleriTableAdapter();
            this.gunlukMuhasebeTableAdapter = new OtelOtomasyonu.GunlukMuhasebeDataSetTableAdapters.GunlukMuhasebeTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_aranan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_esyalar = new System.Windows.Forms.RadioButton();
            this.radioButton_aciklama = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_filtre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_baslikbirebir = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_birebirara = new System.Windows.Forms.Button();
            this.maskedTextBox_tarihbirebir = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_turbirebir = new System.Windows.Forms.ComboBox();
            this.muhasebeTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeTurleriDataSet = new OtelOtomasyonu.MuhasebeTurleriDataSet();
            this.muhasebeTurleriTableAdapter = new OtelOtomasyonu.MuhasebeTurleriDataSetTableAdapters.MuhasebeTurleriTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_raporla1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_raporla2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_islemler.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_islem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeIslemleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeIslemleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_islem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_gunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukMuhasebeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukMuhasebeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gunluk)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeTurleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_islemler
            // 
            this.toolStrip_islemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ekle,
            this.toolStripButton_sil,
            this.toolStripButton_guncelle,
            this.toolStripSeparator1,
            this.toolStripButton_raporla1,
            this.toolStripButton_raporla2});
            this.toolStrip_islemler.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_islemler.Name = "toolStrip_islemler";
            this.toolStrip_islemler.Size = new System.Drawing.Size(1214, 25);
            this.toolStrip_islemler.TabIndex = 3;
            this.toolStrip_islemler.Text = "toolStrip1";
            // 
            // toolStripButton_ekle
            // 
            this.toolStripButton_ekle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ekle.Image")));
            this.toolStripButton_ekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ekle.Name = "toolStripButton_ekle";
            this.toolStripButton_ekle.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton_ekle.Text = "Ekle";
            this.toolStripButton_ekle.ToolTipText = "Cari Ekle";
            this.toolStripButton_ekle.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_sil
            // 
            this.toolStripButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_sil.Image")));
            this.toolStripButton_sil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sil.Name = "toolStripButton_sil";
            this.toolStripButton_sil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton_sil.Text = "Sil";
            this.toolStripButton_sil.ToolTipText = "Cari Sil";
            this.toolStripButton_sil.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_guncelle
            // 
            this.toolStripButton_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_guncelle.Image")));
            this.toolStripButton_guncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_guncelle.Name = "toolStripButton_guncelle";
            this.toolStripButton_guncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton_guncelle.Text = "Güncelle";
            this.toolStripButton_guncelle.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 686);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_islem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 337);
            this.panel1.TabIndex = 0;
            // 
            // gridControl_islem
            // 
            this.gridControl_islem.DataSource = this.muhasebeIslemleriBindingSource;
            this.gridControl_islem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_islem.Location = new System.Drawing.Point(0, 28);
            this.gridControl_islem.MainView = this.gridView_islem;
            this.gridControl_islem.Name = "gridControl_islem";
            this.gridControl_islem.Size = new System.Drawing.Size(978, 309);
            this.gridControl_islem.TabIndex = 7;
            this.gridControl_islem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_islem});
            // 
            // muhasebeIslemleriBindingSource
            // 
            this.muhasebeIslemleriBindingSource.DataMember = "MuhasebeIslemleri";
            this.muhasebeIslemleriBindingSource.DataSource = this.muhasebeIslemleriDataSet;
            // 
            // muhasebeIslemleriDataSet
            // 
            this.muhasebeIslemleriDataSet.DataSetName = "MuhasebeIslemleriDataSet";
            this.muhasebeIslemleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_islem
            // 
            this.gridView_islem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colislem_id,
            this.colislem_ad,
            this.colislem_tur,
            this.colislem_ucret,
            this.colislem_saat,
            this.colislem_tarih});
            this.gridView_islem.GridControl = this.gridControl_islem;
            this.gridView_islem.Name = "gridView_islem";
            this.gridView_islem.OptionsBehavior.Editable = false;
            this.gridView_islem.OptionsSelection.MultiSelect = true;
            this.gridView_islem.OptionsView.ShowAutoFilterRow = true;
            this.gridView_islem.OptionsView.ShowFooter = true;
            this.gridView_islem.OptionsView.ShowGroupPanel = false;
            // 
            // colislem_id
            // 
            this.colislem_id.Caption = "ID";
            this.colislem_id.FieldName = "islem_id";
            this.colislem_id.Name = "colislem_id";
            this.colislem_id.Visible = true;
            this.colislem_id.VisibleIndex = 0;
            // 
            // colislem_ad
            // 
            this.colislem_ad.Caption = "Başlık";
            this.colislem_ad.FieldName = "islem_ad";
            this.colislem_ad.Name = "colislem_ad";
            this.colislem_ad.Visible = true;
            this.colislem_ad.VisibleIndex = 1;
            // 
            // colislem_tur
            // 
            this.colislem_tur.Caption = "Tür";
            this.colislem_tur.FieldName = "islem_tur";
            this.colislem_tur.Name = "colislem_tur";
            this.colislem_tur.Visible = true;
            this.colislem_tur.VisibleIndex = 2;
            // 
            // colislem_ucret
            // 
            this.colislem_ucret.Caption = "Ücret Tutarı";
            this.colislem_ucret.FieldName = "islem_ucret";
            this.colislem_ucret.Name = "colislem_ucret";
            this.colislem_ucret.Visible = true;
            this.colislem_ucret.VisibleIndex = 3;
            // 
            // colislem_saat
            // 
            this.colislem_saat.Caption = "Saat";
            this.colislem_saat.FieldName = "islem_saat";
            this.colislem_saat.Name = "colislem_saat";
            this.colislem_saat.Visible = true;
            this.colislem_saat.VisibleIndex = 4;
            // 
            // colislem_tarih
            // 
            this.colislem_tarih.Caption = "Tarih";
            this.colislem_tarih.FieldName = "islem_tarih";
            this.colislem_tarih.Name = "colislem_tarih";
            this.colislem_tarih.Visible = true;
            this.colislem_tarih.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Muhasebe İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl_gunluk);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 337);
            this.panel2.TabIndex = 1;
            // 
            // gridControl_gunluk
            // 
            this.gridControl_gunluk.DataSource = this.gunlukMuhasebeBindingSource;
            this.gridControl_gunluk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_gunluk.Location = new System.Drawing.Point(0, 28);
            this.gridControl_gunluk.MainView = this.gridView_gunluk;
            this.gridControl_gunluk.Name = "gridControl_gunluk";
            this.gridControl_gunluk.Size = new System.Drawing.Size(978, 309);
            this.gridControl_gunluk.TabIndex = 9;
            this.gridControl_gunluk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_gunluk});
            // 
            // gunlukMuhasebeBindingSource
            // 
            this.gunlukMuhasebeBindingSource.DataMember = "GunlukMuhasebe";
            this.gunlukMuhasebeBindingSource.DataSource = this.gunlukMuhasebeDataSet;
            // 
            // gunlukMuhasebeDataSet
            // 
            this.gunlukMuhasebeDataSet.DataSetName = "GunlukMuhasebeDataSet";
            this.gunlukMuhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_gunluk
            // 
            this.gridView_gunluk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmuhasebe_id,
            this.colmuhasebe_netgelir,
            this.colmuhasebe_gelir,
            this.colmuhasebe_gider,
            this.colmuhasebe_tarih});
            this.gridView_gunluk.GridControl = this.gridControl_gunluk;
            this.gridView_gunluk.Name = "gridView_gunluk";
            this.gridView_gunluk.OptionsBehavior.Editable = false;
            this.gridView_gunluk.OptionsSelection.MultiSelect = true;
            this.gridView_gunluk.OptionsView.ShowAutoFilterRow = true;
            this.gridView_gunluk.OptionsView.ShowFooter = true;
            this.gridView_gunluk.OptionsView.ShowGroupPanel = false;
            // 
            // colmuhasebe_id
            // 
            this.colmuhasebe_id.Caption = "ID";
            this.colmuhasebe_id.FieldName = "muhasebe_id";
            this.colmuhasebe_id.Name = "colmuhasebe_id";
            this.colmuhasebe_id.Visible = true;
            this.colmuhasebe_id.VisibleIndex = 0;
            // 
            // colmuhasebe_netgelir
            // 
            this.colmuhasebe_netgelir.Caption = "Net Gelir Tutarı";
            this.colmuhasebe_netgelir.FieldName = "muhasebe_netgelir";
            this.colmuhasebe_netgelir.Name = "colmuhasebe_netgelir";
            this.colmuhasebe_netgelir.Visible = true;
            this.colmuhasebe_netgelir.VisibleIndex = 1;
            // 
            // colmuhasebe_gelir
            // 
            this.colmuhasebe_gelir.Caption = "Gelir Tutarı";
            this.colmuhasebe_gelir.FieldName = "muhasebe_gelir";
            this.colmuhasebe_gelir.Name = "colmuhasebe_gelir";
            this.colmuhasebe_gelir.Visible = true;
            this.colmuhasebe_gelir.VisibleIndex = 2;
            // 
            // colmuhasebe_gider
            // 
            this.colmuhasebe_gider.Caption = "Gider Tutarı";
            this.colmuhasebe_gider.FieldName = "muhasebe_gider";
            this.colmuhasebe_gider.Name = "colmuhasebe_gider";
            this.colmuhasebe_gider.Visible = true;
            this.colmuhasebe_gider.VisibleIndex = 3;
            // 
            // colmuhasebe_tarih
            // 
            this.colmuhasebe_tarih.Caption = "Tarih";
            this.colmuhasebe_tarih.FieldName = "muhasebe_tarih";
            this.colmuhasebe_tarih.Name = "colmuhasebe_tarih";
            this.colmuhasebe_tarih.Visible = true;
            this.colmuhasebe_tarih.VisibleIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(978, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Günlük Muhasebeler";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muhasebeIslemleriTableAdapter
            // 
            this.muhasebeIslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // gunlukMuhasebeTableAdapter
            // 
            this.gunlukMuhasebeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_aranan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_filtre);
            this.groupBox2.Location = new System.Drawing.Point(990, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 343);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // textBox_aranan
            // 
            this.textBox_aranan.Location = new System.Drawing.Point(7, 284);
            this.textBox_aranan.Name = "textBox_aranan";
            this.textBox_aranan.Size = new System.Drawing.Size(200, 29);
            this.textBox_aranan.TabIndex = 9;
            this.textBox_aranan.TextChanged += new System.EventHandler(this.textBox_aranan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(7, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Başlık:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_esyalar);
            this.groupBox3.Controls.Add(this.radioButton_aciklama);
            this.groupBox3.Location = new System.Drawing.Point(6, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 105);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçimi";
            // 
            // radioButton_esyalar
            // 
            this.radioButton_esyalar.AutoSize = true;
            this.radioButton_esyalar.Location = new System.Drawing.Point(19, 66);
            this.radioButton_esyalar.Name = "radioButton_esyalar";
            this.radioButton_esyalar.Size = new System.Drawing.Size(72, 28);
            this.radioButton_esyalar.TabIndex = 1;
            this.radioButton_esyalar.Text = "Ücret";
            this.radioButton_esyalar.UseVisualStyleBackColor = true;
            this.radioButton_esyalar.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioButton_aciklama
            // 
            this.radioButton_aciklama.AutoSize = true;
            this.radioButton_aciklama.Checked = true;
            this.radioButton_aciklama.Location = new System.Drawing.Point(19, 30);
            this.radioButton_aciklama.Name = "radioButton_aciklama";
            this.radioButton_aciklama.Size = new System.Drawing.Size(76, 28);
            this.radioButton_aciklama.TabIndex = 0;
            this.radioButton_aciklama.TabStop = true;
            this.radioButton_aciklama.Text = "Başlık";
            this.radioButton_aciklama.UseVisualStyleBackColor = true;
            this.radioButton_aciklama.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Arama Türü";
            // 
            // comboBox_filtre
            // 
            this.comboBox_filtre.FormattingEnabled = true;
            this.comboBox_filtre.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.comboBox_filtre.Location = new System.Drawing.Point(6, 70);
            this.comboBox_filtre.Name = "comboBox_filtre";
            this.comboBox_filtre.Size = new System.Drawing.Size(198, 32);
            this.comboBox_filtre.TabIndex = 5;
            this.comboBox_filtre.Text = "İle Başlayan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_baslikbirebir);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button_birebirara);
            this.groupBox1.Controls.Add(this.maskedTextBox_tarihbirebir);
            this.groupBox1.Controls.Add(this.comboBox_turbirebir);
            this.groupBox1.Location = new System.Drawing.Point(990, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 340);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // textBox_baslikbirebir
            // 
            this.textBox_baslikbirebir.Location = new System.Drawing.Point(6, 78);
            this.textBox_baslikbirebir.Name = "textBox_baslikbirebir";
            this.textBox_baslikbirebir.Size = new System.Drawing.Size(200, 29);
            this.textBox_baslikbirebir.TabIndex = 11;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox3.Location = new System.Drawing.Point(9, 201);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 22);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Tarih";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox2.Location = new System.Drawing.Point(9, 122);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 22);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Tür";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(9, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Başlık";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_birebirara
            // 
            this.button_birebirara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_birebirara.Location = new System.Drawing.Point(6, 299);
            this.button_birebirara.Name = "button_birebirara";
            this.button_birebirara.Size = new System.Drawing.Size(201, 35);
            this.button_birebirara.TabIndex = 7;
            this.button_birebirara.Text = "Ara";
            this.button_birebirara.UseVisualStyleBackColor = true;
            this.button_birebirara.Click += new System.EventHandler(this.button_birebirara_Click);
            // 
            // maskedTextBox_tarihbirebir
            // 
            this.maskedTextBox_tarihbirebir.Enabled = false;
            this.maskedTextBox_tarihbirebir.Location = new System.Drawing.Point(6, 229);
            this.maskedTextBox_tarihbirebir.Mask = "00/00/0000";
            this.maskedTextBox_tarihbirebir.Name = "maskedTextBox_tarihbirebir";
            this.maskedTextBox_tarihbirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_tarihbirebir.TabIndex = 6;
            this.maskedTextBox_tarihbirebir.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox_turbirebir
            // 
            this.comboBox_turbirebir.DataSource = this.muhasebeTurleriBindingSource;
            this.comboBox_turbirebir.DisplayMember = "tur_ad";
            this.comboBox_turbirebir.Enabled = false;
            this.comboBox_turbirebir.FormattingEnabled = true;
            this.comboBox_turbirebir.Location = new System.Drawing.Point(6, 150);
            this.comboBox_turbirebir.Name = "comboBox_turbirebir";
            this.comboBox_turbirebir.Size = new System.Drawing.Size(200, 32);
            this.comboBox_turbirebir.TabIndex = 4;
            this.comboBox_turbirebir.ValueMember = "tur_id";
            // 
            // muhasebeTurleriBindingSource
            // 
            this.muhasebeTurleriBindingSource.DataMember = "MuhasebeTurleri";
            this.muhasebeTurleriBindingSource.DataSource = this.muhasebeTurleriDataSet;
            // 
            // muhasebeTurleriDataSet
            // 
            this.muhasebeTurleriDataSet.DataSetName = "MuhasebeTurleriDataSet";
            this.muhasebeTurleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muhasebeTurleriTableAdapter
            // 
            this.muhasebeTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_raporla1
            // 
            this.toolStripButton_raporla1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_raporla1.Image")));
            this.toolStripButton_raporla1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_raporla1.Name = "toolStripButton_raporla1";
            this.toolStripButton_raporla1.Size = new System.Drawing.Size(156, 22);
            this.toolStripButton_raporla1.Text = "Genel Muhasebe Raporu";
            this.toolStripButton_raporla1.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_raporla2
            // 
            this.toolStripButton_raporla2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_raporla2.Image")));
            this.toolStripButton_raporla2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_raporla2.Name = "toolStripButton_raporla2";
            this.toolStripButton_raporla2.Size = new System.Drawing.Size(164, 22);
            this.toolStripButton_raporla2.Text = "Günlük Muhasebe Raporu";
            this.toolStripButton_raporla2.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // Form_Muhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip_islemler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Muhasebe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Muhasebe";
            this.toolStrip_islemler.ResumeLayout(false);
            this.toolStrip_islemler.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_islem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeIslemleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeIslemleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_islem)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_gunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukMuhasebeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukMuhasebeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gunluk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeTurleriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_islemler;
        private System.Windows.Forms.ToolStripButton toolStripButton_ekle;
        private System.Windows.Forms.ToolStripButton toolStripButton_sil;
        private System.Windows.Forms.ToolStripButton toolStripButton_guncelle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_islem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_islem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl_gunluk;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_gunluk;
        private System.Windows.Forms.Label label2;
        private MuhasebeIslemleriDataSet muhasebeIslemleriDataSet;
        private System.Windows.Forms.BindingSource muhasebeIslemleriBindingSource;
        private MuhasebeIslemleriDataSetTableAdapters.MuhasebeIslemleriTableAdapter muhasebeIslemleriTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colislem_id;
        private DevExpress.XtraGrid.Columns.GridColumn colislem_ad;
        private DevExpress.XtraGrid.Columns.GridColumn colislem_tur;
        private DevExpress.XtraGrid.Columns.GridColumn colislem_ucret;
        private DevExpress.XtraGrid.Columns.GridColumn colislem_saat;
        private DevExpress.XtraGrid.Columns.GridColumn colislem_tarih;
        private GunlukMuhasebeDataSet gunlukMuhasebeDataSet;
        private System.Windows.Forms.BindingSource gunlukMuhasebeBindingSource;
        private GunlukMuhasebeDataSetTableAdapters.GunlukMuhasebeTableAdapter gunlukMuhasebeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmuhasebe_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmuhasebe_netgelir;
        private DevExpress.XtraGrid.Columns.GridColumn colmuhasebe_gelir;
        private DevExpress.XtraGrid.Columns.GridColumn colmuhasebe_gider;
        private DevExpress.XtraGrid.Columns.GridColumn colmuhasebe_tarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_aranan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_esyalar;
        private System.Windows.Forms.RadioButton radioButton_aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_filtre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_birebirara;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tarihbirebir;
        private System.Windows.Forms.ComboBox comboBox_turbirebir;
        private MuhasebeTurleriDataSet muhasebeTurleriDataSet;
        private System.Windows.Forms.BindingSource muhasebeTurleriBindingSource;
        private MuhasebeTurleriDataSetTableAdapters.MuhasebeTurleriTableAdapter muhasebeTurleriTableAdapter;
        private System.Windows.Forms.TextBox textBox_baslikbirebir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_raporla1;
        private System.Windows.Forms.ToolStripButton toolStripButton_raporla2;
    }
}