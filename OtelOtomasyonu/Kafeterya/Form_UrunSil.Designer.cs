namespace OtelOtomasyonu.Kafeterya
{
    partial class Form_UrunSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UrunSil));
            this.button_sil = new System.Windows.Forms.Button();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sil
            // 
            this.button_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_sil.Image = ((System.Drawing.Image)(resources.GetObject("button_sil.Image")));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(144, 106);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(84, 53);
            this.button_sil.TabIndex = 27;
            this.button_sil.Text = "Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // textBox_ad
            // 
            this.textBox_ad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_ad.Enabled = false;
            this.textBox_ad.Location = new System.Drawing.Point(120, 59);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(241, 31);
            this.textBox_ad.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün Ad:";
            // 
            // label_id
            // 
            this.label_id.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(120, 24);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 22);
            this.label_id.TabIndex = 29;
            this.label_id.Text = "1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ürün ID:";
            // 
            // Form_UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 171);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_UrunSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label6;
    }
}