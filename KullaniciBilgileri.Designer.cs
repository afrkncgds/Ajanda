namespace Ajanda
{
    partial class KullaniciBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciBilgileri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBilgiGetir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBilgiGetir
            // 
            this.btnBilgiGetir.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBilgiGetir.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGetir.Appearance.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBilgiGetir.Appearance.Options.UseBackColor = true;
            this.btnBilgiGetir.Appearance.Options.UseFont = true;
            this.btnBilgiGetir.Appearance.Options.UseForeColor = true;
            this.btnBilgiGetir.AppearanceDisabled.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBilgiGetir.AppearanceDisabled.Options.UseForeColor = true;
            this.btnBilgiGetir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBilgiGetir.ImageOptions.Image")));
            this.btnBilgiGetir.Location = new System.Drawing.Point(329, 396);
            this.btnBilgiGetir.Name = "btnBilgiGetir";
            this.btnBilgiGetir.Size = new System.Drawing.Size(155, 42);
            this.btnBilgiGetir.TabIndex = 25;
            this.btnBilgiGetir.Text = "BİLGİ GETİR";
            this.btnBilgiGetir.Click += new System.EventHandler(this.btnBilgiGetir_Click);
            // 
            // KullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBilgiGetir);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciBilgileri";
            this.Text = "KullaniciBilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnBilgiGetir;
    }
}