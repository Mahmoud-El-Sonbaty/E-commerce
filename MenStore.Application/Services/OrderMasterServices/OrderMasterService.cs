using AutoMapper;
using MenStore.Application.Contracts;
using MenStore.DTO.OrderMaster;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.OrderMasterServices
{
    public class OrderMasterService : IOrderMasterService
    {
        private readonly IOrderMasterRepository orderMasterRepository;
        private readonly IMapper mapper;
        public OrderMasterService(IOrderMasterRepository _orderMasterRepository, IMapper _mapper)
        {
            orderMasterRepository = _orderMasterRepository;
            mapper = _mapper;
        }
        public GetOneOrderMasterDTO CreateOrderMaster(OrderMaster orderMaster)
        {
            return mapper.Map<GetOneOrderMasterDTO>(orderMasterRepository.Create(orderMaster));
        }

        public GetOneOrderMasterDTO UpdateOrderMaster(OrderMaster orderMaster)
        {
            if (orderMaster != null)
            {
                if (orderMaster.OrderState == State.Processing)
                {
                    //foreach (var OrderDetail in orderMaster.OrderDetails)
                    //{
                    //    OrderDetail.Product.UnitsInStock -= OrderDetail.Quantity;
                    //    // here we should call the product update function in the product service but howwwww????????????
                    //}
                }
                return mapper.Map<GetOneOrderMasterDTO>(orderMasterRepository.Update(orderMaster));
            }
            return null;
        }

        public GetOneOrderMasterDTO DeleteOrderMaster(OrderMaster orderMaster)
        {
            return mapper.Map<GetOneOrderMasterDTO>(orderMasterRepository.Delete(orderMaster));
        }

        public List<GetAllOrderMasterDTO> GetAllOrderMaster()
        {
            return orderMasterRepository.GetAll().Select(OM => mapper.Map<GetAllOrderMasterDTO>(OM)).ToList();
        }

        public List<GetAllOrderMasterDTO> GetAllOrderMasterOnState(State orderState)
            => orderMasterRepository.GetAll().Select(OM => mapper.Map<GetAllOrderMasterDTO>(OM.OrderState == orderState)).ToList();

        public GetOneOrderMasterDTO GetOneOrderMaster(int orderMasterId)
        {
            return mapper.Map<GetOneOrderMasterDTO>(orderMasterRepository.GetOne(orderMasterId));
        }

        public List<GetAllOrderMasterDTO> GetUserOrderMaster(int userId) => throw new NotImplementedException();
        //public List<GetAllOrderMasterDTO> GetUserOrderMaster(int userId)
        //    => orderMasterRepository.GetAll().Select(OM => OM.UserId == userId).ToList();
    }
}
