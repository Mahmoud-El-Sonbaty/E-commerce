using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;

namespace MenStore.Infrastructure
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(StoreContext storeContext) : base(storeContext)
        {

        }

        public User CheckUser(string username)
        {
            return context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
