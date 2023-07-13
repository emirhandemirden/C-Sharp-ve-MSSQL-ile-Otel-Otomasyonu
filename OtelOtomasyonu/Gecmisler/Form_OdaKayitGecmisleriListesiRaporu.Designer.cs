namespace OtelOtomasyonu.Gecmisler
{
    partial class Form_OdaKayitGecmisleriListesiRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaKayitGecmisleriListesiRaporu));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.odaIslemGecmisleriDataSet = new OtelOtomasyonu.OdaIslemGecmisleriDataSet();
            this.odaIslemGecmisleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaIslemGecmisleriTableAdapter = new OtelOtomasyonu.OdaIslemGecmisleriDataSetTableAdapters.OdaIslemGecmisleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.odaIslemGecmisleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaIslemGecmisleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_OdaKayitGecmisleriListesiRaporu";
            reportDataSource1.Value = this.odaIslemGecmisleriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_OdaKayitGecmisleriListesiRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // odaIslemGecmisleriDataSet
            // 
            this.odaIslemGecmisleriDataSet.DataSetName = "OdaIslemGecmisleriDataSet";
            this.odaIslemGecmisleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odaIslemGecmisleriBindingSource
            // 
            this.odaIslemGecmisleriBindingSource.DataMember = "OdaIslemGecmisleri";
            this.odaIslemGecmisleriBindingSource.DataSource = this.odaIslemGecmisleriDataSet;
            // 
            // odaIslemGecmisleriTableAdapter
            // 
            this.odaIslemGecmisleriTableAdapter.ClearBeforeFill = true;
            // 
            // Form_OdaKayıtGecmisleriListesiRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_OdaKayıtGecmisleriListesiRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Kayıt Geçmişleri Listesi Raporu";
            this.Load += new System.EventHandler(this.Form_OdaKayıtGecmisleriListesiRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odaIslemGecmisleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaIslemGecmisleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private OdaIslemGecmisleriDataSet odaIslemGecmisleriDataSet;
        private System.Windows.Forms.BindingSource odaIslemGecmisleriBindingSource;
        private OdaIslemGecmisleriDataSetTableAdapters.OdaIslemGecmisleriTableAdapter odaIslemGecmisleriTableAdapter;
    }
}