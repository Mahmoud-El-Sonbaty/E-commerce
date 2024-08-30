using MenStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace MenStore.Context
{
    public class StoreContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MenStore"].ConnectionString);



        public DbSet<OrderMaster> OrdersMaster { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }
        public DbSet<product> products { get; set; }
    }
}
