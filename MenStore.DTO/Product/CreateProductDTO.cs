using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.Product
{
    public record CreateProductDTO(string Title, int CategoryId, string Image, double Price, int UnitsInStock);
    //public class CreateProductDTO
    //{
    //    public string Title { get; set; }

    //    public int CategoryId { get; set; }

    //    public string Image { get; set; }

    //    public double Price { get; set; }

    //    public int? UnitsInStock { get; set; }
    //}
}
