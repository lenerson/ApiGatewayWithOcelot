using Catalog.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Catalog.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetById(Guid id);
    }
}
