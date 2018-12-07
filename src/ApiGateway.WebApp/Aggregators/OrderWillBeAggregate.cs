using System;
using System.Collections.Generic;

namespace ApiGateway.WebApp.Aggregators
{
    public sealed class OrderWillBeAggregate
    {
        public Guid Id { get; set; }
        public ICollection<OrderProductWillBeAggregate> Products { get; set; }
    }
}
