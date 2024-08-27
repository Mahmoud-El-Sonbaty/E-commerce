using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        //public int OrderMasterId => this.OrderMaster.Id;
        public int OrderMasterId { get; set; }
        public OrderMaster OrderMaster { get; set; }
        //public int ProductId { get; set; }
        //public Product Product { get; set; }
        //public double DetailPrice => Product.Price * this.Quantity;
    }
}
