using Microsoft.EntityFrameworkCore;
using Orders.Domain.Interfaces.Repositories;
using Orders.Domain.Models;
using System.Collections.Generic;
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
    }
}
