using System;
using System.Collections.Generic;

namespace Orders.Domain.Models
{
    public class Order
    {
        public Guid Id { get; private set; }
        public ICollection<OrderProduct> Products { get; private set; } = new List<OrderProduct>();

        protected Order() { }

        public static Order CreateNew(ICollection<Guid> productIds) =>
            new Order
            {
                Id = Guid.NewGuid()
            }.AddProducts(productIds);

        private Order AddProducts(ICollection<Guid> productIds)
        {
            foreach (var productId in productIds)
                Products.Add(OrderProduct.Create(Id, productId));
            return this;
        }
    }
}
