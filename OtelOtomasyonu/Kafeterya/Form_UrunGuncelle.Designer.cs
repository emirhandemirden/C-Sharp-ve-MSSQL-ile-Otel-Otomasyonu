namespace OtelOtomasyonu.Kafeterya
{
    partial class Form_UrunGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UrunGuncelle));
            this.label6 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.comboBox_kategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_stok = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_ucret = new System.Windows.Forms.MaskedTextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_ekstok = new System.Windows.Forms.MaskedTextBox();
            this.urunKategorileriDataSet = new OtelOtomasyonu.UrunKategorileriDataSet();
            this.urunKategorileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunKategorileriTableAdapter = new OtelOtomasyonu.UrunKategorileriDataSetTableAdapters.UrunKategorileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ürün ID:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(170, 10);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 22);
            this.label_id.TabIndex = 41;
            this.label_id.Text = "1";
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_temizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_temizle.Location = new System.Drawing.Point(12, 238);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(129, 53);
            this.button_temizle.TabIndex = 40;
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
            this.button_guncelle.Location = new System.Drawing.Point(264, 238);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(147, 53);
            this.button_guncelle.TabIndex = 39;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_kategori.DataSource = this.urunKategorileriBindingSource;
            this.comboBox_kategori.DisplayMember = "kategori_ad";
            this.comboBox_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Location = new System.Drawing.Point(170, 193);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(241, 30);
            this.comboBox_kategori.TabIndex = 38;
            this.comboBox_kategori.ValueMember = "kategori_id";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ürün Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ürün Stok:";
            // 
            // maskedTextBox_stok
            // 
            this.maskedTextBox_stok.Enabled = false;
            this.maskedTextBox_stok.Location = new System.Drawing.Point(170, 119);
            this.maskedTextBox_stok.Mask = "000";
            this.maskedTextBox_stok.Name = "maskedTextBox_stok";
            this.maskedTextBox_stok.Size = new System.Drawing.Size(241, 31);
            this.maskedTextBox_stok.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ürün Ücret:";
            // 
            // maskedTextBox_ucret
            // 
            this.maskedTextBox_ucret.Location = new System.Drawing.Point(170, 82);
            this.maskedTextBox_ucret.Mask = "00000.00";
            this.maskedTextBox_ucret.Name = "maskedTextBox_ucret";
            this.maskedTextBox_ucret.Size = new System.Drawing.Size(241, 31);
            this.maskedTextBox_ucret.TabIndex = 33;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(170, 45);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(241, 31);
            this.textBox_ad.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ürün Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Eklenecek Stok:";
            // 
            // maskedTextBox_ekstok
            // 
            this.maskedTextBox_ekstok.Location = new System.Drawing.Point(170, 156);
            this.maskedTextBox_ekstok.Mask = "000";
            this.maskedTextBox_ekstok.Name = "maskedTextBox_ekstok";
            this.maskedTextBox_ekstok.Size = new System.Drawing.Size(241, 31);
            this.maskedTextBox_ekstok.TabIndex = 43;
            // 
            // urunKategorileriDataSet
            // 
            this.urunKategorileriDataSet.DataSetName = "UrunKategorileriDataSet";
            this.urunKategorileriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunKategorileriBindingSource
            // 
            this.urunKategorileriBindingSource.DataMember = "UrunKategorileri";
            this.urunKategorileriBindingSource.DataSource = this.urunKategorileriDataSet;
            // 
            // urunKategorileriTableAdapter
            // 
            this.urunKategorileriTableAdapter.ClearBeforeFill = true;
            // 
            // Form_UrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 302);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_ekstok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.comboBox_kategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox_stok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox_ucret);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_UrunGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.ComboBox comboBox_kategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_stok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ucret;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ekstok;
        private UrunKategorileriDataSet urunKategorileriDataSet;
        private System.Windows.Forms.BindingSource urunKategorileriBindingSource;
        private UrunKategorileriDataSetTableAdapters.UrunKategorileriTableAdapter urunKategorileriTableAdapter;
    }
}