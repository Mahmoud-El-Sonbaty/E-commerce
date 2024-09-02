using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.OrderDetail
{
    //public record GetAllOrderDetailDTO(int Id, string ProductName, double DetailPrice);
    public class GetAllOrderDetailDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
