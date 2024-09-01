using AutoMapper;
using MenStore.Application.Contracts;
using MenStore.DTO.OrderDetail;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.OrderDetailServices
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository orderDetailRepository;
        private readonly IMapper mapper;
        public OrderDetailService(IOrderDetailRepository _orderDetailRepository, IMapper _mapper)
        {
            orderDetailRepository = _orderDetailRepository;
            mapper = _mapper;
        }

        public GetOneOrderDetailDTO CreateOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                //if (orderDetail.Quantity <= orderDetail.Product.UnitsInStock)
                //{
                    return mapper.Map<GetOneOrderDetailDTO>(orderDetailRepository.Create(orderDetail));
                //}
            }
            return null;
        }

        public GetOneOrderDetailDTO UpdateOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                //if (orderDetail.Quantity <= orderDetail.Product.UnitsInStock)
                //{
                    return mapper.Map<GetOneOrderDetailDTO>(orderDetailRepository.Update(orderDetail));
                //}
            }
            return null;
        }

        public GetOneOrderDetailDTO DeleteOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                 return mapper.Map<GetOneOrderDetailDTO>(orderDetailRepository.Delete(orderDetail));
            }
            return null;
        }

        public List<GetAllOrderDetailDTO> GetAllDetailsOfMaster(int orderMasterId)
        {
            return orderDetailRepository.GetAll().Select(OD => mapper.Map<GetAllOrderDetailDTO>(OD.Id == orderMasterId)).ToList();
        }

        public GetOneOrderDetailDTO GetOneOrderDetail(int orderDetailId)
        {
            return mapper.Map<GetOneOrderDetailDTO>(orderDetailRepository.GetOne(orderDetailId));
        }
    }
}
