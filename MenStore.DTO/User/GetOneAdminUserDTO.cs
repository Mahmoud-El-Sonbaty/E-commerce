using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.DTO.User
{
    public record GetOneAdminUserDTO(int Id, string Username, string Password, string? FullName);

}
