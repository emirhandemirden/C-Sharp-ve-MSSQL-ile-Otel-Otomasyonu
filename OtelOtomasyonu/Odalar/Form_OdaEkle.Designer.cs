namespace OtelOtomasyonu.Odalar
{
    partial class Form_OdaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox_odano = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_katno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_aciklama = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.odaTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaTurleriDataSet = new OtelOtomasyonu.OdaTurleriDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox_yataksayisi = new System.Windows.Forms.MaskedTextBox();
            this.checkedListBox_esyalar = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_gorevlisi = new System.Windows.Forms.ComboBox();
            this.carilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gorevlilerDataSet = new OtelOtomasyonu.GorevlilerDataSet();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.odaTurleriTableAdapter = new OtelOtomasyonu.OdaTurleriDataSetTableAdapters.OdaTurleriTableAdapter();
            this.carilerTableAdapter1 = new OtelOtomasyonu.GorevlilerDataSetTableAdapters.CarilerTableAdapter();
            this.maskedTextBox_ucret = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlilerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_odano
            // 
            this.maskedTextBox_odano.Location = new System.Drawing.Point(184, 12);
            this.maskedTextBox_odano.Mask = "000";
            this.maskedTextBox_odano.Name = "maskedTextBox_odano";
            this.maskedTextBox_odano.Size = new System.Drawing.Size(224, 29);
            this.maskedTextBox_odano.TabIndex = 1;
            this.maskedTextBox_odano.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oda Kat:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_katno
            // 
            this.maskedTextBox_katno.Location = new System.Drawing.Point(184, 49);
            this.maskedTextBox_katno.Mask = "000";
            this.maskedTextBox_katno.Name = "maskedTextBox_katno";
            this.maskedTextBox_katno.Size = new System.Drawing.Size(224, 29);
            this.maskedTextBox_katno.TabIndex = 3;
            this.maskedTextBox_katno.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oda Açıklaması:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox_aciklama
            // 
            this.richTextBox_aciklama.Location = new System.Drawing.Point(184, 86);
            this.richTextBox_aciklama.Name = "richTextBox_aciklama";
            this.richTextBox_aciklama.Size = new System.Drawing.Size(224, 143);
            this.richTextBox_aciklama.TabIndex = 5;
            this.richTextBox_aciklama.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(2, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oda Tür:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.DataSource = this.odaTurleriBindingSource;
            this.comboBox_tur.DisplayMember = "tur_ad";
            this.comboBox_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Location = new System.Drawing.Point(184, 235);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(224, 32);
            this.comboBox_tur.TabIndex = 7;
            this.comboBox_tur.ValueMember = "tur_id";
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
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(2, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oda Eşyalar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(2, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Oda Yatak Sayısı:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_yataksayisi
            // 
            this.maskedTextBox_yataksayisi.Location = new System.Drawing.Point(184, 271);
            this.maskedTextBox_yataksayisi.Mask = "000";
            this.maskedTextBox_yataksayisi.Name = "maskedTextBox_yataksayisi";
            this.maskedTextBox_yataksayisi.Size = new System.Drawing.Size(224, 29);
            this.maskedTextBox_yataksayisi.TabIndex = 9;
            this.maskedTextBox_yataksayisi.ValidatingType = typeof(int);
            // 
            // checkedListBox_esyalar
            // 
            this.checkedListBox_esyalar.FormattingEnabled = true;
            this.checkedListBox_esyalar.Location = new System.Drawing.Point(184, 308);
            this.checkedListBox_esyalar.Name = "checkedListBox_esyalar";
            this.checkedListBox_esyalar.Size = new System.Drawing.Size(224, 124);
            this.checkedListBox_esyalar.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(2, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Oda Görevlisi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_gorevlisi
            // 
            this.comboBox_gorevlisi.DataSource = this.carilerBindingSource1;
            this.comboBox_gorevlisi.DisplayMember = "cari_ad";
            this.comboBox_gorevlisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gorevlisi.FormattingEnabled = true;
            this.comboBox_gorevlisi.Location = new System.Drawing.Point(184, 448);
            this.comboBox_gorevlisi.Name = "comboBox_gorevlisi";
            this.comboBox_gorevlisi.Size = new System.Drawing.Size(224, 32);
            this.comboBox_gorevlisi.TabIndex = 12;
            this.comboBox_gorevlisi.ValueMember = "cari_id";
            // 
            // carilerBindingSource1
            // 
            this.carilerBindingSource1.DataMember = "Cariler";
            this.carilerBindingSource1.DataSource = this.gorevlilerDataSet;
            // 
            // gorevlilerDataSet
            // 
            this.gorevlilerDataSet.DataSetName = "GorevlilerDataSet";
            this.gorevlilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(279, 529);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(129, 53);
            this.button_kaydet.TabIndex = 13;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_temizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_temizle.Location = new System.Drawing.Point(12, 529);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(129, 53);
            this.button_temizle.TabIndex = 14;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // odaTurleriTableAdapter
            // 
            this.odaTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // carilerTableAdapter1
            // 
            this.carilerTableAdapter1.ClearBeforeFill = true;
            // 
            // maskedTextBox_ucret
            // 
            this.maskedTextBox_ucret.Location = new System.Drawing.Point(184, 484);
            this.maskedTextBox_ucret.Mask = "00000";
            this.maskedTextBox_ucret.Name = "maskedTextBox_ucret";
            this.maskedTextBox_ucret.Size = new System.Drawing.Size(224, 29);
            this.maskedTextBox_ucret.TabIndex = 16;
            this.maskedTextBox_ucret.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(2, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Oda Ücret:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_OdaEkle
            // 
            this.AcceptButton = this.button_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_temizle;
            this.ClientSize = new System.Drawing.Size(422, 594);
            this.Controls.Add(this.maskedTextBox_ucret);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.comboBox_gorevlisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBox_esyalar);
            this.Controls.Add(this.maskedTextBox_yataksayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_tur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox_aciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox_katno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox_odano);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_OdaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlilerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_odano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_katno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_yataksayisi;
        private System.Windows.Forms.CheckedListBox checkedListBox_esyalar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_gorevlisi;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_temizle;
        private OdaTurleriDataSet odaTurleriDataSet;
        private System.Windows.Forms.BindingSource odaTurleriBindingSource;
        private OdaTurleriDataSetTableAdapters.OdaTurleriTableAdapter odaTurleriTableAdapter;
        private GorevlilerDataSet gorevlilerDataSet;
        private System.Windows.Forms.BindingSource carilerBindingSource1;
        private GorevlilerDataSetTableAdapters.CarilerTableAdapter carilerTableAdapter1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ucret;
        private System.Windows.Forms.Label label8;
    }
}