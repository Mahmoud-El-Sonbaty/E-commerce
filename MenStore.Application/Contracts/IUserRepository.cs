using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenStore.Models;
namespace MenStore.Application.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public User CheckUser(string username);
    }
}
