using Catalog.Domain.Interfaces.Repositories;
using Catalog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.Repository.Repositories
{
    public sealed class ProductRepository : IProductRepository
    {
        private readonly DbSet<Product> dbSet;

        public ProductRepository(CatalogDbContext context) =>
            dbSet = context.Set<Product>();

        public async Task<IEnumerable<Product>> GetAll() =>
            await Task.Run(() => dbSet);

        public async Task<Product> GetById(Guid id) =>
            await dbSet.FindAsync(id);
    }
}
