using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }




        private IProductService _productService; 
        private ICategoryService _categoryService; 
        private void Form1_Load(object sender, EventArgs e)
        {


            LoadProducts();
            LoadCategories();

            

        }

        private void LoadCategories()
        {

            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxKategoriEkle.DataSource = _categoryService.GetAll();
            cbxKategoriEkle.DisplayMember = "CategoryName";
            cbxKategoriEkle.ValueMember = "CategoryId";

            cbxKategoriEkleUpdate.DataSource = _categoryService.GetAll();
            cbxKategoriEkleUpdate.DisplayMember = "CategoryName";
            cbxKategoriEkleUpdate.ValueMember = "CategoryId";

        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch
            {

                
            }



        }

       

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                _productService.Add(new Product
                {

                    CategoryId = Convert.ToInt32(cbxKategoriEkle.SelectedValue),
                    ProductName = tbxUrunAdi.Text,
                    QuantityPerUnit = tbxBirimAdedi.Text,
                    UnitPrice = Convert.ToDecimal(tbxFiyatEkle.Text),
                    UnitsInStock = Convert.ToInt16(tbxStokAdedi.Text)



                });

                MessageBox.Show("Ürün Kaydedildi");
                LoadProducts();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }


           
        }

        private void btnEkleUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                _productService.Update(new Product
                {


                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxBirimUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxKategoriEkleUpdate.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxStokUpdate.Text),
                    QuantityPerUnit = tbxBirimUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxFiyatUpdate.Text)



                });

                MessageBox.Show("Ürün Güncellendi");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

            




        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var row = dgwProduct.CurrentRow;

            tbxUrunAdiUpdate.Text = row.Cells[1].Value.ToString();

            cbxKategoriEkleUpdate.SelectedValue = row.Cells[2].Value;

            tbxFiyatUpdate.Text = row.Cells[3].Value.ToString();
            tbxBirimUpdate.Text = row.Cells[4].Value.ToString();
            tbxStokUpdate.Text = row.Cells[5].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow!=null)
            {

                try
                {

                    _productService.Delete(new Product
                    {


                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),





                    });
                    MessageBox.Show("Ürün Silindi!");
                    LoadProducts();


                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    
                }



            }

            

           

        }
    }
}
