namespace OtelOtomasyonu.Kafeterya
{
    partial class Form_UrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UrunEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.maskedTextBox_ucret = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_stok = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_kategori = new System.Windows.Forms.ComboBox();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.urunKategorileriDataSet = new OtelOtomasyonu.UrunKategorileriDataSet();
            this.urunKategorileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunKategorileriTableAdapter = new OtelOtomasyonu.UrunKategorileriDataSetTableAdapters.UrunKategorileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Ad:";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ad.Location = new System.Drawing.Point(170, 12);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(241, 31);
            this.textBox_ad.TabIndex = 1;
            // 
            // maskedTextBox_ucret
            // 
            this.maskedTextBox_ucret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_ucret.Location = new System.Drawing.Point(170, 49);
            this.maskedTextBox_ucret.Mask = "00000.00";
            this.maskedTextBox_ucret.Name = "maskedTextBox_ucret";
            this.maskedTextBox_ucret.Size = new System.Drawing.Size(241, 31);
            this.maskedTextBox_ucret.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Ücret:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Stok:";
            // 
            // maskedTextBox_stok
            // 
            this.maskedTextBox_stok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_stok.Location = new System.Drawing.Point(170, 86);
            this.maskedTextBox_stok.Mask = "000";
            this.maskedTextBox_stok.Name = "maskedTextBox_stok";
            this.maskedTextBox_stok.Size = new System.Drawing.Size(241, 31);
            this.maskedTextBox_stok.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Kategori:";
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_kategori.DataSource = this.urunKategorileriBindingSource;
            this.comboBox_kategori.DisplayMember = "kategori_ad";
            this.comboBox_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Location = new System.Drawing.Point(170, 123);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(241, 30);
            this.comboBox_kategori.TabIndex = 7;
            this.comboBox_kategori.ValueMember = "kategori_id";
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_temizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_temizle.Location = new System.Drawing.Point(12, 168);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(129, 53);
            this.button_temizle.TabIndex = 18;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(282, 168);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(129, 53);
            this.button_kaydet.TabIndex = 17;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
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
            // Form_UrunEkle
            // 
            this.AcceptButton = this.button_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_temizle;
            this.ClientSize = new System.Drawing.Size(423, 233);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_kaydet);
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
            this.Name = "Form_UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "5";
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKategorileriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ucret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_stok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_kategori;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_kaydet;
        private UrunKategorileriDataSet urunKategorileriDataSet;
        private System.Windows.Forms.BindingSource urunKategorileriBindingSource;
        private UrunKategorileriDataSetTableAdapters.UrunKategorileriTableAdapter urunKategorileriTableAdapter;
    }
}