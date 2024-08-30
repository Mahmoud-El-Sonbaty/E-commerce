using MenStore.DTO.Product;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services
{
    public interface IProductService
    {
        public GetOneProductDTO AddProduct(createProductDTO productDto);
        public GetOneProductDTO UpdateProduct(product productDto);
        public GetOneProductDTO DeleteProduct(product productDto);

        public List<getAllProductDTO> GetAllPagination(int count, int pageNumber);

        public List<getAllProductDTO> GetAllPagination(int count, int pageNumber, int categoryID);


        public GetOneProductDTO GetoneOfProduct(int id);
        public IQueryable<getAllProductDTO> productsOfCategory(int categoryId);

    }
}
