using MenStore.DTO.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.CategoryServices
{
    public interface ICategoryService
    {
        public GetCategoryDTO CreateCategory(CreateCategoryDTO category);
        public GetCategoryDTO UpdateCategory(CreateCategoryDTO category);
        public GetCategoryDTO DeleteCategory(CreateCategoryDTO category);
        public GetCategoryDTO GetOneCategory(int categoryId);
        public List<GetCategoryDTO> GetAllCategory();
    }
}
