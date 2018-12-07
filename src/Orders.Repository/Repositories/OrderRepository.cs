using Microsoft.EntityFrameworkCore;
using Orders.Domain.Interfaces.Repositories;
using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Repository.Repositories
{
    public sealed class OrderRepository : IOrderRepository
    {
        private readonly DbSet<Order> dbSet;

        public OrderRepository(OrdersDbContext context) =>
            dbSet = context.Set<Order>();

        public async Task<IEnumerable<Order>> GetAll() =>
            await Task.Run(() => dbSet.Include(x => x.Products));

        public async Task<IEnumerable<Order>> GetByCustomerId(Guid customerId) =>
            await Task.Run(() => dbSet.Where(x => x.CustomerId == customerId).Include(x => x.Products));
    }
}
