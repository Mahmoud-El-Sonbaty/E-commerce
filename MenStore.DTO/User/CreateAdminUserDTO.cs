using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.User
{
    public record CreateAdminUserDTO(string Username, string Password, string? FullName, bool IsAdmin = true);
}
