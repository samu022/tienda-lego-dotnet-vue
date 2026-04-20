using Microsoft.EntityFrameworkCore;
using Proyecto_Tienda_Lego.Models;

namespace Proyecto_Tienda_Lego.DataAccess
{
    public class LegoDBContext: DbContext
    {
        public LegoDBContext(DbContextOptions<LegoDBContext> options ):base(options) { }
        public DbSet<CartItems>? CartItems { get; set; }
        public DbSet<Categories>? Categories { get; set; }
        public DbSet<OrderDetails>?  OrderDetails { get; set; }
        public DbSet<Orders>? Orders { get; set; }
        public DbSet<Products>? Products { get; set; }
        public DbSet<Roles>? Roles { get; set; }
        public DbSet<Users>? Users { get; set; }



    }
}
