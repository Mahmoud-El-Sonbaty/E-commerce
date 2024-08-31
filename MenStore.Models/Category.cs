using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MenStore.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }
    }
}
