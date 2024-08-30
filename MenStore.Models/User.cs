using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenStore.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [MaxLength(20)]
        public string? Name { get; set; }
        [MaxLength(11)]
        public string? PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
        public string? Address { get; set; }
    }
}
