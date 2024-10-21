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
            this.lblKategori = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbCategory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(2, 320);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(999, 204);
            this.dgwProduct.TabIndex = 0;
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.cbxCategory);
            this.gbCategory.Controls.Add(this.lblKategori);
            this.gbCategory.Location = new System.Drawing.Point(12, 12);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(980, 142);
            this.gbCategory.TabIndex = 1;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Kategoriye Göre Arama";
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
            this.groupBox2.Controls.Add(this.cbxProduct);
            this.groupBox2.Controls.Add(this.lblUrunAdi);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
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
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(98, 58);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(287, 24);
            this.cbxCategory.TabIndex = 3;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(98, 67);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(287, 24);
            this.cbxProduct.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 536);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.ComboBox cbxProduct;
    }
}

