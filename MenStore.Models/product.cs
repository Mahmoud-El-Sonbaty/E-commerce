using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Models
{
    public class product
    {

        public int Id { get; set; } 
        [MaxLength(30)]

        public string Title { get; set; }

        //[MaxLength(30)]
        public string category { get; set; }
        [Url]

        public string Image {  get; set; }
        [ForeignKey("id")]

        public int categoryID { get; set; }
        public double price { get; set; }
        [AllowNull]
        public int? UnitsInStock { get; set; }

 //  public ICollection<ProductUser>? ProductUser { get; set; }
     
    }
}
