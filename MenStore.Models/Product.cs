using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MenStore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        [Url]
        public string Image { get; set; }

        [ForeignKey("id")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        
        public double Price { get; set; }
        
        public int? UnitsInStock { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
