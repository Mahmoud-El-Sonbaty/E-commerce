using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; }

        [MaxLength(20)]
        public string? FullName { get; set; }

        [MaxLength(11)]
        public string? PhoneNumber { get; set; }

        public bool IsAdmin { get; set; } = false;

        [MaxLength(256)]
        public string? Address { get; set; }
    }
}
