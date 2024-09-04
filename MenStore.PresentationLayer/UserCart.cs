using MenStore.Application.Services.OrderDetailServices;
using MenStore.Application.Services.OrderMasterServices;
using Autofac;
using MenStore.DTO.Category;
using MenStore.DTO.Product;
using MenStore.DTO.OrderDetail;
using MenStore.DTO.OrderMaster;
using MenStore.Models;
using MenStore.Application.Services.CategoryServices;
using MenStore.Application.Services.ProductServices;
using AutoMapper;
using System.Diagnostics;

namespace MenStore.PresentationLayer
{
    public partial class UserCart : Form
    {
        public UserCart(int _activeUserId)
        {
            activeUserId = _activeUserId;
            InitializeComponent();
            masterService = container.Resolve<IOrderMasterService>();
            detailService = container.Resolve<IOrderDetailService>();
            bindingSource = new BindingSource();
            mapper = container.Resolve<IMapper>();
            SubmitOrderColumn = new DataGridViewButtonColumn();
            SubmitOrderColumn.Text = "Submit";
            SubmitOrderColumn.Name = "SubmitBtn";
            SubmitOrderColumn.HeaderText = "Submit";
            SubmitOrderColumn.UseColumnTextForButtonValue = true;
            ShowOrderDetailsColumn = new DataGridViewButtonColumn();
            ShowOrderDetailsColumn.Text = "Show Details";
            ShowOrderDetailsColumn.Name = "ShowBtn";
            ShowOrderDetailsColumn.HeaderText = "Show";
            ShowOrderDetailsColumn.UseColumnTextForButtonValue = true; ;
            DeleteOrderColumn = new DataGridViewButtonColumn();
            DeleteOrderColumn.Text = "Delete Order";
            DeleteOrderColumn.Name = "DeleteBtn";
            DeleteOrderColumn.HeaderText = "Delete";
            DeleteOrderColumn.UseColumnTextForButtonValue = true;
            DeleteOrderDetailColumn = new DataGridViewButtonColumn();
            DeleteOrderDetailColumn.Text = "Delete Order Detail";
            DeleteOrderDetailColumn.Name = "DeleteDetailBtn";
            DeleteOrderDetailColumn.HeaderText = "Delete Detail";
            DeleteOrderDetailColumn.UseColumnTextForButtonValue = true;
        }
        IContainer container = AutoFac.Inject();
        IOrderMasterService masterService;
        IOrderDetailService detailService;
        BindingSource bindingSource;
        IMapper mapper;
        private int activeUserId = 0;
        DataGridViewButtonColumn SubmitOrderColumn;
        DataGridViewButtonColumn ShowOrderDetailsColumn;
        DataGridViewButtonColumn DeleteOrderColumn;
        DataGridViewButtonColumn DeleteOrderDetailColumn;
        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GetAllOrderMasterDTO> InCartMasters = masterService.GetAllOrderMasterOnState(State.InCart, activeUserId);
            bindingSource.DataSource = InCartMasters;
            MasterDataGrid.DataSource = bindingSource;
            MasterDataGrid.Columns[0].ReadOnly = true;
            MasterDataGrid.AllowUserToAddRows = false;
            MasterDataGrid.AllowUserToDeleteRows = false;
            if (MasterDataGrid.Columns.Count < 6)
            {
                MasterDataGrid.Columns.Add(SubmitOrderColumn);
                MasterDataGrid.Columns.Add(ShowOrderDetailsColumn);
                MasterDataGrid.Columns.Add(DeleteOrderColumn);
            }
            else if (MasterDataGrid.Columns.Count == 6)
            {
                MasterDataGrid.Columns.Add(SubmitOrderColumn);
                MasterDataGrid.Columns.Add(DeleteOrderColumn);
            }
        }

        private void MasterDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn && e.RowIndex >= 0)
            {
                if (MasterDataGrid.Rows[e.RowIndex].DataBoundItem is GetAllOrderMasterDTO orderMaster)
                {
                    var iii = senderGrid.Rows[e.RowIndex].Cells[0].Value;
                    int orderMasterId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                    if (buttonColumn.Name == "SubmitBtn")
                    {
                        masterService.UpdateOrderMaster(new GetOneOrderMasterDTO() { Id = orderMaster.Id, OrderState = (int)State.Processing, ClientId = orderMaster.ClientId});
                        masterService.SaveChanges();
                        Debug.WriteLine("subbbbmit");
                    }
                    else if (buttonColumn.Name == "ShowBtn")
                    {
                        var orderDetails = detailService.GetAllDetailsOfMaster(orderMasterId);
                        DetailDataGrid.DataSource = orderDetails; // here it doesn't show the real quantity in the database
                        try
                        {

                            DetailDataGrid.Columns.Add(DeleteOrderDetailColumn);
                        }
                        catch
                        {

                        }
                        Debug.WriteLine("Shoowowww");
                    }
                    else if (buttonColumn.Name == "DeleteBtn")
                    {
                        //var iu = detailService.GetAllDetailsOfMaster(orderMasterId);
                        Debug.WriteLine("Deleteeee");
                    }
                }
                if (MasterDataGrid.Rows[e.RowIndex].DataBoundItem is GetAllOrderMasterDTO yesorder)
                {
                    //masterService.UpdateOrderMaster(mapper.Map<GetOneOrderMasterDTO>(yesorder));
                    //masterService.SaveChanges();
                    Debug.WriteLine(buttonColumn.Name);
                }

                //Debug.WriteLine(yesorder.Total);
                else Debug.WriteLine("nooooot order");
            }
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GetAllOrderMasterDTO> InCartMasters = masterService.GetAllOrderMasterOnState(State.OutForDelivery, activeUserId);
            bindingSource.DataSource = InCartMasters;
            MasterDataGrid.DataSource = bindingSource;
            MasterDataGrid.Columns[0].ReadOnly = true;
            MasterDataGrid.AllowUserToAddRows = false;
            MasterDataGrid.AllowUserToDeleteRows = false;
            if (MasterDataGrid.Columns.Count < 6)
            {
                MasterDataGrid.Columns.Add(ShowOrderDetailsColumn);
            }
            else if (MasterDataGrid.Columns.Count == 8)
            {
                MasterDataGrid.Columns.Remove("SubmitBtn");
                MasterDataGrid.Columns.Remove("DeleteBtn");
            }
        }

        private void processingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GetAllOrderMasterDTO> InCartMasters = masterService.GetAllOrderMasterOnState(State.Processing, activeUserId);
            bindingSource.DataSource = InCartMasters;
            MasterDataGrid.DataSource = bindingSource;
            MasterDataGrid.Columns[0].ReadOnly = true;
            MasterDataGrid.AllowUserToAddRows = false;
            MasterDataGrid.AllowUserToDeleteRows = false;
            if (MasterDataGrid.Columns.Count < 6)
            {
                MasterDataGrid.Columns.Add(ShowOrderDetailsColumn);
            }
            else if (MasterDataGrid.Columns.Count == 8)
            {
                MasterDataGrid.Columns.Remove("SubmitBtn");
                MasterDataGrid.Columns.Remove("DeleteBtn");
            }
        }

        private void DetailDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn && e.RowIndex >= 0)
            {
                var iii = senderGrid.Rows[e.RowIndex].Cells[0].Value;
                int orderMasterId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                if (MasterDataGrid.Rows[e.RowIndex].DataBoundItem is GetAllOrderMasterDTO orderMaster)
                {
                    if (buttonColumn.Name == "DeleteDetailBtn")
                    {
                        //detailService.DeleteOrderDetail()
                        Debug.WriteLine("delete detail");
                    }
                }
                if (MasterDataGrid.Rows[e.RowIndex].DataBoundItem is GetAllOrderMasterDTO yesorder)
                {
                    //masterService.UpdateOrderMaster(mapper.Map<GetOneOrderMasterDTO>(yesorder));
                    //masterService.SaveChanges();
                    Debug.WriteLine(buttonColumn.Name);
                }

                else Debug.WriteLine("not order");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeUserId = 0;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
