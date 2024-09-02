using MenStore.Application.Services.CategoryServices;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using MenStore.Application.Services.CategoryServices;
namespace MenStore.PresentationLayer
{
    public partial class CategoryForm : Form
    {
        IContainer container;
        ICategoryService categorySevice;
        BindingSource bindingSource;
        public CategoryForm()
        {
            InitializeComponent();
            container = AutoFac.Inject();
            categorySevice = container.Resolve<ICategoryService>();


        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prd = categorySevice.GetAllCategory();
            bindingSource = new BindingSource(prd, "");
            dataGridView1.DataSource = bindingSource;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
