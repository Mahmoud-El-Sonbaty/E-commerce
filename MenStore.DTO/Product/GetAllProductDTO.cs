using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.Product
{
    public record GetAllProductDTO(int Id, string? Title, double? Price, int? CategoryId, string? CategoryName, int? UnitsInStock);

}
