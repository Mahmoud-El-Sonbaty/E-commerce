using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Models
{
    public class OrderMaster
    {
        public int Id { get; set; }
        public double Total { get; set; }
        //public int ClientId { get; set; }
        //public User Client { get; set; }
        public DateTime? OrderDateTime { get; set; }
        public State OrderState { get; set; }

    }
}
