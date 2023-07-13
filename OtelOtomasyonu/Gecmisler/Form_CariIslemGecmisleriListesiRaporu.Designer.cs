namespace OtelOtomasyonu.Gecmisler
{
    partial class Form_CariIslemGecmisleriListesiRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CariIslemGecmisleriListesiRaporu));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cariGecmisleriDataSet = new OtelOtomasyonu.CariGecmisleriDataSet();
            this.cariGecmisleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cariGecmisleriTableAdapter = new OtelOtomasyonu.CariGecmisleriDataSetTableAdapters.CariGecmisleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cariGecmisleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariGecmisleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_CariIslemGecmisleriListesiRaporu";
            reportDataSource1.Value = this.cariGecmisleriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_CariIslemGecmisleriListesiRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // cariGecmisleriDataSet
            // 
            this.cariGecmisleriDataSet.DataSetName = "CariGecmisleriDataSet";
            this.cariGecmisleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cariGecmisleriBindingSource
            // 
            this.cariGecmisleriBindingSource.DataMember = "CariGecmisleri";
            this.cariGecmisleriBindingSource.DataSource = this.cariGecmisleriDataSet;
            // 
            // cariGecmisleriTableAdapter
            // 
            this.cariGecmisleriTableAdapter.ClearBeforeFill = true;
            // 
            // Form_CariIslemGecmisleriListesiRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CariIslemGecmisleriListesiRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cari İşlem Geçmişleri Listesi Raporu Önizleme";
            this.Load += new System.EventHandler(this.Form_CariIslemGecmisleriListesiRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cariGecmisleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariGecmisleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CariGecmisleriDataSet cariGecmisleriDataSet;
        private System.Windows.Forms.BindingSource cariGecmisleriBindingSource;
        private CariGecmisleriDataSetTableAdapters.CariGecmisleriTableAdapter cariGecmisleriTableAdapter;
    }
}