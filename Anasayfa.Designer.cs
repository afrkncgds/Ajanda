namespace Ajanda
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuAjanda = new System.Windows.Forms.MenuStrip();
            this.kullanicilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümRandevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapılacaklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuAjanda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAjanda
            // 
            this.menuAjanda.BackColor = System.Drawing.Color.Gold;
            this.menuAjanda.Enabled = false;
            this.menuAjanda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuAjanda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanicilarToolStripMenuItem,
            this.randevularToolStripMenuItem,
            this.yapılacaklarToolStripMenuItem});
            this.menuAjanda.Location = new System.Drawing.Point(0, 0);
            this.menuAjanda.Name = "menuAjanda";
            this.menuAjanda.Size = new System.Drawing.Size(432, 25);
            this.menuAjanda.TabIndex = 4;
            this.menuAjanda.Text = "menuStrip1";
            // 
            // kullanicilarToolStripMenuItem
            // 
            this.kullanicilarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kullanicilarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcıBilgileriToolStripMenuItem});
            this.kullanicilarToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.kullanicilarToolStripMenuItem.Name = "kullanicilarToolStripMenuItem";
            this.kullanicilarToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.kullanicilarToolStripMenuItem.Text = "Kullanıcılar";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            this.kullanıcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // randevularToolStripMenuItem
            // 
            this.randevularToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.randevularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümRandevularToolStripMenuItem,
            this.randevuEkleToolStripMenuItem});
            this.randevularToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            this.randevularToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.randevularToolStripMenuItem.Text = "Randevular";
            // 
            // tümRandevularToolStripMenuItem
            // 
            this.tümRandevularToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.tümRandevularToolStripMenuItem.Name = "tümRandevularToolStripMenuItem";
            this.tümRandevularToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tümRandevularToolStripMenuItem.Text = "Tüm Randevular";
            this.tümRandevularToolStripMenuItem.Click += new System.EventHandler(this.tümRandevularToolStripMenuItem_Click);
            // 
            // randevuEkleToolStripMenuItem
            // 
            this.randevuEkleToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.randevuEkleToolStripMenuItem.Name = "randevuEkleToolStripMenuItem";
            this.randevuEkleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.randevuEkleToolStripMenuItem.Text = "Randevu Ekle";
            this.randevuEkleToolStripMenuItem.Click += new System.EventHandler(this.randevuEkleToolStripMenuItem_Click);
            // 
            // yapılacaklarToolStripMenuItem
            // 
            this.yapılacaklarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yapılacaklarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümListeToolStripMenuItem,
            this.yeniListeToolStripMenuItem});
            this.yapılacaklarToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.yapılacaklarToolStripMenuItem.Name = "yapılacaklarToolStripMenuItem";
            this.yapılacaklarToolStripMenuItem.Size = new System.Drawing.Size(127, 21);
            this.yapılacaklarToolStripMenuItem.Text = "Yapılacaklar Listesi";
            // 
            // tümListeToolStripMenuItem
            // 
            this.tümListeToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.tümListeToolStripMenuItem.Name = "tümListeToolStripMenuItem";
            this.tümListeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tümListeToolStripMenuItem.Text = "Yapılacaklar Tüm Liste";
            this.tümListeToolStripMenuItem.Click += new System.EventHandler(this.tümListeToolStripMenuItem_Click);
            // 
            // yeniListeToolStripMenuItem
            // 
            this.yeniListeToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.yeniListeToolStripMenuItem.Name = "yeniListeToolStripMenuItem";
            this.yeniListeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.yeniListeToolStripMenuItem.Text = "Yapılacaklar Yeni Liste";
            this.yeniListeToolStripMenuItem.Click += new System.EventHandler(this.yeniListeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Giriş";
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
            this.btnGiris.Location = new System.Drawing.Point(151, 162);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(230, 42);
            this.btnGiris.TabIndex = 12;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(151, 115);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(230, 25);
            this.txtSifre.TabIndex = 11;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(151, 69);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(230, 25);
            this.txtKullaniciAd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(95, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 287);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuAjanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.menuAjanda.ResumeLayout(false);
            this.menuAjanda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuAjanda;
        private System.Windows.Forms.ToolStripMenuItem kullanicilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümRandevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuEkleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private System.Windows.Forms.ToolStripMenuItem yapılacaklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniListeToolStripMenuItem;
    }
}



