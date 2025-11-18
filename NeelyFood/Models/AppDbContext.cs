using System.Data.Entity;

namespace NeelyFood.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=NeelyFoodDb") // اسم الاتصال بالـ DB
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
