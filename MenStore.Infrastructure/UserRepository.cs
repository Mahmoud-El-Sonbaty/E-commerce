using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Infrastructure
{
    public class UserRepository : Genericrepository<User>, IUserRepository
    {
        public UserRepository(StoreContext storeContext) : base(storeContext)
        {
        }



        public User CheckUser(User Obj)
        {
            return context.Users.FirstOrDefault(u => u.UserName == Obj.UserName);
        }
    }
}
