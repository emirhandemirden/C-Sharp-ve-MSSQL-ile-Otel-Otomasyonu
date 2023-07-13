namespace OtelOtomasyonu.Tanimlamalar
{
    partial class Form_TanimlamaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TanimlamaGuncelle));
            this.textBox_icerik = new System.Windows.Forms.TextBox();
            this.label_icerik = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.comboBox_muhasebeTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_yetkiler = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox_yetkiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_icerik
            // 
            this.textBox_icerik.Location = new System.Drawing.Point(92, 41);
            this.textBox_icerik.Name = "textBox_icerik";
            this.textBox_icerik.Size = new System.Drawing.Size(205, 31);
            this.textBox_icerik.TabIndex = 1;
            // 
            // label_icerik
            // 
            this.label_icerik.Location = new System.Drawing.Point(12, 42);
            this.label_icerik.Name = "label_icerik";
            this.label_icerik.Size = new System.Drawing.Size(70, 27);
            this.label_icerik.TabIndex = 29;
            this.label_icerik.Text = "Tür:";
            this.label_icerik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id
            // 
            this.label_id.Location = new System.Drawing.Point(92, 9);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(205, 27);
            this.label_id.TabIndex = 28;
            this.label_id.Text = "1";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_guncelle
            // 
            this.button_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_guncelle.Image")));
            this.button_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle.Location = new System.Drawing.Point(83, 81);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(145, 53);
            this.button_guncelle.TabIndex = 7;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // comboBox_muhasebeTur
            // 
            this.comboBox_muhasebeTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_muhasebeTur.FormattingEnabled = true;
            this.comboBox_muhasebeTur.Items.AddRange(new object[] {
            "Gelir",
            "Gider"});
            this.comboBox_muhasebeTur.Location = new System.Drawing.Point(91, 78);
            this.comboBox_muhasebeTur.Name = "comboBox_muhasebeTur";
            this.comboBox_muhasebeTur.Size = new System.Drawing.Size(206, 30);
            this.comboBox_muhasebeTur.TabIndex = 2;
            this.comboBox_muhasebeTur.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tür:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // groupBox_yetkiler
            // 
            this.groupBox_yetkiler.Controls.Add(this.checkBox8);
            this.groupBox_yetkiler.Controls.Add(this.checkBox7);
            this.groupBox_yetkiler.Controls.Add(this.checkBox6);
            this.groupBox_yetkiler.Controls.Add(this.checkBox5);
            this.groupBox_yetkiler.Controls.Add(this.checkBox4);
            this.groupBox_yetkiler.Controls.Add(this.checkBox3);
            this.groupBox_yetkiler.Controls.Add(this.checkBox2);
            this.groupBox_yetkiler.Controls.Add(this.checkBox1);
            this.groupBox_yetkiler.Location = new System.Drawing.Point(12, 78);
            this.groupBox_yetkiler.Name = "groupBox_yetkiler";
            this.groupBox_yetkiler.Size = new System.Drawing.Size(286, 287);
            this.groupBox_yetkiler.TabIndex = 48;
            this.groupBox_yetkiler.TabStop = false;
            this.groupBox_yetkiler.Text = "Yetkiler";
            this.groupBox_yetkiler.Visible = false;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(15, 158);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(195, 26);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Kafeteryaya Erişim";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(15, 254);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(160, 26);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Ayarlara Erişim";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(15, 222);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(198, 26);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Tanımlamara Erişim";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(15, 190);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(181, 26);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Geçmişlere Erişim";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(15, 126);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(150, 26);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Carilere Erişim";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 94);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(201, 26);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Muhasebeye Erişim";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 62);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 26);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Odalara Erişim";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(198, 26);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Uygulamaya Erişim";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form_TanimlamaGuncelle
            // 
            this.AcceptButton = this.button_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 146);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.comboBox_muhasebeTur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_icerik);
            this.Controls.Add(this.label_icerik);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_yetkiler);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_TanimlamaGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Güncelle";
            this.groupBox_yetkiler.ResumeLayout(false);
            this.groupBox_yetkiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_icerik;
        private System.Windows.Forms.Label label_icerik;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.ComboBox comboBox_muhasebeTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_yetkiler;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}