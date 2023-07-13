namespace OtelOtomasyonu.Cariler
{
    partial class Form_CariGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CariGuncelle));
            this.label_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.cariTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cariTurleriDataSet = new OtelOtomasyonu.CariTurleriDataSet();
            this.maskedTextBox_dogum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_tel = new System.Windows.Forms.MaskedTextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_temizle = new System.Windows.Forms.Button();
            this.cariTurleriTableAdapter = new OtelOtomasyonu.CariTurleriDataSetTableAdapters.CariTurleriTableAdapter();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.Location = new System.Drawing.Point(190, 13);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(224, 23);
            this.label_id.TabIndex = 38;
            this.label_id.Text = "1";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cari ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_guncelle
            // 
            this.button_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_guncelle.Image")));
            this.button_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle.Location = new System.Drawing.Point(265, 199);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(146, 53);
            this.button_guncelle.TabIndex = 36;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cari Tür:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Doğum Tarihi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Telefon Numarası:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.DataSource = this.cariTurleriBindingSource;
            this.comboBox_tur.DisplayMember = "tur_ad";
            this.comboBox_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Location = new System.Drawing.Point(190, 156);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(224, 30);
            this.comboBox_tur.TabIndex = 32;
            this.comboBox_tur.ValueMember = "tur_id";
            this.comboBox_tur.SelectedIndexChanged += new System.EventHandler(this.comboBox_tur_SelectedIndexChanged);
            // 
            // cariTurleriBindingSource
            // 
            this.cariTurleriBindingSource.DataMember = "CariTurleri";
            this.cariTurleriBindingSource.DataSource = this.cariTurleriDataSet;
            // 
            // cariTurleriDataSet
            // 
            this.cariTurleriDataSet.DataSetName = "CariTurleriDataSet";
            this.cariTurleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox_dogum
            // 
            this.maskedTextBox_dogum.Location = new System.Drawing.Point(190, 119);
            this.maskedTextBox_dogum.Mask = "00/00/0000";
            this.maskedTextBox_dogum.Name = "maskedTextBox_dogum";
            this.maskedTextBox_dogum.Size = new System.Drawing.Size(224, 31);
            this.maskedTextBox_dogum.TabIndex = 31;
            this.maskedTextBox_dogum.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_tel
            // 
            this.maskedTextBox_tel.Location = new System.Drawing.Point(190, 82);
            this.maskedTextBox_tel.Mask = "(999) 000-0000";
            this.maskedTextBox_tel.Name = "maskedTextBox_tel";
            this.maskedTextBox_tel.Size = new System.Drawing.Size(224, 31);
            this.maskedTextBox_tel.TabIndex = 30;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(190, 45);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(224, 31);
            this.textBox_ad.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cari Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_temizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_temizle.Location = new System.Drawing.Point(12, 199);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(129, 53);
            this.button_temizle.TabIndex = 39;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // cariTurleriTableAdapter
            // 
            this.cariTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(190, 192);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(224, 31);
            this.textBox_sifre.TabIndex = 33;
            this.textBox_sifre.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kullanıcı Şifresi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Visible = false;
            // 
            // Form_CariGuncelle
            // 
            this.AcceptButton = this.button_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_temizle;
            this.ClientSize = new System.Drawing.Size(423, 264);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_tur);
            this.Controls.Add(this.maskedTextBox_dogum);
            this.Controls.Add(this.maskedTextBox_tel);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_CariGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cari Güncelle";
            this.Load += new System.EventHandler(this.Form_CariGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTurleriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dogum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tel;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_temizle;
        private CariTurleriDataSet cariTurleriDataSet;
        private System.Windows.Forms.BindingSource cariTurleriBindingSource;
        private CariTurleriDataSetTableAdapters.CariTurleriTableAdapter cariTurleriTableAdapter;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Label label6;
    }
}