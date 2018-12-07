using Catalog.Domain.Models;
using Catalog.Repository.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Catalog.Repository
{
    public sealed class CatalogDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public CatalogDbContext(IConfiguration configuration) => this.configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CatalogDb"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new ProductMap());

            modelBuilder.Entity<Customer>().HasData(
                Customer.CreateNew("João da Silva")
            );

            modelBuilder.Entity<Product>().HasData(
                Product.CreateNew("Notebook Avell G1513 FOX-5 BS", "Notebook Avell G1513 FOX-5 BS", 4799.70m),
                Product.CreateNew("Smartphone ASUS ZenFone 5Z 8GB/256GB Preto", "Smartphone ASUS ZenFone 5Z 8GB/256GB Preto", 3509.10m),
                Product.CreateNew("Console Xbox One X 1TB 4K+ Controle sem Fio", "Console Xbox One X 1TB 4K+ Controle sem Fio", 2540.19m),
                Product.CreateNew("Console Playstation 4 Pro 1tb - Ps4", "Console Playstation 4 Pro 1tb - Ps4", 2640.00m)
            );
        }
    }
}
