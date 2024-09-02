using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.Category
{
    //public record GetCategoryDTO(int Id, string Name);
    public class GetCategoryDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
