using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.Product
{
    public record getAllProductDTO(int ProductId, string Title, double price , int categoryID);

}
