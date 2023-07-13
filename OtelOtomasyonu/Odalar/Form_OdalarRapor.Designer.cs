namespace OtelOtomasyonu.Odalar
{
    partial class Form_OdalarRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdalarRapor));
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new OtelOtomasyonu.OtelDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.odalarTableAdapter = new OtelOtomasyonu.OtelDataSetTableAdapters.OdalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "OtelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OtelDataSet";
            reportDataSource1.Value = this.odalarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_OdaListesi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // Form_OdalarRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_OdalarRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Listesi Raporu Önizleme";
            this.Load += new System.EventHandler(this.Form_OdalarRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private OtelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private OtelDataSetTableAdapters.OdalarTableAdapter odalarTableAdapter;
    }
}