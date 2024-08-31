using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Infrastructure
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(StoreContext context) : base(context)
        {

        }
    }
}
