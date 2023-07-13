namespace OtelOtomasyonu.Muhasebe
{
    partial class Form_GenelMuhasebeRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GenelMuhasebeRaporu));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.muhasebeIslemleriDataSet = new OtelOtomasyonu.MuhasebeIslemleriDataSet();
            this.muhasebeIslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeIslemleriTableAdapter = new OtelOtomasyonu.MuhasebeIslemleriDataSetTableAdapters.MuhasebeIslemleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeIslemleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeIslemleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_GenelMuhasebeRaporu";
            reportDataSource1.Value = this.muhasebeIslemleriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_GenelMuhasebeRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // muhasebeIslemleriDataSet
            // 
            this.muhasebeIslemleriDataSet.DataSetName = "MuhasebeIslemleriDataSet";
            this.muhasebeIslemleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muhasebeIslemleriBindingSource
            // 
            this.muhasebeIslemleriBindingSource.DataMember = "MuhasebeIslemleri";
            this.muhasebeIslemleriBindingSource.DataSource = this.muhasebeIslemleriDataSet;
            // 
            // muhasebeIslemleriTableAdapter
            // 
            this.muhasebeIslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // Form_GeneMuhasebeRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GeneMuhasebeRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genel Muhasebe Raporu";
            this.Load += new System.EventHandler(this.Form_GeneMuhasebeRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeIslemleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeIslemleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MuhasebeIslemleriDataSet muhasebeIslemleriDataSet;
        private System.Windows.Forms.BindingSource muhasebeIslemleriBindingSource;
        private MuhasebeIslemleriDataSetTableAdapters.MuhasebeIslemleriTableAdapter muhasebeIslemleriTableAdapter;
    }
}