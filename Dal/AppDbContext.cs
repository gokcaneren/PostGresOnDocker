using Microsoft.EntityFrameworkCore;
using SimpleApi.Models;

namespace SimpleApi.Dal
{
    public class AppDbContext : DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
         {
            
         }

         public DbSet<Category> Categories { get; set; }
         public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("");


            base.OnConfiguring(optionsBuilder);
        }
    }
}