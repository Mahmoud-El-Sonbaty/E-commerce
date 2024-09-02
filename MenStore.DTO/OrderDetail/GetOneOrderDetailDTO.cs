using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.OrderDetail
{
    public record GetOneOrderDetailDTO(int Id, int OrderMasterId, int ProductId, int Quantity);
}
