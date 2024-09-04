using MenStore.Application.Contracts;
using MenStore.Application.Mapper;
using MenStore.Models;
using MenStore.DTO.User;
using AutoMapper;
using System.Text;
namespace MenStore.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        private IMapper mapper;

        public UserService(IUserRepository _userRepository, IMapper _mapper)
        {
            userRepository = _userRepository;
            mapper = _mapper;
        }

        public GetOneUserDTO Login(CheckUserDTO user)
        {
            if (user.Username != null && user.Password != null)
            {
                User User = userRepository.CheckUser(user.Username);
                if (User == null)
                {
                    // wrong USER
                }
                else if (User.Password == user.Password)
                {
                    return mapper.Map<GetOneUserDTO>(User);
                }
                // wrong password
            }
            return null;
        }

        public GetOneUserDTO Register(CreateUserDTO user)
        {
            if (user.Username != null && user.Password != null)
            {
                User mappedUser = mapper.Map<User>(user);
                // here we should encrypt the password before storing it in DB
                var Check = userRepository.CheckUser(user.Username);
                if (Check == null)
                {
                    return mapper.Map<GetOneUserDTO>(userRepository.Create(mappedUser));
                }
            }
            return null;
        }
    }
}
