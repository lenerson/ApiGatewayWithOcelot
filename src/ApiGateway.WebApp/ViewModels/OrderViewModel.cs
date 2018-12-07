using System;
using System.Collections.Generic;

namespace ApiGateway.WebApp.ViewModels
{
    public sealed class OrderViewModel
    {
        public Guid Id { get; private set; }
        public string Customer { get; private set; }
        public ICollection<ProductViewModel> Products { get; private set; }

        private OrderViewModel() { }

        public static OrderViewModel Create(Guid id, string customer, ICollection<ProductViewModel> products) =>
            new OrderViewModel
            {
                Id = id,
                Customer = customer,
                Products = products
            };
    }
}
