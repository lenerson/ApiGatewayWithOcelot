using System;
using System.Collections.Generic;

namespace Orders.Api.ViewModels
{
    public sealed class OrderViewModel
    {
        public Guid Id { get; private set; }
        public ICollection<ProductViewModel> Products { get; } = new List<ProductViewModel>();

        private OrderViewModel AddProducts(IEnumerable<Guid> productIds)
        {
            foreach (var productId in productIds)
                Products.Add(ProductViewModel.Create(productId));
            return this;
        }
        public static OrderViewModel Create(IEnumerable<Guid> productIds) =>
            new OrderViewModel
            {
                Id = Guid.NewGuid()
            }.AddProducts(productIds);
    }
}
