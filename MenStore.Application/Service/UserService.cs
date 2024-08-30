using MenStore.Application.Contracts;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Service
{
    public class UserService:IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userService)
        {
            _userRepository = userService;
        }
      

        public User Login(User user)
        {
            if (user.UserName != null && user.Password != null)
            {
                var User = _userRepository.CheckUser(user);
                if (User.UserName == user.UserName && User.Password == user.Password)
                {
                    return user;
                }
                return null;
            }
            return user;
        }

        public User Register(User user)
        {
            if (user.UserName!=null && user.Password!=null&&user.Name!=null&&user.PhoneNumber != null && user.Address != null)
            {
                _userRepository.Create(user);
            }
            return user;
        }
    }
}
