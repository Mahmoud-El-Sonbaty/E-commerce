using MenStore.Application.Contracts;
using MenStore.Application.Mapper;
using MenStore.Models;
using MenStore.DTO.User;
using AutoMapper;

namespace MenStore.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IMapper mapper;
        public UserService(IUserRepository _userRepository)
        {
            _userRepository = _userRepository;
        }

        public GetOneUserDTO Login(CreateUserDTO user)
        {
            if (user.Username != null && user.Password != null)
            {
                User User = _userRepository.CheckUser(user.Username);
                if (User.Password == user.Password)
                {
                    return mapper.Map<GetOneUserDTO>(user);
                }
                //msg box wrong password
            }
            //msg box user doesn't exist
            return null;
        }

        public GetOneUserDTO Register(CreateUserDTO user)
        {
            if (user.Username != null && user.Password != null)
            {
                User mappedUser = mapper.Map<User>(user);
                // here we should encrypt the password before sending it
                //mappedUser.Password = Encrypt(user.Password);
                return mapper.Map<GetOneUserDTO>(_userRepository.Create(mappedUser));
            }
            return null;
        }
    }
}
