namespace StokTakipProgrami
{
    partial class MusteriSorgula
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdreseGore = new System.Windows.Forms.TextBox();
            this.txtTelefonaGore = new System.Windows.Forms.TextBox();
            this.txtSoyadaGore = new System.Windows.Forms.TextBox();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdreseGore);
            this.groupBox1.Controls.Add(this.txtTelefonaGore);
            this.groupBox1.Controls.Add(this.txtSoyadaGore);
            this.groupBox1.Controls.Add(this.txtAdaGore);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lvMusteriler);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(28, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1282, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Sorgulama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Adrese Göre Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Telefona Göre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Soyadına Göre";
            // 
            // txtAdreseGore
            // 
            this.txtAdreseGore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtAdreseGore.Location = new System.Drawing.Point(218, 298);
            this.txtAdreseGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdreseGore.Name = "txtAdreseGore";
            this.txtAdreseGore.Size = new System.Drawing.Size(280, 32);
            this.txtAdreseGore.TabIndex = 30;
            this.txtAdreseGore.TextChanged += new System.EventHandler(this.txtAdreseGore_TextChanged);
            // 
            // txtTelefonaGore
            // 
            this.txtTelefonaGore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtTelefonaGore.Location = new System.Drawing.Point(218, 236);
            this.txtTelefonaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonaGore.Name = "txtTelefonaGore";
            this.txtTelefonaGore.Size = new System.Drawing.Size(280, 32);
            this.txtTelefonaGore.TabIndex = 29;
            this.txtTelefonaGore.TextChanged += new System.EventHandler(this.txtTelefonaGore_TextChanged);
            // 
            // txtSoyadaGore
            // 
            this.txtSoyadaGore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtSoyadaGore.Location = new System.Drawing.Point(218, 172);
            this.txtSoyadaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadaGore.Name = "txtSoyadaGore";
            this.txtSoyadaGore.Size = new System.Drawing.Size(280, 32);
            this.txtSoyadaGore.TabIndex = 28;
            this.txtSoyadaGore.TextChanged += new System.EventHandler(this.txtSoyadaGore_TextChanged);
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtAdaGore.Location = new System.Drawing.Point(218, 108);
            this.txtAdaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(280, 32);
            this.txtAdaGore.TabIndex = 27;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Müşteri Adına Göre";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMusteriler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.Location = new System.Drawing.Point(531, 100);
            this.lvMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(721, 241);
            this.lvMusteriler.TabIndex = 25;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.DoubleClick += new System.EventHandler(this.lvMusteriler_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MusteriNo";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MüşteriAdı";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adres";
            this.columnHeader4.Width = 210;
            // 
            // MusteriSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1322, 444);
            this.Controls.Add(this.groupBox1);
            this.Name = "MusteriSorgula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Müşteri Sorgula";
            this.Load += new System.EventHandler(this.MusteriSorgula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdreseGore;
        private System.Windows.Forms.TextBox txtTelefonaGore;
        private System.Windows.Forms.TextBox txtSoyadaGore;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}