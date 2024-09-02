using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.OrderMaster
{
    public class CreateOrderMasterDTO
    {
        public double Total { get; set; }
        public int ClientId { get; set; }
        public DateTime? OrderDateTime = DateTime.Now;
        public int OrderState { get; set; }
    }
}
