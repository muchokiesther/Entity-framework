
using UserDomain;
using Microsoft.EntityFrameworkCore;

namespace UserData
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
           public DbSet<Order> Orders { get; set; }
           public DbSet<Payment> Payments { get; set; }
           public DbSet<Cart> Carts { get; set; } 
             public DbSet<Shipment> Shipments { get; set; }
            public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-Q8FU87I\\SQLEXPRESS; database = KiShop; TrustServerCertificate = true; Trusted_Connection = true; user Id  = sa; password = wamuyu@2023 ");//connecting to my database
        }

    }
}
