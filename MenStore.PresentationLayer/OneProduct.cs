using MenStore.DTO.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenStore.PresentationLayer
{
    public partial class OneProduct : Form
    {
        public OneProduct(GetAllProductUserDTO productDTO)
        {
            InitializeComponent();
            lblTitle.Text = productDTO.Title;
            lblPrice.Text = productDTO.Price.ToString();
            lblCategory.Text = productDTO.CategoryName;
            lblUnits.Text = productDTO.UnitsInStock.ToString();
            BoxPic.ImageLocation = productDTO.Image;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
