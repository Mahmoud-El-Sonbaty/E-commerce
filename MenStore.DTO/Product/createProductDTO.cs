using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.Product
{
    public class createProductDTO
    {

        public string Title { get; set; }

        public string category { get; set; }
        public int categoryID { get; set; }


        public string Image { get; set; }
        public double price { get; set; }
        public int? quantity { get; set; }

    }

}
