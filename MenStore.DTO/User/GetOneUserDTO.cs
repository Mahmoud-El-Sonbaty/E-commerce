using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.User
{
    public record GetOneUserDTO(int Id, string Username, string Password, string? FullName, string? PhoneNumber, string? Address, bool IsAdmin);
}
