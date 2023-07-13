namespace OtelOtomasyonu.Odalar
{
    partial class Form_OdaKayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaKayitlari));
            this.toolStrip_islemler = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_raporla1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_raporla2 = new System.Windows.Forms.ToolStripButton();
            this.gridControl_list = new DevExpress.XtraGrid.GridControl();
            this.odaKayitlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaKayitlariDataSet = new OtelOtomasyonu.OdaKayitlariDataSet();
            this.gridView_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkayit_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayit_musteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayit_giris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayit_cikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayit_sure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayıt_ucret = new DevExpress.XtraGrid.Columns.GridColumn();
            this.odaKayitlariTableAdapter = new OtelOtomasyonu.OdaKayitlariDataSetTableAdapters.OdaKayitlariTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_aranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_sure = new System.Windows.Forms.RadioButton();
            this.radioButton_ad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_filtre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_girisbirebir = new System.Windows.Forms.MaskedTextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_birebirara = new System.Windows.Forms.Button();
            this.maskedTextBox_cikisbirebir = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_odabirebir = new System.Windows.Forms.ComboBox();
            this.toolStrip_islemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaKayitlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaKayitlariDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_list)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_islemler
            // 
            this.toolStrip_islemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ekle,
            this.toolStripButton_sil,
            this.toolStripSeparator1,
            this.toolStripButton_raporla1,
            this.toolStripButton_raporla2});
            this.toolStrip_islemler.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_islemler.Name = "toolStrip_islemler";
            this.toolStrip_islemler.Size = new System.Drawing.Size(1034, 25);
            this.toolStrip_islemler.TabIndex = 3;
            this.toolStrip_islemler.Text = "toolStrip1";
            // 
            // toolStripButton_ekle
            // 
            this.toolStripButton_ekle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ekle.Image")));
            this.toolStripButton_ekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ekle.Name = "toolStripButton_ekle";
            this.toolStripButton_ekle.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton_ekle.Tag = "Ekle";
            this.toolStripButton_ekle.Text = "Kayıt Ekle";
            this.toolStripButton_ekle.ToolTipText = "Cari Ekle";
            this.toolStripButton_ekle.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_sil
            // 
            this.toolStripButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_sil.Image")));
            this.toolStripButton_sil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sil.Name = "toolStripButton_sil";
            this.toolStripButton_sil.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton_sil.Tag = "Sil";
            this.toolStripButton_sil.Text = "Kayıt Sil";
            this.toolStripButton_sil.ToolTipText = "Cari Sil";
            this.toolStripButton_sil.Click += new System.EventHandler(this.ToolStripButtons_Click);
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
            this.toolStripButton_raporla1.Size = new System.Drawing.Size(201, 22);
            this.toolStripButton_raporla1.Tag = "Rapor1";
            this.toolStripButton_raporla1.Text = "Odalara Göre Kayıt Listesi Raporu";
            this.toolStripButton_raporla1.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_raporla2
            // 
            this.toolStripButton_raporla2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_raporla2.Image")));
            this.toolStripButton_raporla2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_raporla2.Name = "toolStripButton_raporla2";
            this.toolStripButton_raporla2.Size = new System.Drawing.Size(220, 22);
            this.toolStripButton_raporla2.Tag = "Rapor2";
            this.toolStripButton_raporla2.Text = "Oda ID\'sine Göre Kayıt Listesi Raporu";
            this.toolStripButton_raporla2.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // gridControl_list
            // 
            this.gridControl_list.DataSource = this.odaKayitlariBindingSource;
            this.gridControl_list.Location = new System.Drawing.Point(0, 25);
            this.gridControl_list.MainView = this.gridView_list;
            this.gridControl_list.Name = "gridControl_list";
            this.gridControl_list.Size = new System.Drawing.Size(800, 525);
            this.gridControl_list.TabIndex = 4;
            this.gridControl_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_list});
            // 
            // odaKayitlariBindingSource
            // 
            this.odaKayitlariBindingSource.DataMember = "OdaKayitlari";
            this.odaKayitlariBindingSource.DataSource = this.odaKayitlariDataSet;
            // 
            // odaKayitlariDataSet
            // 
            this.odaKayitlariDataSet.DataSetName = "OdaKayitlariDataSet";
            this.odaKayitlariDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_list
            // 
            this.gridView_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkayit_id,
            this.colkayit_musteri,
            this.colkayit_giris,
            this.colkayit_cikis,
            this.coloda_id,
            this.coloda_ad,
            this.colkayit_sure,
            this.colkayıt_ucret});
            this.gridView_list.GridControl = this.gridControl_list;
            this.gridView_list.Name = "gridView_list";
            this.gridView_list.OptionsBehavior.Editable = false;
            this.gridView_list.OptionsSelection.MultiSelect = true;
            this.gridView_list.OptionsView.ShowAutoFilterRow = true;
            this.gridView_list.OptionsView.ShowFooter = true;
            this.gridView_list.OptionsView.ShowGroupPanel = false;
            // 
            // colkayit_id
            // 
            this.colkayit_id.Caption = "ID";
            this.colkayit_id.FieldName = "kayit_id";
            this.colkayit_id.Name = "colkayit_id";
            this.colkayit_id.Visible = true;
            this.colkayit_id.VisibleIndex = 0;
            // 
            // colkayit_musteri
            // 
            this.colkayit_musteri.Caption = "Müşteri Ad";
            this.colkayit_musteri.FieldName = "kayit_musteri";
            this.colkayit_musteri.Name = "colkayit_musteri";
            this.colkayit_musteri.Visible = true;
            this.colkayit_musteri.VisibleIndex = 3;
            // 
            // colkayit_giris
            // 
            this.colkayit_giris.Caption = "Giriş Tarihi";
            this.colkayit_giris.FieldName = "kayit_giris";
            this.colkayit_giris.Name = "colkayit_giris";
            this.colkayit_giris.Visible = true;
            this.colkayit_giris.VisibleIndex = 6;
            // 
            // colkayit_cikis
            // 
            this.colkayit_cikis.Caption = "Çıkış Tarihi";
            this.colkayit_cikis.FieldName = "kayit_cikis";
            this.colkayit_cikis.Name = "colkayit_cikis";
            this.colkayit_cikis.Visible = true;
            this.colkayit_cikis.VisibleIndex = 7;
            // 
            // coloda_id
            // 
            this.coloda_id.Caption = "Oda ID";
            this.coloda_id.FieldName = "oda_id";
            this.coloda_id.Name = "coloda_id";
            this.coloda_id.Visible = true;
            this.coloda_id.VisibleIndex = 1;
            // 
            // coloda_ad
            // 
            this.coloda_ad.Caption = "Oda";
            this.coloda_ad.FieldName = "oda_ad";
            this.coloda_ad.Name = "coloda_ad";
            this.coloda_ad.Visible = true;
            this.coloda_ad.VisibleIndex = 2;
            // 
            // colkayit_sure
            // 
            this.colkayit_sure.Caption = "Süre (Gün)";
            this.colkayit_sure.FieldName = "kayit_sure";
            this.colkayit_sure.Name = "colkayit_sure";
            this.colkayit_sure.Visible = true;
            this.colkayit_sure.VisibleIndex = 5;
            // 
            // colkayıt_ucret
            // 
            this.colkayıt_ucret.Caption = "Ücret";
            this.colkayıt_ucret.FieldName = "kayıt_ucret";
            this.colkayıt_ucret.Name = "colkayıt_ucret";
            this.colkayıt_ucret.Visible = true;
            this.colkayıt_ucret.VisibleIndex = 4;
            // 
            // odaKayitlariTableAdapter
            // 
            this.odaKayitlariTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_aranan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox_filtre);
            this.groupBox2.Location = new System.Drawing.Point(809, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 263);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // textBox_aranan
            // 
            this.textBox_aranan.Location = new System.Drawing.Point(6, 225);
            this.textBox_aranan.Name = "textBox_aranan";
            this.textBox_aranan.Size = new System.Drawing.Size(200, 29);
            this.textBox_aranan.TabIndex = 9;
            this.textBox_aranan.TextChanged += new System.EventHandler(this.textBox_aranan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müşteri Ad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_sure);
            this.groupBox3.Controls.Add(this.radioButton_ad);
            this.groupBox3.Location = new System.Drawing.Point(6, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 105);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçimi";
            // 
            // radioButton_sure
            // 
            this.radioButton_sure.AutoSize = true;
            this.radioButton_sure.Location = new System.Drawing.Point(19, 66);
            this.radioButton_sure.Name = "radioButton_sure";
            this.radioButton_sure.Size = new System.Drawing.Size(121, 28);
            this.radioButton_sure.TabIndex = 1;
            this.radioButton_sure.Text = "Süre (Gün)";
            this.radioButton_sure.UseVisualStyleBackColor = true;
            this.radioButton_sure.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioButton_ad
            // 
            this.radioButton_ad.AutoSize = true;
            this.radioButton_ad.Checked = true;
            this.radioButton_ad.Location = new System.Drawing.Point(19, 30);
            this.radioButton_ad.Name = "radioButton_ad";
            this.radioButton_ad.Size = new System.Drawing.Size(118, 28);
            this.radioButton_ad.TabIndex = 0;
            this.radioButton_ad.TabStop = true;
            this.radioButton_ad.Text = "Müşteri Ad";
            this.radioButton_ad.UseVisualStyleBackColor = true;
            this.radioButton_ad.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arama Türü";
            // 
            // comboBox_filtre
            // 
            this.comboBox_filtre.FormattingEnabled = true;
            this.comboBox_filtre.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.comboBox_filtre.Location = new System.Drawing.Point(6, 56);
            this.comboBox_filtre.Name = "comboBox_filtre";
            this.comboBox_filtre.Size = new System.Drawing.Size(198, 32);
            this.comboBox_filtre.TabIndex = 5;
            this.comboBox_filtre.Text = "İle Başlayan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_girisbirebir);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button_birebirara);
            this.groupBox1.Controls.Add(this.maskedTextBox_cikisbirebir);
            this.groupBox1.Controls.Add(this.comboBox_odabirebir);
            this.groupBox1.Location = new System.Drawing.Point(809, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 269);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // maskedTextBox_girisbirebir
            // 
            this.maskedTextBox_girisbirebir.Enabled = false;
            this.maskedTextBox_girisbirebir.Location = new System.Drawing.Point(6, 125);
            this.maskedTextBox_girisbirebir.Mask = "00/00/0000";
            this.maskedTextBox_girisbirebir.Name = "maskedTextBox_girisbirebir";
            this.maskedTextBox_girisbirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_girisbirebir.TabIndex = 11;
            this.maskedTextBox_girisbirebir.ValidatingType = typeof(System.DateTime);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox3.Location = new System.Drawing.Point(9, 160);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 22);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Çıkış Tarihi";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox2.Location = new System.Drawing.Point(9, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 22);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Giriş Tarihi";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(9, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Oda";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_birebirara
            // 
            this.button_birebirara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_birebirara.Location = new System.Drawing.Point(6, 228);
            this.button_birebirara.Name = "button_birebirara";
            this.button_birebirara.Size = new System.Drawing.Size(201, 35);
            this.button_birebirara.TabIndex = 7;
            this.button_birebirara.Text = "Ara";
            this.button_birebirara.UseVisualStyleBackColor = true;
            this.button_birebirara.Click += new System.EventHandler(this.button_birebirara_Click);
            // 
            // maskedTextBox_cikisbirebir
            // 
            this.maskedTextBox_cikisbirebir.Enabled = false;
            this.maskedTextBox_cikisbirebir.Location = new System.Drawing.Point(6, 188);
            this.maskedTextBox_cikisbirebir.Mask = "00/00/0000";
            this.maskedTextBox_cikisbirebir.Name = "maskedTextBox_cikisbirebir";
            this.maskedTextBox_cikisbirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_cikisbirebir.TabIndex = 6;
            this.maskedTextBox_cikisbirebir.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox_odabirebir
            // 
            this.comboBox_odabirebir.DataSource = this.odaKayitlariBindingSource;
            this.comboBox_odabirebir.DisplayMember = "oda_ad";
            this.comboBox_odabirebir.Enabled = false;
            this.comboBox_odabirebir.FormattingEnabled = true;
            this.comboBox_odabirebir.Location = new System.Drawing.Point(6, 59);
            this.comboBox_odabirebir.Name = "comboBox_odabirebir";
            this.comboBox_odabirebir.Size = new System.Drawing.Size(198, 32);
            this.comboBox_odabirebir.TabIndex = 4;
            this.comboBox_odabirebir.ValueMember = "oda_id";
            // 
            // Form_OdaKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl_list);
            this.Controls.Add(this.toolStrip_islemler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_OdaKayitlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Kayıtları";
            this.toolStrip_islemler.ResumeLayout(false);
            this.toolStrip_islemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaKayitlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaKayitlariDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_list)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_islemler;
        private System.Windows.Forms.ToolStripButton toolStripButton_ekle;
        private System.Windows.Forms.ToolStripButton toolStripButton_sil;
        private DevExpress.XtraGrid.GridControl gridControl_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_list;
        private OdaKayitlariDataSet odaKayitlariDataSet;
        private System.Windows.Forms.BindingSource odaKayitlariBindingSource;
        private OdaKayitlariDataSetTableAdapters.OdaKayitlariTableAdapter odaKayitlariTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colkayit_id;
        private DevExpress.XtraGrid.Columns.GridColumn colkayit_musteri;
        private DevExpress.XtraGrid.Columns.GridColumn colkayit_giris;
        private DevExpress.XtraGrid.Columns.GridColumn colkayit_cikis;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_id;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_ad;
        private DevExpress.XtraGrid.Columns.GridColumn colkayit_sure;
        private DevExpress.XtraGrid.Columns.GridColumn colkayıt_ucret;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_aranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_sure;
        private System.Windows.Forms.RadioButton radioButton_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_filtre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_birebirara;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cikisbirebir;
        private System.Windows.Forms.ComboBox comboBox_odabirebir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_girisbirebir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_raporla1;
        private System.Windows.Forms.ToolStripButton toolStripButton_raporla2;
    }
}