using System;

namespace ApiGateway.WebApp.ViewModels
{
    public sealed class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        private ProductViewModel() { }

        public static ProductViewModel Create(Guid id, string name, decimal price) =>
            new ProductViewModel()
            {
                Id = id,
                Name = name,
                Price = price
            };
    }
}
