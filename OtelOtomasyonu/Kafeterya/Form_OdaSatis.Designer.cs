namespace OtelOtomasyonu.Kafeterya
{
    partial class Form_OdaSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaSatis));
            this.button_iptal = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_urunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_iptal
            // 
            this.button_iptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_iptal.Image = ((System.Drawing.Image)(resources.GetObject("button_iptal.Image")));
            this.button_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_iptal.Location = new System.Drawing.Point(15, 400);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(107, 53);
            this.button_iptal.TabIndex = 21;
            this.button_iptal.Text = "İptal";
            this.button_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ekle.Image = ((System.Drawing.Image)(resources.GetObject("button_ekle.Image")));
            this.button_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ekle.Location = new System.Drawing.Point(155, 400);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(231, 53);
            this.button_ekle.TabIndex = 20;
            this.button_ekle.Text = "Ekle ve Ödemeyi Al";
            this.button_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_urunler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 376);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kafeterya";
            // 
            // listView_urunler
            // 
            this.listView_urunler.CheckBoxes = true;
            this.listView_urunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_urunler.HideSelection = false;
            this.listView_urunler.Location = new System.Drawing.Point(3, 25);
            this.listView_urunler.Name = "listView_urunler";
            this.listView_urunler.Size = new System.Drawing.Size(370, 348);
            this.listView_urunler.TabIndex = 1;
            this.listView_urunler.UseCompatibleStateImageBehavior = false;
            this.listView_urunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet Tutarı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // Form_OdaSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 465);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_OdaSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_KafeteryaSatis1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_urunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}