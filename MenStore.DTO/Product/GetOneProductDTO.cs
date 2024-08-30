using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MenStore.DTO.Product
{
  
    public record GetOneProductDTO(int Id, string Title,string Image , double price, int categoryID,string CatergoryName);

}
