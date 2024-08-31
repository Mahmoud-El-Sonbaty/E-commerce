using AutoMapper;
using MenStore.Application.Contracts;
using MenStore.DTO.Product;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;
        private IMapper mapper;

        public ProductService (IProductRepository _repository, IMapper _mapper)
        {
            productRepository = _repository;
            this.mapper = _mapper;
        }

        public GetOneProductDTO AddProduct(CreateProductDTO productDto)
        {
            var product1 = mapper.Map<Product>(productDto);
            if (productDto != null && productDto.UnitsInStock > 10)
            {
                Product p = productRepository.Create(product1);
                return mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }

        public GetOneProductDTO UpdateProduct(Product productDto)
        {
            var product1 = mapper.Map<Product>(productDto);
            if (productDto != null)
            {
                Product p = productRepository.Update(product1);
                return mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }

        public GetOneProductDTO DeleteProduct(Product productDto)
        {
            var product1 = mapper.Map<Product>(productDto);
            if (productDto != null)
            {
                Product p = productRepository.Delete(product1);
                return mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }

        //public List<GetAllProductDTO> GetAllPagination(int count, int pageNumber)
        //{
        //    var products = productRepository.GetAll().Skip(count * (pageNumber - 1)).Take(count)
        //        .Select(b => new GetAllProductDTO(b.Id, b.Title, b.Price, b.CategoryId)).ToList();
        //    return products;
        //}

        public List<GetAllProductDTO> GetAllPagination(int count, int pageNumber, int categoryID)
        {
            var products = productRepository.GetAll().Where(s => s.CategoryId == categoryID).Skip(count * (pageNumber - 1)).Take(count)
                .Select(b => new GetAllProductDTO(b.Id, b.Title, b.Price, b.CategoryId, b.Category.Name, b.UnitsInStock)).ToList();
            return products;
        }

        public GetOneProductDTO GetoneOfProduct(int id)
        {
            var products = productRepository.GetOne(id);

            return mapper.Map<GetOneProductDTO>(products);
        }

        public List<GetAllProductDTO> ProductsOfCategory(int categoryId)
        {
            var products = productRepository.GetAll().Where(s => s.CategoryId == categoryId)
                .Select(b => new GetAllProductDTO(b.Id, b.Title, b.Price, b.CategoryId, b.Category.Name, b.UnitsInStock)).ToList();

            return products;
        }
    }
}
