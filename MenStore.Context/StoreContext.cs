using MenStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace MenStore.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderMaster> OrdersMaster { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-G3N1PK3\\SQLEXPRESS;Initial Catalog=MenStore;Integrated Security=True;Encrypt=False;");
            //=> optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=DESKTOP-G3N1PK3\\SQLEXPRESS;Initial Catalog=MenStore;Integrated Security=True;Encrypt=False;");
            //=> optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MenStore"].ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(buildAction =>
            {
                buildAction.HasAlternateKey(U => U.Username).HasName("AlternateKey_Username");
            });
        }
    }
}
