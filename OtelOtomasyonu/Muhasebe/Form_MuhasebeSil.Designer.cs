namespace OtelOtomasyonu.Muhasebe
{
    partial class Form_MuhasebeSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MuhasebeSil));
            this.maskedTextBox_tutar = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_baslik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.button_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox_tutar
            // 
            this.maskedTextBox_tutar.Enabled = false;
            this.maskedTextBox_tutar.Location = new System.Drawing.Point(121, 119);
            this.maskedTextBox_tutar.Mask = "000.00";
            this.maskedTextBox_tutar.Name = "maskedTextBox_tutar";
            this.maskedTextBox_tutar.Size = new System.Drawing.Size(235, 31);
            this.maskedTextBox_tutar.TabIndex = 14;
            this.maskedTextBox_tutar.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tutar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_baslik
            // 
            this.comboBox_baslik.Enabled = false;
            this.comboBox_baslik.FormattingEnabled = true;
            this.comboBox_baslik.Location = new System.Drawing.Point(121, 83);
            this.comboBox_baslik.Name = "comboBox_baslik";
            this.comboBox_baslik.Size = new System.Drawing.Size(235, 30);
            this.comboBox_baslik.TabIndex = 11;
            this.comboBox_baslik.Text = "Tür seçiniz..";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Başlık:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.Enabled = false;
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Items.AddRange(new object[] {
            "Gelir",
            "Gider"});
            this.comboBox_tur.Location = new System.Drawing.Point(121, 47);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(235, 30);
            this.comboBox_tur.TabIndex = 9;
            this.comboBox_tur.Text = "Gelir";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tür:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tür:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id
            // 
            this.label_id.Location = new System.Drawing.Point(121, 14);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(235, 23);
            this.label_id.TabIndex = 17;
            this.label_id.Text = "1";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_sil
            // 
            this.button_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sil.Image = ((System.Drawing.Image)(resources.GetObject("button_sil.Image")));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(141, 164);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(86, 53);
            this.button_sil.TabIndex = 27;
            this.button_sil.Text = "Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // Form_MuhasebeSil
            // 
            this.AcceptButton = this.button_sil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 229);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox_tutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_baslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_tur);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_MuhasebeSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gelir / Gider Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_baslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_sil;
    }
}