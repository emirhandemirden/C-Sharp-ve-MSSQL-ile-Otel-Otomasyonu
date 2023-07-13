namespace OtelOtomasyonu.Muhasebe
{
    partial class Form_MuhasebeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MuhasebeEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.comboBox_baslik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_tutar = new System.Windows.Forms.MaskedTextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tür:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Items.AddRange(new object[] {
            "Gelir",
            "Gider"});
            this.comboBox_tur.Location = new System.Drawing.Point(121, 12);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(235, 32);
            this.comboBox_tur.TabIndex = 1;
            this.comboBox_tur.SelectedIndexChanged += new System.EventHandler(this.comboBox_tur_SelectedIndexChanged);
            // 
            // comboBox_baslik
            // 
            this.comboBox_baslik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baslik.FormattingEnabled = true;
            this.comboBox_baslik.Location = new System.Drawing.Point(121, 48);
            this.comboBox_baslik.Name = "comboBox_baslik";
            this.comboBox_baslik.Size = new System.Drawing.Size(235, 32);
            this.comboBox_baslik.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlık:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tutar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_tutar
            // 
            this.maskedTextBox_tutar.Location = new System.Drawing.Point(121, 84);
            this.maskedTextBox_tutar.Mask = "00000.00";
            this.maskedTextBox_tutar.Name = "maskedTextBox_tutar";
            this.maskedTextBox_tutar.Size = new System.Drawing.Size(235, 29);
            this.maskedTextBox_tutar.TabIndex = 7;
            this.maskedTextBox_tutar.ValidatingType = typeof(int);
            // 
            // button_kaydet
            // 
            this.button_kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(119, 132);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(129, 53);
            this.button_kaydet.TabIndex = 8;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // Form_MuhasebeEkle
            // 
            this.AcceptButton = this.button_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 197);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.maskedTextBox_tutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_baslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_tur);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_MuhasebeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gelir / Gider Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.ComboBox comboBox_baslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tutar;
        private System.Windows.Forms.Button button_kaydet;
    }
}