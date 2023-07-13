namespace OtelOtomasyonu.Cariler
{
    partial class Form_CarilerListesiRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CarilerListesiRaporu));
            this.carilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet = new OtelOtomasyonu.CarilerDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carilerTableAdapter = new OtelOtomasyonu.CarilerDataSetTableAdapters.CarilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // carilerBindingSource
            // 
            this.carilerBindingSource.DataMember = "Cariler";
            this.carilerBindingSource.DataSource = this.carilerDataSet;
            // 
            // carilerDataSet
            // 
            this.carilerDataSet.DataSetName = "CarilerDataSet";
            this.carilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_CarilerListesiRaporu";
            reportDataSource1.Value = this.carilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_CarilerListesiRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // carilerTableAdapter
            // 
            this.carilerTableAdapter.ClearBeforeFill = true;
            // 
            // Form_CarilerListesiRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CarilerListesiRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cariler Listesi Raporu Önizleme";
            this.Load += new System.EventHandler(this.Form_CarilerListesiRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CarilerDataSet carilerDataSet;
        private System.Windows.Forms.BindingSource carilerBindingSource;
        private CarilerDataSetTableAdapters.CarilerTableAdapter carilerTableAdapter;
    }
}