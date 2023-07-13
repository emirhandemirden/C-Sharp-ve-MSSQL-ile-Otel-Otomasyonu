namespace OtelOtomasyonu.Muhasebe
{
    partial class Form_GunlukMuhasebeRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GunlukMuhasebeRaporu));
            this.gunlukMuhasebeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunlukMuhasebeDataSet = new OtelOtomasyonu.GunlukMuhasebeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gunlukMuhasebeTableAdapter = new OtelOtomasyonu.GunlukMuhasebeDataSetTableAdapters.GunlukMuhasebeTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Filtrele = new System.Windows.Forms.Button();
            this.textBox_Filtre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukMuhasebeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukMuhasebeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunlukMuhasebeBindingSource
            // 
            this.gunlukMuhasebeBindingSource.DataMember = "GunlukMuhasebe";
            this.gunlukMuhasebeBindingSource.DataSource = this.gunlukMuhasebeDataSet;
            // 
            // gunlukMuhasebeDataSet
            // 
            this.gunlukMuhasebeDataSet.DataSetName = "GunlukMuhasebeDataSet";
            this.gunlukMuhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_GunlukMuhasebeRaporu";
            reportDataSource1.Value = this.gunlukMuhasebeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelOtomasyonu.Raporlar.Report_GunlukMuhasebeRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // gunlukMuhasebeTableAdapter
            // 
            this.gunlukMuhasebeTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarih";
            // 
            // Button_Filtrele
            // 
            this.Button_Filtrele.Location = new System.Drawing.Point(283, 25);
            this.Button_Filtrele.Name = "Button_Filtrele";
            this.Button_Filtrele.Size = new System.Drawing.Size(92, 37);
            this.Button_Filtrele.TabIndex = 1;
            this.Button_Filtrele.Text = "Filtrele";
            this.Button_Filtrele.UseVisualStyleBackColor = true;
            this.Button_Filtrele.Click += new System.EventHandler(this.Button_Filtrele_Click);
            // 
            // textBox_Filtre
            // 
            this.textBox_Filtre.Location = new System.Drawing.Point(106, 30);
            this.textBox_Filtre.Name = "textBox_Filtre";
            this.textBox_Filtre.Size = new System.Drawing.Size(171, 26);
            this.textBox_Filtre.TabIndex = 0;
            // 
            // Form_GunlukMuhasebeRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GunlukMuhasebeRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günlük Muhasebe Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.gunlukMuhasebeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukMuhasebeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GunlukMuhasebeDataSet gunlukMuhasebeDataSet;
        private System.Windows.Forms.BindingSource gunlukMuhasebeBindingSource;
        private GunlukMuhasebeDataSetTableAdapters.GunlukMuhasebeTableAdapter gunlukMuhasebeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Filtrele;
        private System.Windows.Forms.TextBox textBox_Filtre;
    }
}