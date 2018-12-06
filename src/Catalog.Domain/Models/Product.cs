using System;

namespace Catalog.Domain.Models
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        protected Product() { }

        public static Product CreateNew(string name, string description, decimal price) =>
            new Product
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                Price = price
            };

        public static Product CreateExisting(Guid id, string name, string description, decimal price) =>
            new Product
            {
                Id = id,
                Name = name,
                Description = description,
                Price = price
            };
    }
}
