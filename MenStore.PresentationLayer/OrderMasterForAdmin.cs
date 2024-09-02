using Autofac;
using AutoMapper;
using MenStore.Application.Mapper;
using MenStore.Application.Services.OrderDetailServices;
using MenStore.Application.Services.OrderMasterServices;
using MenStore.DTO.OrderMaster;
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
            bindingSource = new BindingSource();
            mapper = container.Resolve<IMapper>();
        }
        Autofac.IContainer container;
        IOrderMasterService orderMasterService;
        IOrderDetailService orderDetailService;
        BindingSource bindingSource;
        IMapper mapper;
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewButtonColumn addToCartColumn = new DataGridViewButtonColumn();
            addToCartColumn.Text = "Process Order";
            addToCartColumn.HeaderText = "Process Order";
            //addToCartColumn.DataPropertyName = "Name";
            List<GetAllOrderMasterDTO> allOrderMaster = orderMasterService.GetAllOrderMaster();
            bindingSource.DataSource = allOrderMaster;
            OrdersMasterGrid.DataSource = bindingSource;
            OrdersMasterGrid.Columns.Add(addToCartColumn);
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
                    orderMasterService.UpdateOrderMaster(mapper.Map<GetOneOrderMasterDTO>(yesorder));
                    orderMasterService.SaveChanges();
                }
                    
                    //Debug.WriteLine(yesorder.Total);
                else Debug.WriteLine("yesorder");
            }
        }
    }
}
