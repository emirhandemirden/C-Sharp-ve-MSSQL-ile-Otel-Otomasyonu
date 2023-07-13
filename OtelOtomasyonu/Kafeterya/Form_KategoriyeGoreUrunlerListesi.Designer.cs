namespace OtelOtomasyonu.Kafeterya
{
    partial class Form_KategoriyeGoreUrunlerListesi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KategoriyeGoreUrunlerListesi));
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerDataSet = new OtelOtomasyonu.UrunlerDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.urunlerTableAdapter = new OtelOtomasyonu.UrunlerDataSetTableAdapters.UrunlerTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Filtre = new System.Windows.Forms.TextBox();
            this.Button_Filtrele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.urunlerDataSet;
            // 
            // urunlerDataSet
            // 
            this.urunlerDataSet.DataSetName = "UrunlerDataSet";
            this.urunlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_KtegoriyeGoreUrunlerListesiRaporu";
            reportDataSource1.Value = this.urunlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_KategoriyeGoreUrunlerListesiRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Button_Filtrele);
            this.groupBox1.Controls.Add(this.textBox_Filtre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(556, 573);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme";
            // 
            // textBox_Filtre
            // 
            this.textBox_Filtre.Location = new System.Drawing.Point(118, 30);
            this.textBox_Filtre.Name = "textBox_Filtre";
            this.textBox_Filtre.Size = new System.Drawing.Size(171, 26);
            this.textBox_Filtre.TabIndex = 0;
            // 
            // Button_Filtrele
            // 
            this.Button_Filtrele.Location = new System.Drawing.Point(295, 25);
            this.Button_Filtrele.Name = "Button_Filtrele";
            this.Button_Filtrele.Size = new System.Drawing.Size(92, 37);
            this.Button_Filtrele.TabIndex = 1;
            this.Button_Filtrele.Text = "Filtrele";
            this.Button_Filtrele.UseVisualStyleBackColor = true;
            this.Button_Filtrele.Click += new System.EventHandler(this.Button_Filtrele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori:";
            // 
            // Form_KategoriyeGoreUrunlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_KategoriyeGoreUrunlerListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategoriye Göre Ürünler Listesi Raporu Önizleme";
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private UrunlerDataSet urunlerDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private UrunlerDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Filtrele;
        private System.Windows.Forms.TextBox textBox_Filtre;
    }
}