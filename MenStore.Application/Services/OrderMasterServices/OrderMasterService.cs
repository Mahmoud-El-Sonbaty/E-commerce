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
using Microsoft.EntityFrameworkCore;
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

        public GetOneOrderMasterDTO CreateOrderMaster(CreateOrderMasterDTO orderMaster)
        {
            var hh = mapper.Map<OrderMaster>(orderMaster);
            var ii = orderMasterRepository.Create(hh);
            return mapper.Map<GetOneOrderMasterDTO>(ii);
        }

        public GetOneOrderMasterDTO UpdateOrderMaster(GetOneOrderMasterDTO orderMaster)
        {
            if (orderMaster != null)
            {
                if (orderMaster.OrderState == (int)State.Processing)
                {
                    //foreach (var OrderDetail in orderMaster.OrderDetails)
                    //{
                    //    OrderDetail.Product.UnitsInStock -= OrderDetail.Quantity;
                    //    // here we should call the product update function in the product service but howwwww????????????
                    //}
                }
                return mapper.Map<GetOneOrderMasterDTO>(orderMasterRepository.Update(mapper.Map<OrderMaster>(orderMaster)));
            }
            return null;
        }

        public GetOneOrderMasterDTO DeleteOrderMaster(GetOneOrderMasterDTO orderMaster)
        {
            return mapper.Map<GetOneOrderMasterDTO>(orderMasterRepository.Delete(mapper.Map<OrderMaster>(orderMaster)));
        }

        public List<GetAllOrderMasterDTO> GetAllOrderMaster()
        {
            IQueryable<OrderMaster> orderMasterQuery = orderMasterRepository.GetAll();
            //i want to return iii including the user.Name 
            return orderMasterRepository.GetAll()
                .Select(OM => new GetAllOrderMasterDTO() { Id = OM.Id, ClientId = OM.ClientId,/* ClientName = OM.Client.FullName,*/ Total = OM.Total, OrderDateTime = OM.OrderDateTime, OrderState = (int)OM.OrderState })
                .ToList(); // whyyyyyyyyyy????
            //return orderMasterRepository.GetAll().Select(OM => mapper.Map<GetAllOrderMasterDTO>(OM)).ToList();
        }

        public List<GetAllOrderMasterDTO> GetAllOrderMasterOnState(State orderState, int clientId)
            => orderMasterRepository.GetAll().AsNoTracking().Where(O => O.OrderState == orderState && O.ClientId == clientId)
                .Select(OM => mapper.Map<GetAllOrderMasterDTO>(OM)).ToList();

        public GetOneOrderMasterDTO GetOneOrderMaster(int orderMasterId)
        {
            return mapper.Map<GetOneOrderMasterDTO>(orderMasterRepository.GetOne(orderMasterId));
        }

        //public List<GetAllOrderMasterDTO> GetUserOrderMaster(int userId) => throw new NotImplementedException();
        public List<GetAllOrderMasterDTO> GetUserOrderMaster(int userId)
        => orderMasterRepository.GetAll().Where(OM => OM.ClientId == userId).Select(OM => mapper.Map<GetAllOrderMasterDTO>(OM)).ToList();

        public int SaveChanges() => orderMasterRepository.SaveChanges();
    }
}
