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

namespace MenStore.PresentationLayer
{
    public partial class ProductForAdmin : Form
    {
        public ProductForAdmin()
        {
            InitializeComponent();
            productService = container.Resolve<IProductService>();


        }
        IContainer container = AutoFac.Inject();
        IProductService productService;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productForAdmin_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
