using MenStore.DTO.Product;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.ProductServices
{
    public interface IProductService
    {
        public GetOneProductDTO AddProduct(CreateProductDTO productDto);

        public GetOneProductDTO UpdateProduct(GetAllProductDTO productDto);
        //public GetOneProductDTO UpdateProduct(Product productDto);

        public GetOneProductDTO DeleteProduct(GetAllProductDTO productDto);

        //public List<GetAllProductDTO> GetAllPagination(int count, int pageNumber);

        public List<GetAllProductDTO> GetAllPagination(int count, int pageNumber, int categoryID);

        public GetOneProductDTO GetoneOfProduct(int id);

        public List<GetAllProductDTO> ProductsOfCategory(int categoryId);
        public List<GetAllProductDTO> search(string key);  
        public int SaveChanges();  


    }
}
