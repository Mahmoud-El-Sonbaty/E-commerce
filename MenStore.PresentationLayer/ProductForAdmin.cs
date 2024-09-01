using MenStore.Application.Services.ProductServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using MenStore.Models;
using MenStore.DTO.Product;
using MenStore.Application.Services.CategoryServices;
using MenStore.DTO.Category;
using System.Diagnostics;
using AutoMapper;
using MenStore.Application.Mapper;

namespace MenStore.PresentationLayer
{
    public partial class ProductForAdmin : Form
    {
        public ProductForAdmin()
        {
            InitializeComponent();

            productService = container.Resolve<IProductService>();
            categorySevice = container.Resolve<ICategorySevice>();
            List<GetCategoryDTO> categories = categorySevice.GetAllCategory();
            //mapper=container.Resolve<Mapper>();

            foreach (GetCategoryDTO item in categories)
            {

                categorySelect.Items.Add(item);
                txtCategoryID.Items.Add(item);


            }

            categorySelect.SelectedIndexChanged += (sender, e) =>


            {
                if (categorySelect.SelectedItem is GetCategoryDTO selectedCategory)
                    showProductsOfCategory(selectedCategory.Id, 10, pageNumber);


                //Debug.WriteLine(selectedCategory.Id); 
            };


            txtSearch.TextChanged += (sender, e) =>
            {
                searchingForproducts(txtSearch.Text);
            };
            Datagrid.ReadOnly = false;

        }
        IContainer container = AutoFac.Inject();
        IProductService productService;
        ICategorySevice categorySevice;
        BindingSource BdSource;
        private int pageNumber = 1;
        //IMapper mapper;





        private void showProductsOfCategory(int CategoryID, int count, int pageNumber)
        {
            List<GetAllProductDTO> products = productService.GetAllPagination(count, pageNumber, CategoryID);

            if (products.Count > 0)
            {
                if (products.Count < 10)
                {
                    btnNext.Enabled = false;

                }


                System.ComponentModel.BindingList<GetAllProductDTO> list = new System.ComponentModel.BindingList<GetAllProductDTO>(products);
                BdSource = new BindingSource(list, "");
                Datagrid.DataSource = BdSource;


                if (productService.GetAllPagination(count, pageNumber + 1, CategoryID).Count == 0)
                {
                    btnNext.Enabled = false;

                }

            }
            else
            {
                btnNext.Enabled = false;
            }

            Datagrid.AllowUserToAddRows = true;


        }

        private void searchingForproducts(string key)
        {

            List<GetAllProductDTO> products = productService.search(key);

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnHome.Enabled = true;

            if (products.Count > 10)
            {
                btnNext.Enabled = true;

            }

            System.ComponentModel.BindingList<GetAllProductDTO> list = new System.ComponentModel.BindingList<GetAllProductDTO>(products);
            BdSource = new BindingSource(list, "");
            Datagrid.DataSource = BdSource;

            Datagrid.ReadOnly = false;


        }


        private void productForAdmin_Load(object sender, EventArgs e)
        {



        }






        private void dataChanged(object sender, DataGridViewCellEventArgs e)
        {


            var row = Datagrid.Rows[e.RowIndex];
            GetAllProductDTO updatedProduct = (GetAllProductDTO)row.DataBoundItem;
            Debug.WriteLine("sssss");

            productService.UpdateProduct(updatedProduct);


        }
        private void deletinkkkg(object sender, DataGridViewRowCancelEventArgs e)
        {

            int hh = e.Row.Index;
            var row = Datagrid.Rows[e.Row.Index];

            GetAllProductDTO delete = (GetAllProductDTO)row.DataBoundItem;
            Debug.WriteLine(delete);
            Debug.WriteLine(row);

            productService.DeleteProduct(delete);


        }


        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            btnHome.Enabled = false;
            showProductsOfCategory(-1, 10, 1);
            Datagrid.CellValueChanged += dataChanged;
            Datagrid.UserDeletingRow += deletinkkkg;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string Image = txtImage.Text;
            int unitsInStock = int.Parse(txtUnits.Text);
            int categoryId = 1;


            if (txtCategoryID.SelectedItem is GetCategoryDTO selectedCategory)
            {

                categoryId = (int)selectedCategory.Id;
            }
            Debug.WriteLine(categoryId);
            double price = double.Parse(txtPrice.Text);


            productService.AddProduct(new CreateProductDTO(title, categoryId, Image, price, unitsInStock));

            txtTitle.Clear();
            txtImage.Clear();
            txtUnits.SelectedIndex = -1;
            txtCategoryID.SelectedIndex = -1;
            txtPrice.SelectedIndex = -1;

        }

        private void saveToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            productService.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Datagrid.AllowUserToAddRows);
            productService.SaveChanges();

        }



        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (categorySelect.SelectedItem is GetCategoryDTO selectedCategory)
            {
                pageNumber++;


                Debug.WriteLine(selectedCategory.Id.GetType());

                showProductsOfCategory(selectedCategory.Id, 10, pageNumber);
                btnHome.Enabled = true;
                btnPrevious.Enabled = true;

            }
            else
            {
                pageNumber++;
                showProductsOfCategory(-1, 10, pageNumber);
                btnHome.Enabled = true;
                btnPrevious.Enabled = true;
            }
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (categorySelect.SelectedItem is GetCategoryDTO selectedCategory && pageNumber > 1)
            {
                pageNumber--;
                showProductsOfCategory(selectedCategory.Id, 10, pageNumber);
                if (pageNumber == 1)
                {
                    btnPrevious.Enabled = false;
                    btnHome.Enabled = false;
                }

            }
            else
            {
                pageNumber--;
                showProductsOfCategory(-1, 10, pageNumber);
                if (pageNumber == 1)
                {
                    btnPrevious.Enabled = false;
                    btnHome.Enabled = false;
                }
            }
            btnNext.Enabled = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            btnNext.Enabled = true;
            btnPrevious.Enabled = false;
            btnHome.Enabled = false;
            txtSearch.Clear();
            categorySelect.SelectedIndex = 0;



            if (categorySelect.SelectedItem is GetCategoryDTO selectedCategory)
            {
                showProductsOfCategory(selectedCategory.Id, 10, pageNumber);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var row2 = Datagrid.SelectedRows;
            ////foreach (DataGridViewRow row3 in row2)
            ////{
            ////  GetOneProductDTO x=  productService.GetoneOfProduct((int)row3.Cells[0].Value);
            ////   productService.DeleteProduct(x);
            ////    Debug.WriteLine(x.Id);
            ////    Debug.WriteLine(Datagrid.Rows[row3.Index]);
            ////    //var tt = productService.GetAllPagination(35, 1, -1);
            ////}
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void categorySelect_Click(object sender, EventArgs e)
        {

        }
    }
}
