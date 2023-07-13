namespace OtelOtomasyonu.Giriş_Ekranı
{
    partial class Form_GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GirisYap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_cikis = new System.Windows.Forms.Button();
            this.button_website = new System.Windows.Forms.Button();
            this.button_youtube = new System.Windows.Forms.Button();
            this.button_twitter = new System.Windows.Forms.Button();
            this.button_instagram = new System.Windows.Forms.Button();
            this.button_girisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 461);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_cikis);
            this.panel2.Controls.Add(this.button_website);
            this.panel2.Controls.Add(this.button_youtube);
            this.panel2.Controls.Add(this.button_twitter);
            this.panel2.Controls.Add(this.button_instagram);
            this.panel2.Controls.Add(this.button_girisYap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_Sifre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_kullaniciAdi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(269, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 461);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Otel Samsun";
            // 
            // button_cikis
            // 
            this.button_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cikis.Location = new System.Drawing.Point(1000, 600);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(98, 36);
            this.button_cikis.TabIndex = 9;
            this.button_cikis.Text = "button1";
            this.button_cikis.UseVisualStyleBackColor = true;
            this.button_cikis.Visible = false;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // button_website
            // 
            this.button_website.AccessibleDescription = "https://emirhandemirden.infinityfreeapp.com/?i=1";
            this.button_website.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_website.BackColor = System.Drawing.Color.White;
            this.button_website.Image = ((System.Drawing.Image)(resources.GetObject("button_website.Image")));
            this.button_website.Location = new System.Drawing.Point(285, 399);
            this.button_website.Name = "button_website";
            this.button_website.Size = new System.Drawing.Size(50, 50);
            this.button_website.TabIndex = 5;
            this.button_website.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_website.UseVisualStyleBackColor = false;
            this.button_website.Click += new System.EventHandler(this.SocialMediaButtons_Clicked);
            // 
            // button_youtube
            // 
            this.button_youtube.AccessibleDescription = "https://www.youtube.com/channel/UCCA4NW1LkMsL7zUFnaV5tvw";
            this.button_youtube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_youtube.BackColor = System.Drawing.Color.White;
            this.button_youtube.Image = ((System.Drawing.Image)(resources.GetObject("button_youtube.Image")));
            this.button_youtube.Location = new System.Drawing.Point(341, 399);
            this.button_youtube.Name = "button_youtube";
            this.button_youtube.Size = new System.Drawing.Size(50, 50);
            this.button_youtube.TabIndex = 6;
            this.button_youtube.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_youtube.UseVisualStyleBackColor = false;
            this.button_youtube.Click += new System.EventHandler(this.SocialMediaButtons_Clicked);
            // 
            // button_twitter
            // 
            this.button_twitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_twitter.BackColor = System.Drawing.Color.White;
            this.button_twitter.Image = ((System.Drawing.Image)(resources.GetObject("button_twitter.Image")));
            this.button_twitter.Location = new System.Drawing.Point(397, 399);
            this.button_twitter.Name = "button_twitter";
            this.button_twitter.Size = new System.Drawing.Size(50, 50);
            this.button_twitter.TabIndex = 7;
            this.button_twitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_twitter.UseVisualStyleBackColor = false;
            this.button_twitter.Click += new System.EventHandler(this.SocialMediaButtons_Clicked);
            // 
            // button_instagram
            // 
            this.button_instagram.AccessibleDescription = "https://www.instagram.com/emirhan.demirden/";
            this.button_instagram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_instagram.BackColor = System.Drawing.Color.White;
            this.button_instagram.Image = ((System.Drawing.Image)(resources.GetObject("button_instagram.Image")));
            this.button_instagram.Location = new System.Drawing.Point(453, 399);
            this.button_instagram.Name = "button_instagram";
            this.button_instagram.Size = new System.Drawing.Size(50, 50);
            this.button_instagram.TabIndex = 8;
            this.button_instagram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_instagram.UseVisualStyleBackColor = false;
            this.button_instagram.Click += new System.EventHandler(this.SocialMediaButtons_Clicked);
            // 
            // button_girisYap
            // 
            this.button_girisYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_girisYap.Image = ((System.Drawing.Image)(resources.GetObject("button_girisYap.Image")));
            this.button_girisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_girisYap.Location = new System.Drawing.Point(113, 269);
            this.button_girisYap.Name = "button_girisYap";
            this.button_girisYap.Size = new System.Drawing.Size(143, 50);
            this.button_girisYap.TabIndex = 4;
            this.button_girisYap.Text = "Giriş Yap";
            this.button_girisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_girisYap.UseVisualStyleBackColor = true;
            this.button_girisYap.Click += new System.EventHandler(this.button_girisYap_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Şifre:";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Sifre.Location = new System.Drawing.Point(140, 215);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.PasswordChar = '*';
            this.textBox_Sifre.Size = new System.Drawing.Size(229, 29);
            this.textBox_Sifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(140, 178);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(229, 29);
            this.textBox_kullaniciAdi.TabIndex = 0;
            // 
            // Form_GirisYap
            // 
            this.AcceptButton = this.button_girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button_cikis;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form_GirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GirisYap_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_girisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Button button_instagram;
        private System.Windows.Forms.Button button_website;
        private System.Windows.Forms.Button button_youtube;
        private System.Windows.Forms.Button button_twitter;
        private System.Windows.Forms.Button button_cikis;
        private System.Windows.Forms.Label label3;
    }
}