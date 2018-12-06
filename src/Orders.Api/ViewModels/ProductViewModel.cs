using System;

namespace Orders.Api.ViewModels
{
    public sealed class ProductViewModel
    {
        public Guid Id { get; private set; }

        public static ProductViewModel Create(Guid id) =>
            new ProductViewModel { Id = id };
    }
}
