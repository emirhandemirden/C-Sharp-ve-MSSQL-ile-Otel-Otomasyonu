namespace OtelOtomasyonu.Odalar
{
    partial class Form_OdaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaGuncelle));
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.comboBox_gorevlisi = new System.Windows.Forms.ComboBox();
            this.carilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevlilerDataSet = new OtelOtomasyonu.GorevlilerDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox_esyalar = new System.Windows.Forms.CheckedListBox();
            this.maskedTextBox_yataksayisi = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.odaTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaTurleriDataSet = new OtelOtomasyonu.OdaTurleriDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_aciklama = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_katno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_odano = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_odaid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.odaTurleriTableAdapter = new OtelOtomasyonu.OdaTurleriDataSetTableAdapters.OdaTurleriTableAdapter();
            this.carilerTableAdapter = new OtelOtomasyonu.GorevlilerDataSetTableAdapters.CarilerTableAdapter();
            this.maskedTextBox_ucret = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_temizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_temizle.Location = new System.Drawing.Point(12, 561);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(129, 53);
            this.button_temizle.TabIndex = 30;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_guncelle.Image")));
            this.button_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle.Location = new System.Drawing.Point(272, 561);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(147, 53);
            this.button_guncelle.TabIndex = 29;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // comboBox_gorevlisi
            // 
            this.comboBox_gorevlisi.DataSource = this.carilerBindingSource;
            this.comboBox_gorevlisi.DisplayMember = "cari_ad";
            this.comboBox_gorevlisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gorevlisi.FormattingEnabled = true;
            this.comboBox_gorevlisi.Location = new System.Drawing.Point(195, 481);
            this.comboBox_gorevlisi.Name = "comboBox_gorevlisi";
            this.comboBox_gorevlisi.Size = new System.Drawing.Size(224, 32);
            this.comboBox_gorevlisi.TabIndex = 28;
            this.comboBox_gorevlisi.ValueMember = "cari_id";
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Oda Görevlisi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkedListBox_esyalar
            // 
            this.checkedListBox_esyalar.FormattingEnabled = true;
            this.checkedListBox_esyalar.Location = new System.Drawing.Point(195, 341);
            this.checkedListBox_esyalar.Name = "checkedListBox_esyalar";
            this.checkedListBox_esyalar.Size = new System.Drawing.Size(224, 124);
            this.checkedListBox_esyalar.TabIndex = 26;
            // 
            // maskedTextBox_yataksayisi
            // 
            this.maskedTextBox_yataksayisi.Location = new System.Drawing.Point(195, 304);
            this.maskedTextBox_yataksayisi.Mask = "000";
            this.maskedTextBox_yataksayisi.Name = "maskedTextBox_yataksayisi";
            this.maskedTextBox_yataksayisi.Size = new System.Drawing.Size(224, 29);
            this.maskedTextBox_yataksayisi.TabIndex = 25;
            this.maskedTextBox_yataksayisi.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Oda Yatak Sayısı:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Oda Eşyalar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.DataSource = this.odaTurleriBindingSource;
            this.comboBox_tur.DisplayMember = "tur_ad";
            this.comboBox_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Location = new System.Drawing.Point(195, 268);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(224, 32);
            this.comboBox_tur.TabIndex = 22;
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
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Oda Tür:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox_aciklama
            // 
            this.richTextBox_aciklama.Location = new System.Drawing.Point(195, 119);
            this.richTextBox_aciklama.Name = "richTextBox_aciklama";
            this.richTextBox_aciklama.Size = new System.Drawing.Size(224, 143);
            this.richTextBox_aciklama.TabIndex = 20;
            this.richTextBox_aciklama.Text = "";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Oda Açıklaması:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_katno
            // 
            this.maskedTextBox_katno.Location = new System.Drawing.Point(195, 82);
            this.maskedTextBox_katno.Mask = "000";
            this.maskedTextBox_katno.Name = "maskedTextBox_katno";
            this.maskedTextBox_katno.Size = new System.Drawing.Size(224, 29);
            this.maskedTextBox_katno.TabIndex = 18;
            this.maskedTextBox_katno.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Oda Kat:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_odano
            // 
            this.maskedTextBox_odano.Location = new System.Drawing.Point(195, 45);
            this.maskedTextBox_odano.Mask = "000";
            this.maskedTextBox_odano.Name = "maskedTextBox_odano";
            this.maskedTextBox_odano.Size = new System.Drawing.Size(224, 29);
            this.maskedTextBox_odano.TabIndex = 16;
            this.maskedTextBox_odano.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Oda No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_odaid
            // 
            this.label_odaid.Location = new System.Drawing.Point(195, 13);
            this.label_odaid.Name = "label_odaid";
            this.label_odaid.Size = new System.Drawing.Size(224, 23);
            this.label_odaid.TabIndex = 32;
            this.label_odaid.Text = "1";
            this.label_odaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(17, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "Oda ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // odaTurleriTableAdapter
            // 
            this.odaTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // carilerTableAdapter
            // 
            this.carilerTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox_ucret
            // 
            this.maskedTextBox_ucret.Location = new System.Drawing.Point(195, 517);
            this.maskedTextBox_ucret.Mask = "00000";
            this.maskedTextBox_ucret.Name = "maskedTextBox_ucret";
            this.maskedTextBox_ucret.Size = new System.Drawing.Size(224, 29);
            this.maskedTextBox_ucret.TabIndex = 34;
            this.maskedTextBox_ucret.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(13, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Oda Ücret:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_OdaGuncelle
            // 
            this.AcceptButton = this.button_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_temizle;
            this.ClientSize = new System.Drawing.Size(433, 626);
            this.Controls.Add(this.maskedTextBox_ucret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_odaid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_guncelle);
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
            this.Name = "Form_OdaGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTurleriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.ComboBox comboBox_gorevlisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBox_esyalar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_yataksayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_aciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_katno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_odano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_odaid;
        private System.Windows.Forms.Label label8;
        private OdaTurleriDataSet odaTurleriDataSet;
        private System.Windows.Forms.BindingSource odaTurleriBindingSource;
        private OdaTurleriDataSetTableAdapters.OdaTurleriTableAdapter odaTurleriTableAdapter;
        private GorevlilerDataSet gorevlilerDataSet;
        private System.Windows.Forms.BindingSource carilerBindingSource;
        private GorevlilerDataSetTableAdapters.CarilerTableAdapter carilerTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ucret;
        private System.Windows.Forms.Label label9;
    }
}