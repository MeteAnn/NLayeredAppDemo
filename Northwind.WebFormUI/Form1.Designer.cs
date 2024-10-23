namespace Northwind.WebFormUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.gbProductAdd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.tbxFiyatEkle = new System.Windows.Forms.TextBox();
            this.tbxStokAdedi = new System.Windows.Forms.TextBox();
            this.tbxBirimAdedi = new System.Windows.Forms.TextBox();
            this.cbxKategoriEkle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbCategory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbProductAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(-7, 258);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(999, 141);
            this.dgwProduct.TabIndex = 0;
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.cbxCategory);
            this.gbCategory.Controls.Add(this.lblKategori);
            this.gbCategory.Location = new System.Drawing.Point(12, 12);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(980, 92);
            this.gbCategory.TabIndex = 1;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Kategoriye Göre Arama";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(98, 58);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(287, 24);
            this.cbxCategory.TabIndex = 3;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(29, 61);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(63, 16);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxProductName);
            this.groupBox2.Controls.Add(this.lblUrunAdi);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Adına Göre Arama";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(28, 70);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(64, 16);
            this.lblUrunAdi.TabIndex = 2;
            this.lblUrunAdi.Text = "Ürün Adı :";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(98, 70);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(287, 22);
            this.tbxProductName.TabIndex = 3;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // gbProductAdd
            // 
            this.gbProductAdd.Controls.Add(this.cbxKategoriEkle);
            this.gbProductAdd.Controls.Add(this.tbxBirimAdedi);
            this.gbProductAdd.Controls.Add(this.tbxStokAdedi);
            this.gbProductAdd.Controls.Add(this.tbxFiyatEkle);
            this.gbProductAdd.Controls.Add(this.tbxUrunAdi);
            this.gbProductAdd.Controls.Add(this.button1);
            this.gbProductAdd.Controls.Add(this.label5);
            this.gbProductAdd.Controls.Add(this.label4);
            this.gbProductAdd.Controls.Add(this.label3);
            this.gbProductAdd.Controls.Add(this.label2);
            this.gbProductAdd.Controls.Add(this.label1);
            this.gbProductAdd.Location = new System.Drawing.Point(13, 417);
            this.gbProductAdd.Name = "gbProductAdd";
            this.gbProductAdd.Size = new System.Drawing.Size(980, 223);
            this.gbProductAdd.TabIndex = 3;
            this.gbProductAdd.TabStop = false;
            this.gbProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Adedi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birim Adedi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Location = new System.Drawing.Point(81, 37);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(182, 22);
            this.tbxUrunAdi.TabIndex = 6;
            // 
            // tbxFiyatEkle
            // 
            this.tbxFiyatEkle.Location = new System.Drawing.Point(81, 113);
            this.tbxFiyatEkle.Name = "tbxFiyatEkle";
            this.tbxFiyatEkle.Size = new System.Drawing.Size(182, 22);
            this.tbxFiyatEkle.TabIndex = 8;
            // 
            // tbxStokAdedi
            // 
            this.tbxStokAdedi.Location = new System.Drawing.Point(447, 37);
            this.tbxStokAdedi.Name = "tbxStokAdedi";
            this.tbxStokAdedi.Size = new System.Drawing.Size(182, 22);
            this.tbxStokAdedi.TabIndex = 9;
            // 
            // tbxBirimAdedi
            // 
            this.tbxBirimAdedi.Location = new System.Drawing.Point(447, 76);
            this.tbxBirimAdedi.Name = "tbxBirimAdedi";
            this.tbxBirimAdedi.Size = new System.Drawing.Size(182, 22);
            this.tbxBirimAdedi.TabIndex = 10;
            // 
            // cbxKategoriEkle
            // 
            this.cbxKategoriEkle.FormattingEnabled = true;
            this.cbxKategoriEkle.Location = new System.Drawing.Point(80, 76);
            this.cbxKategoriEkle.Name = "cbxKategoriEkle";
            this.cbxKategoriEkle.Size = new System.Drawing.Size(183, 24);
            this.cbxKategoriEkle.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 646);
            this.Controls.Add(this.gbProductAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbProductAdd.ResumeLayout(false);
            this.gbProductAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.GroupBox gbProductAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxKategoriEkle;
        private System.Windows.Forms.TextBox tbxBirimAdedi;
        private System.Windows.Forms.TextBox tbxStokAdedi;
        private System.Windows.Forms.TextBox tbxFiyatEkle;
        private System.Windows.Forms.TextBox tbxUrunAdi;
        private System.Windows.Forms.Button button1;
    }
}

