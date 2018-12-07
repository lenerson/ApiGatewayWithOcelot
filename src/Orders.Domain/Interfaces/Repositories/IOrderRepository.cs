using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orders.Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task<IEnumerable<Order>> GetByCustomerId(Guid customerId);
    }
}
