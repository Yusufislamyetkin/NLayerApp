using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Entity;
using System.Reflection;

namespace NLayerApp.Repository.Context
{
    public class AppDbContext : DbContext
    {
  
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product>  products { get; set; }
        public DbSet<ProductFeature>  productFeatures { get; set; }
        public DbSet<Category>  categories { get; set; }
       

    }
}
