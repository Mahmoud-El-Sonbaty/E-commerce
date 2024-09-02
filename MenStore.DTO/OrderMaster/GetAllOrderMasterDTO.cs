using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.OrderMaster
{
    //public record GetAllOrderMasterDTO(int Id, double Total, string ClientName, DateTime OrderDateTime, string OrderState);
    //System.ArgumentException:
    //'MenStore.DTO.OrderMaster.GetAllOrderMasterDTO needs to have a constructor with 0 args or only
    //optional args. Validate your configuration for details
    public record GetAllOrderMasterDTO
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int ClientId { get; set; }
        //public string ClientName { get; set; }
        public DateTime? OrderDateTime { get; set; } = DateTime.Now;
        public int OrderState { get; set; }
    }
}
