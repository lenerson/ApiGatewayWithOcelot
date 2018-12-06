using Catalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(Guid id);
    }
}
