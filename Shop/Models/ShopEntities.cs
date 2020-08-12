using System.Data.Entity;

namespace Shop.Models
{
    public class ShopEntities : DbContext
    {
        public DbSet<Clothing> Clothes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}