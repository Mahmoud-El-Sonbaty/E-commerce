using AutoMapper;
using MenStore.Application.Contracts;
using MenStore.DTO.OrderDetail;
using MenStore.Models;
using Microsoft.EntityFrameworkCore;
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

        public GetOneOrderDetailDTO CreateOrderDetail(CreateOrderDetailDTO orderDetail)
        {
            if (orderDetail != null)
            {
                //if (orderDetail.Quantity <= orderDetail.Product.UnitsInStock)
                //{
                var hh = mapper.Map<OrderDetail>(orderDetail);
                var tt = orderDetailRepository.Create(hh);
                    return mapper.Map<GetOneOrderDetailDTO>(tt);
                //}
            }
            return null;
        }

        public GetOneOrderDetailDTO UpdateOrderDetail(GetOneOrderDetailDTO orderDetail)
        {
            if (orderDetail != null)
            {
                //if (orderDetail.Quantity <= orderDetail.Product.UnitsInStock)
                //{
                    return mapper.Map<GetOneOrderDetailDTO>(orderDetailRepository.Update(mapper.Map<OrderDetail>(orderDetail)));
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
            return orderDetailRepository.GetAll().Where(OD => OD.Id == orderMasterId)
                .Select(OD => mapper.Map<GetAllOrderDetailDTO>(OD)).ToList();
        }

        public GetOneOrderDetailDTO GetOneOrderDetail(int orderDetailId)
        {
            return mapper.Map<GetOneOrderDetailDTO>(orderDetailRepository.GetOne(orderDetailId));
        }

        public GetOneOrderDetailDTO GetOneOrderDetailByProduct(int masterId, int productId)
        {
            OrderDetail checkOrderDetail = orderDetailRepository.GetAll().AsNoTracking()
                .FirstOrDefault(OD => OD.OrderMasterId == masterId && OD.ProductId == productId);
            return mapper.Map<GetOneOrderDetailDTO>(checkOrderDetail);
        }
        public int SaveChanges()
        {
           return orderDetailRepository.SaveChanges();
        }
    }
}
