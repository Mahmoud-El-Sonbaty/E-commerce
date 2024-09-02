using MenStore.DTO.User;
using MenStore.Models;

namespace MenStore.Application.Services.UserServices
{
    public interface IUserService
    {
        public GetOneUserDTO Login(CheckUserDTO user);
        public GetOneUserDTO Register(CreateUserDTO user);
    }
}
