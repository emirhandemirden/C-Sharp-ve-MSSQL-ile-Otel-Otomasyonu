namespace OtelOtomasyonu.Cariler
{
    partial class Form_CariSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CariSil));
            this.button_sil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_dogum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_tel = new System.Windows.Forms.MaskedTextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sil
            // 
            this.button_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sil.Image = ((System.Drawing.Image)(resources.GetObject("button_sil.Image")));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(168, 199);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(86, 53);
            this.button_sil.TabIndex = 25;
            this.button_sil.Text = "Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(8, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cari Tür";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Doğum Tarihi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Telefon Numarası:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_tur.Enabled = false;
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Location = new System.Drawing.Point(190, 156);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(224, 30);
            this.comboBox_tur.TabIndex = 21;
            // 
            // maskedTextBox_dogum
            // 
            this.maskedTextBox_dogum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox_dogum.Enabled = false;
            this.maskedTextBox_dogum.Location = new System.Drawing.Point(190, 119);
            this.maskedTextBox_dogum.Mask = "00/00/0000";
            this.maskedTextBox_dogum.Name = "maskedTextBox_dogum";
            this.maskedTextBox_dogum.Size = new System.Drawing.Size(224, 31);
            this.maskedTextBox_dogum.TabIndex = 20;
            this.maskedTextBox_dogum.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_tel
            // 
            this.maskedTextBox_tel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox_tel.Enabled = false;
            this.maskedTextBox_tel.Location = new System.Drawing.Point(190, 82);
            this.maskedTextBox_tel.Mask = "(999) 000-0000";
            this.maskedTextBox_tel.Name = "maskedTextBox_tel";
            this.maskedTextBox_tel.Size = new System.Drawing.Size(224, 31);
            this.maskedTextBox_tel.TabIndex = 19;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_ad.Enabled = false;
            this.textBox_ad.Location = new System.Drawing.Point(190, 45);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(224, 31);
            this.textBox_ad.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cari Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cari ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id
            // 
            this.label_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_id.Location = new System.Drawing.Point(190, 13);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(224, 23);
            this.label_id.TabIndex = 27;
            this.label_id.Text = "1";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_CariSil
            // 
            this.AcceptButton = this.button_sil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 264);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_tur);
            this.Controls.Add(this.maskedTextBox_dogum);
            this.Controls.Add(this.maskedTextBox_tel);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_CariSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cari Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dogum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tel;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_id;
    }
}