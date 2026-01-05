using Microsoft.EntityFrameworkCore;
using Skoppers.Models.Product;

namespace Skoppers.Data
{
    public class ShoppersDBcontext : DbContext
    {
        public ShoppersDBcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}
