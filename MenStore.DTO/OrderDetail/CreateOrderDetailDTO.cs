using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.OrderDetail
{
    public record CreateOrderDetailDTO(int OrderMasterId, int ProductId, int Quantity, double DetailPrice);
    //public class CreateOrderDetailDTO
    //{

    //}
}
