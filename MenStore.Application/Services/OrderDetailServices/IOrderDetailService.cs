using MenStore.DTO.OrderDetail;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.OrderDetailServices
{
    public interface IOrderDetailService
    {
        public GetOneOrderDetailDTO CreateOrderDetail(OrderDetail orderDetail);
        public GetOneOrderDetailDTO UpdateOrderDetail(OrderDetail orderDetail);
        public GetOneOrderDetailDTO DeleteOrderDetail(OrderDetail orderDetail);
        public List<GetAllOrderDetailDTO> GetAllDetailsOfMaster(int orderMasterId);
        public GetOneOrderDetailDTO GetOneOrderDetail(int orderDetailId);
    }
}
