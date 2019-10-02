namespace StokTakipProgrami
{
    partial class FilmSorgulama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOyuncularaGore = new System.Windows.Forms.TextBox();
            this.txtYonetmeneGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilmTurleri = new System.Windows.Forms.ComboBox();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvFilmler = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOyuncularaGore);
            this.groupBox1.Controls.Add(this.txtYonetmeneGore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFilmTurleri);
            this.groupBox1.Controls.Add(this.txtAdaGore);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lvFilmler);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 601);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Sorgulama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(609, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "Oyunculara Göre";
            // 
            // txtOyuncularaGore
            // 
            this.txtOyuncularaGore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtOyuncularaGore.Location = new System.Drawing.Point(613, 92);
            this.txtOyuncularaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtOyuncularaGore.Name = "txtOyuncularaGore";
            this.txtOyuncularaGore.Size = new System.Drawing.Size(267, 32);
            this.txtOyuncularaGore.TabIndex = 61;
            this.txtOyuncularaGore.TextChanged += new System.EventHandler(this.txtOyuncularaGore_TextChanged);
            // 
            // txtYonetmeneGore
            // 
            this.txtYonetmeneGore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtYonetmeneGore.Location = new System.Drawing.Point(398, 92);
            this.txtYonetmeneGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtYonetmeneGore.Name = "txtYonetmeneGore";
            this.txtYonetmeneGore.Size = new System.Drawing.Size(160, 32);
            this.txtYonetmeneGore.TabIndex = 60;
            this.txtYonetmeneGore.TextChanged += new System.EventHandler(this.txtYonetmeneGore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(394, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "Yönetmene Göre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(202, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Film Türüne Göre";
            // 
            // cbFilmTurleri
            // 
            this.cbFilmTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTurleri.DropDownWidth = 110;
            this.cbFilmTurleri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cbFilmTurleri.FormattingEnabled = true;
            this.cbFilmTurleri.Location = new System.Drawing.Point(206, 92);
            this.cbFilmTurleri.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilmTurleri.Name = "cbFilmTurleri";
            this.cbFilmTurleri.Size = new System.Drawing.Size(123, 32);
            this.cbFilmTurleri.TabIndex = 57;
            this.cbFilmTurleri.SelectedIndexChanged += new System.EventHandler(this.cbFilmTurleri_SelectedIndexChanged);
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtAdaGore.Location = new System.Drawing.Point(40, 92);
            this.txtAdaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(140, 32);
            this.txtAdaGore.TabIndex = 56;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(36, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Film Adına Göre";
            // 
            // lvFilmler
            // 
            this.lvFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvFilmler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lvFilmler.FullRowSelect = true;
            this.lvFilmler.Location = new System.Drawing.Point(40, 149);
            this.lvFilmler.Margin = new System.Windows.Forms.Padding(4);
            this.lvFilmler.Name = "lvFilmler";
            this.lvFilmler.Size = new System.Drawing.Size(905, 425);
            this.lvFilmler.TabIndex = 54;
            this.lvFilmler.UseCompatibleStateImageBehavior = false;
            this.lvFilmler.View = System.Windows.Forms.View.Details;
            this.lvFilmler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFilmler_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "FilmNo";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FilmAdı";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FilmTurNo";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FilmTürü";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yönetmen";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Oyuncular";
            this.columnHeader6.Width = 202;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Özet";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Miktar";
            // 
            // FilmSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1075, 625);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilmSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Film Sorgula";
            this.Load += new System.EventHandler(this.FilmSorgulama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOyuncularaGore;
        private System.Windows.Forms.TextBox txtYonetmeneGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilmTurleri;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}