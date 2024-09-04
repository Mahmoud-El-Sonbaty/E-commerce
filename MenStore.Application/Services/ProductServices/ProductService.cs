using AutoMapper;
using MenStore.Application.Contracts;
using MenStore.DTO.Product;
using MenStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;
        private IMapper mapper;

        public ProductService(IProductRepository _repository, IMapper _mapper)
        {
            productRepository = _repository;
            this.mapper = _mapper;
        }

        public GetOneProductDTO AddProduct(CreateProductDTO productDto)
        {
            var product1 = mapper.Map<Product>(productDto);
            if (productDto != null && productDto.UnitsInStock > 0)
            {
                Product p = productRepository.Create(product1);
                Debug.WriteLine(p.CategoryId);
                return mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }

        public GetOneProductDTO UpdateProduct(GetAllProductDTO productDto)
        {
            var product1 = mapper.Map<Product>(productDto);
            if (productDto != null)
            {
                Product p = productRepository.Update(product1);
                return mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }

        public GetOneProductDTO DeleteProduct(GetAllProductDTO productDto)
        {
            var product1 = mapper.Map<Product>(productDto);
            if (productDto != null)
            {
                Product p = productRepository.Delete(product1);
                return mapper.Map<GetOneProductDTO>(p);
            }
            return null;
        }

        public List<GetAllProductDTO> GetAllPagination(int count, int pageNumber, int categoryID)
        {
            List<GetAllProductDTO> products;
            if (categoryID == -1)
            {
                products = productRepository.GetAll().Skip(count * (pageNumber - 1)).Take(count)
                    .Select(b => new GetAllProductDTO(b.Id, b.Title, b.Price, b.CategoryId, b.Category.Name, b.UnitsInStock)).ToList();
            }
            else
            {
                products = productRepository.GetAll().Where(s => s.CategoryId == categoryID).Skip(count * (pageNumber - 1)).Take(count)
                   .Select(b => new GetAllProductDTO(b.Id, b.Title, b.Price, b.CategoryId, b.Category.Name, b.UnitsInStock)).ToList();
            }
            return products;
        }

        public List<GetAllProductUserDTO> GetAllPaginationUser(int count, int pageNumber, int categoryID)
        {
            List<GetAllProductUserDTO> products;
            if (categoryID == -1)
            {
                products = productRepository.GetAll().Skip(count * (pageNumber - 1)).Take(count)
                    .Select(b => new GetAllProductUserDTO(b.Id, b.Title, b.Price, b.Image, b.CategoryId, b.Category.Name, b.UnitsInStock)).ToList();
            }
            else
            {
                products = productRepository.GetAll().Where(s => s.CategoryId == categoryID).Skip(count * (pageNumber - 1)).Take(count)
                   .Select(b => new GetAllProductUserDTO(b.Id, b.Title, b.Price, b.Image, b.CategoryId, b.Category.Name, b.UnitsInStock)).ToList();
            }
            return products;
        }

        public GetOneProductDTO GetoneOfProduct(int id)
        {// here get one uses find which cannot be set as no tracking so i had to use getall the firstordefault
            //var products = productRepository.GetOne(id);
            var products = productRepository.GetAll().AsNoTracking().FirstOrDefault(P => P.Id == id);
            return mapper.Map<GetOneProductDTO>(products);
        }

        public List<GetAllProductDTO> search(string key)
        {
            var products = productRepository.GetAll().Where(b => b.Title.Contains(key))
                .Select(b => new GetAllProductDTO(b.Id, b.Title, b.Price, b.CategoryId, b.Category.Name, b.UnitsInStock))
                .ToList();
            return products;
        }

        public List<GetAllProductUserDTO> searchUser(string key)
        {
            var products = productRepository.GetAll().Where(b => b.Title.Contains(key))
                .Select(b => new GetAllProductUserDTO(b.Id, b.Title, b.Price, b.Image, b.CategoryId, b.Category.Name, b.UnitsInStock))
                .ToList();
            return products;
        }

        public List<GetAllProductDTO> ProductsOfCategory(int categoryId)
        {
            var products = productRepository.GetAll().Where(s => s.CategoryId == categoryId)
                .Select(b => new GetAllProductDTO(b.Id, b.Title, b.Price, b.CategoryId, b.Category.Name, b.UnitsInStock)).ToList();
            return products;
        }

        public int SaveChanges()
        {
            return productRepository.SaveChanges();
        }
    }
}