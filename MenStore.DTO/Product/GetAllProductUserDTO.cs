using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.Product
{

    public record GetAllProductUserDTO(int Id, string Title, double Price, string Image, int CategoryId, string CategoryName, int? UnitsInStock);


}