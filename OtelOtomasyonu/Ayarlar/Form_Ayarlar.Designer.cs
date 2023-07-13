namespace OtelOtomasyonu.Ayarlar
{
    partial class Form_Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ayarlar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_uygulamaAyarlari = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel_uygulamaayarlari = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel_uygulamaayarlari.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_uygulamaAyarlari});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_uygulamaAyarlari
            // 
            this.toolStripButton_uygulamaAyarlari.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_uygulamaAyarlari.Image")));
            this.toolStripButton_uygulamaAyarlari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_uygulamaAyarlari.Name = "toolStripButton_uygulamaAyarlari";
            this.toolStripButton_uygulamaAyarlari.Size = new System.Drawing.Size(124, 22);
            this.toolStripButton_uygulamaAyarlari.Text = "Uygulama Ayarları";
            this.toolStripButton_uygulamaAyarlari.Click += new System.EventHandler(this.ToolStripButtons_Click);
            // 
            // tableLayoutPanel_uygulamaayarlari
            // 
            this.tableLayoutPanel_uygulamaayarlari.ColumnCount = 2;
            this.tableLayoutPanel_uygulamaayarlari.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_uygulamaayarlari.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_uygulamaayarlari.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel_uygulamaayarlari.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_uygulamaayarlari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_uygulamaayarlari.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel_uygulamaayarlari.Name = "tableLayoutPanel_uygulamaayarlari";
            this.tableLayoutPanel_uygulamaayarlari.RowCount = 1;
            this.tableLayoutPanel_uygulamaayarlari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_uygulamaayarlari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_uygulamaayarlari.Size = new System.Drawing.Size(784, 436);
            this.tableLayoutPanel_uygulamaayarlari.TabIndex = 1;
            this.tableLayoutPanel_uygulamaayarlari.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(395, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 430);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Renk Teması Ayarları";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 430);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dil Ayarları";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yakında";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yakında";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel_uygulamaayarlari);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel_uygulamaayarlari.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_uygulamaAyarlari;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_uygulamaayarlari;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}