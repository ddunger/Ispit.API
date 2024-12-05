using Ispit.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ispit.API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Item> ShoppingItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ShoppingDb;Integrated Security = True;TrustServerCertificate = True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
