using System;

namespace Catalog.Api.ViewModels
{
    public sealed class ProductViewModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public static ProductViewModel Create(Guid id, string name, decimal price) =>
            new ProductViewModel
            {
                Id = id,
                Name = name,
                Price = price
            };
    }
}
