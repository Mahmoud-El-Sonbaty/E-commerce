using MenStore.Application.Contracts;
using MenStore.Application.Mapper;
using MenStore.Models;
using MenStore.DTO.User;
using AutoMapper;

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
                    //msg box wrong USER
                }
                else if (User.Password == user.Password)
                {
                    return mapper.Map<GetOneUserDTO>(User);
                }
                //msg box wrong password
                
            }
            return null;
        }

        public GetOneUserDTO Register(CreateUserDTO user)
        {
            if (user.Username != null && user.Password != null)
            {
                User mappedUser = mapper.Map<User>(user);
                // here we should encrypt the password before sending it
                //mappedUser.Password = Encrypt(user.Password);
                var Check = userRepository.CheckUser(user.Username);
                if (Check == null)
                {
                    return mapper.Map<GetOneUserDTO>(userRepository.Create(mappedUser));
                }
                //message box user already exisit
            }
            return null;
        }
    }
}