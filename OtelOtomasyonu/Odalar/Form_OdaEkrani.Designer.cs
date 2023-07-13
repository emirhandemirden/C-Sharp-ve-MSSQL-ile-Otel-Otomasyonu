namespace OtelOtomasyonu.Odalar
{
    partial class Form_OdaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaEkrani));
            this.toolStrip_islemler = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox_musteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label_musteriBilgileri = new System.Windows.Forms.Label();
            this.groupBox_siparisler = new System.Windows.Forms.GroupBox();
            this.listView_urunler = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip_islemler.SuspendLayout();
            this.groupBox_musteriBilgileri.SuspendLayout();
            this.groupBox_siparisler.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_islemler
            // 
            this.toolStrip_islemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_islemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip_islemler.Location = new System.Drawing.Point(0, 436);
            this.toolStrip_islemler.Name = "toolStrip_islemler";
            this.toolStrip_islemler.Size = new System.Drawing.Size(784, 25);
            this.toolStrip_islemler.TabIndex = 0;
            this.toolStrip_islemler.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(135, 22);
            this.toolStripButton3.Tag = "2";
            this.toolStripButton3.Text = "Kafeterya Siparişi Ver";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton4.Tag = "3";
            this.toolStripButton4.Text = "Sipariş İptal";
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // groupBox_musteriBilgileri
            // 
            this.groupBox_musteriBilgileri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_musteriBilgileri.Controls.Add(this.label_musteriBilgileri);
            this.groupBox_musteriBilgileri.Location = new System.Drawing.Point(12, 12);
            this.groupBox_musteriBilgileri.Name = "groupBox_musteriBilgileri";
            this.groupBox_musteriBilgileri.Size = new System.Drawing.Size(298, 413);
            this.groupBox_musteriBilgileri.TabIndex = 1;
            this.groupBox_musteriBilgileri.TabStop = false;
            this.groupBox_musteriBilgileri.Text = "Oda 1.1 Müşteri Bilgileri";
            // 
            // label_musteriBilgileri
            // 
            this.label_musteriBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_musteriBilgileri.Location = new System.Drawing.Point(3, 25);
            this.label_musteriBilgileri.Name = "label_musteriBilgileri";
            this.label_musteriBilgileri.Size = new System.Drawing.Size(292, 385);
            this.label_musteriBilgileri.TabIndex = 0;
            this.label_musteriBilgileri.Text = "label1";
            // 
            // groupBox_siparisler
            // 
            this.groupBox_siparisler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_siparisler.Controls.Add(this.listView_urunler);
            this.groupBox_siparisler.Location = new System.Drawing.Point(316, 12);
            this.groupBox_siparisler.Name = "groupBox_siparisler";
            this.groupBox_siparisler.Size = new System.Drawing.Size(458, 413);
            this.groupBox_siparisler.TabIndex = 2;
            this.groupBox_siparisler.TabStop = false;
            this.groupBox_siparisler.Text = "Kafeterya Siparişleri";
            // 
            // listView_urunler
            // 
            this.listView_urunler.CheckBoxes = true;
            this.listView_urunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_urunler.HideSelection = false;
            this.listView_urunler.Location = new System.Drawing.Point(3, 25);
            this.listView_urunler.Name = "listView_urunler";
            this.listView_urunler.Size = new System.Drawing.Size(452, 385);
            this.listView_urunler.TabIndex = 2;
            this.listView_urunler.UseCompatibleStateImageBehavior = false;
            this.listView_urunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 43;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet Tutarı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 135;
            // 
            // Form_OdaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox_siparisler);
            this.Controls.Add(this.groupBox_musteriBilgileri);
            this.Controls.Add(this.toolStrip_islemler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_OdaEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Paneli";
            this.toolStrip_islemler.ResumeLayout(false);
            this.toolStrip_islemler.PerformLayout();
            this.groupBox_musteriBilgileri.ResumeLayout(false);
            this.groupBox_siparisler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_islemler;
        private System.Windows.Forms.GroupBox groupBox_musteriBilgileri;
        private System.Windows.Forms.Label label_musteriBilgileri;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBox_siparisler;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ListView listView_urunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}