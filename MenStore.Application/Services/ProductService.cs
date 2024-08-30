using AutoMapper;
using MenStore.Application.Contracts;
using MenStore.DTO.Product;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services
{
    public class ProductService:IProductService
    {
        private IProductRepository _repository;
        private IMapper _mapper;

        public ProductService(IProductRepository repository ,IMapper mapper )
        {
            _repository = repository;
               _mapper=mapper;
        }
        public GetOneProductDTO AddProduct(createProductDTO productDto)
        {
           var product1= _mapper.Map<product>(productDto);
            if (productDto != null && productDto.quantity > 10)
            {
                product p = _repository.Create(product1);
                return _mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }     
        public GetOneProductDTO UpdateProduct(product productDto)
        {
           var product1= _mapper.Map<product>(productDto);
            if (productDto != null )
            {
                product p = _repository.Update(product1);
                return _mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }   
        public GetOneProductDTO DeleteProduct(product productDto)
        {
           var product1= _mapper.Map<product>(productDto);
            if (productDto != null )
            {
                product p = _repository.Delete(product1);
                return _mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }
        public List<getAllProductDTO> GetAllPagination(int count , int pageNumber)
        {
            var products = _repository.GetAll().Skip(count * (pageNumber - 1)).Take(count)
                .Select(b => new getAllProductDTO(b.Id, b.Title, b.price, b.categoryID)).ToList();

            return products;
        }
        public List<getAllProductDTO> GetAllPagination(int count, int pageNumber, int categoryID)
        {
            var products = _repository.GetAll().Where(s => s.categoryID == categoryID).Skip(count * (pageNumber - 1)).Take(count)
                .Select(b => new getAllProductDTO(b.Id, b.Title, b.price,b.categoryID)).ToList();

            return products;
        }
        public GetOneProductDTO GetoneOfProduct(int id)
        {
            var products = _repository.GetOne(id);

            return _mapper.Map<GetOneProductDTO>(products);
        }     
        
        //public List<getAllProductDTO> productsOfCategory(int categoryId)
        //{
        //    var products = _repository.productsOfCategory(categoryId).Where(s => s.categoryID == categoryId)
        //        .Select(b => new getAllProductDTO(b.Id, b.Title, b.price, b.categoryID)).ToList();

        //    return products;
        //}

           public   IQueryable<getAllProductDTO>productsOfCategory(int categoryId)
        {
            var products = _repository.productsOfCategory(categoryId).Where(s => s.categoryID == categoryId)
               .Select(b => new getAllProductDTO(b.Id, b.Title, b.price, b.categoryID));
            return products;
        }
    }
}
     