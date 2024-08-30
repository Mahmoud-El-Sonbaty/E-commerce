using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Contracts
{
    public interface IProductRepository:IGenericRepository<product>
    {
        public  IQueryable<product> productsOfCategory(int categoryId);

    }
}
