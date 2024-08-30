using MenStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace MenStore.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<OrderMaster> OrdersMaster { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MenStore"].ConnectionString);
    }
}
