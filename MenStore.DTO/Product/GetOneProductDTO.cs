using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.Product
{
    public record GetOneProductDTO(int Id, string Title, string Image, double Price, int CategoryID, string CategoryName, int? UnitsInStock);
}
