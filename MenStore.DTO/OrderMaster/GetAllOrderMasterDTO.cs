using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.OrderMaster
{
    public record GetAllOrderMasterDTO(int Id, double Total, string ClientName, DateTime OrderDateTime, string OrderState);
}
