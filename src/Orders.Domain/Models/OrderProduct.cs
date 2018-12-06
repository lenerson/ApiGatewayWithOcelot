using System;

namespace Orders.Domain.Models
{
    public class OrderProduct
    {
        public Guid OrderId { get; private set; }
        public Order Order { get; private set; }

        public Guid ProductId { get; private set; }

        protected OrderProduct() { }

        public static OrderProduct Create(Guid orderId, Guid productId) =>
            new OrderProduct { OrderId = orderId, ProductId = productId };
    }
}
