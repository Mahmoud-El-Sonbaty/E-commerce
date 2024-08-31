using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;

namespace MenStore.Infrastructure
{
    public class OrderMasterRepository : GenericRepository<OrderMaster>, IOrderMasterRepository
    {
        public OrderMasterRepository(StoreContext _storeContext) : base(_storeContext)
        { 

        }
    }
}
