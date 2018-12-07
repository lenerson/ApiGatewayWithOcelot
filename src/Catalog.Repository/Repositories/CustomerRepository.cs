using Catalog.Domain.Interfaces.Repositories;
using Catalog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.Repository.Repositories
{
    public sealed class CustomerRepository : ICustomerRepository
    {
        private readonly DbSet<Customer> dbSet;

        public CustomerRepository(CatalogDbContext context) =>
            dbSet = context.Set<Customer>();

        public async Task<IEnumerable<Customer>> GetAll() =>
            await Task.Run(() => dbSet);

        public async Task<Customer> GetById(Guid id) =>
            await dbSet.FindAsync(id);
    }
}
