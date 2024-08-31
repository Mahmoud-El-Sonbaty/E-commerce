using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;

namespace MenStore.Infrastructure
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(StoreContext context) : base(context)
        {

        }
    }
}
