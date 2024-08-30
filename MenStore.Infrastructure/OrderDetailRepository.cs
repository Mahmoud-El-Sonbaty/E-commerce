using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;
namespace MenStore.Infrastructure
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public StoreContext Context;
        public OrderDetailRepository(StoreContext _storeContext) => Context = _storeContext; // doesn't the fat arrow means return? or the ctor is a special case
        public OrderDetail Create(OrderDetail entity)
        {
            return Context.OrdersDetail.Add(entity).Entity;
        }

        public OrderDetail Delete(OrderDetail entity)
        {
            return Context.OrdersDetail.Remove(entity).Entity;
        }

        public IQueryable<OrderDetail> GetAll()
        {
            return Context.OrdersDetail;
        }

        public OrderDetail GetOne(int entityId)
        {
            return Context.OrdersDetail.FirstOrDefault(D => D.Id == entityId);
        }

        public OrderDetail Update(OrderDetail entity)
        {
            return Context.OrdersDetail.Update(entity).Entity;
        }
    }
}
