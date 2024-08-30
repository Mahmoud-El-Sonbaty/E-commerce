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
    public class ProductRepository :  Genericrepository<product>, IProductRepository
    {
        private readonly StoreContext context;
        public ProductRepository(StoreContext context):base(context)
        {
            this.context = context;
        }

        public IQueryable<product> productsOfCategory(int categoryId)
        {

            var products = context.products.Where(b=>b.categoryID==categoryId);
            return products;
        }
    }
}
