namespace OtelOtomasyonu.Odalar
{
    partial class Form_OdaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaKayıt));
            this.groupBox_odaBilgileri = new System.Windows.Forms.GroupBox();
            this.label_odaAciklama = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_oda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ucret2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker_cikis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_giris = new System.Windows.Forms.DateTimePicker();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ucret = new System.Windows.Forms.TextBox();
            this.comboBox_musteri = new System.Windows.Forms.ComboBox();
            this.carilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerDataSet = new OtelOtomasyonu.MusterilerDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.carilerTableAdapter = new OtelOtomasyonu.MusterilerDataSetTableAdapters.CarilerTableAdapter();
            this.odalarDataSet = new OtelOtomasyonu.OdalarDataSet();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odalarTableAdapter = new OtelOtomasyonu.OdalarDataSetTableAdapters.OdalarTableAdapter();
            this.groupBox_odaBilgileri.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_odaBilgileri
            // 
            this.groupBox_odaBilgileri.Controls.Add(this.label_odaAciklama);
            this.groupBox_odaBilgileri.Location = new System.Drawing.Point(12, 12);
            this.groupBox_odaBilgileri.Name = "groupBox_odaBilgileri";
            this.groupBox_odaBilgileri.Size = new System.Drawing.Size(543, 163);
            this.groupBox_odaBilgileri.TabIndex = 0;
            this.groupBox_odaBilgileri.TabStop = false;
            this.groupBox_odaBilgileri.Text = "Oda Bilgileri";
            // 
            // label_odaAciklama
            // 
            this.label_odaAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_odaAciklama.Location = new System.Drawing.Point(3, 25);
            this.label_odaAciklama.Name = "label_odaAciklama";
            this.label_odaAciklama.Size = new System.Drawing.Size(537, 135);
            this.label_odaAciklama.TabIndex = 0;
            this.label_odaAciklama.Text = "Bir oda seçimi yapınız.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_oda);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_ucret2);
            this.groupBox2.Controls.Add(this.dateTimePicker_cikis);
            this.groupBox2.Controls.Add(this.dateTimePicker_giris);
            this.groupBox2.Controls.Add(this.button_kaydet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_ucret);
            this.groupBox2.Controls.Add(this.comboBox_musteri);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 322);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Bilgileri";
            // 
            // comboBox_oda
            // 
            this.comboBox_oda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_oda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_oda.FormattingEnabled = true;
            this.comboBox_oda.Location = new System.Drawing.Point(207, 36);
            this.comboBox_oda.Name = "comboBox_oda";
            this.comboBox_oda.Size = new System.Drawing.Size(320, 32);
            this.comboBox_oda.TabIndex = 20;
            this.comboBox_oda.SelectedIndexChanged += new System.EventHandler(this.comboBox_oda_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Oda:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.Location = new System.Drawing.Point(13, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "1 Günlük Ücret:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ucret2
            // 
            this.textBox_ucret2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_ucret2.Enabled = false;
            this.textBox_ucret2.Location = new System.Drawing.Point(207, 145);
            this.textBox_ucret2.Name = "textBox_ucret2";
            this.textBox_ucret2.Size = new System.Drawing.Size(320, 29);
            this.textBox_ucret2.TabIndex = 17;
            // 
            // dateTimePicker_cikis
            // 
            this.dateTimePicker_cikis.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker_cikis.Location = new System.Drawing.Point(207, 219);
            this.dateTimePicker_cikis.Name = "dateTimePicker_cikis";
            this.dateTimePicker_cikis.Size = new System.Drawing.Size(320, 29);
            this.dateTimePicker_cikis.TabIndex = 16;
            // 
            // dateTimePicker_giris
            // 
            this.dateTimePicker_giris.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker_giris.Location = new System.Drawing.Point(207, 182);
            this.dateTimePicker_giris.Name = "dateTimePicker_giris";
            this.dateTimePicker_giris.Size = new System.Drawing.Size(320, 29);
            this.dateTimePicker_giris.TabIndex = 15;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(207, 256);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(129, 53);
            this.button_kaydet.TabIndex = 14;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Çıkış Tarihi:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "1 Günlük Ücret:";
            // 
            // textBox_ucret
            // 
            this.textBox_ucret.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_ucret.Enabled = false;
            this.textBox_ucret.Location = new System.Drawing.Point(207, 108);
            this.textBox_ucret.Name = "textBox_ucret";
            this.textBox_ucret.Size = new System.Drawing.Size(320, 29);
            this.textBox_ucret.TabIndex = 2;
            // 
            // comboBox_musteri
            // 
            this.comboBox_musteri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_musteri.DataSource = this.carilerBindingSource;
            this.comboBox_musteri.DisplayMember = "cari_ad";
            this.comboBox_musteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_musteri.FormattingEnabled = true;
            this.comboBox_musteri.Location = new System.Drawing.Point(207, 72);
            this.comboBox_musteri.Name = "comboBox_musteri";
            this.comboBox_musteri.Size = new System.Drawing.Size(320, 32);
            this.comboBox_musteri.TabIndex = 1;
            this.comboBox_musteri.ValueMember = "cari_id";
            // 
            // carilerBindingSource
            // 
            this.carilerBindingSource.DataMember = "Cariler";
            this.carilerBindingSource.DataSource = this.musterilerDataSet;
            // 
            // musterilerDataSet
            // 
            this.musterilerDataSet.DataSetName = "MusterilerDataSet";
            this.musterilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri:";
            // 
            // carilerTableAdapter
            // 
            this.carilerTableAdapter.ClearBeforeFill = true;
            // 
            // odalarDataSet
            // 
            this.odalarDataSet.DataSetName = "OdalarDataSet";
            this.odalarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.odalarDataSet;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // Form_OdaKayıt
            // 
            this.AcceptButton = this.button_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_odaBilgileri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "Form_OdaKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Kayıt";
            this.groupBox_odaBilgileri.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_odaBilgileri;
        private System.Windows.Forms.Label label_odaAciklama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ucret;
        private System.Windows.Forms.ComboBox comboBox_musteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cikis;
        private System.Windows.Forms.DateTimePicker dateTimePicker_giris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ucret2;
        private MusterilerDataSet musterilerDataSet;
        private System.Windows.Forms.BindingSource carilerBindingSource;
        private MusterilerDataSetTableAdapters.CarilerTableAdapter carilerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_oda;
        private System.Windows.Forms.Label label6;
        private OdalarDataSet odalarDataSet;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private OdalarDataSetTableAdapters.OdalarTableAdapter odalarTableAdapter;
    }
}