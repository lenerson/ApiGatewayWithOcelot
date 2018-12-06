using Orders.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orders.Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
    }
}
