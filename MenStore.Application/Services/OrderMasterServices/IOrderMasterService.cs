using MenStore.DTO.OrderMaster;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Services.OrderMasterServices
{
    public interface IOrderMasterService
    {
        public GetOneOrderMasterDTO CreateOrderMaster(CreateOrderMasterDTO orderMaster);
        public GetOneOrderMasterDTO UpdateOrderMaster(GetOneOrderMasterDTO orderMaster);
        public GetOneOrderMasterDTO DeleteOrderMaster(GetOneOrderMasterDTO orderMaster);
        public GetOneOrderMasterDTO GetOneOrderMaster(int orderMasterId);
        public List<GetAllOrderMasterDTO> GetUserOrderMaster(int userId);
        public List<GetAllOrderMasterDTO> GetAllOrderMaster();
        public List<GetAllOrderMasterDTO> GetAllOrderMasterAdminState(State state);
        public List<GetAllOrderMasterDTO> GetAllOrderMasterOnState(State state, int clientId);
        public int SaveChanges();
    }
}
