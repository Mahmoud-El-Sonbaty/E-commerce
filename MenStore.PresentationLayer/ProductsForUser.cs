using Autofac.Core;
using MenStore.Application.Services.CategoryServices;
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
using MenStore.DTO.Category;
using MenStore.DTO.Product;
using MenStore.DTO.OrderDetail;
using MenStore.DTO.OrderMaster;
using MenStore.Models;
using System.Diagnostics;
using MenStore.Application.Services.OrderDetailServices;
using MenStore.Application.Services.OrderMasterServices;

namespace MenStore.PresentationLayer
{
    public partial class ProductsForUser : Form
    {
        public ProductsForUser(int _activeUserId)
        {
            InitializeComponent();
            productService = container.Resolve<IProductService>();
            categorySevice = container.Resolve<ICategoryService>();
            masterService = container.Resolve<IOrderMasterService>();
            detailService = container.Resolve<IOrderDetailService>();
            List<GetCategoryDTO> categories = categorySevice.GetAllCategory();
            activeUserId = _activeUserId;
            GetCategoryDTO Allproducts = new GetCategoryDTO()
            {

                Id = -1,
                Name = "All"

            };
            categorySelect.Items.Add(Allproducts);

            foreach (GetCategoryDTO item in categories)
            {

                categorySelect.Items.Add(item);


            }
            categorySelect.SelectedIndexChanged += (sender, e) =>
            {
                if (categorySelect.SelectedItem is GetCategoryDTO selectedCategory)
                    showProductsOfCategory(selectedCategory.Id, 10, pageNumber);
                btnHome.Enabled = true;



                //Debug.WriteLine(selectedCategory.Id); 
            };
            btnHome.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;

            txtSearch.TextChanged += (sender, e) =>
            {
                searchingForproducts(txtSearch.Text);
            };

        }
        IContainer container = AutoFac.Inject();
        IProductService productService;
        ICategoryService categorySevice;
        IOrderMasterService masterService;
        IOrderDetailService detailService;

        BindingSource BdSource;
        private int pageNumber = 1;
        private int activeUserId = 0;


        private void searchingForproducts(string key)
        {

            List<GetAllProductUserDTO> products = productService.searchUser(key);

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnHome.Enabled = true;

            if (products.Count > 10)
            {
                btnNext.Enabled = true;

            }


            if (products.Count > 0)
            {
                CreateProductCards(products);

                if (products.Count <= 10)
                {
                    btnNext.Enabled = false;
                }
            }
            else
            {
                btnNext.Enabled = false;
            }

        }


        private void CreateProductCards(List<GetAllProductUserDTO> products)
        {
            // Clear any existing controls
            PanelProducts.Controls.Clear();

            // Set the card size and spacing
            int cardWidth = 220;
            int cardHeight = 250;
            int spacing = 10;

            // Calculate the number of columns and rows
            int columns = 5; // Number of cards per row
            int rows = products.Count / columns + (products.Count % columns > 0 ? 1 : 0);

            // Iterate through the products and create cards
            for (int i = 0; i < products.Count; i++)
            {
                var product = products[i];

                Panel card = new Panel();
                card.Size = new Size(cardWidth, cardHeight);
                card.BorderStyle = BorderStyle.FixedSingle;

                int row = i / columns;
                int column = i % columns;
                card.Location = new Point(column * (cardWidth + spacing), row * (cardHeight + spacing));

                // PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(cardWidth, cardHeight - 100); // Adjusted height to leave space for title, price, and button
                pictureBox.ImageLocation = product.Image;
                //// Set ImageLocation directly
                //if (!string.IsNullOrEmpty(product.Image))
                //{
                //    try
                //    {
                //    }
                //    catch (Exception ex)
                //    {
                //        pictureBox.Image = Properties.Resources.DefaultImage; // Fallback image
                //    }
                //}
                //else
                //{
                //    pictureBox.Image = Properties.Resources.DefaultImage; // Fallback image if no URL
                //}
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(0, 0); // Position at the top of the panel
                card.Controls.Add(pictureBox);
                pictureBox.Click += (sender, e) => { OneProduct oneProduct = new OneProduct(product/*, activeUserId*/); oneProduct.Show(); };
                // Title Label
                Label lblTitle = new Label();
                lblTitle.Text = product.Title;
                lblTitle.TextAlign = ContentAlignment.MiddleCenter;
                lblTitle.AutoSize = false;
                lblTitle.Size = new Size(cardWidth, 20); // Set label size
                lblTitle.Location = new Point(0, cardHeight - 80); // Position it below the PictureBox
                card.Controls.Add(lblTitle);

                // Price Label
                Label lblPrice = new Label();
                lblPrice.Text = $"Price: {product.Price:C}";
                lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                lblPrice.AutoSize = false;
                lblPrice.Size = new Size(cardWidth, 20); // Set label size
                lblPrice.Location = new Point(0, cardHeight - 60); // Position it below the title
                card.Controls.Add(lblPrice);

                // Add Button
                Button btnAdd = new Button();
                btnAdd.Text = "Add";
                btnAdd.Size = new Size(cardWidth - 20, 30); // Set button size
                btnAdd.Location = new Point(10, cardHeight - 40); // Position it at the bottom
                btnAdd.Click += (s, e) => AddToCart(product); // Hook up the event handler
                card.Controls.Add(btnAdd);

                card.Click += (sender, e) => { OneProduct oneProduct = new OneProduct(product/*, activeUserId*/); oneProduct.Show(); };
                // Add the card to the panel
                PanelProducts.Controls.Add(card);

            }
        }

        private void AddToCart(GetAllProductUserDTO product)
        {
            var checkExistingMaster = masterService.GetAllOrderMasterOnState(State.InCart, activeUserId);//here
            if (checkExistingMaster.Count == 0)
            {
                GetOneOrderMasterDTO createdMaster = masterService
                    .CreateOrderMaster(new CreateOrderMasterDTO() { ClientId = activeUserId, OrderDateTime = DateTime.Now, Total = product.Price });
                //masterService.SaveChanges();
                GetOneOrderDetailDTO createdDetail = detailService
                    .CreateOrderDetail(new CreateOrderDetailDTO(createdMaster.Id, product.Id, 1, product.Price));
                if (createdDetail != null)
                {
                    MessageBox.Show("Your Order Was Created Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                GetAllOrderMasterDTO currentOrderMaster = checkExistingMaster.First();
                GetOneOrderDetailDTO checkDetail = detailService.GetOneOrderDetailByProduct(checkExistingMaster.First().Id, product.Id);
                if (checkDetail == null)
                {
                    GetOneOrderDetailDTO createdDetail =
                        detailService.CreateOrderDetail(new CreateOrderDetailDTO(checkExistingMaster.First().Id, product.Id, 1, product.Price));
                    GetOneOrderMasterDTO updatedMaster =
                        masterService.UpdateOrderMaster(new GetOneOrderMasterDTO()
                        {
                            Id = currentOrderMaster.Id,
                            ClientId = currentOrderMaster.ClientId,
                            Total = currentOrderMaster.Total + product.Price
                        });
                    MessageBox.Show("Product Added Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetOneOrderDetailDTO updatedDetail =
                        detailService.UpdateOrderDetail(new GetOneOrderDetailDTO(checkDetail.Id, checkDetail.OrderMasterId,
                        checkDetail.ProductId, checkDetail.Quantity + 1));
                    detailService.SaveChanges();
                    GetOneOrderMasterDTO updatedMaster =
                        masterService.UpdateOrderMaster(new GetOneOrderMasterDTO()
                        {
                            Id = currentOrderMaster.Id,
                            ClientId = currentOrderMaster.ClientId,
                            Total = currentOrderMaster.Total + product.Price

                        });
                    masterService.SaveChanges();
                    MessageBox.Show($"Increased Quantity For {product.Title} Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void showProductsOfCategory(int CategoryID, int count, int pageNumber)
        {
            List<GetAllProductUserDTO> products = productService.GetAllPaginationUser(count, pageNumber, CategoryID);

            if (products.Count > 0)
            {
                CreateProductCards(products); // Call to create the cards

                if (products.Count < count)
                {
                    btnNext.Enabled = false;
                }

                if (productService.GetAllPaginationUser(count, pageNumber + 1, CategoryID).Count == 0)
                {
                    btnNext.Enabled = false;
                }
            }
            else
            {
                btnNext.Enabled = false;
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
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

        private void btnPrevious_Click(object sender, EventArgs e)
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
            categorySelect.SelectedIndex = 0;



            if (categorySelect.SelectedItem is GetCategoryDTO selectedCategory)
            {
                showProductsOfCategory(selectedCategory.Id, 10, pageNumber);

            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            btnHome.Enabled = false;
            pageNumber = 1;
            btnNext.Enabled = true;
            categorySelect.SelectedIndex = 0;

            if (categorySelect.SelectedItem is GetCategoryDTO selectedCategory)
            {
                showProductsOfCategory(selectedCategory.Id, 10, pageNumber);

            }
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCart userCart = new UserCart(activeUserId);
            userCart.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}