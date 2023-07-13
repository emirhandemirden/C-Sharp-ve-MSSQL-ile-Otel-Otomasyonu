namespace OtelOtomasyonu.Cariler
{
    partial class Form_Cariler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cariler));
            this.toolStrip_islemler = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_guncelle = new System.Windows.Forms.ToolStripButton();
            this.gridControl_list = new DevExpress.XtraGrid.GridControl();
            this.carilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet = new OtelOtomasyonu.CarilerDataSet();
            this.gridView_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcari_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_dogum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_kayit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_tur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_sifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.carilerTableAdapter = new OtelOtomasyonu.CarilerDataSetTableAdapters.CarilerTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_aranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_telefonno = new System.Windows.Forms.RadioButton();
            this.radioButton_ad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_filtre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_dogumbirebir = new System.Windows.Forms.MaskedTextBox();
            this.textBox_adBirebir = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_birebirara = new System.Windows.Forms.Button();
            this.comboBox_turbirebir = new System.Windows.Forms.ComboBox();
            this.cariTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cariTurleriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cariTurleriDataSet = new OtelOtomasyonu.CariTurleriDataSet();
            this.cariTurleriTableAdapter = new OtelOtomasyonu.CariTurleriDataSetTableAdapters.CariTurleriTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_islemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_list)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_islemler
            // 
            this.toolStrip_islemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ekle,
            this.toolStripButton_sil,
            this.toolStripButton_guncelle,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip_islemler.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_islemler.Name = "toolStrip_islemler";
            this.toolStrip_islemler.Size = new System.Drawing.Size(1234, 25);
            this.toolStrip_islemler.TabIndex = 1;
            this.toolStrip_islemler.Text = "toolStrip1";
            // 
            // toolStripButton_ekle
            // 
            this.toolStripButton_ekle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ekle.Image")));
            this.toolStripButton_ekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ekle.Name = "toolStripButton_ekle";
            this.toolStripButton_ekle.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton_ekle.Text = "Cari Ekle";
            this.toolStripButton_ekle.ToolTipText = "Cari Ekle";
            this.toolStripButton_ekle.Click += new System.EventHandler(this.toolStripButtons_Click);
            // 
            // toolStripButton_sil
            // 
            this.toolStripButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_sil.Image")));
            this.toolStripButton_sil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sil.Name = "toolStripButton_sil";
            this.toolStripButton_sil.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton_sil.Text = "Cari Sil";
            this.toolStripButton_sil.ToolTipText = "Cari Sil";
            this.toolStripButton_sil.Click += new System.EventHandler(this.toolStripButtons_Click);
            // 
            // toolStripButton_guncelle
            // 
            this.toolStripButton_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_guncelle.Image")));
            this.toolStripButton_guncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_guncelle.Name = "toolStripButton_guncelle";
            this.toolStripButton_guncelle.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton_guncelle.Text = "Cari Güncelle";
            this.toolStripButton_guncelle.Click += new System.EventHandler(this.toolStripButtons_Click);
            // 
            // gridControl_list
            // 
            this.gridControl_list.DataSource = this.carilerBindingSource;
            this.gridControl_list.Location = new System.Drawing.Point(0, 25);
            this.gridControl_list.MainView = this.gridView_list;
            this.gridControl_list.Name = "gridControl_list";
            this.gridControl_list.Size = new System.Drawing.Size(1000, 686);
            this.gridControl_list.TabIndex = 2;
            this.gridControl_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_list});
            // 
            // carilerBindingSource
            // 
            this.carilerBindingSource.DataMember = "Cariler";
            this.carilerBindingSource.DataSource = this.carilerDataSet;
            // 
            // carilerDataSet
            // 
            this.carilerDataSet.DataSetName = "CarilerDataSet";
            this.carilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_list
            // 
            this.gridView_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcari_id,
            this.colcari_ad,
            this.colcari_tel,
            this.colcari_dogum,
            this.colcari_kayit,
            this.colcari_tur,
            this.colcari_sifre});
            this.gridView_list.GridControl = this.gridControl_list;
            this.gridView_list.Name = "gridView_list";
            this.gridView_list.OptionsBehavior.Editable = false;
            this.gridView_list.OptionsSelection.MultiSelect = true;
            this.gridView_list.OptionsView.ShowAutoFilterRow = true;
            this.gridView_list.OptionsView.ShowFooter = true;
            this.gridView_list.OptionsView.ShowGroupPanel = false;
            // 
            // colcari_id
            // 
            this.colcari_id.Caption = "ID";
            this.colcari_id.FieldName = "cari_id";
            this.colcari_id.Name = "colcari_id";
            this.colcari_id.Visible = true;
            this.colcari_id.VisibleIndex = 0;
            // 
            // colcari_ad
            // 
            this.colcari_ad.Caption = "Cari Ad";
            this.colcari_ad.FieldName = "cari_ad";
            this.colcari_ad.Name = "colcari_ad";
            this.colcari_ad.Visible = true;
            this.colcari_ad.VisibleIndex = 1;
            // 
            // colcari_tel
            // 
            this.colcari_tel.Caption = "Telefon Numarası";
            this.colcari_tel.FieldName = "cari_tel";
            this.colcari_tel.Name = "colcari_tel";
            this.colcari_tel.Visible = true;
            this.colcari_tel.VisibleIndex = 2;
            // 
            // colcari_dogum
            // 
            this.colcari_dogum.Caption = "Doğum Tarihi";
            this.colcari_dogum.FieldName = "cari_dogum";
            this.colcari_dogum.Name = "colcari_dogum";
            this.colcari_dogum.Visible = true;
            this.colcari_dogum.VisibleIndex = 3;
            // 
            // colcari_kayit
            // 
            this.colcari_kayit.Caption = "Kayıt Tarihi";
            this.colcari_kayit.FieldName = "cari_kayit";
            this.colcari_kayit.Name = "colcari_kayit";
            this.colcari_kayit.Visible = true;
            this.colcari_kayit.VisibleIndex = 6;
            // 
            // colcari_tur
            // 
            this.colcari_tur.Caption = "Tür";
            this.colcari_tur.FieldName = "cari_tur";
            this.colcari_tur.Name = "colcari_tur";
            this.colcari_tur.Visible = true;
            this.colcari_tur.VisibleIndex = 4;
            // 
            // colcari_sifre
            // 
            this.colcari_sifre.Caption = "Şifre";
            this.colcari_sifre.FieldName = "cari_sifre";
            this.colcari_sifre.Name = "colcari_sifre";
            this.colcari_sifre.Visible = true;
            this.colcari_sifre.VisibleIndex = 5;
            // 
            // carilerTableAdapter
            // 
            this.carilerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_aranan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox_filtre);
            this.groupBox2.Location = new System.Drawing.Point(1009, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 346);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // textBox_aranan
            // 
            this.textBox_aranan.Location = new System.Drawing.Point(6, 296);
            this.textBox_aranan.Name = "textBox_aranan";
            this.textBox_aranan.Size = new System.Drawing.Size(200, 29);
            this.textBox_aranan.TabIndex = 9;
            this.textBox_aranan.TextChanged += new System.EventHandler(this.textBox_aranan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_telefonno);
            this.groupBox3.Controls.Add(this.radioButton_ad);
            this.groupBox3.Location = new System.Drawing.Point(6, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 105);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçimi";
            // 
            // radioButton_telefonno
            // 
            this.radioButton_telefonno.AutoSize = true;
            this.radioButton_telefonno.Location = new System.Drawing.Point(19, 66);
            this.radioButton_telefonno.Name = "radioButton_telefonno";
            this.radioButton_telefonno.Size = new System.Drawing.Size(177, 28);
            this.radioButton_telefonno.TabIndex = 1;
            this.radioButton_telefonno.Text = "Telefon Numarası";
            this.radioButton_telefonno.UseVisualStyleBackColor = true;
            this.radioButton_telefonno.CheckedChanged += new System.EventHandler(this.RadioButtonsCheckedChanged);
            // 
            // radioButton_ad
            // 
            this.radioButton_ad.AutoSize = true;
            this.radioButton_ad.Checked = true;
            this.radioButton_ad.Location = new System.Drawing.Point(19, 30);
            this.radioButton_ad.Name = "radioButton_ad";
            this.radioButton_ad.Size = new System.Drawing.Size(52, 28);
            this.radioButton_ad.TabIndex = 0;
            this.radioButton_ad.TabStop = true;
            this.radioButton_ad.Text = "Ad";
            this.radioButton_ad.UseVisualStyleBackColor = true;
            this.radioButton_ad.CheckedChanged += new System.EventHandler(this.RadioButtonsCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 47);
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
            this.comboBox_filtre.Location = new System.Drawing.Point(6, 70);
            this.comboBox_filtre.Name = "comboBox_filtre";
            this.comboBox_filtre.Size = new System.Drawing.Size(198, 32);
            this.comboBox_filtre.TabIndex = 5;
            this.comboBox_filtre.Text = "İle Başlayan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_dogumbirebir);
            this.groupBox1.Controls.Add(this.textBox_adBirebir);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button_birebirara);
            this.groupBox1.Controls.Add(this.comboBox_turbirebir);
            this.groupBox1.Location = new System.Drawing.Point(1009, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 346);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // maskedTextBox_dogumbirebir
            // 
            this.maskedTextBox_dogumbirebir.Enabled = false;
            this.maskedTextBox_dogumbirebir.Location = new System.Drawing.Point(6, 147);
            this.maskedTextBox_dogumbirebir.Mask = "00/00/0000";
            this.maskedTextBox_dogumbirebir.Name = "maskedTextBox_dogumbirebir";
            this.maskedTextBox_dogumbirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_dogumbirebir.TabIndex = 12;
            this.maskedTextBox_dogumbirebir.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_adBirebir
            // 
            this.textBox_adBirebir.Enabled = false;
            this.textBox_adBirebir.Location = new System.Drawing.Point(6, 66);
            this.textBox_adBirebir.Name = "textBox_adBirebir";
            this.textBox_adBirebir.Size = new System.Drawing.Size(201, 29);
            this.textBox_adBirebir.TabIndex = 11;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox3.Location = new System.Drawing.Point(6, 210);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 22);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Tür";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox2.Location = new System.Drawing.Point(9, 119);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 22);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Doğum Tarihi";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(9, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Ad";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_birebirara
            // 
            this.button_birebirara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_birebirara.Location = new System.Drawing.Point(6, 305);
            this.button_birebirara.Name = "button_birebirara";
            this.button_birebirara.Size = new System.Drawing.Size(201, 35);
            this.button_birebirara.TabIndex = 7;
            this.button_birebirara.Text = "Ara";
            this.button_birebirara.UseVisualStyleBackColor = true;
            this.button_birebirara.Click += new System.EventHandler(this.button_birebirara_Click);
            // 
            // comboBox_turbirebir
            // 
            this.comboBox_turbirebir.DataSource = this.cariTurleriBindingSource;
            this.comboBox_turbirebir.DisplayMember = "tur_ad";
            this.comboBox_turbirebir.Enabled = false;
            this.comboBox_turbirebir.FormattingEnabled = true;
            this.comboBox_turbirebir.Location = new System.Drawing.Point(6, 238);
            this.comboBox_turbirebir.Name = "comboBox_turbirebir";
            this.comboBox_turbirebir.Size = new System.Drawing.Size(198, 32);
            this.comboBox_turbirebir.TabIndex = 4;
            this.comboBox_turbirebir.ValueMember = "tur_id";
            // 
            // cariTurleriBindingSource
            // 
            this.cariTurleriBindingSource.DataMember = "CariTurleri";
            this.cariTurleriBindingSource.DataSource = this.cariTurleriDataSetBindingSource;
            // 
            // cariTurleriDataSetBindingSource
            // 
            this.cariTurleriDataSetBindingSource.DataSource = this.cariTurleriDataSet;
            this.cariTurleriDataSetBindingSource.Position = 0;
            // 
            // cariTurleriDataSet
            // 
            this.cariTurleriDataSet.DataSetName = "CariTurleriDataSet";
            this.cariTurleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cariTurleriTableAdapter
            // 
            this.cariTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(137, 22);
            this.toolStripButton1.Text = "Cariler Listesi Raporu";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButtons_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(205, 22);
            this.toolStripButton2.Text = "Türüne Göre Cariler Listesi Raporu";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButtons_Click);
            // 
            // Form_Cariler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl_list);
            this.Controls.Add(this.toolStrip_islemler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Cariler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cariler";
            this.toolStrip_islemler.ResumeLayout(false);
            this.toolStrip_islemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_list)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriDataSet)).EndInit();
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
        private CarilerDataSet carilerDataSet;
        private System.Windows.Forms.BindingSource carilerBindingSource;
        private CarilerDataSetTableAdapters.CarilerTableAdapter carilerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_ad;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_tel;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_dogum;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_kayit;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_tur;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_sifre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_aranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_telefonno;
        private System.Windows.Forms.RadioButton radioButton_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_filtre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_birebirara;
        private System.Windows.Forms.ComboBox comboBox_turbirebir;
        private System.Windows.Forms.TextBox textBox_adBirebir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dogumbirebir;
        private System.Windows.Forms.BindingSource cariTurleriDataSetBindingSource;
        private CariTurleriDataSet cariTurleriDataSet;
        private System.Windows.Forms.BindingSource cariTurleriBindingSource;
        private CariTurleriDataSetTableAdapters.CariTurleriTableAdapter cariTurleriTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}