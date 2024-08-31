using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;

namespace MenStore.Infrastructure
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        //public OrderDetailRepository(StoreContext _storeContext) => Context = _storeContext; // doesn't the fat arrow means return? or the ctor is a special case
        public OrderDetailRepository(StoreContext _storeContext) : base(_storeContext)
        {

        }
    }
}
