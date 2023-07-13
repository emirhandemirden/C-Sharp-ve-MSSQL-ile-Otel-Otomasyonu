namespace OtelOtomasyonu.Odalar
{
    partial class Form_OdaKayitSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaKayitSil));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_oda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ucret2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker_cikis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_giris = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_musteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_sil);
            this.groupBox2.Controls.Add(this.label_id);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox_oda);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_ucret2);
            this.groupBox2.Controls.Add(this.dateTimePicker_cikis);
            this.groupBox2.Controls.Add(this.dateTimePicker_giris);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_musteri);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 324);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Bilgileri";
            // 
            // button_sil
            // 
            this.button_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sil.Image = ((System.Drawing.Image)(resources.GetObject("button_sil.Image")));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(230, 258);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(86, 53);
            this.button_sil.TabIndex = 27;
            this.button_sil.Text = "Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(207, 33);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 22);
            this.label_id.TabIndex = 22;
            this.label_id.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kayıt ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Oda:";
            // 
            // comboBox_oda
            // 
            this.comboBox_oda.DisplayMember = "cari_ad";
            this.comboBox_oda.Enabled = false;
            this.comboBox_oda.FormattingEnabled = true;
            this.comboBox_oda.Location = new System.Drawing.Point(207, 70);
            this.comboBox_oda.Name = "comboBox_oda";
            this.comboBox_oda.Size = new System.Drawing.Size(320, 30);
            this.comboBox_oda.TabIndex = 19;
            this.comboBox_oda.ValueMember = "cari_id";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "1 Günlük Ücret:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ucret2
            // 
            this.textBox_ucret2.Enabled = false;
            this.textBox_ucret2.Location = new System.Drawing.Point(207, 142);
            this.textBox_ucret2.Name = "textBox_ucret2";
            this.textBox_ucret2.Size = new System.Drawing.Size(320, 31);
            this.textBox_ucret2.TabIndex = 17;
            // 
            // dateTimePicker_cikis
            // 
            this.dateTimePicker_cikis.Enabled = false;
            this.dateTimePicker_cikis.Location = new System.Drawing.Point(207, 216);
            this.dateTimePicker_cikis.Name = "dateTimePicker_cikis";
            this.dateTimePicker_cikis.Size = new System.Drawing.Size(320, 31);
            this.dateTimePicker_cikis.TabIndex = 16;
            // 
            // dateTimePicker_giris
            // 
            this.dateTimePicker_giris.Enabled = false;
            this.dateTimePicker_giris.Location = new System.Drawing.Point(207, 179);
            this.dateTimePicker_giris.Name = "dateTimePicker_giris";
            this.dateTimePicker_giris.Size = new System.Drawing.Size(320, 31);
            this.dateTimePicker_giris.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Çıkış Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // comboBox_musteri
            // 
            this.comboBox_musteri.DisplayMember = "cari_ad";
            this.comboBox_musteri.Enabled = false;
            this.comboBox_musteri.FormattingEnabled = true;
            this.comboBox_musteri.Location = new System.Drawing.Point(207, 106);
            this.comboBox_musteri.Name = "comboBox_musteri";
            this.comboBox_musteri.Size = new System.Drawing.Size(320, 30);
            this.comboBox_musteri.TabIndex = 1;
            this.comboBox_musteri.ValueMember = "cari_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri:";
            // 
            // Form_OdaKayitSil
            // 
            this.AcceptButton = this.button_sil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 351);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_OdaKayitSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Kaydı Sil";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ucret2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cikis;
        private System.Windows.Forms.DateTimePicker dateTimePicker_giris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_musteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_oda;
        private System.Windows.Forms.Button button_sil;
    }
}