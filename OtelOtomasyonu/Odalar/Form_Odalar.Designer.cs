namespace OtelOtomasyonu.Odalar
{
    partial class Form_Odalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Odalar));
            this.toolStrip_islemler = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_guncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_raporla = new System.Windows.Forms.ToolStripButton();
            this.gridControl_list = new DevExpress.XtraGrid.GridControl();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odalarDataSet = new OtelOtomasyonu.OdalarDataSet();
            this.gridView_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coloda_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_tur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_yataksayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_gorevlisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_kat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloda_esyalar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.odalarTableAdapter = new OtelOtomasyonu.OdalarDataSetTableAdapters.OdalarTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_birebirara = new System.Windows.Forms.Button();
            this.maskedTextBox_yataksayisibirebir = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_turbirebir = new System.Windows.Forms.ComboBox();
            this.odaTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaTurleriDataSet = new OtelOtomasyonu.OdaTurleriDataSet();
            this.maskedTextBox_katnobirebir = new System.Windows.Forms.MaskedTextBox();
            this.odaTurleriTableAdapter = new OtelOtomasyonu.OdaTurleriDataSetTableAdapters.OdaTurleriTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_aranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_esyalar = new System.Windows.Forms.RadioButton();
            this.radioButton_aciklama = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_filtre = new System.Windows.Forms.ComboBox();
            this.toolStripButton_raporla2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_islemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_list)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_islemler
            // 
            this.toolStrip_islemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ekle,
            this.toolStripButton_sil,
            this.toolStripButton_guncelle,
            this.toolStripSeparator1,
            this.toolStripButton_raporla,
            this.toolStripButton_raporla2});
            this.toolStrip_islemler.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_islemler.Name = "toolStrip_islemler";
            this.toolStrip_islemler.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip_islemler.Size = new System.Drawing.Size(1234, 25);
            this.toolStrip_islemler.TabIndex = 2;
            this.toolStrip_islemler.Text = "toolStrip1";
            // 
            // toolStripButton_ekle
            // 
            this.toolStripButton_ekle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ekle.Image")));
            this.toolStripButton_ekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ekle.Name = "toolStripButton_ekle";
            this.toolStripButton_ekle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton_ekle.Text = "Oda Ekle";
            this.toolStripButton_ekle.ToolTipText = "Oda Ekle";
            this.toolStripButton_ekle.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_sil
            // 
            this.toolStripButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_sil.Image")));
            this.toolStripButton_sil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sil.Name = "toolStripButton_sil";
            this.toolStripButton_sil.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton_sil.Text = "Oda Sil";
            this.toolStripButton_sil.ToolTipText = "Oda Sil";
            this.toolStripButton_sil.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton_guncelle
            // 
            this.toolStripButton_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_guncelle.Image")));
            this.toolStripButton_guncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_guncelle.Name = "toolStripButton_guncelle";
            this.toolStripButton_guncelle.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton_guncelle.Text = "Oda Güncelle";
            this.toolStripButton_guncelle.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_raporla
            // 
            this.toolStripButton_raporla.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_raporla.Image")));
            this.toolStripButton_raporla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_raporla.Name = "toolStripButton_raporla";
            this.toolStripButton_raporla.Size = new System.Drawing.Size(125, 22);
            this.toolStripButton_raporla.Text = "Oda Listesi Raporu";
            this.toolStripButton_raporla.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // gridControl_list
            // 
            this.gridControl_list.DataSource = this.odalarBindingSource;
            this.gridControl_list.Location = new System.Drawing.Point(0, 25);
            this.gridControl_list.MainView = this.gridView_list;
            this.gridControl_list.Name = "gridControl_list";
            this.gridControl_list.Size = new System.Drawing.Size(1000, 686);
            this.gridControl_list.TabIndex = 3;
            this.gridControl_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_list});
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.odalarDataSet;
            // 
            // odalarDataSet
            // 
            this.odalarDataSet.DataSetName = "OdalarDataSet";
            this.odalarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_list
            // 
            this.gridView_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coloda_id,
            this.coloda_aciklama,
            this.coloda_tur,
            this.coloda_yataksayisi,
            this.coloda_gorevlisi,
            this.coloda_kat,
            this.coloda_no,
            this.coloda_esyalar});
            this.gridView_list.GridControl = this.gridControl_list;
            this.gridView_list.Name = "gridView_list";
            this.gridView_list.OptionsBehavior.Editable = false;
            this.gridView_list.OptionsSelection.MultiSelect = true;
            this.gridView_list.OptionsView.ShowAutoFilterRow = true;
            this.gridView_list.OptionsView.ShowFooter = true;
            this.gridView_list.OptionsView.ShowGroupPanel = false;
            // 
            // coloda_id
            // 
            this.coloda_id.Caption = "ID";
            this.coloda_id.FieldName = "oda_id";
            this.coloda_id.Name = "coloda_id";
            this.coloda_id.Visible = true;
            this.coloda_id.VisibleIndex = 0;
            // 
            // coloda_aciklama
            // 
            this.coloda_aciklama.Caption = "Oda Açıklaması";
            this.coloda_aciklama.FieldName = "oda_aciklama";
            this.coloda_aciklama.Name = "coloda_aciklama";
            this.coloda_aciklama.Visible = true;
            this.coloda_aciklama.VisibleIndex = 3;
            // 
            // coloda_tur
            // 
            this.coloda_tur.Caption = "Oda Türü";
            this.coloda_tur.FieldName = "oda_tur";
            this.coloda_tur.Name = "coloda_tur";
            this.coloda_tur.Visible = true;
            this.coloda_tur.VisibleIndex = 4;
            // 
            // coloda_yataksayisi
            // 
            this.coloda_yataksayisi.Caption = "Yatak Sayısı";
            this.coloda_yataksayisi.FieldName = "oda_yataksayisi";
            this.coloda_yataksayisi.Name = "coloda_yataksayisi";
            this.coloda_yataksayisi.Visible = true;
            this.coloda_yataksayisi.VisibleIndex = 5;
            // 
            // coloda_gorevlisi
            // 
            this.coloda_gorevlisi.Caption = "Oda Görevlisi";
            this.coloda_gorevlisi.FieldName = "oda_gorevlisi";
            this.coloda_gorevlisi.Name = "coloda_gorevlisi";
            this.coloda_gorevlisi.Visible = true;
            this.coloda_gorevlisi.VisibleIndex = 7;
            // 
            // coloda_kat
            // 
            this.coloda_kat.Caption = "Oda Kat No";
            this.coloda_kat.FieldName = "oda_kat";
            this.coloda_kat.Name = "coloda_kat";
            this.coloda_kat.Visible = true;
            this.coloda_kat.VisibleIndex = 2;
            // 
            // coloda_no
            // 
            this.coloda_no.Caption = "Oda No";
            this.coloda_no.FieldName = "oda_no";
            this.coloda_no.Name = "coloda_no";
            this.coloda_no.Visible = true;
            this.coloda_no.VisibleIndex = 1;
            // 
            // coloda_esyalar
            // 
            this.coloda_esyalar.Caption = "Eşyalar";
            this.coloda_esyalar.FieldName = "oda_esyalar";
            this.coloda_esyalar.Name = "coloda_esyalar";
            this.coloda_esyalar.Visible = true;
            this.coloda_esyalar.VisibleIndex = 6;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button_birebirara);
            this.groupBox1.Controls.Add(this.maskedTextBox_yataksayisibirebir);
            this.groupBox1.Controls.Add(this.comboBox_turbirebir);
            this.groupBox1.Controls.Add(this.maskedTextBox_katnobirebir);
            this.groupBox1.Location = new System.Drawing.Point(1009, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 346);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox3.Location = new System.Drawing.Point(9, 210);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(139, 22);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Oda Yatak Sayısı";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox2.Location = new System.Drawing.Point(9, 119);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 22);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Oda Tür";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(9, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Oda Kat No";
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
            // maskedTextBox_yataksayisibirebir
            // 
            this.maskedTextBox_yataksayisibirebir.Enabled = false;
            this.maskedTextBox_yataksayisibirebir.Location = new System.Drawing.Point(6, 238);
            this.maskedTextBox_yataksayisibirebir.Mask = "00000";
            this.maskedTextBox_yataksayisibirebir.Name = "maskedTextBox_yataksayisibirebir";
            this.maskedTextBox_yataksayisibirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_yataksayisibirebir.TabIndex = 6;
            this.maskedTextBox_yataksayisibirebir.ValidatingType = typeof(int);
            // 
            // comboBox_turbirebir
            // 
            this.comboBox_turbirebir.DataSource = this.odaTurleriBindingSource;
            this.comboBox_turbirebir.DisplayMember = "tur_ad";
            this.comboBox_turbirebir.Enabled = false;
            this.comboBox_turbirebir.FormattingEnabled = true;
            this.comboBox_turbirebir.Location = new System.Drawing.Point(9, 147);
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
            this.maskedTextBox_katnobirebir.Enabled = false;
            this.maskedTextBox_katnobirebir.Location = new System.Drawing.Point(6, 66);
            this.maskedTextBox_katnobirebir.Mask = "00000";
            this.maskedTextBox_katnobirebir.Name = "maskedTextBox_katnobirebir";
            this.maskedTextBox_katnobirebir.Size = new System.Drawing.Size(201, 29);
            this.maskedTextBox_katnobirebir.TabIndex = 2;
            this.maskedTextBox_katnobirebir.ValidatingType = typeof(int);
            // 
            // odaTurleriTableAdapter
            // 
            this.odaTurleriTableAdapter.ClearBeforeFill = true;
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
            this.groupBox2.TabIndex = 8;
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
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Açıklama:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_esyalar);
            this.groupBox3.Controls.Add(this.radioButton_aciklama);
            this.groupBox3.Location = new System.Drawing.Point(6, 134);
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
            this.radioButton_esyalar.Size = new System.Drawing.Size(89, 28);
            this.radioButton_esyalar.TabIndex = 1;
            this.radioButton_esyalar.Text = "Eşyalar";
            this.radioButton_esyalar.UseVisualStyleBackColor = true;
            this.radioButton_esyalar.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioButton_aciklama
            // 
            this.radioButton_aciklama.AutoSize = true;
            this.radioButton_aciklama.Checked = true;
            this.radioButton_aciklama.Location = new System.Drawing.Point(19, 30);
            this.radioButton_aciklama.Name = "radioButton_aciklama";
            this.radioButton_aciklama.Size = new System.Drawing.Size(104, 28);
            this.radioButton_aciklama.TabIndex = 0;
            this.radioButton_aciklama.TabStop = true;
            this.radioButton_aciklama.Text = "Açıklama";
            this.radioButton_aciklama.UseVisualStyleBackColor = true;
            this.radioButton_aciklama.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
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
            // toolStripButton_raporla2
            // 
            this.toolStripButton_raporla2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_raporla2.Image")));
            this.toolStripButton_raporla2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_raporla2.Name = "toolStripButton_raporla2";
            this.toolStripButton_raporla2.Size = new System.Drawing.Size(206, 22);
            this.toolStripButton_raporla2.Text = "Türüne Göre Odalar Listesi Raporu";
            this.toolStripButton_raporla2.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // Form_Odalar
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
            this.Name = "Form_Odalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Odalar";
            this.toolStrip_islemler.ResumeLayout(false);
            this.toolStrip_islemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private OdalarDataSet odalarDataSet;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private OdalarDataSetTableAdapters.OdalarTableAdapter odalarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_id;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_tur;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_yataksayisi;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_gorevlisi;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_kat;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_no;
        private DevExpress.XtraGrid.Columns.GridColumn coloda_esyalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_turbirebir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_katnobirebir;
        private OdaTurleriDataSet odaTurleriDataSet;
        private System.Windows.Forms.BindingSource odaTurleriBindingSource;
        private OdaTurleriDataSetTableAdapters.OdaTurleriTableAdapter odaTurleriTableAdapter;
        private System.Windows.Forms.Button button_birebirara;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_yataksayisibirebir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_filtre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_esyalar;
        private System.Windows.Forms.RadioButton radioButton_aciklama;
        private System.Windows.Forms.TextBox textBox_aranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_raporla;
        private System.Windows.Forms.ToolStripButton toolStripButton_raporla2;
    }
}