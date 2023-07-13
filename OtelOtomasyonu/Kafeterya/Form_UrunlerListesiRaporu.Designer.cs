namespace OtelOtomasyonu.Kafeterya
{
    partial class Form_UrunlerListesiRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UrunlerListesiRaporu));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.urunlerDataSet = new OtelOtomasyonu.UrunlerDataSet();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new OtelOtomasyonu.UrunlerDataSetTableAdapters.UrunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_UrunlerListesiRaporu";
            reportDataSource1.Value = this.urunlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_UrunlerListesiRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // urunlerDataSet
            // 
            this.urunlerDataSet.DataSetName = "UrunlerDataSet";
            this.urunlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.urunlerDataSet;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // Form_UrunlerListesiRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_UrunlerListesiRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürünler Listesi Raporu Önizleme";
            this.Load += new System.EventHandler(this.Form_UrunlerListesiRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private UrunlerDataSet urunlerDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private UrunlerDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
    }
}