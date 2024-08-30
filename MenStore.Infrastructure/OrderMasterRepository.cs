using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;

namespace MenStore.Infrastructure
{
    public class OrderMasterRepository : IOrderMasterRepository
    {
        public StoreContext Context;
        public OrderMasterRepository(StoreContext _storeContext) => Context = _storeContext;
        public OrderMaster Create(OrderMaster entity)
        {
            return Context.OrdersMaster.Add(entity).Entity;
        }

        public OrderMaster Delete(OrderMaster entity)
        {
            return Context.OrdersMaster.Remove(entity).Entity;
        }

        public IQueryable<OrderMaster> GetAll()
        {
            return Context.OrdersMaster;
        }

        public OrderMaster GetOne(int entityId)
        {
            return Context.OrdersMaster.FirstOrDefault(O => O.Id == entityId);
        }

        public OrderMaster Update(OrderMaster entity)
        {
            return Context.OrdersMaster.Update(entity).Entity;
        }
    }
}
