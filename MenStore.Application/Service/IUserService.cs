using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Service
{
    public interface IUserService
    {
        public User Register(User user);
        public User Login(User user);
    }
}
