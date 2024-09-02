using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.OrderMaster
{
    public class UpdateOrderMasterDTO
    {
        public double Total { get; set; }
        public int ClientId { get; set; }
        public int OrderState { get; set; }
    }
}
