using Autofac;
using AutoMapper;
using MenStore.Application.Mapper;
using MenStore.Application.Services.OrderDetailServices;
using MenStore.Application.Services.OrderMasterServices;
using MenStore.Application.Services.ProductServices;
using MenStore.DTO.OrderDetail;
using MenStore.DTO.OrderMaster;
using MenStore.DTO.Product;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MenStore.PresentationLayer
{
    public partial class OrderMasterForAdmin : Form
    {
        public OrderMasterForAdmin()
        {
            InitializeComponent();
            container = AutoFac.Inject();
            orderMasterService = container.Resolve<IOrderMasterService>();
            orderDetailService = container.Resolve<IOrderDetailService>();
            productService = container.Resolve<IProductService>();
            bindingSource = new BindingSource();
            mapper = container.Resolve<IMapper>();
        }
        Autofac.IContainer container;
        IOrderMasterService orderMasterService;
        IOrderDetailService orderDetailService;
        IProductService productService;
        BindingSource bindingSource;
        IMapper mapper;
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewButtonColumn processOrderColumn = new DataGridViewButtonColumn();
            processOrderColumn.Text = "Process Order";
            processOrderColumn.HeaderText = "Process Order";
            processOrderColumn.UseColumnTextForButtonValue = true;
            List<GetAllOrderMasterDTO> allOrderMaster = orderMasterService.GetAllOrderMasterAdminState(State.Processing);
            bindingSource.DataSource = allOrderMaster;
            OrdersMasterGrid.DataSource = bindingSource;
            OrdersMasterGrid.Columns.Add(processOrderColumn);
            OrdersMasterGrid.Columns[0].ReadOnly = true;
            OrdersMasterGrid.AllowUserToAddRows = false;
            OrdersMasterGrid.AllowUserToDeleteRows = false;
        }

        private void OrdersMasterGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //int orderMasterId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                if (OrdersMasterGrid.Rows[e.RowIndex].DataBoundItem is GetAllOrderMasterDTO yesorder)
                {
                    //orderMasterService.UpdateOrderMaster(mapper.Map<GetOneOrderMasterDTO>(yesorder));
                    orderMasterService.UpdateOrderMaster(new GetOneOrderMasterDTO() { Id = yesorder.Id, ClientId = yesorder.ClientId,
                    OrderState = yesorder.OrderState+1});
                    orderMasterService.SaveChanges();
                    List<GetAllOrderDetailDTO> orderDetails = orderDetailService.GetAllDetailsOfMaster(yesorder.Id);
                    foreach (GetAllOrderDetailDTO detail in orderDetails)
                    {// here throw tracking exception after the first loop if we processed an order before that have the same product because
                        //the tracking error
                        GetOneProductDTO product = productService.GetoneOfProduct(detail.ProductId); 
                        productService.UpdateProduct(new GetAllProductDTO(detail.ProductId, product.Title, product.Price, product.CategoryID, 
                            product.CategoryName, product.UnitsInStock - detail.Quantity));
                        productService.SaveChanges();
                    }
                    OrdersMasterGrid.Refresh();
                }

                //Debug.WriteLine(yesorder.Total);
                else Debug.WriteLine("yesorder");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
