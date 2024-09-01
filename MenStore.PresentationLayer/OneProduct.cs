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
using MenStore.Models;

namespace MenStore.PresentationLayer
{
    public partial class OneProduct : Form
    {
        public OneProduct()
        {
            InitializeComponent();
            productService = container.Resolve<IProductService>();
            categorySevice = container.Resolve<ICategorySevice>();
        }

        IContainer container = AutoFac.Inject();
        IProductService productService;
        ICategorySevice categorySevice;
        BindingSource BdSource;

        private void loadImage(int productID)
        {
            var product = productService.GetoneOfProduct(productID);
            if (product.Image != null && product.Image.Length > 0)
            {
                Image image = Image.FromFile(product.Image);
                BoxPic.Image = image;
            }
            else
            {
                BoxPic.Image = null;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OneProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {


            ProductForAdmin admin = new ProductForAdmin();
            this.Size = admin.Size;

            this.Location = admin.Location;

            this.WindowState = admin.WindowState;
            foreach (Control control in this.Controls)
            {
                control.Hide();
            }
            //foreach (Control control in this.Controls)
            //{
            //    if (control.Name != "btnHome" && control.Name != "someOtherButtonName") // Replace with the names of controls you want to keep visible
            //    {
            //        control.Hide();
            //    }
            //}
            foreach (Control control in admin.Controls)
            {
                this.Controls.Add(control);
            }



        }

        private void BoxPic_Click(object sender, EventArgs e)
        {

        }
    }

}
