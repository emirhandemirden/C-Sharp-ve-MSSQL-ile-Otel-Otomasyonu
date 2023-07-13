namespace OtelOtomasyonu.Gecmisler
{
    partial class Form_PersonelIslemGecmisleriListesiRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PersonelIslemGecmisleriListesiRaporu));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personelIslemGecmisleriDataSet = new OtelOtomasyonu.PersonelIslemGecmisleriDataSet();
            this.personelIslemGecmisleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelIslemGecmisleriTableAdapter = new OtelOtomasyonu.PersonelIslemGecmisleriDataSetTableAdapters.PersonelIslemGecmisleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personelIslemGecmisleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelIslemGecmisleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_PersonelIslemGecmisleriListesiRaporu";
            reportDataSource1.Value = this.personelIslemGecmisleriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_PersonelIslemGecmisleriListesiRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // personelIslemGecmisleriDataSet
            // 
            this.personelIslemGecmisleriDataSet.DataSetName = "PersonelIslemGecmisleriDataSet";
            this.personelIslemGecmisleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelIslemGecmisleriBindingSource
            // 
            this.personelIslemGecmisleriBindingSource.DataMember = "PersonelIslemGecmisleri";
            this.personelIslemGecmisleriBindingSource.DataSource = this.personelIslemGecmisleriDataSet;
            // 
            // personelIslemGecmisleriTableAdapter
            // 
            this.personelIslemGecmisleriTableAdapter.ClearBeforeFill = true;
            // 
            // Form_PersonelIslemGecmisleriListesiRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PersonelIslemGecmisleriListesiRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel İşlem Geçmişleri Listesi Raporu Önizleme";
            this.Load += new System.EventHandler(this.Form_PersonelIslemGecmisleriListesiRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelIslemGecmisleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelIslemGecmisleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PersonelIslemGecmisleriDataSet personelIslemGecmisleriDataSet;
        private System.Windows.Forms.BindingSource personelIslemGecmisleriBindingSource;
        private PersonelIslemGecmisleriDataSetTableAdapters.PersonelIslemGecmisleriTableAdapter personelIslemGecmisleriTableAdapter;
    }
}