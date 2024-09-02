using AutoMapper;
using MenStore.Application.Contracts;
using MenStore.DTO.Category;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        public readonly ICategoryRepository categoryRepository;
        public readonly IMapper mapper;
        public CategoryService(ICategoryRepository _categoryRepository, IMapper _mapper)
        {
            categoryRepository = _categoryRepository;
            mapper = _mapper;
        }

        public GetCategoryDTO CreateCategory(CreateCategoryDTO category)
        {
            if (category.Name.Length < 30)
            {
                Category mappedCategory = mapper.Map<Category>(category);
                Category createdCategory = categoryRepository.Create(mappedCategory);
                //icategoryRepository.SaveChanges();
                return mapper.Map<GetCategoryDTO>(createdCategory);
            }
            return null;
        }

        public GetCategoryDTO UpdateCategory(CreateCategoryDTO category)
        {
            if (category != null && category.Name.Length < 30)
                return mapper.Map<GetCategoryDTO>(categoryRepository.Update(mapper.Map<Category>(category)));
            return null;
        }

        public GetCategoryDTO DeleteCategory(CreateCategoryDTO category)
        {
            if (category != null)
                return mapper.Map<GetCategoryDTO>(categoryRepository.Delete(mapper.Map<Category>(category)));
            return null;
        }

        public List<GetCategoryDTO> GetAllCategory()
        {
            return categoryRepository.GetAll().Select(C => new GetCategoryDTO() { Id = C.Id, Name = C.Name}).ToList();
        }

        public GetCategoryDTO GetOneCategory(int categoryId)
        {
            if (categoryId > 0)
                return mapper.Map<GetCategoryDTO>(categoryRepository.GetOne(categoryId));
            return null;
        }
    }
}
