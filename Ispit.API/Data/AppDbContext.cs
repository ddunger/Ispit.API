using Ispit.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ispit.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ShoppingItem> ShoppingItem { get; set; }

      
    }
}
