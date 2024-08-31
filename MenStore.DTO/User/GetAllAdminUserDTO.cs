using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.User
{
    public record GetAllAdminUserDTO(int Id, string Username, string? FullName);
}
