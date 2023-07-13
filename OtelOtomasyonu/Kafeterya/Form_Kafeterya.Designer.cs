namespace OtelOtomasyonu.Kafeterya
{
    partial class Form_Kafeterya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kafeterya));
            this.toolStrip_islemler = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_guncelle = new System.Windows.Forms.ToolStripButton();
            this.gridControl_list = new DevExpress.XtraGrid.GridControl();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerDataSet = new OtelOtomasyonu.UrunlerDataSet();
            this.gridView_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colurun_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurun_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurun_ucret = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurun_stok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurun_kategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urunlerTableAdapter = new OtelOtomasyonu.UrunlerDataSetTableAdapters.UrunlerTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_aranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_stok = new System.Windows.Forms.RadioButton();
            this.radioButton_ad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_filtre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_urunadbirebir = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_birebirara = new System.Windows.Forms.Button();
            this.comboBox_kategoribirebir = new System.Windows.Forms.ComboBox();
            this.urunKategorileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunKategorileriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunKategorileriDataSet = new OtelOtomasyonu.UrunKategorileriDataSet();
            this.urunKategorileriTableAdapter = new OtelOtomasyonu.UrunKategorileriDataSetTableAdapters.UrunKategorileriTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_raporla1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_raporla2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_islemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_list)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriDataSet)).BeginInit();
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
            this.toolStrip_islemler.Size = new System.Drawing.Size(984, 25);
            this.toolStrip_islemler.TabIndex = 3;
            this.toolStrip_islemler.Text = "toolStrip1";
            // 
            // toolStripButton_ekle
            // 
            this.toolStripButton_ekle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ekle.Image")));
            this.toolStripButton_ekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ekle.Name = "toolStripButton_ekle";
            this.toolStripButton_ekle.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton_ekle.Text = "Ürün Ekle";
            this.toolStripButton_ekle.ToolTipText = "Cari Ekle";
            this.toolStripButton_ekle.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_sil
            // 
            this.toolStripButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_sil.Image")));
            this.toolStripButton_sil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sil.Name = "toolStripButton_sil";
            this.toolStripButton_sil.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton_sil.Text = "Ürün Sil";
            this.toolStripButton_sil.ToolTipText = "Cari Sil";
            this.toolStripButton_sil.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_guncelle
            // 
            this.toolStripButton_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_guncelle.Image")));
            this.toolStripButton_guncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_guncelle.Name = "toolStripButton_guncelle";
            this.toolStripButton_guncelle.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton_guncelle.Text = "Ürün Güncelle";
            this.toolStripButton_guncelle.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // gridControl_list
            // 
            this.gridControl_list.DataSource = this.urunlerBindingSource;
            this.gridControl_list.Location = new System.Drawing.Point(0, 25);
            this.gridControl_list.MainView = this.gridView_list;
            this.gridControl_list.Name = "gridControl_list";
            this.gridControl_list.Size = new System.Drawing.Size(750, 475);
            this.gridControl_list.TabIndex = 4;
            this.gridControl_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_list});
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.urunlerDataSet;
            // 
            // urunlerDataSet
            // 
            this.urunlerDataSet.DataSetName = "UrunlerDataSet";
            this.urunlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_list
            // 
            this.gridView_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colurun_id,
            this.colurun_ad,
            this.colurun_ucret,
            this.colurun_stok,
            this.colurun_kategori});
            this.gridView_list.GridControl = this.gridControl_list;
            this.gridView_list.Name = "gridView_list";
            this.gridView_list.OptionsBehavior.Editable = false;
            this.gridView_list.OptionsSelection.MultiSelect = true;
            this.gridView_list.OptionsView.ShowAutoFilterRow = true;
            this.gridView_list.OptionsView.ShowFooter = true;
            this.gridView_list.OptionsView.ShowGroupPanel = false;
            // 
            // colurun_id
            // 
            this.colurun_id.Caption = "ID";
            this.colurun_id.FieldName = "urun_id";
            this.colurun_id.Name = "colurun_id";
            this.colurun_id.Visible = true;
            this.colurun_id.VisibleIndex = 0;
            // 
            // colurun_ad
            // 
            this.colurun_ad.Caption = "Ürün Adı";
            this.colurun_ad.FieldName = "urun_ad";
            this.colurun_ad.Name = "colurun_ad";
            this.colurun_ad.Visible = true;
            this.colurun_ad.VisibleIndex = 1;
            // 
            // colurun_ucret
            // 
            this.colurun_ucret.Caption = "Adet Ücreti";
            this.colurun_ucret.FieldName = "urun_ucret";
            this.colurun_ucret.Name = "colurun_ucret";
            this.colurun_ucret.Visible = true;
            this.colurun_ucret.VisibleIndex = 2;
            // 
            // colurun_stok
            // 
            this.colurun_stok.Caption = "Ürün Stok";
            this.colurun_stok.FieldName = "urun_stok";
            this.colurun_stok.Name = "colurun_stok";
            this.colurun_stok.Visible = true;
            this.colurun_stok.VisibleIndex = 3;
            // 
            // colurun_kategori
            // 
            this.colurun_kategori.Caption = "Ürün Kategori";
            this.colurun_kategori.FieldName = "urun_kategori";
            this.colurun_kategori.Name = "colurun_kategori";
            this.colurun_kategori.Visible = true;
            this.colurun_kategori.VisibleIndex = 4;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_aranan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox_filtre);
            this.groupBox2.Location = new System.Drawing.Point(759, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 274);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // textBox_aranan
            // 
            this.textBox_aranan.Location = new System.Drawing.Point(5, 233);
            this.textBox_aranan.Name = "textBox_aranan";
            this.textBox_aranan.Size = new System.Drawing.Size(200, 29);
            this.textBox_aranan.TabIndex = 9;
            this.textBox_aranan.TextChanged += new System.EventHandler(this.textBox_aranan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(5, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Ad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_stok);
            this.groupBox3.Controls.Add(this.radioButton_ad);
            this.groupBox3.Location = new System.Drawing.Point(6, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 105);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçimi";
            // 
            // radioButton_stok
            // 
            this.radioButton_stok.AutoSize = true;
            this.radioButton_stok.Location = new System.Drawing.Point(19, 66);
            this.radioButton_stok.Name = "radioButton_stok";
            this.radioButton_stok.Size = new System.Drawing.Size(110, 28);
            this.radioButton_stok.TabIndex = 1;
            this.radioButton_stok.Text = "Ürün Stok";
            this.radioButton_stok.UseVisualStyleBackColor = true;
            this.radioButton_stok.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioButton_ad
            // 
            this.radioButton_ad.AutoSize = true;
            this.radioButton_ad.Checked = true;
            this.radioButton_ad.Location = new System.Drawing.Point(19, 30);
            this.radioButton_ad.Name = "radioButton_ad";
            this.radioButton_ad.Size = new System.Drawing.Size(98, 28);
            this.radioButton_ad.TabIndex = 0;
            this.radioButton_ad.TabStop = true;
            this.radioButton_ad.Text = "Ürün Ad";
            this.radioButton_ad.UseVisualStyleBackColor = true;
            this.radioButton_ad.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 32);
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
            this.comboBox_filtre.Location = new System.Drawing.Point(6, 55);
            this.comboBox_filtre.Name = "comboBox_filtre";
            this.comboBox_filtre.Size = new System.Drawing.Size(198, 32);
            this.comboBox_filtre.TabIndex = 5;
            this.comboBox_filtre.Text = "İle Başlayan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_urunadbirebir);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button_birebirara);
            this.groupBox1.Controls.Add(this.comboBox_kategoribirebir);
            this.groupBox1.Location = new System.Drawing.Point(759, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 208);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // textBox_urunadbirebir
            // 
            this.textBox_urunadbirebir.Enabled = false;
            this.textBox_urunadbirebir.Location = new System.Drawing.Point(9, 62);
            this.textBox_urunadbirebir.Name = "textBox_urunadbirebir";
            this.textBox_urunadbirebir.Size = new System.Drawing.Size(198, 29);
            this.textBox_urunadbirebir.TabIndex = 10;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox2.Location = new System.Drawing.Point(9, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 22);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Kategori";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(9, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Ürün Ad";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_birebirara
            // 
            this.button_birebirara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_birebirara.Location = new System.Drawing.Point(6, 167);
            this.button_birebirara.Name = "button_birebirara";
            this.button_birebirara.Size = new System.Drawing.Size(201, 35);
            this.button_birebirara.TabIndex = 7;
            this.button_birebirara.Text = "Ara";
            this.button_birebirara.UseVisualStyleBackColor = true;
            this.button_birebirara.Click += new System.EventHandler(this.button_birebirara_Click);
            // 
            // comboBox_kategoribirebir
            // 
            this.comboBox_kategoribirebir.DataSource = this.urunKategorileriBindingSource;
            this.comboBox_kategoribirebir.DisplayMember = "kategori_ad";
            this.comboBox_kategoribirebir.Enabled = false;
            this.comboBox_kategoribirebir.FormattingEnabled = true;
            this.comboBox_kategoribirebir.Location = new System.Drawing.Point(9, 125);
            this.comboBox_kategoribirebir.Name = "comboBox_kategoribirebir";
            this.comboBox_kategoribirebir.Size = new System.Drawing.Size(198, 32);
            this.comboBox_kategoribirebir.TabIndex = 4;
            this.comboBox_kategoribirebir.ValueMember = "kategori_id";
            // 
            // urunKategorileriBindingSource
            // 
            this.urunKategorileriBindingSource.DataMember = "UrunKategorileri";
            this.urunKategorileriBindingSource.DataSource = this.urunKategorileriDataSetBindingSource;
            // 
            // urunKategorileriDataSetBindingSource
            // 
            this.urunKategorileriDataSetBindingSource.DataSource = this.urunKategorileriDataSet;
            this.urunKategorileriDataSetBindingSource.Position = 0;
            // 
            // urunKategorileriDataSet
            // 
            this.urunKategorileriDataSet.DataSetName = "UrunKategorileriDataSet";
            this.urunKategorileriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunKategorileriTableAdapter
            // 
            this.urunKategorileriTableAdapter.ClearBeforeFill = true;
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
            this.toolStripButton_raporla1.Size = new System.Drawing.Size(142, 22);
            this.toolStripButton_raporla1.Text = "Ürünler Listesi Raporu";
            this.toolStripButton_raporla1.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_raporla2
            // 
            this.toolStripButton_raporla2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_raporla2.Image")));
            this.toolStripButton_raporla2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_raporla2.Name = "toolStripButton_raporla2";
            this.toolStripButton_raporla2.Size = new System.Drawing.Size(229, 22);
            this.toolStripButton_raporla2.Text = "Kategoriye Göre Ürünler Listesi Raporu";
            this.toolStripButton_raporla2.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // Form_Kafeterya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl_list);
            this.Controls.Add(this.toolStrip_islemler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Kafeterya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kafeterya";
            this.toolStrip_islemler.ResumeLayout(false);
            this.toolStrip_islemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_list)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_islemler;
        private System.Windows.Forms.ToolStripButton toolStripButton_ekle;
        private System.Windows.Forms.ToolStripButton toolStripButton_sil;
        private System.Windows.Forms.ToolStripButton toolStripButton_guncelle;
        private DevExpress.XtraGrid.GridControl gridControl_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_list;
        private UrunlerDataSet urunlerDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private UrunlerDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colurun_id;
        private DevExpress.XtraGrid.Columns.GridColumn colurun_ad;
        private DevExpress.XtraGrid.Columns.GridColumn colurun_ucret;
        private DevExpress.XtraGrid.Columns.GridColumn colurun_stok;
        private DevExpress.XtraGrid.Columns.GridColumn colurun_kategori;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_aranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_stok;
        private System.Windows.Forms.RadioButton radioButton_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_filtre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_birebirara;
        private System.Windows.Forms.ComboBox comboBox_kategoribirebir;
        private System.Windows.Forms.BindingSource urunKategorileriDataSetBindingSource;
        private UrunKategorileriDataSet urunKategorileriDataSet;
        private System.Windows.Forms.BindingSource urunKategorileriBindingSource;
        private UrunKategorileriDataSetTableAdapters.UrunKategorileriTableAdapter urunKategorileriTableAdapter;
        private System.Windows.Forms.TextBox textBox_urunadbirebir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_raporla1;
        private System.Windows.Forms.ToolStripButton toolStripButton_raporla2;
    }
}