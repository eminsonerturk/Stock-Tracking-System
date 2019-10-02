namespace StokTakipProgrami
{
    partial class kullaniciEkrani
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünStokTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSatışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünStokTakipToolStripMenuItem,
            this.müşteriTakipToolStripMenuItem,
            this.satışGörüntüleToolStripMenuItem,
            this.iletişimToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünStokTakipToolStripMenuItem
            // 
            this.ürünStokTakipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünSatışıToolStripMenuItem,
            this.ürünEkleToolStripMenuItem1});
            this.ürünStokTakipToolStripMenuItem.Name = "ürünStokTakipToolStripMenuItem";
            this.ürünStokTakipToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.ürünStokTakipToolStripMenuItem.Text = "Film Bilgileri";
            // 
            // ürünSatışıToolStripMenuItem
            // 
            this.ürünSatışıToolStripMenuItem.Name = "ürünSatışıToolStripMenuItem";
            this.ürünSatışıToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.ürünSatışıToolStripMenuItem.Text = "Film Tanımlama";
            this.ürünSatışıToolStripMenuItem.Click += new System.EventHandler(this.FilmTanimlamaToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem1
            // 
            this.ürünEkleToolStripMenuItem1.Name = "ürünEkleToolStripMenuItem1";
            this.ürünEkleToolStripMenuItem1.Size = new System.Drawing.Size(221, 26);
            this.ürünEkleToolStripMenuItem1.Text = "Film Türü Tanımlama";
            this.ürünEkleToolStripMenuItem1.Click += new System.EventHandler(this.FilmTurleriToolStripMenuItem1_Click);
            // 
            // müşteriTakipToolStripMenuItem
            // 
            this.müşteriTakipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem});
            this.müşteriTakipToolStripMenuItem.Name = "müşteriTakipToolStripMenuItem";
            this.müşteriTakipToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.müşteriTakipToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.müşterilerToolStripMenuItem.Text = "Müşteri Tanımlama";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.MusteriTanimlaToolStripMenuItem_Click);
            // 
            // satışGörüntüleToolStripMenuItem
            // 
            this.satışGörüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışlarToolStripMenuItem,
            this.satışSorgulamaToolStripMenuItem});
            this.satışGörüntüleToolStripMenuItem.Name = "satışGörüntüleToolStripMenuItem";
            this.satışGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.satışGörüntüleToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // satışlarToolStripMenuItem
            // 
            this.satışlarToolStripMenuItem.Name = "satışlarToolStripMenuItem";
            this.satışlarToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.satışlarToolStripMenuItem.Text = "Film Satış";
            this.satışlarToolStripMenuItem.Click += new System.EventHandler(this.FilmSatisToolStripMenuItem_Click);
            // 
            // satışSorgulamaToolStripMenuItem
            // 
            this.satışSorgulamaToolStripMenuItem.Name = "satışSorgulamaToolStripMenuItem";
            this.satışSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.satışSorgulamaToolStripMenuItem.Text = "Satış Sorgulama";
            this.satışSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.satisSorgulamaToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // kullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 786);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kullaniciEkrani";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Digital Mağaza Film Takip Otomasyonu";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünStokTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSatışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşteriTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        
        private System.Windows.Forms.ToolStripMenuItem satışGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışSorgulamaToolStripMenuItem;
    }
}