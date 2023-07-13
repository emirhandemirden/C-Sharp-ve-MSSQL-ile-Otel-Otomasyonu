namespace OtelOtomasyonu.Odalar
{
    partial class Form_OdaSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OdaSil));
            this.button_sil = new System.Windows.Forms.Button();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_katno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_odano = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_odaid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sil
            // 
            this.button_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_sil.Image = ((System.Drawing.Image)(resources.GetObject("button_sil.Image")));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(140, 157);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(80, 53);
            this.button_sil.TabIndex = 20;
            this.button_sil.Text = "Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_tur.Enabled = false;
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Location = new System.Drawing.Point(125, 117);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(224, 30);
            this.comboBox_tur.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.Location = new System.Drawing.Point(1, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Oda Tür:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_katno
            // 
            this.maskedTextBox_katno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_katno.Enabled = false;
            this.maskedTextBox_katno.Location = new System.Drawing.Point(125, 80);
            this.maskedTextBox_katno.Mask = "000";
            this.maskedTextBox_katno.Name = "maskedTextBox_katno";
            this.maskedTextBox_katno.Size = new System.Drawing.Size(224, 31);
            this.maskedTextBox_katno.TabIndex = 17;
            this.maskedTextBox_katno.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Location = new System.Drawing.Point(1, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Oda Kat:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_odano
            // 
            this.maskedTextBox_odano.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_odano.Enabled = false;
            this.maskedTextBox_odano.Location = new System.Drawing.Point(125, 43);
            this.maskedTextBox_odano.Mask = "000";
            this.maskedTextBox_odano.Name = "maskedTextBox_odano";
            this.maskedTextBox_odano.Size = new System.Drawing.Size(224, 31);
            this.maskedTextBox_odano.TabIndex = 15;
            this.maskedTextBox_odano.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Location = new System.Drawing.Point(1, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Oda No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Oda ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_odaid
            // 
            this.label_odaid.Location = new System.Drawing.Point(125, 9);
            this.label_odaid.Name = "label_odaid";
            this.label_odaid.Size = new System.Drawing.Size(224, 23);
            this.label_odaid.TabIndex = 22;
            this.label_odaid.Text = "1";
            this.label_odaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_OdaSil
            // 
            this.AcceptButton = this.button_sil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 222);
            this.Controls.Add(this.label_odaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.comboBox_tur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox_katno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox_odano);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_OdaSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_katno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_odano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_odaid;
    }
}