namespace OtelOtomasyonu.Tanimlamalar
{
    partial class Form_TanimlamaSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TanimlamaSil));
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_icerik = new System.Windows.Forms.Label();
            this.textBox_icerik = new System.Windows.Forms.TextBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id
            // 
            this.label_id.Location = new System.Drawing.Point(92, 9);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(205, 27);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "1";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_icerik
            // 
            this.label_icerik.Location = new System.Drawing.Point(12, 36);
            this.label_icerik.Name = "label_icerik";
            this.label_icerik.Size = new System.Drawing.Size(70, 27);
            this.label_icerik.TabIndex = 2;
            this.label_icerik.Text = "Tür:";
            this.label_icerik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_icerik
            // 
            this.textBox_icerik.Enabled = false;
            this.textBox_icerik.Location = new System.Drawing.Point(92, 35);
            this.textBox_icerik.Name = "textBox_icerik";
            this.textBox_icerik.Size = new System.Drawing.Size(205, 31);
            this.textBox_icerik.TabIndex = 3;
            // 
            // button_sil
            // 
            this.button_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sil.Image = ((System.Drawing.Image)(resources.GetObject("button_sil.Image")));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(112, 81);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(86, 53);
            this.button_sil.TabIndex = 26;
            this.button_sil.Text = "Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // Form_TanimlamaSil
            // 
            this.AcceptButton = this.button_sil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 146);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.textBox_icerik);
            this.Controls.Add(this.label_icerik);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_TanimlamaSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_icerik;
        private System.Windows.Forms.TextBox textBox_icerik;
        private System.Windows.Forms.Button button_sil;
    }
}